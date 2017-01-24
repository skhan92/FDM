﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMGift.WPF.ViewModels
{
    public class NavigationViewModel : BaseViewModel
    {
        private string _location;

        public string location
        {
            get { return _location; }
            set
            {
                _location = value;
                OnPropertyChanged("location");
            }
        }

        public NavigationViewModel()
        {
            location = "Views/PageOne.xaml";
        }
    }
}