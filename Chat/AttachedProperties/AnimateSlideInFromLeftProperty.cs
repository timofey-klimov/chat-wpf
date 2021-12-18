using System.Windows;
using Chat.Animations;

namespace Chat.Wpf.AttachedProperties
{
    public class AnimateSlideInFromLeftProperty : AnimateBaseProperty<AnimateSlideInFromLeftProperty>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value)
        {
            if (value)
            {
                await element.SlideAnimationFramewokElementFromLeft(FirstLoad == true ? 0 : 0.3, false);
            }
            else
            {
                await element.SlideAnimationFrameworkElementToLeft(FirstLoad == true ? 0 : 0.3, false);
            }
        }
    }
}
