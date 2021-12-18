using Chat.Animations;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Chat
{
    public class BasePage : Page
    {
        #region Public Properties
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.FromRightToLeft;

        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.FromLeftToRight;

        public double SlideSeconds { get; set; } = 0.3;

        public bool ShouldAnimateOut { get; set; }

        #endregion

        public BasePage()
        {
            if (PageLoadAnimation != PageAnimation.None)
                Visibility = Visibility.Hidden;

            Loaded += BasePage_Loaded;
        }

        private async void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            if (ShouldAnimateOut)
                await AnimateOut();
            else
                await AnimateIn();
        }

        private async Task AnimateIn()
        {
            if (PageLoadAnimation == PageAnimation.None)
                return;

            switch (PageLoadAnimation)
            {
                case PageAnimation.FromRightToLeft:
                    await this.SlideAnimationIn(SlideSeconds, Animations.Model.SlideDirection.Vertical);
                    break;
                case PageAnimation.FromLeftToRight:
                    await this.SlideAnimationOut(SlideSeconds, Animations.Model.SlideDirection.Vertical);
                    break;
            }
        }

        public async Task AnimateOut()
        {
            if (PageUnloadAnimation == PageAnimation.None)
                return;

            switch (PageUnloadAnimation)
            {
                case PageAnimation.FromLeftToRight:
                    await this.SlideAnimationOut(SlideSeconds, Animations.Model.SlideDirection.Vertical);
                    break;
                case PageAnimation.FromRightToLeft:
                    await this.SlideAnimationIn(SlideSeconds, Animations.Model.SlideDirection.Vertical);
                    break;
            }

            await Task.Delay((int)SlideSeconds * 10);
        }
    }
}
