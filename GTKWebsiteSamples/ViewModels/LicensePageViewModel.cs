using GTKWebsiteSamples.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace GTKWebsiteSamples.ViewModels
{
    public class LicensePageViewModel : BindableBase
    {
        #region Properties
        private string title = "Licenses";
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        private ObservableCollection<License> licenses = new ObservableCollection<License>
        {
            new License
            {
                LibraryName = "Xamarin Forms",
                LicenseType = "MIT License",
                Copyright = "Copyright (c) .NET Foundation Contributors",
                LibraryUrl = "https://github.com/xamarin/Xamarin.Forms",
                LicenseUrl = "https://github.com/xamarin/Xamarin.Forms/blob/5.0.0/LICENSE"
            },
            new License
            {
                LibraryName = "Prism.DryIoc.Forms",
                LicenseType = "MIT License",
                Copyright = "Copyright (c) .NET Foundation",
                LibraryUrl = "https://github.com/PrismLibrary/Prism",
                LicenseUrl = "https://github.com/PrismLibrary/Prism/blob/master/LICENSE"
            },
            new License
            {
                LibraryName = "FormsGtkToolkit",
                LicenseType = "MIT License",
                Copyright = "Copyright (c) 2017 FormsGtkToolkit",
                LibraryUrl = "https://github.com/jsuarezruiz/FormsGtkToolkit",
                LicenseUrl = "https://github.com/jsuarezruiz/FormsGtkToolkit/blob/master/LICENSE"
            }
        };
        public ObservableCollection<License> Licenses
        {
            get { return licenses; }
            set { SetProperty(ref licenses, value); }
        } 
        #endregion

        public LicensePageViewModel()
        {

        }


    }
}
