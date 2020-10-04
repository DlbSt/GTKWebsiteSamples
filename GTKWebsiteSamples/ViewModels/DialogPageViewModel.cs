using Prism.Commands;
using Prism.Mvvm;
using Prism.Services;
using Xamarin.Forms;

namespace GTKWebsiteSamples.ViewModels
{
    public class DialogPageViewModel : BindableBase
    {
        #region Commands
        public DelegateCommand OnShowMessageBoxCommand { get; set; }
        public DelegateCommand OnShowActionSheetCommand { get; set; }
        #endregion

        #region Properties
        private string title;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        private Color selectedColor = Color.Red;
        public Color SelectedColor
        {
            get { return selectedColor; }
            set { SetProperty(ref selectedColor, value); }
        }

        private double scaleButtonValue = 5.00;
        public double ScaleButtonValue
        {
            get { return scaleButtonValue; }
            set { SetProperty(ref scaleButtonValue, value); }
        }

        private string fontName = "Verdana Bold 10";
        public string FontName
        {
            get { return fontName; }
            set { SetProperty(ref fontName, value); }
        }
        #endregion

        #region Services
        private IPageDialogService _pageDialogService;
        #endregion

        #region Constructor
        public DialogPageViewModel(IPageDialogService pageDialogService)
        {
            Title = "Dialog Page";

            _pageDialogService = pageDialogService;

            OnShowMessageBoxCommand = new DelegateCommand(ShowMessageBox);
            OnShowActionSheetCommand = new DelegateCommand(ShowActionSheet);
        } 
        #endregion

        private void ShowMessageBox() => _pageDialogService.DisplayAlertAsync("Message Box Title", "Message Box Message", "OK");
        private void ShowActionSheet() => _pageDialogService.DisplayActionSheetAsync("Action Sheet Title", "Cancel", "Destroy", "Add", "Modify", "Delete");
    }
}
