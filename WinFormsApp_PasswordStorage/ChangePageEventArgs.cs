﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_PasswordStorage
{
    public enum Page
    {
        Login,
        Registration,
        Account
    }

    public class ChangePageEventArgs
    {
        public ChangePageEventArgs(Page page) { this.Page = page; }
        public Page Page { get; private set; }
    }
}