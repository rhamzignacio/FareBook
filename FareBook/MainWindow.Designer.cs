namespace FareBook
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNoLF = new System.Windows.Forms.Label();
            this.richTxtBoxLF = new System.Windows.Forms.RichTextBox();
            this.lblYesLF = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNoRF = new System.Windows.Forms.Label();
            this.richTxtBoxReferenceFare = new System.Windows.Forms.RichTextBox();
            this.lblYesRF = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNoHotel = new System.Windows.Forms.Label();
            this.lblYesHotel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblNoCar = new System.Windows.Forms.Label();
            this.lblYesCar = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(10, 12);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(318, 21);
            this.txtBoxSearch.TabIndex = 0;
            this.txtBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxSearch_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNoLF);
            this.groupBox1.Controls.Add(this.richTxtBoxLF);
            this.groupBox1.Controls.Add(this.lblYesLF);
            this.groupBox1.Location = new System.Drawing.Point(12, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Low Fare";
            // 
            // lblNoLF
            // 
            this.lblNoLF.AutoSize = true;
            this.lblNoLF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoLF.ForeColor = System.Drawing.Color.Red;
            this.lblNoLF.Location = new System.Drawing.Point(276, 16);
            this.lblNoLF.Name = "lblNoLF";
            this.lblNoLF.Size = new System.Drawing.Size(27, 15);
            this.lblNoLF.TabIndex = 5;
            this.lblNoLF.Text = "NO";
            this.lblNoLF.Visible = false;
            // 
            // richTxtBoxLF
            // 
            this.richTxtBoxLF.Location = new System.Drawing.Point(5, 34);
            this.richTxtBoxLF.Name = "richTxtBoxLF";
            this.richTxtBoxLF.ReadOnly = true;
            this.richTxtBoxLF.Size = new System.Drawing.Size(298, 62);
            this.richTxtBoxLF.TabIndex = 4;
            this.richTxtBoxLF.Text = "";
            this.richTxtBoxLF.TextChanged += new System.EventHandler(this.richTxtBoxLF_TextChanged);
            // 
            // lblYesLF
            // 
            this.lblYesLF.AutoSize = true;
            this.lblYesLF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYesLF.ForeColor = System.Drawing.Color.Green;
            this.lblYesLF.Location = new System.Drawing.Point(7, 16);
            this.lblYesLF.Name = "lblYesLF";
            this.lblYesLF.Size = new System.Drawing.Size(33, 15);
            this.lblYesLF.TabIndex = 3;
            this.lblYesLF.Text = "YES";
            this.lblYesLF.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNoRF);
            this.groupBox2.Controls.Add(this.richTxtBoxReferenceFare);
            this.groupBox2.Controls.Add(this.lblYesRF);
            this.groupBox2.Location = new System.Drawing.Point(10, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 103);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reference Fare / High Fare";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblNoRF
            // 
            this.lblNoRF.AutoSize = true;
            this.lblNoRF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRF.ForeColor = System.Drawing.Color.Red;
            this.lblNoRF.Location = new System.Drawing.Point(278, 16);
            this.lblNoRF.Name = "lblNoRF";
            this.lblNoRF.Size = new System.Drawing.Size(27, 15);
            this.lblNoRF.TabIndex = 5;
            this.lblNoRF.Text = "NO";
            this.lblNoRF.Visible = false;
            // 
            // richTxtBoxReferenceFare
            // 
            this.richTxtBoxReferenceFare.Location = new System.Drawing.Point(9, 34);
            this.richTxtBoxReferenceFare.Name = "richTxtBoxReferenceFare";
            this.richTxtBoxReferenceFare.ReadOnly = true;
            this.richTxtBoxReferenceFare.Size = new System.Drawing.Size(298, 62);
            this.richTxtBoxReferenceFare.TabIndex = 4;
            this.richTxtBoxReferenceFare.Text = "";
            // 
            // lblYesRF
            // 
            this.lblYesRF.AutoSize = true;
            this.lblYesRF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYesRF.ForeColor = System.Drawing.Color.Green;
            this.lblYesRF.Location = new System.Drawing.Point(7, 16);
            this.lblYesRF.Name = "lblYesRF";
            this.lblYesRF.Size = new System.Drawing.Size(33, 15);
            this.lblYesRF.TabIndex = 3;
            this.lblYesRF.Text = "YES";
            this.lblYesRF.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblNoHotel);
            this.groupBox3.Controls.Add(this.lblYesHotel);
            this.groupBox3.Location = new System.Drawing.Point(12, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 40);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hotel Standard Rate";
            // 
            // lblNoHotel
            // 
            this.lblNoHotel.AutoSize = true;
            this.lblNoHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoHotel.ForeColor = System.Drawing.Color.Red;
            this.lblNoHotel.Location = new System.Drawing.Point(95, 16);
            this.lblNoHotel.Name = "lblNoHotel";
            this.lblNoHotel.Size = new System.Drawing.Size(27, 15);
            this.lblNoHotel.TabIndex = 6;
            this.lblNoHotel.Text = "NO";
            this.lblNoHotel.Visible = false;
            // 
            // lblYesHotel
            // 
            this.lblYesHotel.AutoSize = true;
            this.lblYesHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYesHotel.ForeColor = System.Drawing.Color.Green;
            this.lblYesHotel.Location = new System.Drawing.Point(6, 15);
            this.lblYesHotel.Name = "lblYesHotel";
            this.lblYesHotel.Size = new System.Drawing.Size(33, 15);
            this.lblYesHotel.TabIndex = 4;
            this.lblYesHotel.Text = "YES";
            this.lblYesHotel.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblNoCar);
            this.groupBox4.Controls.Add(this.lblYesCar);
            this.groupBox4.Location = new System.Drawing.Point(195, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(128, 40);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Car Standard Rate";
            // 
            // lblNoCar
            // 
            this.lblNoCar.AutoSize = true;
            this.lblNoCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCar.ForeColor = System.Drawing.Color.Red;
            this.lblNoCar.Location = new System.Drawing.Point(93, 15);
            this.lblNoCar.Name = "lblNoCar";
            this.lblNoCar.Size = new System.Drawing.Size(27, 15);
            this.lblNoCar.TabIndex = 6;
            this.lblNoCar.Text = "NO";
            this.lblNoCar.Visible = false;
            // 
            // lblYesCar
            // 
            this.lblYesCar.AutoSize = true;
            this.lblYesCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYesCar.ForeColor = System.Drawing.Color.Green;
            this.lblYesCar.Location = new System.Drawing.Point(6, 16);
            this.lblYesCar.Name = "lblYesCar";
            this.lblYesCar.Size = new System.Drawing.Size(33, 15);
            this.lblYesCar.TabIndex = 4;
            this.lblYesCar.Text = "YES";
            this.lblYesCar.Visible = false;
            // 
            // lblClientName
            // 
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblClientName.Location = new System.Drawing.Point(12, 41);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(311, 50);
            this.lblClientName.TabIndex = 6;
            this.lblClientName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblClientName.Click += new System.EventHandler(this.lblClientName_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = global::FareBook.Properties.Resources.Zoom_icon;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(305, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(19, 19);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 361);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "FareRef 1.5";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNoLF;
        private System.Windows.Forms.RichTextBox richTxtBoxLF;
        private System.Windows.Forms.Label lblYesLF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNoRF;
        private System.Windows.Forms.RichTextBox richTxtBoxReferenceFare;
        private System.Windows.Forms.Label lblYesRF;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblNoHotel;
        private System.Windows.Forms.Label lblYesHotel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblNoCar;
        private System.Windows.Forms.Label lblYesCar;
        private System.Windows.Forms.Label lblClientName;
    }
}