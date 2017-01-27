using FDMGift.EntityFramework;
using FDMGift.Logic;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace FDMGift.WPF.ViewModels
{
    public class AdminViewModel : BaseViewModel
    {
        private static readonly ILog logger = LogManager.GetLogger("AdminViewModel.cs");

        UserRepository _userRepo;
        EFramework _EF;

        public AdminViewModel() 
        {
            _EF = new EFramework();
            _userRepo = new UserRepository(_EF);
        
        }

        private Users _user;

        public Users user
        {
            get { return _user; }
            set { _user = value; OnPropertyChanged("user"); }
        }

        private List<Users> _userList;

        public List<Users> userList
        {
            get { return _userList; }
            set 
            { 
                _userList = value;
                OnPropertyChanged("userList");
            }
        }
        
        //private string _IdToChange;
        //public string IdToChange
        //{
        //    get { return _IdToChange; }
        //    set
        //    {
        //        _IdToChange = value;
        //        OnPropertyChanged("IdToChange");
        //    }
        //}

        //private int _newTargetAmount;
        //public int newTargetAmount
        //{
        //    get { return _newTargetAmount; }
        //    set
        //    {
        //        _newTargetAmount = value;
        //        OnPropertyChanged("newTargetAmount");
        //    }
        //}

        //private string _charityName;
        //public string charityName
        //{
        //    get { return _charityName; }
        //    set
        //    {
        //        _charityName = value;
        //        OnPropertyChanged("charityName");
        //    }
        //}

        //private int _targetAmount;
        //public int targetAmount
        //{
        //    get { return _targetAmount; }
        //    set
        //    {
        //        _targetAmount = value;
        //        OnPropertyChanged("targetAmount");
        //    }
        //}

        private ICommand _navigateCommand;
        public ICommand navigateCommand
        {
            get
            {
                if (_navigateCommand == null)
                {
                    _navigateCommand = new Command(GetUsers, CanGetUsers);
                }
                return _navigateCommand;
            }
            set { _navigateCommand = value; }
        }

        //public AdminViewModel()
        //{
        //    userList = _userRepo.GetAllUsers();
        //}

        public void GetUsers()
        {
            logger.Info("User List has been returned");
            userList = _userRepo.GetAllUsers();
        }

        public bool CanGetUsers()
        {
            return true;
        }

        //private void Navigate()
        //{
            

        //    //access the nav view model
        //    NavigationViewModel navVM =
        //        App.Current.MainWindow.DataContext as NavigationViewModel;
        //    //change the location to pagetwo.xaml
        //    navVM.location = "Views/PageTwo.xaml";
        //}
    }
}
