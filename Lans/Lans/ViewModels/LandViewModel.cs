namespace Lans.ViewModels
{
    using Models;

    public class LandViewModel
    {
        #region Properties
        public  Land Land
        {
            get;
            set;
             
        }
        #endregion
        #region Contructors
        private LandItemViewModel landItemViewModel;

        public LandViewModel(Land land)
        {
            this.Land = land;
        } 
        #endregion
    }
}
