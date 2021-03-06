﻿namespace Lands.ViewModels
{
    using Helpers;
    using Models;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class MainViewModel
    {

        #region Properties
        public List<Land> LandsList
        {
            get;
            set;
        }


        public string Token { get; set; }
        public string ToketType { get; set; }


    public ObservableCollection<MenuItemViewModel> Menus
        {
            get;
            set;
        }
        #endregion

        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }

        public LandsViewModel Lands
        {
            get;
            set;
        }

        public LandViewModel Land
        {
            get;
            set;
        }

        public RegisterViewModel Register
        {
            get;
            set;
        }

        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
            this.LoadMenu();
        }

        #endregion

        #region Methods
        private void LoadMenu()
        {
            this.Menus = new ObservableCollection<MenuItemViewModel>();

            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_account_circleB",
                PageName = "MyProfilePage",
                Title = Languages.MyProfile,
            });
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_insert_chartB",
                PageName = "StatisticsPage",
                Title = Languages.Statistics,
            });
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_exit_to_appB",
                PageName = "LoginPage",
                Title = Languages.LogOut,
            });
        }
        #endregion

        #region Syngleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }
        #endregion
    }
}
