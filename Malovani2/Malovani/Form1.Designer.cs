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
            this.labelSize = new System.Windows.Forms.Label();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonImportIMg = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelColorName = new System.Windows.Forms.Label();
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelSelectedColor = new System.Windows.Forms.Label();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.colorDialogSelected = new System.Windows.Forms.ColorDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelPosX = new System.Windows.Forms.Label();
            this.labelPosY = new System.Windows.Forms.Label();
            this.labelPosi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPosXStart = new System.Windows.Forms.Label();
            this.labelPosYStart = new System.Windows.Forms.Label();
            this.panelPositition = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            this.panelPositition.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.Window;
            this.panelSideMenu.Controls.Add(this.panelPositition);
            this.panelSideMenu.Controls.Add(this.labelPosY);
            this.panelSideMenu.Controls.Add(this.labelPosX);
            this.panelSideMenu.Controls.Add(this.labelY);
            this.panelSideMenu.Controls.Add(this.labelX);
            this.panelSideMenu.Controls.Add(this.labelSize);
            this.panelSideMenu.Controls.Add(this.trackBarSize);
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
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(150, 701);
            this.panelSideMenu.TabIndex = 0;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(59, 160);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(19, 13);
            this.labelSize.TabIndex = 10;
            this.labelSize.Text = "12";
            // 
            // trackBarSize
            // 
            this.trackBarSize.LargeChange = 10;
            this.trackBarSize.Location = new System.Drawing.Point(3, 128);
            this.trackBarSize.Maximum = 100;
            this.trackBarSize.Minimum = 2;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(142, 45);
            this.trackBarSize.SmallChange = 2;
            this.trackBarSize.TabIndex = 9;
            this.trackBarSize.Value = 12;
            this.trackBarSize.ValueChanged += new System.EventHandler(this.trackBarSize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Šírka štětce";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.White;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.ForeColor = System.Drawing.Color.Black;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Volný tvar",
            "Obdelník",
            "Čtverec",
            "Elipsa",
            "Kruh"});
            this.checkedListBox1.Location = new System.Drawing.Point(4, 219);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(90, 90);
            this.checkedListBox1.TabIndex = 6;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kreslení tvarů:";
            // 
            // buttonImportIMg
            // 
            this.buttonImportIMg.Location = new System.Drawing.Point(1, 313);
            this.buttonImportIMg.Margin = new System.Windows.Forms.Padding(2);
            this.buttonImportIMg.Name = "buttonImportIMg";
            this.buttonImportIMg.Size = new System.Drawing.Size(146, 61);
            this.buttonImportIMg.TabIndex = 4;
            this.buttonImportIMg.Text = "Importovat obrázek";
            this.buttonImportIMg.UseVisualStyleBackColor = true;
            this.buttonImportIMg.Click += new System.EventHandler(this.buttonImportImg_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(2, 378);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(146, 61);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Vymazat a začít znovu";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 443);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Vytisknout výtvor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelColorName
            // 
            this.labelColorName.AutoSize = true;
            this.labelColorName.Location = new System.Drawing.Point(80, 39);
            this.labelColorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelColorName.Name = "labelColorName";
            this.labelColorName.Size = new System.Drawing.Size(52, 13);
            this.labelColorName.TabIndex = 3;
            this.labelColorName.Text = "dffdfdfdfd";
            // 
            // panelColor
            // 
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Location = new System.Drawing.Point(3, 24);
            this.panelColor.Margin = new System.Windows.Forms.Padding(2);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(72, 49);
            this.panelColor.TabIndex = 2;
            // 
            // labelSelectedColor
            // 
            this.labelSelectedColor.AutoSize = true;
            this.labelSelectedColor.Location = new System.Drawing.Point(2, 7);
            this.labelSelectedColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSelectedColor.Name = "labelSelectedColor";
            this.labelSelectedColor.Size = new System.Drawing.Size(79, 13);
            this.labelSelectedColor.TabIndex = 1;
            this.labelSelectedColor.Text = "Zvolená barva:";
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Location = new System.Drawing.Point(2, 77);
            this.buttonChangeColor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(146, 19);
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
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelX.Location = new System.Drawing.Point(74, 640);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(72, 25);
            this.labelX.TabIndex = 11;
            this.labelX.Text = "labelX";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelY.Location = new System.Drawing.Point(75, 674);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(73, 25);
            this.labelY.TabIndex = 11;
            this.labelY.Text = "labelY";
            // 
            // labelPosX
            // 
            this.labelPosX.AutoSize = true;
            this.labelPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPosX.Location = new System.Drawing.Point(3, 645);
            this.labelPosX.Name = "labelPosX";
            this.labelPosX.Size = new System.Drawing.Size(75, 20);
            this.labelPosX.TabIndex = 12;
            this.labelPosX.Text = "Pozice X:";
            // 
            // labelPosY
            // 
            this.labelPosY.AutoSize = true;
            this.labelPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPosY.Location = new System.Drawing.Point(4, 678);
            this.labelPosY.Name = "labelPosY";
            this.labelPosY.Size = new System.Drawing.Size(75, 20);
            this.labelPosY.TabIndex = 12;
            this.labelPosY.Text = "Pozice Y:";
            // 
            // labelPosi
            // 
            this.labelPosi.AutoSize = true;
            this.labelPosi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPosi.Location = new System.Drawing.Point(75, 9);
            this.labelPosi.Name = "labelPosi";
            this.labelPosi.Size = new System.Drawing.Size(72, 25);
            this.labelPosi.TabIndex = 11;
            this.labelPosi.Text = "labelX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(76, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "labelY";
            // 
            // labelPosXStart
            // 
            this.labelPosXStart.AutoSize = true;
            this.labelPosXStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPosXStart.Location = new System.Drawing.Point(4, 14);
            this.labelPosXStart.Name = "labelPosXStart";
            this.labelPosXStart.Size = new System.Drawing.Size(75, 20);
            this.labelPosXStart.TabIndex = 12;
            this.labelPosXStart.Text = "Pozice X:";
            // 
            // labelPosYStart
            // 
            this.labelPosYStart.AutoSize = true;
            this.labelPosYStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPosYStart.Location = new System.Drawing.Point(5, 47);
            this.labelPosYStart.Name = "labelPosYStart";
            this.labelPosYStart.Size = new System.Drawing.Size(75, 20);
            this.labelPosYStart.TabIndex = 12;
            this.labelPosYStart.Text = "Pozice Y:";
            // 
            // panelPositition
            // 
            this.panelPositition.Controls.Add(this.labelPosYStart);
            this.panelPositition.Controls.Add(this.labelPosi);
            this.panelPositition.Controls.Add(this.label4);
            this.panelPositition.Controls.Add(this.labelPosXStart);
            this.panelPositition.Location = new System.Drawing.Point(0, 534);
            this.panelPositition.Name = "panelPositition";
            this.panelPositition.Size = new System.Drawing.Size(150, 69);
            this.panelPositition.TabIndex = 13;
            this.panelPositition.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 701);
            this.Controls.Add(this.panelSideMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            this.panelPositition.ResumeLayout(false);
            this.panelPositition.PerformLayout();
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
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Button buttonImportIMg;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelPosX;
        private System.Windows.Forms.Label labelPosY;
        private System.Windows.Forms.Panel panelPositition;
        private System.Windows.Forms.Label labelPosYStart;
        private System.Windows.Forms.Label labelPosi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPosXStart;
    }
}

