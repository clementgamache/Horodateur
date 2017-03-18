using Punch.Forms;
using Punch.SQL_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punch
{
    public partial class MenuWindow : Form
    {
        public PunchWindow refToMain { get; set; }

        public MenuWindow()
        {
            InitializeComponent();
        }

        private void MenuWindow_Load(object sender, EventArgs e)
        {
            setTranslations();
        }

        private void buttonReturnToPunch_Click(object sender, EventArgs e)
        {
            Close();
            refToMain.Show();
        }

        private void setTranslations()
        {
            buttonReturnToPunch.Text =  Translations.getRightString(7);
            buttonActivityManager.Text = Translations.getRightString(12);
            buttonDepartmentManager.Text = Translations.getRightString(9);
            buttonTypeManager.Text = Translations.getRightString(10);
            buttonEmployeeManager.Text = Translations.getRightString(8);
            buttonSettings.Text = Translations.getRightString(13);

        }

        private void closeAll(object sender, FormClosingEventArgs e)
        {
            refToMain.Close();
        }

        private void buttonEmployeeManager_Click(object sender, EventArgs e)
        {
            EmployeeManagerWindow newWindow = new EmployeeManagerWindow();
            newWindow.Show();
        }
    }
}
