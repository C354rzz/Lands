﻿namespace Lands
{
    using Views;
    using Xamarin.Forms;
    using Helpers;
    using Lands.ViewModels;

    public partial class App : Application
	{
        #region Properties
        public static NavigationPage Navigator
        {
            get;
            internal set;
        } 
        #endregion

        #region Constructors
        public App ()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(Settings.Token))
            {

                //this.MainPage = new MasterPage();
                this.MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                var mainViewModel = MainViewModel.GetInstance();
                mainViewModel.Token = Settings.Token;
                mainViewModel.ToketType = Settings.TokenType;
                mainViewModel.Lands = new LandsViewModel();
                this.MainPage = new MasterPage();

                //mainViewModel.Lands = new LandsViewModel();
                //Application.Current.MainPage = new MasterPage();
            }
        }

        #endregion

        #region Methods
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        } 
        #endregion
    }
}
