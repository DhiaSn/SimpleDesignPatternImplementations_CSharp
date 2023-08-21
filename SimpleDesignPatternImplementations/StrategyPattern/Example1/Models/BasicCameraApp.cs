using SimpleDesignPatternImplementations.StrategyPattern.Example1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesignPatternImplementations.StrategyPattern.Example1.Models
{
    public class BasicCameraApp
    {
        public IEditBehaviour EditBehaviour { get; set; }
        public IShareBehavior ShareBehavior { get; set; }
        public void Edit()
        {
            EditBehaviour.Edit(); 
        }
        public void Share()
        {
            ShareBehavior.Share(); 
        }

        public void Take()
        {
            Console.WriteLine("Taking Picture..."); 
        }
        public void Save()
        {
            Console.WriteLine("Saving Image..."); 
        }
    }
}
