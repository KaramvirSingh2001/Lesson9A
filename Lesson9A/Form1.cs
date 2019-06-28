using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson9A
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// This is the constructor method
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// this is the shared ecent handler for all of the calculator buttons click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorNumbers_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;


            try
            {
                int.Parse(selectedButton.Text);
                ResultLabel.Text = selectedButton.Text;
            }
            catch
            {
                ResultLabel.Text = "Not a number";
            }
            //switch (selectedButton.Text)
            //{
            //    case "1":
            //        ResultLabel.Text = "1";
            //        break;
            //    default:
            //        break;
            //}
        }

        private void NumberButtonTableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
