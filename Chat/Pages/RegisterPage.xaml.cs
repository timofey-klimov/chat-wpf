using Chat.Core.Services.Abstraction.Providers;
using System.Security;

namespace Chat.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : BasePage, IPasswordProvider
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        public SecureString Password => this.PasswordBox.SecurePassword;
    }
}
