using Prism;
using Prism.Ioc;
using GTKWebsiteSamples.ViewModels;
using GTKWebsiteSamples.Views;
using Xamarin.Forms;
using GTKWebsiteSamples.Enums;

namespace GTKWebsiteSamples
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/" + NavigationEnum.MainPage.ToString());
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<DialogPage, DialogPageViewModel>();
        }
    }
}
