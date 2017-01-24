using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAdvancedMvvmDemo.ViewModels
{
    public class AdvancedViewModel : BaseViewModel      
    {
        private string _message;
        public string message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged("message");
            }
        }

        private ICommand _changeMessageCommand;
        public ICommand changeMessageCommand
        {
            get
            {
                if (_changeMessageCommand == null)
                {
                    _changeMessageCommand = new Command(ChangeText, CanChangeText);
                }
                return _changeMessageCommand;
            }
            set { _changeMessageCommand = value; }
        }

        private ICommand _navigateCommand;
        public ICommand navigateCommand
        {
            get
            {
            if (_navigateCommand == null)
	        {
		        _navigateCommand = new Command(Navigate);
	        }
                return _navigateCommand; 
            }
            set { _navigateCommand = value; }
        }

        private void Navigate()
        {
            //access the navigation view model
            NavigationViewModel navVM =
                App.Current.MainWindow.DataContext as NavigationViewModel;
            //change the location to pagetwo.xaml
            navVM.location = "Views/PageTwo.xaml";
        }

        private bool CanChangeText()
        {
            //we could put logic in here to test whether the button has been clicked or not
            return true;
        }

        private void ChangeText()
        {
            message = "Today is Friday";
        }
        

        public AdvancedViewModel()
        {
            message = "Today is Tuesday!";
        }
    }
}
