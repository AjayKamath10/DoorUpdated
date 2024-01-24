using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorFunctionsLibrary
{
    public enum DoorStates
    {
        OPEN,
        CLOSE
    }

    public class SimpleDoor
    {
        
        public string name { get; private set; }
        public DoorStates state { get; private set; }


        public double price { get; protected set; }

        public SimpleDoor(string Name, double Price = 200)
        {
            this.name = Name;
            this.state = DoorStates.CLOSE;//initial state
            this.price = Price;
        }

        public virtual void Open()
        {
            this.state = DoorStates.OPEN;
        }

        public virtual void Close()
        {
            this.state = DoorStates.CLOSE;
        }

        
        

    }
}
