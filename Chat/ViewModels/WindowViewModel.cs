using Chat.Core.Commands;
using Chat.Core.DataModels;
using Chat.Core.Services.Implementation.IoC;
using Chat.Core.ServicesAbstraction;
using Chat.Core.ServicesAbstraction.Providers;
using Chat.Core.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace ChatWpf.ViewModels
{
    public class WindowViewModel : BaseViewModel
    {
        #region private
        private readonly Window _window;
        private int _autoMargin = 10;
        private int _radius = 10;
        private double _sidePanelWidth;
        #endregion

        #region public props
        public int ResizeBorder { get; set; } = 3;

        public int OuterMarginSize
        {
            get
            {
                return _window.WindowState == WindowState.Maximized ? 5 : _autoMargin;
            }
            set
            {
                _autoMargin = value;
            }
        }

        public int WindowRadius
        {
            get
            {
                return _window.WindowState == WindowState.Maximized ? 0 : _radius;
            }
            set
            {
                _radius = value;
            }
        }

        public int TitleHeight { get; set; } = 42;

        public Thickness ResizeBorderThickness => new Thickness(ResizeBorder);

        public CornerRadius WindowCornerRadius => new CornerRadius(WindowRadius);
       
        public Thickness OuterMarginThickness => new Thickness(OuterMarginSize);

        public GridLength TitleGridHeight => new GridLength(TitleHeight);

        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;


        #endregion

        #region commands
        public ICommand MinimizeWindowCommand { get; }
        public ICommand MaximizeWindowCommand { get; }
        public ICommand CloseCommand { get; }
        public ICommand MenuCommand { get; }
        #endregion

        #region Services

        public INavigationService NavigationService { get; }
        public IApplicationStateProvider ApplicationStateProvider { get; }
        #endregion

        public bool IsSideMenuActive { get; set; }

        #region ctor
        public WindowViewModel(Window window)
        {
            ApplicationStateProvider = IocContainer.Get<IApplicationStateProvider>();
            _window = window;
            _window.StateChanged += (s, e) =>
            {
                OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(WindowCornerRadius));
                OnPropertyChanged(nameof(OuterMarginThickness));
                OnPropertyChanged(nameof(WindowCornerRadius));
                ApplicationStateProvider.StateChanged(window.WindowState);
            };
            MinimizeWindowCommand = new DelegateCommand((e) => _window.WindowState = System.Windows.WindowState.Minimized);
            MaximizeWindowCommand = new DelegateCommand((e) => _window.WindowState ^= System.Windows.WindowState.Maximized);
            CloseCommand = new DelegateCommand((e) => _window.Close());
            NavigationService = IocContainer.Get<INavigationService>();
            NavigationService.PageChanged += OnPageChanged;
            _window.SizeChanged += (s, e) =>
            {
                ApplicationStateProvider.ChangeWindowSize(e.NewSize);
            };
        }
        #endregion

        #region helper
        private void OnPageChanged(ApplicationPage page)
        {
            CurrentPage = page;
        }
        #endregion
    }
}
