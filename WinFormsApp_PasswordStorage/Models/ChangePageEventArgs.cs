using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_PasswordStorage.Models
{
    public enum Page
    {
        Login,
        Registration,
        Account
    }

    /// <summary>
    /// Costom event arg to use when invoking ChangePage.
    /// </summary>
    public class ChangePageEventArgs
    {
        public ChangePageEventArgs(Page page) { Page = page; }
        public Page Page { get; private set; }
    }
}
