using SimpleDesignPatternImplementations.AdapterPattern.Example2.Interfaces;

namespace SimpleDesignPatternImplementations.AdapterPattern.Example2.Models
{
    public class SuperDrone : IDrone
    {
        public void Beep()
        {
            Console.WriteLine("Beep Beep Beep");
        }

        public void Spin_Rotors()
        {
            Console.WriteLine("Rotors are spinning");
        }

        public void Take_Off()
        {
            Console.WriteLine("Taking off!!");
        }
    }
}
