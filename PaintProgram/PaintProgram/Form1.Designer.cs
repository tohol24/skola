namespace PaintProgram
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
            this.buttonFill = new System.Windows.Forms.Button();
            this.labelActualPos = new System.Windows.Forms.Label();
            this.labelStartPos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX = new System.Windows.Forms.Label();
            this.labelPosY = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelPosX = new System.Windows.Forms.Label();
            this.panelPositition = new System.Windows.Forms.Panel();
            this.labelPosYStart = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelPosXStart = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonImportImg = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelColorName = new System.Windows.Forms.Label();
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelSelectedColor = new System.Windows.Forms.Label();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.panelUpperMenu = new System.Windows.Forms.Panel();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPainting = new System.Windows.Forms.Panel();
            this.colorDialogSelected = new System.Windows.Forms.ColorDialog();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialogBackColor = new System.Windows.Forms.ColorDialog();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelPositition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            this.panelUpperMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelSideMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSideMenu.Controls.Add(this.labelInfo);
            this.panelSideMenu.Controls.Add(this.buttonFill);
            this.panelSideMenu.Controls.Add(this.labelActualPos);
            this.panelSideMenu.Controls.Add(this.labelStartPos);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.panelPositition);
            this.panelSideMenu.Controls.Add(this.labelSize);
            this.panelSideMenu.Controls.Add(this.trackBarSize);
            this.panelSideMenu.Controls.Add(this.label2);
            this.panelSideMenu.Controls.Add(this.checkedListBox1);
            this.panelSideMenu.Controls.Add(this.label1);
            this.panelSideMenu.Controls.Add(this.buttonImportImg);
            this.panelSideMenu.Controls.Add(this.buttonReset);
            this.panelSideMenu.Controls.Add(this.button1);
            this.panelSideMenu.Controls.Add(this.labelColorName);
            this.panelSideMenu.Controls.Add(this.panelColor);
            this.panelSideMenu.Controls.Add(this.labelSelectedColor);
            this.panelSideMenu.Controls.Add(this.buttonChangeColor);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(215, 1274);
            this.panelSideMenu.TabIndex = 0;
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(118, 268);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(75, 81);
            this.buttonFill.TabIndex = 33;
            this.buttonFill.Text = "Klikni pro výplň";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Visible = false;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // labelActualPos
            // 
            this.labelActualPos.AutoSize = true;
            this.labelActualPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelActualPos.Location = new System.Drawing.Point(3, 818);
            this.labelActualPos.Name = "labelActualPos";
            this.labelActualPos.Size = new System.Drawing.Size(113, 20);
            this.labelActualPos.TabIndex = 31;
            this.labelActualPos.Text = "Pozice kurzoru";
            // 
            // labelStartPos
            // 
            this.labelStartPos.AutoSize = true;
            this.labelStartPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStartPos.Location = new System.Drawing.Point(3, 650);
            this.labelStartPos.Name = "labelStartPos";
            this.labelStartPos.Size = new System.Drawing.Size(111, 20);
            this.labelStartPos.TabIndex = 31;
            this.labelStartPos.Text = "Výsledný útvar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelX);
            this.panel1.Controls.Add(this.labelPosY);
            this.panel1.Controls.Add(this.labelY);
            this.panel1.Controls.Add(this.labelPosX);
            this.panel1.Location = new System.Drawing.Point(3, 841);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 90);
            this.panel1.TabIndex = 0;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelX.Location = new System.Drawing.Point(103, 6);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(84, 30);
            this.labelX.TabIndex = 26;
            this.labelX.Text = "labelX";
            // 
            // labelPosY
            // 
            this.labelPosY.AutoSize = true;
            this.labelPosY.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPosY.Location = new System.Drawing.Point(9, 52);
            this.labelPosY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPosY.Name = "labelPosY";
            this.labelPosY.Size = new System.Drawing.Size(95, 25);
            this.labelPosY.TabIndex = 29;
            this.labelPosY.Text = "Pozice Y:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelY.Location = new System.Drawing.Point(104, 48);
            this.labelY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(83, 30);
            this.labelY.TabIndex = 27;
            this.labelY.Text = "labelY";
            // 
            // labelPosX
            // 
            this.labelPosX.AutoSize = true;
            this.labelPosX.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPosX.Location = new System.Drawing.Point(8, 12);
            this.labelPosX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPosX.Name = "labelPosX";
            this.labelPosX.Size = new System.Drawing.Size(96, 25);
            this.labelPosX.TabIndex = 28;
            this.labelPosX.Text = "Pozice X:";
            // 
            // panelPositition
            // 
            this.panelPositition.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelPositition.Controls.Add(this.labelPosYStart);
            this.panelPositition.Controls.Add(this.labelA);
            this.panelPositition.Controls.Add(this.labelB);
            this.panelPositition.Controls.Add(this.labelPosXStart);
            this.panelPositition.Location = new System.Drawing.Point(4, 674);
            this.panelPositition.Margin = new System.Windows.Forms.Padding(4);
            this.panelPositition.Name = "panelPositition";
            this.panelPositition.Size = new System.Drawing.Size(200, 140);
            this.panelPositition.TabIndex = 30;
            this.panelPositition.Visible = false;
            // 
            // labelPosYStart
            // 
            this.labelPosYStart.AutoSize = true;
            this.labelPosYStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPosYStart.Location = new System.Drawing.Point(0, 73);
            this.labelPosYStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPosYStart.Name = "labelPosYStart";
            this.labelPosYStart.Size = new System.Drawing.Size(138, 25);
            this.labelPosYStart.TabIndex = 12;
            this.labelPosYStart.Text = "Délka strany Y";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelA.Location = new System.Drawing.Point(0, 25);
            this.labelA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(84, 30);
            this.labelA.TabIndex = 11;
            this.labelA.Text = "labelA";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelB.Location = new System.Drawing.Point(0, 98);
            this.labelB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(84, 30);
            this.labelB.TabIndex = 11;
            this.labelB.Text = "labelB";
            // 
            // labelPosXStart
            // 
            this.labelPosXStart.AutoSize = true;
            this.labelPosXStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPosXStart.Location = new System.Drawing.Point(0, 0);
            this.labelPosXStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPosXStart.Name = "labelPosXStart";
            this.labelPosXStart.Size = new System.Drawing.Size(139, 25);
            this.labelPosXStart.TabIndex = 12;
            this.labelPosXStart.Text = "Délka strany X";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSize.Location = new System.Drawing.Point(79, 195);
            this.labelSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(30, 24);
            this.labelSize.TabIndex = 25;
            this.labelSize.Text = "12";
            // 
            // trackBarSize
            // 
            this.trackBarSize.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.trackBarSize.LargeChange = 10;
            this.trackBarSize.Location = new System.Drawing.Point(4, 156);
            this.trackBarSize.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarSize.Maximum = 200;
            this.trackBarSize.Minimum = 2;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(189, 53);
            this.trackBarSize.SmallChange = 2;
            this.trackBarSize.TabIndex = 24;
            this.trackBarSize.Value = 12;
            this.trackBarSize.ValueChanged += new System.EventHandler(this.trackBarSize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(3, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Šírka štětce/gumy";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.ForeColor = System.Drawing.Color.Black;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Volný tvar",
            "Obdelník",
            "Čtverec",
            "Elipsa",
            "Kruh"});
            this.checkedListBox1.Location = new System.Drawing.Point(5, 268);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 102);
            this.checkedListBox1.TabIndex = 22;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(3, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kreslení tvarů:";
            // 
            // buttonImportImg
            // 
            this.buttonImportImg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonImportImg.Location = new System.Drawing.Point(9, 415);
            this.buttonImportImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonImportImg.Name = "buttonImportImg";
            this.buttonImportImg.Size = new System.Drawing.Size(195, 75);
            this.buttonImportImg.TabIndex = 20;
            this.buttonImportImg.Text = "Importovat obrázek";
            this.buttonImportImg.UseVisualStyleBackColor = false;
            this.buttonImportImg.Click += new System.EventHandler(this.buttonImportImg_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonReset.Location = new System.Drawing.Point(7, 494);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(195, 75);
            this.buttonReset.TabIndex = 19;
            this.buttonReset.Text = "Vymazat a začít znovu";
            this.buttonReset.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(7, 573);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 75);
            this.button1.TabIndex = 18;
            this.button1.Text = "Vytisknout výtvor";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelColorName
            // 
            this.labelColorName.AutoSize = true;
            this.labelColorName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelColorName.Location = new System.Drawing.Point(107, 29);
            this.labelColorName.Name = "labelColorName";
            this.labelColorName.Size = new System.Drawing.Size(41, 16);
            this.labelColorName.TabIndex = 17;
            this.labelColorName.Text = "Black";
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Location = new System.Drawing.Point(6, 29);
            this.panelColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(95, 60);
            this.panelColor.TabIndex = 16;
            // 
            // labelSelectedColor
            // 
            this.labelSelectedColor.AutoSize = true;
            this.labelSelectedColor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelSelectedColor.Location = new System.Drawing.Point(3, 7);
            this.labelSelectedColor.Name = "labelSelectedColor";
            this.labelSelectedColor.Size = new System.Drawing.Size(97, 16);
            this.labelSelectedColor.TabIndex = 15;
            this.labelSelectedColor.Text = "Zvolená barva:";
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonChangeColor.ForeColor = System.Drawing.Color.Black;
            this.buttonChangeColor.Location = new System.Drawing.Point(3, 93);
            this.buttonChangeColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(195, 28);
            this.buttonChangeColor.TabIndex = 14;
            this.buttonChangeColor.Text = "Změnit barvu";
            this.buttonChangeColor.UseVisualStyleBackColor = false;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // panelUpperMenu
            // 
            this.panelUpperMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelUpperMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelUpperMenu.Controls.Add(this.buttonEraser);
            this.panelUpperMenu.Controls.Add(this.label3);
            this.panelUpperMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpperMenu.Location = new System.Drawing.Point(215, 0);
            this.panelUpperMenu.Name = "panelUpperMenu";
            this.panelUpperMenu.Size = new System.Drawing.Size(1307, 98);
            this.panelUpperMenu.TabIndex = 1;
            // 
            // buttonEraser
            // 
            this.buttonEraser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEraser.Location = new System.Drawing.Point(4, 10);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(96, 79);
            this.buttonEraser.TabIndex = 16;
            this.buttonEraser.Text = "Guma";
            this.buttonEraser.UseVisualStyleBackColor = false;
            this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(377, -18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Zvolená barva:";
            // 
            // panelPainting
            // 
            this.panelPainting.BackColor = System.Drawing.Color.White;
            this.panelPainting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPainting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPainting.Location = new System.Drawing.Point(215, 98);
            this.panelPainting.Name = "panelPainting";
            this.panelPainting.Size = new System.Drawing.Size(1307, 1176);
            this.panelPainting.TabIndex = 2;
            this.panelPainting.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPainting_MouseDown);
            this.panelPainting.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPainting_MouseMove);
            this.panelPainting.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelPainting_MouseUp);
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialog1";
            // 
            // labelInfo
            // 
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo.ForeColor = System.Drawing.Color.Red;
            this.labelInfo.Location = new System.Drawing.Point(3, 352);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(201, 61);
            this.labelInfo.TabIndex = 34;
            this.labelInfo.Text = "Šírka tohoto tvaru se nastvauje podle pohybu po ose X";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInfo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 1274);
            this.Controls.Add(this.panelPainting);
            this.Controls.Add(this.panelUpperMenu);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPositition.ResumeLayout(false);
            this.panelPositition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            this.panelUpperMenu.ResumeLayout(false);
            this.panelUpperMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelUpperMenu;
        private System.Windows.Forms.Panel panelPainting;
        private System.Windows.Forms.Panel panelPositition;
        private System.Windows.Forms.Label labelPosYStart;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelPosXStart;
        private System.Windows.Forms.Label labelPosY;
        private System.Windows.Forms.Label labelPosX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonImportImg;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelColorName;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label labelSelectedColor;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialogSelected;
        private System.Windows.Forms.Label labelActualPos;
        private System.Windows.Forms.Label labelStartPos;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialogBackColor;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.Label labelInfo;
    }
}

