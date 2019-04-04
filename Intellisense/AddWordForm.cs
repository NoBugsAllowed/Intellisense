using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intellisense
{
    public partial class AddWordForm : Form
    {
        private String newWord = "";
        public AddWordForm()
        {
            InitializeComponent();
            this.addWordTextBox.Left = this.Width / 2 - this.addWordTextBox.Width / 2;
            this.btnCancel.Left = this.Width / 4 - this.btnCancel.Width / 2;
            this.btnOk.Left = 3 * this.Width / 4 - this.btnOk.Width / 2; 
        }

        public String Word
        {
            get { return newWord; }
            set { newWord = value; this.addWordTextBox.Text = newWord; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addWordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (addWordTextBox.Text.Length == 0)
            {
                errorProvider.SetError(addWordTextBox, "Cannot be empty!");
                return;
            }
            else
                foreach (char c in addWordTextBox.Text)
                    if (!char.IsLetter(c))
                    {
                        errorProvider.SetError(addWordTextBox, "Only letters are allowed");
                        return;
                    }
            errorProvider.SetError(addWordTextBox, "");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(errorProvider.GetError(addWordTextBox)!="")
            {
                var result = MessageBox.Show("Validation error!");
            }
            else
            {
                this.newWord = addWordTextBox.Text;
                this.Close();
            }
        }
    }
}
