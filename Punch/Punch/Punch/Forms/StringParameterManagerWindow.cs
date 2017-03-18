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

namespace Punch.Forms
{
    public partial class StringParameterManagerWindow : Form
    {
        string tableName;
        int titleId;

        public StringParameterManagerWindow(string tableName, int titleId)
        {
            InitializeComponent();
            this.tableName = tableName;
            this.titleId = titleId; 
        }

        private void StringParameterManagerWindow_Load(object sender, EventArgs e)
        {
            groupBoxSelect.Text = Translations.getRightString(21);
            groupBoxName.Text = Translations.getRightString(31);
            groupBoxAction.Text = Translations.getRightString(22);
            groupBoxRun.Text = Translations.getRightString(27);
            buttonCreate.Text = Translations.getRightString(28);
            buttonUpdate.Text = Translations.getRightString(29);
            buttonDelete.Text = Translations.getRightString(30);
            radioButtonCreate.Text = Translations.getRightString(25);
            radioButtonUpdate.Text = Translations.getRightString(26);
            labelTitle.Text = Translations.getRightString(titleId);

        }

        /**
         * Radio Button handlers
         */
        private void radioButtons_ActionChanged(object sender, EventArgs e)
        {
            if (radioButtonCreate.Checked)
            {
                //textBoxId.Enabled = true;
                //buttonCreate.Enabled = true;
                //buttonUpdate.Enabled = false;
                //buttonDelete.Enabled = false;
                //groupBoxEmployeeSelect.Enabled = false;
                //clearTextBoxes();
            }
            else
            {
                //textBoxId.Enabled = false;
                //buttonCreate.Enabled = false;
                //buttonUpdate.Enabled = true;
                //buttonDelete.Enabled = true;
                //groupBoxEmployeeSelect.Enabled = true;
                //selectAnIndex();
            }
        

        /**
         * Buttons handlers
         */
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Employee newEmployee = new Employee(textBoxId.Text, textBoxFirstName.Text, textBoxLastName.Text);
                //newEmployee.insert();
                //updateEmployeeList();
                //clearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Employee currentEmploye = Employee.getEmployee(textBoxId.Text);
                //currentEmploye.FirstName = textBoxFirstName.Text;
                //currentEmploye.LastName = textBoxLastName.Text;
                //currentEmploye.update();
                //updateEmployeeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Employee currentEmploye = Employee.getEmployee(textBoxId.Text);
                //currentEmploye.delete();
                //updateEmployeeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
