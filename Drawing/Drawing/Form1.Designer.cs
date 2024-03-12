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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxFilled = new System.Windows.Forms.CheckBox();
            this.panelColorSelected = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBrushSize = new System.Windows.Forms.TextBox();
            this.CheckBoxTavr = new System.Windows.Forms.Label();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.labelFilled = new System.Windows.Forms.Label();
            this.panelPainting = new System.Windows.Forms.Panel();
            this.colorDialogColorSelect = new System.Windows.Forms.ColorDialog();
            this.panelTemp = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelPainting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 1181);
            this.panel1.TabIndex = 8;
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zvolená barva";
            // 
            // checkBoxFilled
            // 
            this.checkBoxFilled.AutoSize = true;
            this.checkBoxFilled.Location = new System.Drawing.Point(7, 353);
            this.checkBoxFilled.Name = "checkBoxFilled";
            this.checkBoxFilled.Size = new System.Drawing.Size(45, 17);
            this.checkBoxFilled.TabIndex = 6;
            this.checkBoxFilled.Text = "Ano";
            this.checkBoxFilled.UseVisualStyleBackColor = true;
            // 
            // panelColorSelected
            // 
            this.panelColorSelected.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelColorSelected.Location = new System.Drawing.Point(7, 72);
            this.panelColorSelected.Name = "panelColorSelected";
            this.panelColorSelected.Size = new System.Drawing.Size(35, 28);
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
            this.checkedListBox1.Location = new System.Drawing.Point(7, 253);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 60);
            this.checkedListBox1.TabIndex = 5;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Šířka štětce";
            // 
            // textBoxBrushSize
            // 
            this.textBoxBrushSize.Location = new System.Drawing.Point(7, 169);
            this.textBoxBrushSize.Name = "textBoxBrushSize";
            this.textBoxBrushSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrushSize.TabIndex = 4;
            this.textBoxBrushSize.Text = "10";
            this.textBoxBrushSize.TextChanged += new System.EventHandler(this.textBoxBrushSize_TextChanged);
            // 
            // CheckBoxTavr
            // 
            this.CheckBoxTavr.AutoSize = true;
            this.CheckBoxTavr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxTavr.Location = new System.Drawing.Point(7, 229);
            this.CheckBoxTavr.Name = "CheckBoxTavr";
            this.CheckBoxTavr.Size = new System.Drawing.Size(39, 20);
            this.CheckBoxTavr.TabIndex = 2;
            this.CheckBoxTavr.Text = "Tvar";
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Location = new System.Drawing.Point(48, 77);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeColor.TabIndex = 3;
            this.buttonChangeColor.Text = "Změnit";
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // labelFilled
            // 
            this.labelFilled.AutoSize = true;
            this.labelFilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFilled.Location = new System.Drawing.Point(3, 330);
            this.labelFilled.Name = "labelFilled";
            this.labelFilled.Size = new System.Drawing.Size(57, 20);
            this.labelFilled.TabIndex = 2;
            this.labelFilled.Text = "Výplň?";
            // 
            // panelPainting
            // 
            this.panelPainting.BackColor = System.Drawing.Color.White;
            this.panelPainting.Controls.Add(this.panelTemp);
            this.panelPainting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPainting.ForeColor = System.Drawing.Color.Transparent;
            this.panelPainting.Location = new System.Drawing.Point(135, 0);
            this.panelPainting.Name = "panelPainting";
            this.panelPainting.Size = new System.Drawing.Size(1789, 1181);
            this.panelPainting.TabIndex = 9;
            // 
            // panelTemp
            // 
            this.panelTemp.BackColor = System.Drawing.Color.Transparent;
            this.panelTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTemp.ForeColor = System.Drawing.Color.Transparent;
            this.panelTemp.Location = new System.Drawing.Point(0, 0);
            this.panelTemp.Name = "panelTemp";
            this.panelTemp.Size = new System.Drawing.Size(1789, 1181);
            this.panelTemp.TabIndex = 10;
            this.panelTemp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTemp_MouseDown);
            this.panelTemp.MouseHover += new System.EventHandler(this.panelTemp_MouseHover);
            this.panelTemp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTemp_MouseMove);
            this.panelTemp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTemp_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Vymazat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1181);
            this.Controls.Add(this.panelPainting);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPainting.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelPainting;
        private System.Windows.Forms.ColorDialog colorDialogColorSelect;
        private System.Windows.Forms.Panel panelTemp;
        private System.Windows.Forms.Button button1;
    }
}

