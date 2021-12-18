using Chat.Core.Services.Abstraction.Providers;
using System.Security;

namespace Chat.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : BasePage, IPasswordProvider
    {
        public LoginPage() 
        {
            InitializeComponent();
        }

        public SecureString Password => this.PasswordBox.SecurePassword;
    }
}
