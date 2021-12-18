using System;
using System.Windows;

namespace Chat.AttachedProperties
{
    public abstract class BaseAttachedProperty<TParent,TValue>
        where TParent : BaseAttachedProperty<TParent, TValue>, new()
    {
        public static TParent Instance = new();

        public static DependencyProperty ValueProperty =
            DependencyProperty.RegisterAttached("Value", 
                typeof(TValue), 
                typeof(BaseAttachedProperty<TParent, TValue>), 
                new UIPropertyMetadata(default(TValue), OnValuePropertyChanged, OnValueUpdated));


        public static void SetValue(DependencyObject d, TValue value) => d.SetValue(ValueProperty, value);
        public static TValue GetValue(DependencyObject d) => (TValue)d.GetValue(ValueProperty);

        private static object OnValueUpdated(DependencyObject d, object baseValue)
        {
            Instance.OnValuePropertyUpdated(d, baseValue);
            return baseValue;
        }
        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Instance.OnPropertyChanged(d, e);
        }

        public virtual void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        public virtual void OnValuePropertyUpdated(DependencyObject d, object baseValue)
        {
        }
    }
}
