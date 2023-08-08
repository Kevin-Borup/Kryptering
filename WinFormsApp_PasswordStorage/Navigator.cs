using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp_PasswordStorage
{

    internal class Navigator
    {
        private GroupBox pageContainer;
        public Navigator(GroupBox pageContainer)
        {
            this.pageContainer = pageContainer;
        }

        public void ChangePage(UserControl page)
        {
            ClearPageContainer(pageContainer);

            pageContainer.Controls.Add(page);
        }

        private void ClearPageContainer(GroupBox pageContainer)
        {
            if (pageContainer.Controls.Count > 0)
            {
                UserControl previousPage = pageContainer.Controls[0] as UserControl;
                pageContainer.Controls.Remove(previousPage);
                previousPage.Dispose();
            }
        }
    }
}
