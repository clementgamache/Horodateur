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
    public partial class PunchWindow : Form
    {
        private Employee currentEmployee = null;
        public PunchWindow()
        {
            InitializeComponent();
        }


        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string newEntry = textBoxID.Text;
                if (newEntry.Length >= 3)
                {
                    textBoxID.Text = "";
                    currentEmployee = new Employee(newEntry);
                    Button buttonToEnable;
                    //display the employee
                    labelName.Text = currentEmployee.LastName + ", " + currentEmployee.FirstName;

                    //enable the button
                    if (currentEmployee.LastMomentIn == DateTime.MinValue) buttonToEnable = buttonIn;
                    else buttonToEnable = buttonOut;
                    buttonToEnable.Enabled = true;
                    buttonToEnable.Select();
                    AcceptButton = buttonToEnable;
                    buttonToEnable.ForeColor = Color.Blue;
                    
                }
                else
                {
                    disableButtons();
                }
            }
            catch (Exception ex) //entry is bad or ID does not exist
            {
                MessageBox.Show(ex.Message);
                textBoxID.Clear();
            }

        }

        private void addSelf(object sender, EventArgs e)
        {
            Button self = (Button)sender;
            textBoxID.Text += self.Text;

        }

        private void onTick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm tt");
            
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            try
            {
                currentEmployee.punchOut();
                disableButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonIn.Text = Translations.getRightString(0);
            buttonOut.Text = Translations.getRightString(1);
            labelName.Text = Translations.getRightString(2);
            disableButtons();
        }

        private void buttonIn_Click(object sender, EventArgs e)
        {
            try
            {
                currentEmployee.punchIn();
                disableButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void disableButtons()
        {
            labelName.Text = Translations.getRightString(2);
            buttonIn.ForeColor = buttonOut.ForeColor = Color.Black;
            buttonIn.Enabled = buttonOut.Enabled = false;
            textBoxID.SelectionStart = textBoxID.Text.Length;
            textBoxID.SelectionLength = 0;
            textBoxID.Select();
            currentEmployee = null;
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                string title = Translations.getRightString(3);
                string input = Microsoft.VisualBasic.Interaction.InputBox(title, title, "");
                string rightPassword = SQL.get("SELECT * FROM SETTINGS WHERE NAME = 'Password'", 2)[0][1];
                if (input != rightPassword)
                {
                    string exceptionMessage = Translations.getRightString(4);
                    throw new Exception(exceptionMessage);
                }
                MessageBox.Show("success");
                MenuWindow menuWindow = new MenuWindow();
                menuWindow.refToMain = this;
                Hide();
                menuWindow.Show();

            }
            catch (Exception ex)
            {
                string title = Translations.getRightString(5);
                MessageBox.Show(ex.Message);
            }



        }
    }
}
