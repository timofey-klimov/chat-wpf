using System;
using System.Windows;
using System.Windows.Controls;

namespace Chat.Wpf.Controls.Messages
{
    /// <summary>
    /// Логика взаимодействия для ChatMessageItem.xaml
    /// </summary>
    public partial class ChatMessageItem : UserControl
    {
        public double MessageBlockWidth
        {
            get { return (double)GetValue(MessageBlockWidthProperty); }
            set { SetValue(MessageBlockWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaxMessageBlockWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MessageBlockWidthProperty =
            DependencyProperty.Register("MessageBlockWidth", typeof(double), typeof(ChatMessageItem), new PropertyMetadata(default(double),ValueChanged));

        private static void ValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var chatItem = (ChatMessageItem)d;
            chatItem.MessageTextBlock.MaxWidth = (double)e.NewValue;
        }

        public ChatMessageItem()
        {
            InitializeComponent();
        }
    }
}
