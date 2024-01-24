using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorFunctionsLibrary
{
    public class SmartDoor : SimpleDoor
    {
        public event Action <SmartDoor> TimerThresholdReachedEvent;
        
        public Timer timer { get; private set; }
        

        private int doorTimeThreshold = 3;

        public SmartDoor(string Name, double Price = 200) : base(Name, Price)
        {
            price += CalculateAdditionalPrice(this);
            timer = new Timer(this);//remove event and call method directly
        }

        public void SetTimer(int Time)
        { 
            doorTimeThreshold = Time;
        }
            
        public override void Open()
        {
            base.Open();
            timer.StartTimer(doorTimeThreshold);
        }
        public override void Close()
        {
            base.Close();
        }

        public void ThresholdReached()
        {
            TimerThresholdReachedEvent?.Invoke(this);
        }

        private static double CalculateAdditionalPrice(SmartDoor This)
        {
            double additionalPrice = 0;

            return additionalPrice;
        }
    }
}
