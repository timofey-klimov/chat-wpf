using Chat.Animations.Model;
using Chat.Wpf.Animations;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Chat.Animations
{
    public static class AnimationExtension
    {
        /// <summary>
        /// Animation when the page loaded
        /// </summary>
        /// <param name="page"></param>
        /// <param name="seconds"></param>
        /// <param name="slideDirection"></param>
        /// <returns></returns>
        public static async Task SlideAnimationIn(this Page page, double seconds, SlideDirection slideDirection)
        {
            var sb = new Storyboard();

            var thicknessAnimation = new ThicknessAnimation()
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                DecelerationRatio = 0.9f,
                To = new Thickness(0)
            };


            Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath("Margin"));

            if (slideDirection == SlideDirection.Horizontal)
                thicknessAnimation.From = new Thickness(page.WindowWidth, 0, -page.WindowWidth, 0);

            if (slideDirection == SlideDirection.Vertical)
                thicknessAnimation.From = new Thickness(0, -page.WindowHeight, 0, page.WindowHeight);

            sb.Children.Add(thicknessAnimation);
            sb.FadeIn(seconds);

            sb.Begin(page);

            page.Visibility = Visibility.Visible;

            await Task.Delay((int)seconds);
        }

        /// <summary>
        /// Animation when the page unloaded
        /// </summary>
        /// <param name="page"></param>
        /// <param name="seconds"></param>
        /// <param name="slideDirection"></param>
        /// <returns></returns>
        public static async Task SlideAnimationOut(this Page page, double seconds, SlideDirection slideDirection)
        {
            var sb = new Storyboard();

            var thicknessAnimation = new ThicknessAnimation()
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                DecelerationRatio = 0.9f,
                From = new Thickness(0)
            };

            Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath("Margin"));

            if (slideDirection == SlideDirection.Horizontal)
                thicknessAnimation.To = new Thickness(-page.WindowWidth, 0, page.WindowWidth, 0);

            if (slideDirection == SlideDirection.Vertical)
                thicknessAnimation.To = new Thickness(0, page.WindowHeight, 0, -page.WindowHeight);

            sb.Children.Add(thicknessAnimation);
            sb.FadeOut(seconds);

            sb.Begin(page);

            page.Visibility = Visibility.Visible;

            await Task.Delay((int)seconds);
        }
        
        public static async Task SlideAnimationFramewokElementFromLeft(this FrameworkElement element, double seconds, bool keepMargin)
        {
            var storyBoard = new Storyboard();

            var thicknessAnimation = new ThicknessAnimation()
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(-element.ActualWidth, 0, 0, 0),
                DecelerationRatio = 0.9f,
                To = new Thickness(0)
            };

            Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath("Margin"));

            storyBoard.Children.Add(thicknessAnimation);
            storyBoard.FadeIn(seconds);

            storyBoard.Begin(element);

            element.Visibility = Visibility.Visible;

            await Task.Delay((int)seconds);
        }

        public static async Task SlideAnimationFrameworkElementToLeft(this FrameworkElement element, double seconds, bool keepMargin)
        {
            var storyBoard = new Storyboard();

            var thicknessAnimation = new ThicknessAnimation()
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                DecelerationRatio = 0.9f,
                To = new Thickness(keepMargin ? 0 : -element.ActualWidth, 0, keepMargin ? element.ActualWidth : 0, 0)
            };

            Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath("Margin"));

            storyBoard.Children.Add(thicknessAnimation);
            storyBoard.FadeOut(seconds);

            storyBoard.Begin(element);

            element.Visibility = Visibility.Visible;

            await Task.Delay((int)seconds);
        }
    }
}
