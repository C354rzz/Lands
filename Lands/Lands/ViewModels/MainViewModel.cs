namespace Lands.ViewModels
{
    
    public class MainViewModel
    {
        #region ViewModels
        public LoginViewmodel Login
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            this.Login = new LoginViewmodel();
        }
        #endregion
    }
}
