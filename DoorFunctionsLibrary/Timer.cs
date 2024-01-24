using DoorFunctionsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorFunctionsLibrary
{
    public class Timer : ITimerControl
    {
        private SmartDoor door;
        public Timer(SmartDoor Door)
        {
            this.door = Door; 
        }

        public event Action<SmartDoor> TimerThresholdReachedEvent;
        public void StartTimer(int Threshold)
        {
            Thread timerThread = new Thread(() => { 
            Thread.Sleep(Threshold * 1000);

            if (door.state == DoorStates.OPEN) door.ThresholdReached();

            });
            timerThread.Start();

        }
       


    }
}
