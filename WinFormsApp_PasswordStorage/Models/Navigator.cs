﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp_PasswordStorage.Models
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

        /// <summary>
        /// Clears the GroupBox container of the previous usercontrol page
        /// </summary>
        /// <param name="pageContainer"></param>
        private void ClearPageContainer(GroupBox pageContainer)
        {
            if (pageContainer.Controls.Count > 0)
            {
                UserControl previousPage = pageContainer.Controls[0] as UserControl;
                pageContainer.Controls.Remove(previousPage);
            }
        }
    }
}
