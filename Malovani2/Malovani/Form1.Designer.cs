namespace Malovani
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelColorName = new System.Windows.Forms.Label();
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelSelectedColor = new System.Windows.Forms.Label();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.colorDialogSelected = new System.Windows.Forms.ColorDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.buttonImportIMg = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.Window;
            this.panelSideMenu.Controls.Add(this.numericUpDown1);
            this.panelSideMenu.Controls.Add(this.label2);
            this.panelSideMenu.Controls.Add(this.checkedListBox1);
            this.panelSideMenu.Controls.Add(this.label1);
            this.panelSideMenu.Controls.Add(this.buttonImportIMg);
            this.panelSideMenu.Controls.Add(this.buttonReset);
            this.panelSideMenu.Controls.Add(this.button1);
            this.panelSideMenu.Controls.Add(this.labelColorName);
            this.panelSideMenu.Controls.Add(this.panelColor);
            this.panelSideMenu.Controls.Add(this.labelSelectedColor);
            this.panelSideMenu.Controls.Add(this.buttonChangeColor);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 863);
            this.panelSideMenu.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.White;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.ForeColor = System.Drawing.Color.Black;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Elipsa",
            "Obdelník"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 307);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 85);
            this.checkedListBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kreslení tvarů:";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(3, 695);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(194, 75);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Vymazat a začít znovu";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 776);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 75);
            this.button1.TabIndex = 4;
            this.button1.Text = "Vytisknout výtvor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelColorName
            // 
            this.labelColorName.AutoSize = true;
            this.labelColorName.Location = new System.Drawing.Point(106, 48);
            this.labelColorName.Name = "labelColorName";
            this.labelColorName.Size = new System.Drawing.Size(62, 16);
            this.labelColorName.TabIndex = 3;
            this.labelColorName.Text = "dffdfdfdfd";
            // 
            // panelColor
            // 
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Location = new System.Drawing.Point(4, 29);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(96, 60);
            this.panelColor.TabIndex = 2;
            // 
            // labelSelectedColor
            // 
            this.labelSelectedColor.AutoSize = true;
            this.labelSelectedColor.Location = new System.Drawing.Point(3, 9);
            this.labelSelectedColor.Name = "labelSelectedColor";
            this.labelSelectedColor.Size = new System.Drawing.Size(97, 16);
            this.labelSelectedColor.TabIndex = 1;
            this.labelSelectedColor.Text = "Zvolená barva:";
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Location = new System.Drawing.Point(3, 95);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(194, 23);
            this.buttonChangeColor.TabIndex = 0;
            this.buttonChangeColor.Text = "Změnit barvu";
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // colorDialogSelected
            // 
            this.colorDialogSelected.FullOpen = true;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Šírka štětce";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(6, 157);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // buttonImportIMg
            // 
            this.buttonImportIMg.Location = new System.Drawing.Point(3, 614);
            this.buttonImportIMg.Name = "buttonImportIMg";
            this.buttonImportIMg.Size = new System.Drawing.Size(194, 75);
            this.buttonImportIMg.TabIndex = 4;
            this.buttonImportIMg.Text = "Importovat obrázek";
            this.buttonImportIMg.UseVisualStyleBackColor = true;
            this.buttonImportIMg.Click += new System.EventHandler(this.buttonImportImg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1938, 863);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label labelSelectedColor;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.ColorDialog colorDialogSelected;
        private System.Windows.Forms.Label labelColorName;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Button buttonImportIMg;
    }
}

