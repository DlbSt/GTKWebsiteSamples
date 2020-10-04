using GTKWebsiteSamples.Enums;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GTKWebsiteSamples.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        #region Properties
        private string title = "GTK# Samples";
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        } 
        #endregion

        #region Commands
        public DelegateCommand OnNavigateToDialogPage { get; set; }
        #endregion

        #region Services
        private INavigationService _navigationService; 
        #endregion

        #region Constructor
        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            OnNavigateToDialogPage = new DelegateCommand(NavigateToDialogPage);
        } 
        #endregion

        private async void NavigateToDialogPage()
        {
            await _navigationService.NavigateAsync(NavigationEnum.DialogPage.ToString());
        }
    }
}
