using System.Windows;
using System.Windows.Controls;

namespace Chat.AttachedProperties
{
    public class MonitorPasswordProperty : BaseAttachedProperty<MonitorPasswordProperty, bool> 
    {
        public override void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue && (d is PasswordBox box))
            {
                HasTextProperty.SetValue(box);
                box.PasswordChanged += Box_PasswordChanged;
            }
        }

        private void Box_PasswordChanged(object sender, RoutedEventArgs e)
        {
            HasTextProperty.SetValue((PasswordBox)sender);
        }
    }

    public class HasTextProperty : BaseAttachedProperty<HasTextProperty, bool>
    {
        public static void SetValue(PasswordBox sender)
        {
            SetValue(sender, sender.Password.Length > 0);
        }
    }
}
