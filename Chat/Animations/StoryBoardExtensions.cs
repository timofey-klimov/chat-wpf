using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace Chat.Wpf.Animations
{
    public static class StoryBoardExtensions
    {
        public static void FadeIn(this Storyboard storyboard, double duration)
        {
            var doubleAnimation = new DoubleAnimation()
            {
                From = 0,
                To = 1,
                DecelerationRatio = 0.9f,
                Duration = new System.Windows.Duration(TimeSpan.FromSeconds(duration))
            };

            Storyboard.SetTargetProperty(doubleAnimation, new System.Windows.PropertyPath("Opacity"));

            storyboard.Children.Add(doubleAnimation);
        }

        public static void FadeOut(this Storyboard storyboard, double duration)
        {
            var doubleAnimation = new DoubleAnimation()
            {
                From = 1,
                To = 0,
                DecelerationRatio = 0.9f,
                Duration = new System.Windows.Duration(TimeSpan.FromSeconds(duration))
            };

            Storyboard.SetTargetProperty(doubleAnimation, new System.Windows.PropertyPath("Opacity"));

            storyboard.Children.Add(doubleAnimation);
        }
    }
}
