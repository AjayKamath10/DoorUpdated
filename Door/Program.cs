
using DoorFunctionsLibrary;

namespace Door
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Buzzer Buzzer1 = new Buzzer();
            Pager Pager1 = new Pager();
            AutoClose AutoClose1 = new AutoClose();

            SimpleDoor Door1 = new SimpleDoor("Door1");
            SmartDoor Door2 = new SmartDoor("Door2");
            Door2.SetTimer(2);

            Buzzer1.Subscribe(Door2);
            Pager1.Subscribe(Door2);
            AutoClose1.Subscribe(Door2);



            Door2.Open();

            Console.ReadKey();

         
        }
    }
}
