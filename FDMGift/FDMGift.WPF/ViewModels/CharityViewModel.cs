using FDMGift.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FDMGift.WPF.ViewModels
{
    public class CharityViewModel : BaseViewModel
    {
        private string _IdToChange;
        public string IdToChange
        {
            get { return _IdToChange; }
            set
            {
                _IdToChange = value;
                OnPropertyChanged("IdToChange");
            }
        }

        private int _newTargetAmount;
        public int newTargetAmount
        {
            get { return _newTargetAmount; }
            set
            {
                _newTargetAmount = value;
                OnPropertyChanged("newTargetAmount");
            }
        }

        private string _charityName;
        public string charityName
        {
            get { return _charityName; }
            set
            {
                _charityName = value;
                OnPropertyChanged("charityName");
            }
        }

        private int _targetAmount;
        public int targetAmount
        {
            get { return _targetAmount; }
            set
            {
                _targetAmount = value;
                OnPropertyChanged("targetAmount");
            }
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

            //access the nav view model
            NavigationViewModel navVM =
                App.Current.MainWindow.DataContext as NavigationViewModel;
            //change the location to pagetwo.xaml
            navVM.location = "Views/PageTwo.xaml";
        }
    }
}
