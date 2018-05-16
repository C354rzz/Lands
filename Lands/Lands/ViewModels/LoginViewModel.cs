using System.Windows.Input;

namespace Lands.ViewModels
{
    public class LoginViewmodel
    {
        #region Properties
        public string Email
        { get; set; }
        public string Password
        { get; set; }
        public bool IsRunning
        { get; set; }
        public bool IsRemembered
        { get; set; }
        #endregion
        #region Constructor
        public LoginViemodel()
        {
            this.IsRemembered = true;

        }
        #endregion
        #region Commands
        public ICommand LoginCommand
        { get; set; }
        #endregion
    }
}