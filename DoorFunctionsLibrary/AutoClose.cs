using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorFunctionsLibrary
{
    public class AutoClose : AddOn
    {
        public override void Alert(SmartDoor Door) 
        {
            Door.Close();
            Logger.Write($"Door {Door.name} has been closed");
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
