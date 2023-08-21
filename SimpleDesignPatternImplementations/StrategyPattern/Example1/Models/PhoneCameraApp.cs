using SimpleDesignPatternImplementations.StrategyPattern.Example1.Services;

namespace SimpleDesignPatternImplementations.StrategyPattern.Example1.Models
{
    public class PhoneCameraApp : BasicCameraApp
    {
        public PhoneCameraApp()
        {
            EditBehaviour = new EditCanva();
            ShareBehavior = new ShareByEmail();
        }
    }
}
