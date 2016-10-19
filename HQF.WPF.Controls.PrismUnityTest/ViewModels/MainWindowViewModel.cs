using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace HQF.WPF.Controls.PrismUnityTest.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public ICommand SelectedGenderCommand { get; }

        public ICommand OKCommand { get; }

        private MessageBoxTypes _messageBoxType;

        public MessageBoxTypes MessageBoxType
        {
            get { return _messageBoxType; }
            set { SetProperty(ref _messageBoxType, value); }
        }

        private string _title = "Prism Unity Application";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {
            MessageBoxType = MessageBoxTypes.SelectView;

            SelectedGenderCommand = new DelegateCommand<object>(SelectedGender);

            OKCommand = new DelegateCommand<object>(OK);
        }

        private void OK(object obj)
        {
            MessageBoxType = MessageBoxTypes.SelectView;
        }

        private void SelectedGender(object obj)
        {
            MessageBoxType = MessageBoxTypes.MessageView;
        }
    }

    public enum MessageBoxTypes
    {
        SelectView,
        MessageView,
        ConfirmView
    }
}