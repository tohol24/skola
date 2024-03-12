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
    public partial class Form1 : Form
    {
        int BrushSize = 10;
        bool Fill = false;
        string Shape = "Line";
        Pen myPen = new Pen(Color.Black, 3);
        Pen systemPen = new Pen(Color.Black, 3);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;
        }

        private void textBoxBrushSize_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxBrushSize.Text, out int n))
            {

                int Size = Convert.ToInt32(textBoxBrushSize.Text);
                if (Size > 0)
                {
                    BrushSize = Size;
                }
                else
                {
                    MessageBox.Show("Toto není platná hodnota. Byla změněna na 10");
                    BrushSize = 10;
                    textBoxBrushSize.Text = "10";
                }
            }
            else
            {
                MessageBox.Show("Toto není platná hodnota. Byla změněna na 10");
            }
        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            colorDialogColorSelect.ShowDialog();
            panelColorSelected.BackColor = colorDialogColorSelect.Color;
            myPen.Color = colorDialogColorSelect.Color;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iSelectedIndex = checkedListBox1.SelectedIndex;
            if (iSelectedIndex == -1)
                return;
            for (int iIndex = 0; iIndex < checkedListBox1.Items.Count; iIndex++)
                checkedListBox1.SetItemCheckState(iIndex, CheckState.Unchecked);
            checkedListBox1.SetItemCheckState(iSelectedIndex, CheckState.Checked);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
      
        }

        private void panelPainting_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void panelPainting_Paint_1(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }
    }
}
