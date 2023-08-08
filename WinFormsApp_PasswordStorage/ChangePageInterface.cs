using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_PasswordStorage
{
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
