using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09_Monday
{
    public partial class Week_09_Form : Form
    {/// <summary>
    /// This is the constructor for the calculator_form
    /// </summary>
        public Week_09_Form()
        {
            InitializeComponent();
        }

        private void Week_09_Form_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This is the shared event handler for all the calculator buttons - Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;

            int ButtonValue;

            bool resultcondition = int.TryParse(TheButton.Text, out ButtonValue);
            if (resultcondition)
            {
                Result_label.Text += TheButton.Text;
            }
            else
            {
                Result_label.Text = "NOT A NUMBER (NAN)";
            }
        }
    }
}
