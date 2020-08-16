namespace Modern_setting_form
{
    partial class frm_skin_setting
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.rbDark = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbLight = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rbGreen = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbPink = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.rbBlue = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbOrange = new MaterialSkin.Controls.MaterialRadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.rbBlack = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbWhite = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 23);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Theme";
            // 
            // rbDark
            // 
            this.rbDark.AutoSize = true;
            this.rbDark.Depth = 0;
            this.rbDark.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbDark.Location = new System.Drawing.Point(200, 18);
            this.rbDark.Margin = new System.Windows.Forms.Padding(0);
            this.rbDark.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDark.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDark.Name = "rbDark";
            this.rbDark.Ripple = true;
            this.rbDark.Size = new System.Drawing.Size(57, 30);
            this.rbDark.TabIndex = 14;
            this.rbDark.Text = "Dark";
            this.rbDark.UseVisualStyleBackColor = true;
            this.rbDark.Click += new System.EventHandler(this.tbDark_Click);
            // 
            // rbLight
            // 
            this.rbLight.AutoSize = true;
            this.rbLight.Checked = true;
            this.rbLight.Depth = 0;
            this.rbLight.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbLight.Location = new System.Drawing.Point(118, 18);
            this.rbLight.Margin = new System.Windows.Forms.Padding(0);
            this.rbLight.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbLight.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbLight.Name = "rbLight";
            this.rbLight.Ripple = true;
            this.rbLight.Size = new System.Drawing.Size(60, 30);
            this.rbLight.TabIndex = 13;
            this.rbLight.TabStop = true;
            this.rbLight.Text = "Light";
            this.rbLight.UseVisualStyleBackColor = true;
            this.rbLight.Click += new System.EventHandler(this.rbLight_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(26, 144);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(339, 117);
            this.materialTabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.rbLight);
            this.tabPage1.Controls.Add(this.rbDark);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(273, 87);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dark/Light";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.rbGreen);
            this.tabPage2.Controls.Add(this.rbPink);
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Controls.Add(this.rbBlue);
            this.tabPage2.Controls.Add(this.rbOrange);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(331, 91);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Color";
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Depth = 0;
            this.rbGreen.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbGreen.Location = new System.Drawing.Point(95, 42);
            this.rbGreen.Margin = new System.Windows.Forms.Padding(0);
            this.rbGreen.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbGreen.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Ripple = true;
            this.rbGreen.Size = new System.Drawing.Size(66, 30);
            this.rbGreen.TabIndex = 19;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.Click += new System.EventHandler(this.rbGreen_Click);
            // 
            // rbPink
            // 
            this.rbPink.AutoSize = true;
            this.rbPink.Depth = 0;
            this.rbPink.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbPink.Location = new System.Drawing.Point(181, 42);
            this.rbPink.Margin = new System.Windows.Forms.Padding(0);
            this.rbPink.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbPink.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbPink.Name = "rbPink";
            this.rbPink.Ripple = true;
            this.rbPink.Size = new System.Drawing.Size(56, 30);
            this.rbPink.TabIndex = 20;
            this.rbPink.Text = "Pink";
            this.rbPink.UseVisualStyleBackColor = true;
            this.rbPink.Click += new System.EventHandler(this.rbPink_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(11, 33);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 19);
            this.materialLabel2.TabIndex = 18;
            this.materialLabel2.Text = "Theme";
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Checked = true;
            this.rbBlue.Depth = 0;
            this.rbBlue.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbBlue.Location = new System.Drawing.Point(95, 12);
            this.rbBlue.Margin = new System.Windows.Forms.Padding(0);
            this.rbBlue.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbBlue.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Ripple = true;
            this.rbBlue.Size = new System.Drawing.Size(56, 30);
            this.rbBlue.TabIndex = 16;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
          //  this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            this.rbBlue.Click += new System.EventHandler(this.rbBlue_Click);
            // 
            // rbOrange
            // 
            this.rbOrange.AutoSize = true;
            this.rbOrange.Depth = 0;
            this.rbOrange.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbOrange.Location = new System.Drawing.Point(181, 12);
            this.rbOrange.Margin = new System.Windows.Forms.Padding(0);
            this.rbOrange.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbOrange.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbOrange.Name = "rbOrange";
            this.rbOrange.Ripple = true;
            this.rbOrange.Size = new System.Drawing.Size(73, 30);
            this.rbOrange.TabIndex = 17;
            this.rbOrange.Text = "Orange";
            this.rbOrange.UseVisualStyleBackColor = true;
            this.rbOrange.Click += new System.EventHandler(this.rbOrange_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.materialLabel3);
            this.tabPage3.Controls.Add(this.rbBlack);
            this.tabPage3.Controls.Add(this.rbWhite);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(352, 91);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Text Color";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(11, 33);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(83, 19);
            this.materialLabel3.TabIndex = 18;
            this.materialLabel3.Text = "Text Color:";
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Checked = true;
            this.rbBlack.Depth = 0;
            this.rbBlack.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbBlack.Location = new System.Drawing.Point(121, 28);
            this.rbBlack.Margin = new System.Windows.Forms.Padding(0);
            this.rbBlack.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbBlack.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Ripple = true;
            this.rbBlack.Size = new System.Drawing.Size(63, 30);
            this.rbBlack.TabIndex = 16;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Black";
            this.rbBlack.UseVisualStyleBackColor = true;
            this.rbBlack.Click += new System.EventHandler(this.rbBlack_Click);
            // 
            // rbWhite
            // 
            this.rbWhite.AutoSize = true;
            this.rbWhite.Depth = 0;
            this.rbWhite.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbWhite.Location = new System.Drawing.Point(200, 28);
            this.rbWhite.Margin = new System.Windows.Forms.Padding(0);
            this.rbWhite.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbWhite.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbWhite.Name = "rbWhite";
            this.rbWhite.Ripple = true;
            this.rbWhite.Size = new System.Drawing.Size(64, 30);
            this.rbWhite.TabIndex = 17;
            this.rbWhite.Text = "White";
            this.rbWhite.UseVisualStyleBackColor = true;
            this.rbWhite.Click += new System.EventHandler(this.rbWhite_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(26, 115);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(339, 23);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // frm_skin_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(452, 309);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_skin_setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skin Setting";
            this.Load += new System.EventHandler(this.frm_skin_setting_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialRadioButton rbGreen;
        private MaterialSkin.Controls.MaterialRadioButton rbPink;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRadioButton rbBlue;
        private MaterialSkin.Controls.MaterialRadioButton rbOrange;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRadioButton rbBlack;
        private MaterialSkin.Controls.MaterialRadioButton rbWhite;
        public MaterialSkin.Controls.MaterialRadioButton rbDark;
        public MaterialSkin.Controls.MaterialRadioButton rbLight;
        public MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        public MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    }
}