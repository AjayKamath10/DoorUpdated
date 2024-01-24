using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorFunctionsLibrary
{
    public class Pager : AddOn
    {
        public override void Alert(SmartDoor door)
        {
            Logger.Write($"Pager: door {door.name} is open");
        }
        public void Subscribe(SmartDoor door)
        {
            door.TimerThresholdReachedEvent += this.Alert;
        }

        public void UnSubscribe(SmartDoor door)
        {
            door.TimerThresholdReachedEvent -= this.Alert;
        }
    }
}
