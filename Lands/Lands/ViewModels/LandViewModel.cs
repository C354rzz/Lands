namespace Lands.ViewModels
{
    using Models;

    public class LandViewModel : BaseViewModel
    {
        #region Propperties
        public Land Land
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public LandViewModel(Land land)
        {
            this.Land = land;

        } 
        #endregion
    }
}
