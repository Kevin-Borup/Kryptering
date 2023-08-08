using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp_PasswordStorage.Models;

namespace WinFormsApp_PasswordStorage
{
    /// <summary>
    /// An interface to easily implement the changepage event on all UserControls.
    /// </summary>
    public class ChangePageControl : UserControl
    {
        public delegate void ChangePageEventHandler(object sender, ChangePageEventArgs e);

        public event ChangePageEventHandler ChangePageEvent;

        public void ChangePage(Page page)
        {
            ChangePageEvent?.Invoke(this, new ChangePageEventArgs(page));
        }
    }
}
