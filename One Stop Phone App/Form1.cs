using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Stop_Phone_App
{
    public partial class OneStopPhoneApp : Form
    {
        private string phoneType = "";
        private string pcondition = "";
        public OneStopPhoneApp()
        {
            InitializeComponent();
            this.phoneComboBox.SelectedIndex = 0;
            this.pconditionComboBox.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void transactionalListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OneStopPhoneApp_Load(object sender, EventArgs e)
        {

        }

        private void confirmationButton_Click(object sender, EventArgs e)
        {
            transactionalListBox.Items.Add("You are planning to trading in a " + this.pconditionComboBox.Text +" " + this.phoneComboBox.Text + " cell phone.");
        }

        private void phoneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // phoneComboBox.Items.Insert(0, "-Select a Phone-");
            // phoneComboBox.SelectedIndex = 0;

        }

        private void pconditionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string phoneCondition = pconditionComboBox.SelectedItem.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            transactionalListBox.Items.Clear();
        }
    }
}
