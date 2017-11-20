namespace _1CCC
{
    partial class RC
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
            this.metroProgressSpinner3 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroButton10 = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroProgressSpinner3
            // 
            this.metroProgressSpinner3.Location = new System.Drawing.Point(191, 255);
            this.metroProgressSpinner3.Maximum = 100;
            this.metroProgressSpinner3.Name = "metroProgressSpinner3";
            this.metroProgressSpinner3.Size = new System.Drawing.Size(47, 46);
            this.metroProgressSpinner3.TabIndex = 30;
            this.metroProgressSpinner3.UseSelectable = true;
            this.metroProgressSpinner3.Visible = false;
            // 
            // metroLabel9
            // 
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(19, 193);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(389, 48);
            this.metroLabel9.TabIndex = 29;
            this.metroLabel9.Text = "Пожалуйста подождите...\r\nИдет резервное копирование";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel9.UseStyleColors = true;
            this.metroLabel9.Visible = false;
            // 
            // metroButton10
            // 
            this.metroButton10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.metroButton10.Enabled = false;
            this.metroButton10.Location = new System.Drawing.Point(19, 144);
            this.metroButton10.Name = "metroButton10";
            this.metroButton10.Size = new System.Drawing.Size(389, 46);
            this.metroButton10.TabIndex = 28;
            this.metroButton10.Text = "Сделать резервную копию программы";
            this.metroButton10.UseSelectable = true;
            this.metroButton10.UseStyleColors = true;
            this.metroButton10.Click += new System.EventHandler(this.metroButton10_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(19, 64);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(389, 25);
            this.metroLabel7.TabIndex = 27;
            this.metroLabel7.Text = "Выберите информационную базу";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(19, 92);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(389, 29);
            this.metroComboBox1.TabIndex = 26;
            this.metroComboBox1.UseSelectable = true;
            // 
            // RC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 376);
            this.Controls.Add(this.metroProgressSpinner3);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroButton10);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroComboBox1);
            this.Name = "RC";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Резервное копирование";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner3;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton metroButton10;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}