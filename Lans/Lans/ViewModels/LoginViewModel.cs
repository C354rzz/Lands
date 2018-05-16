namespace Lans.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Services;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    public class LoginViewModel : BaseViewModel
    {
        #region Services
        private ApiService apiService;
        #endregion

        #region Attributes
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnabled; 
        #endregion
        
        #region Properties
        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
            
        }

        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }

        public bool IsRemembered
        {
            get;
            set;
        }

        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.apiService = new ApiService();

            this.IsRemembered = true;
            this.IsEnabled = true;

            this.Email = "armijo@gmail.com";
            this.Password = "123456";
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                   "Error",
                   "You must enter an email",
                   "Accept");
                return;
            }


            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                   "Error",
                   "You must enter a password",
                   "Accept");
                return;
            }

            this.IsRunning = true;
            this.IsEnabled = false;

            var connection = await this.apiService.CheckConnection();

            if (!connection.IsSuccess)
            {
                this.IsRunning = false;
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    connection.Message,
                    "Accept");
                return;
            }

           

            MainViewModel.GetInstance().Lands = new LandsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new LandsPage());


            this.Email = string.Empty;
            this.Password = string.Empty;

        }
        #endregion
    }
}
