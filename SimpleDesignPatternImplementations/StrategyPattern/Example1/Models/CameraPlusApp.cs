using SimpleDesignPatternImplementations.StrategyPattern.Example1.Services;

namespace SimpleDesignPatternImplementations.StrategyPattern.Example1.Models
{
    public class CameraPlusApp : BasicCameraApp
    {
        public CameraPlusApp()
        {
            EditBehaviour = new EditPhotoshop();
            ShareBehavior = new ShareSocialMedia();
        }
    }
}
