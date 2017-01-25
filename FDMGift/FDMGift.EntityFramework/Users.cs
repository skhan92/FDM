﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMGift.EntityFramework
{
    public class Users
    {
        public virtual int id { get; set; }
        [DisplayName("Full Name")]
        public string fullName { get; set; }
        [DisplayName("E-Mail")]
        public string email { get; set; }
        [DisplayName("Password")]
        public string password { get; set; }
    }
}
