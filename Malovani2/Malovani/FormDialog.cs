using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malovani
{
    public partial class FormDialog : Form
    {
        string Answer = "";
        Form1 form1 = new Form1();
        public FormDialog()
        {
            InitializeComponent();
        }

        public string UserAnswer(string Answer)
        {
            return Answer;
        }
        private void buttonYes_Click(object sender, EventArgs e)
        {
            Answer = "yes";
            form1.actionDialog(Answer);
            this.Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Answer = "no";
            form1.actionDialog(Answer);
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Answer = "save";
            form1.actionDialog(Answer);
            this.Close();
        }
    }
}
