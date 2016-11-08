//------------------------------------------------------------------------------
// C #   I N   A C T I O N   ( C S A )
//------------------------------------------------------------------------------
// Repository:
//    $Id: MotorCtrl.cs 973 2015-11-10 13:12:03Z zajost $
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RobotCtrl
{

    public class DriveCtrl : IDisposable
    {

        #region members
        private int ioAddress;
        #endregion


        private const byte POWER_LEFT_MASK = 0x01;
        private const byte POWER_RIGHT_MASK = 0x02;
        private const byte POWER_BOTH_MASK = POWER_LEFT_MASK | POWER_RIGHT_MASK;
        private const byte RESET_MASK = 0x80;


        #region constructor & destructor
        public DriveCtrl(int IOAddress)
        {
            this.ioAddress = IOAddress;
            Reset();
        }

        public void Dispose()
        {
            Reset();
        }
        #endregion


        #region properties
        /// <summary>
        /// Schaltet die Stromversorgung der beiden Motoren ein oder aus.
        /// </summary>
        public bool Power
        {
            set { DriveState = (value) ? DriveState | POWER_BOTH_MASK : DriveState & ~POWER_BOTH_MASK; }
        }


        /// <summary>
        /// Liefert den Status ob der rechte Motor ein-/ausgeschaltet ist bzw. schaltet den rechten Motor ein-/aus.
        /// Die Information dazu steht im Bit0 von DriveState.
        /// </summary>
        public bool PowerRight
        {
            get { return (DriveState & POWER_RIGHT_MASK) == POWER_RIGHT_MASK; }
            set
            {
                IOPort.Write(ioAddress, value ? DriveState | POWER_RIGHT_MASK : DriveState & ~POWER_RIGHT_MASK);
            }
        }


        /// <summary>
        /// Liefert den Status ob der linke Motor ein-/ausgeschaltet ist bzw. schaltet den linken Motor ein-/aus.
        /// </summary>
        public bool PowerLeft
        {
            get { return (DriveState & POWER_LEFT_MASK) == POWER_LEFT_MASK; }
            set
            {
                DriveState = value ? DriveState | POWER_LEFT_MASK : DriveState & ~POWER_LEFT_MASK;
            }
        }


        /// <summary>
        /// Bietet Zugriff auf das Status-/Controlregister
        /// </summary>
        public int DriveState
        {
            get { return IOPort.Read(ioAddress); } 
            set { IOPort.Write(ioAddress, value); }
        }
        #endregion


        #region methods
        /// <summary>
        /// Setzt die beiden Motorencontroller (LM629) zurück, 
        /// indem kurz die Reset-Leitung aktiviert wird.
        /// </summary>
        public void Reset()
        {
            DriveState &= ~RESET_MASK;
            Thread.Sleep(5);
            DriveState |= RESET_MASK;
            Thread.Sleep(5);
            DriveState &= ~RESET_MASK;
            Thread.Sleep(5);
        }
        #endregion

    }
}
