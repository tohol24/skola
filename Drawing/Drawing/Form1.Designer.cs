namespace Drawing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTemporary = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxFilled = new System.Windows.Forms.CheckBox();
            this.panelColorSelected = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBrushSize = new System.Windows.Forms.TextBox();
            this.CheckBoxTavr = new System.Windows.Forms.Label();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.labelFilled = new System.Windows.Forms.Label();
            this.colorDialogColorSelect = new System.Windows.Forms.ColorDialog();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTemporary);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBoxFilled);
            this.panel1.Controls.Add(this.panelColorSelected);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxBrushSize);
            this.panel1.Controls.Add(this.CheckBoxTavr);
            this.panel1.Controls.Add(this.buttonChangeColor);
            this.panel1.Controls.Add(this.labelFilled);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 1417);
            this.panel1.TabIndex = 8;
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // panelTemporary
            // 
            this.panelTemporary.Location = new System.Drawing.Point(9, 618);
            this.panelTemporary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTemporary.Name = "panelTemporary";
            this.panelTemporary.Size = new System.Drawing.Size(65, 52);
            this.panelTemporary.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 503);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Vymazat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zvolená barva";
            // 
            // checkBoxFilled
            // 
            this.checkBoxFilled.AutoSize = true;
            this.checkBoxFilled.Location = new System.Drawing.Point(9, 434);
            this.checkBoxFilled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxFilled.Name = "checkBoxFilled";
            this.checkBoxFilled.Size = new System.Drawing.Size(50, 20);
            this.checkBoxFilled.TabIndex = 6;
            this.checkBoxFilled.Text = "Ano";
            this.checkBoxFilled.UseVisualStyleBackColor = true;
            // 
            // panelColorSelected
            // 
            this.panelColorSelected.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelColorSelected.Location = new System.Drawing.Point(9, 89);
            this.panelColorSelected.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelColorSelected.Name = "panelColorSelected";
            this.panelColorSelected.Size = new System.Drawing.Size(47, 34);
            this.panelColorSelected.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Volný tvar",
            "Linka",
            "Čtverec",
            "Elipsa"});
            this.checkedListBox1.Location = new System.Drawing.Point(9, 311);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(160, 68);
            this.checkedListBox1.TabIndex = 5;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(4, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Šířka štětce";
            // 
            // textBoxBrushSize
            // 
            this.textBoxBrushSize.Location = new System.Drawing.Point(9, 208);
            this.textBoxBrushSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBrushSize.Name = "textBoxBrushSize";
            this.textBoxBrushSize.Size = new System.Drawing.Size(132, 22);
            this.textBoxBrushSize.TabIndex = 4;
            this.textBoxBrushSize.Text = "10";
            this.textBoxBrushSize.TextChanged += new System.EventHandler(this.textBoxBrushSize_TextChanged);
            // 
            // CheckBoxTavr
            // 
            this.CheckBoxTavr.AutoSize = true;
            this.CheckBoxTavr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxTavr.Location = new System.Drawing.Point(9, 282);
            this.CheckBoxTavr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CheckBoxTavr.Name = "CheckBoxTavr";
            this.CheckBoxTavr.Size = new System.Drawing.Size(52, 25);
            this.CheckBoxTavr.TabIndex = 2;
            this.CheckBoxTavr.Text = "Tvar";
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Location = new System.Drawing.Point(64, 95);
            this.buttonChangeColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(100, 28);
            this.buttonChangeColor.TabIndex = 3;
            this.buttonChangeColor.Text = "Změnit";
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // labelFilled
            // 
            this.labelFilled.AutoSize = true;
            this.labelFilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFilled.Location = new System.Drawing.Point(4, 406);
            this.labelFilled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilled.Name = "labelFilled";
            this.labelFilled.Size = new System.Drawing.Size(73, 25);
            this.labelFilled.TabIndex = 2;
            this.labelFilled.Text = "Výplň?";
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.Color.Transparent;
            this.panelDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDraw.ForeColor = System.Drawing.Color.Transparent;
            this.panelDraw.Location = new System.Drawing.Point(180, 0);
            this.panelDraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(2384, 1417);
            this.panelDraw.TabIndex = 10;
            this.panelDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTemp_Paint);
            this.panelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTemp_MouseDown);
            this.panelDraw.MouseHover += new System.EventHandler(this.panelTemp_MouseHover);
            this.panelDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTemp_MouseMove);
            this.panelDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTemp_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1417);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxFilled;
        private System.Windows.Forms.Panel panelColorSelected;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBrushSize;
        private System.Windows.Forms.Label CheckBoxTavr;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.Label labelFilled;
        private System.Windows.Forms.ColorDialog colorDialogColorSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Panel panelTemporary;
    }
}

