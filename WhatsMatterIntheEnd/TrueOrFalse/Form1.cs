using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueOrFalse
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            Check();

        }

        private void Check()
        {
            //oru values
            string firstWord = txtBxFirst.Text;
            string lastWord = txtBxLast.Text;

            //reads words
            string textBoard = rchTxtBxInsert.Text;

            //show whats is true
            MessageBox.Show($"{rchTxtBxInsert.Text.StartsWith(firstWord)}" + " and last is " +
                $"{rchTxtBxInsert.Text.EndsWith(lastWord)}");
                
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset app
            txtBxFirst.Text = " ";
            txtBxLast.Text = " ";
            rchTxtBxInsert.Text = " ";

        }
    }
}
