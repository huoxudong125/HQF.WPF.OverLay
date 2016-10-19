using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace HQF.WPF.ToolKitDemos.ViewModels
{
    public class BusyIndicatorViewModel : BindableBase
    {
        private bool _isChangedBusyContent;
        private bool _isBusy;
        public ICommand ChangeBusyCommand { get; }
        public ICommand ChangeTemplateCommand { get; }

        public bool IsBusy
        {
            get { return _isBusy; }
            set { SetProperty(ref _isBusy, value); }
        }

        public bool IsChangedBusyContent
        {
            get { return _isChangedBusyContent; }
            set { SetProperty(ref _isChangedBusyContent, value); }
        }

        public BusyIndicatorViewModel()
        {
            ChangeBusyCommand = new DelegateCommand(ChangeBusy);
            ChangeTemplateCommand=new DelegateCommand(ChangeTemplate);
        }

        private void ChangeTemplate()
        {
            IsChangedBusyContent = !IsChangedBusyContent;
        }

        private void ChangeBusy()
        {
            IsBusy = !IsBusy;
        }
    }
}