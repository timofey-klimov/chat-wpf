using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Chat.Wpf.Controls
{
    /// <summary>
    /// Логика взаимодействия для PageHost.xaml
    /// </summary>
    public partial class PageHost : UserControl
    {
        public BasePage CurrentPage
        {
            get { return (BasePage)GetValue(CurrentPageProperty); }
            set { SetValue(CurrentPageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register(nameof(CurrentPage), typeof(BasePage), typeof(PageHost), new PropertyMetadata(PropertyChanged));

        private static async void PropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var newPageFrame = (d as PageHost).NewPage;
            var oldPageFrame = (d as PageHost).OldPage;

            var oldPageContent = newPageFrame.Content;

            newPageFrame.Content = null;

            oldPageFrame.Content = oldPageContent;

            //Animate our previous page
            if (oldPageContent is BasePage oldPage)
            {
                oldPage.ShouldAnimateOut = true;

                 await Task.Delay((int)oldPage.SlideSeconds * 1000)
                    .ContinueWith((e) =>
                    {
                        Application.Current.Dispatcher.Invoke(() => oldPageFrame.Content = null);
                    });
            }


            //set the new page content

            newPageFrame.Content = e.NewValue;
        }

        public PageHost()
        {
            InitializeComponent();
        }
    }
}
