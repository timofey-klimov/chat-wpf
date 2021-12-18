using Chat.AttachedProperties;
using System.Windows;

namespace Chat.Wpf.AttachedProperties
{
    /// <summary>
    /// Base class to run any animation when a boolean is set to true
    /// and reverse when set to false
    /// </summary>
    /// <typeparam name="Parent"></typeparam>
    public abstract class AnimateBaseProperty<Parent> : BaseAttachedProperty<Parent, bool>
        where Parent : BaseAttachedProperty<Parent, bool>, new()
    {
        public bool FirstLoad { get; set; } = true;

        public override void OnValuePropertyUpdated(DependencyObject d, object value)
        {
            if (!(d is FrameworkElement element))
                return;

            if (FirstLoad == false && d.GetValue(ValueProperty) == value)
                return;

            if (FirstLoad)
            {
                RoutedEventHandler onloaded = null;

                onloaded = (s, e) =>
                {
                    element.Loaded -= onloaded;

                    DoAnimation(element, (bool)value);
                    FirstLoad = false; 
                };

                element.Loaded += onloaded;
            }
            else
            {
                DoAnimation(element, (bool)value);
            }
        }

        protected abstract void DoAnimation(FrameworkElement element, bool value);
    }
}
