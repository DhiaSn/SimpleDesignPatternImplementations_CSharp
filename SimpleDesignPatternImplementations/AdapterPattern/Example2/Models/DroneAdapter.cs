using SimpleDesignPatternImplementations.AdapterPattern.Example1.Interfaces;
using SimpleDesignPatternImplementations.AdapterPattern.Example2.Interfaces;

namespace SimpleDesignPatternImplementations.AdapterPattern.Example2.Models
{
    public class DroneAdapter : IDuck
    {
        private IDrone Drone { get; set; }
        public DroneAdapter(IDrone drone)
        {
            Drone = drone;
        }

        public void Fly()
        {
            Drone.Spin_Rotors();
            Drone.Take_Off();
        }

        public void Quack()
        {
            Drone.Beep();
        }
    }
}
