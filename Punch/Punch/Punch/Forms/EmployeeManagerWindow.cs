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
    public partial class EmployeeManagerWindow : Form
    {
        public EmployeeManagerWindow()
        {
            InitializeComponent();
        }

        private void EmployeeManagerWindow_Load(object sender, EventArgs e)
        {
            try
            {
                setTranslations();
                radioButtons_ActionChanged(sender, e);
                updateEmployeeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setTranslations()
        {
            groupBoxEmployeeManager.Text = Translations.getRightString(24);
            groupBoxEmployeeParameters.Text = Translations.getRightString(23);
            radioButtonCreate.Text = Translations.getRightString(25);
            radioButtonUpdate.Text = Translations.getRightString(26);
            groupBoxEmployeeAction.Text = Translations.getRightString(22);
            groupBoxEmployeeSelect.Text = Translations.getRightString(21);
            groupBoxFilter.Text = Translations.getRightString(19);
            groupBoxSort.Text = Translations.getRightString(20);
            radioButtonId.Text = groupBoxId.Text = Translations.getRightString(14);
            radioButtonFirstName.Text = groupBoxFirstName.Text = Translations.getRightString(15);
            radioButtonLastName.Text = groupBoxLastName.Text = Translations.getRightString(16);
            groupBoxType.Text = groupBoxTypeFilter.Text = Translations.getRightString(17);
            groupBoxDepartment.Text = groupBoxDepartmentFilter.Text = Translations.getRightString(18);
            groupBoxRun.Text = Translations.getRightString(27);
            buttonCreate.Text = Translations.getRightString(28);
            buttonUpdate.Text = Translations.getRightString(29);
            buttonDelete.Text = Translations.getRightString(30);
        }

        private void clearTextBoxes()
        {
            textBoxId.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
        }

        

        private void selectAnIndex()
        {
            if (listBoxEmployees.SelectedIndex == -1 && listBoxEmployees.Items.Count > 0)
            {
                listBoxEmployees.SelectedIndex = 0;
            }
        }

        private string getSelectedId()
        {
            string line = listBoxEmployees.SelectedItem.ToString();
            if (radioButtonId.Checked)
            {
                return line.Substring(0, 3);
            }
            return line.Substring(line.Length - 3, 3);
        }

        private void updateEmployeeList()
        {
            fillEmployeeList();
            selectAnIndex();
        }

        private string getEmployeeRequest()
        {
            string request = "select * from employees";
            string orderBystring = " order by ";
            if (radioButtonId.Checked)
            {
                orderBystring += "id";
            }
            else if (radioButtonFirstName.Checked)
            {
                orderBystring += "firstname";
            }
            else
            {
                orderBystring += "lastname";
            }
            request += orderBystring;
            return request;
        }

        private void fillEmployeeList()
        {
            listBoxEmployees.Items.Clear();
            List<Employee> allEmployees = Employee.getEmployees(getEmployeeRequest());
            foreach(Employee employee in allEmployees)
            {
                string line;
                if (radioButtonId.Checked)
                {
                    line = employee.Id + "\t" + employee.LastName + ", " + employee.FirstName;
                }
                else
                {
                    if (radioButtonFirstName.Checked)
                    {
                        line = employee.FirstName + " " + employee.LastName ;
                    }
                    else
                    {
                        line = employee.LastName + ", " + employee.FirstName;
                    }
                    
                    int desitedWidth = 200;
                    int width = TextRenderer.MeasureText(line, listBoxEmployees.Font).Width;
                    int tabSize = 50;
                    int tabs = (desitedWidth - width)/tabSize ;

                    line += new string('\t', tabs);
                    line += employee.Id;
                }
                listBoxEmployees.Items.Add(line);
            }
        }

        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonUpdate.Checked)
            {
                textBoxId.Text = getSelectedId();
                Employee currentEmployee = new Employee(textBoxId.Text);
                textBoxLastName.Text = currentEmployee.LastName;
                textBoxFirstName.Text = currentEmployee.FirstName;
            }
        }

        /**
         * Radio Button handlers
         */
        private void radioButtons_ActionChanged(object sender, EventArgs e)
        {
            if (radioButtonCreate.Checked)
            {
                textBoxId.Enabled = true;
                buttonCreate.Enabled = true;
                buttonUpdate.Enabled = false;
                buttonDelete.Enabled = false;
                groupBoxEmployeeSelect.Enabled = false;
                clearTextBoxes();
            }
            else
            {
                textBoxId.Enabled = false;
                buttonCreate.Enabled = false;
                buttonUpdate.Enabled = true;
                buttonDelete.Enabled = true;
                groupBoxEmployeeSelect.Enabled = true;
                selectAnIndex();
            }
        }

        private void radioButtons_SortChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                updateEmployeeList();
            }

        }

        /**
         * Buttons handlers
         */
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Employee newEmployee = new Employee(textBoxId.Text, textBoxFirstName.Text, textBoxLastName.Text);
                newEmployee.insert();
                updateEmployeeList();
                clearTextBoxes();
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
                Employee currentEmploye = new Employee(textBoxId.Text);
                currentEmploye.FirstName = textBoxFirstName.Text;
                currentEmploye.LastName = textBoxLastName.Text;
                currentEmploye.update();
                updateEmployeeList();
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
                Employee currentEmploye = new Employee(textBoxId.Text);
                currentEmploye.delete();
                updateEmployeeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
