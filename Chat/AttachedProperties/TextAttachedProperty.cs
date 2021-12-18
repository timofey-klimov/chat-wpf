using System.Windows;
using System.Windows.Controls;

namespace Chat.AttachedProperties
{
    public class FocusTestAttachedProperty : BaseAttachedProperty<FocusTestAttachedProperty, bool>
    {
        public override void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue && d is Control control)
            {
                control.Loaded += (s, e) => control.Focus();
            }
        }
    }

    public class MonitorTextBoxOverflowProperty : BaseAttachedProperty<MonitorTextBoxOverflowProperty, bool>
    {
        public override void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue && d is TextBox textBox)
            {
                IsTextBoxOverFlowProperty.SetValue(textBox, false);
                textBox.SizeChanged += OnSizeChanged;
            }
        }

        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            IsTextBoxOverFlowProperty.SetValue((TextBox)sender, e.HeightChanged);
        }
    }

    public class IsTextBoxOverFlowProperty : BaseAttachedProperty<IsTextBoxOverFlowProperty, bool>
    {
        public static void SetValue(TextBox textBox, bool isOverFlow)
        {
            BaseAttachedProperty<IsTextBoxOverFlowProperty, bool>.SetValue(textBox, isOverFlow);
        }
    }
}
