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
            this.lblNoLF = new System.Windows.Forms.Label();
            this.lblYesLF = new System.Windows.Forms.Label();
            this.lblNoRF = new System.Windows.Forms.Label();
            this.lblYesRF = new System.Windows.Forms.Label();
            this.lblNoHotel = new System.Windows.Forms.Label();
            this.lblYesHotel = new System.Windows.Forms.Label();
            this.lblNoCar = new System.Windows.Forms.Label();
            this.lblYesCar = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTxtBoxReferenceFare = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTxtBoxLF = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(3, 27);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(147, 18);
            this.txtBoxSearch.TabIndex = 0;
            this.txtBoxSearch.Text = "Search Here";
            this.txtBoxSearch.Enter += new System.EventHandler(this.txtBoxSearch_Enter);
            this.txtBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxSearch_KeyUp);
            this.txtBoxSearch.Leave += new System.EventHandler(this.txtBoxSearch_Leave);
            this.txtBoxSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBoxSearch_MouseDown);
            // 
            // lblNoLF
            // 
            this.lblNoLF.AutoSize = true;
            this.lblNoLF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoLF.ForeColor = System.Drawing.Color.Red;
            this.lblNoLF.Location = new System.Drawing.Point(284, 4);
            this.lblNoLF.Name = "lblNoLF";
            this.lblNoLF.Size = new System.Drawing.Size(27, 15);
            this.lblNoLF.TabIndex = 5;
            this.lblNoLF.Text = "NO";
            this.lblNoLF.Visible = false;
            this.lblNoLF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTxtBoxReferenceFare_MouseDown);
            // 
            // lblYesLF
            // 
            this.lblYesLF.AutoSize = true;
            this.lblYesLF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYesLF.ForeColor = System.Drawing.Color.Green;
            this.lblYesLF.Location = new System.Drawing.Point(245, 4);
            this.lblYesLF.Name = "lblYesLF";
            this.lblYesLF.Size = new System.Drawing.Size(33, 15);
            this.lblYesLF.TabIndex = 3;
            this.lblYesLF.Text = "YES";
            this.lblYesLF.Visible = false;
            this.lblYesLF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTxtBoxReferenceFare_MouseDown);
            // 
            // lblNoRF
            // 
            this.lblNoRF.AutoSize = true;
            this.lblNoRF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRF.ForeColor = System.Drawing.Color.Red;
            this.lblNoRF.Location = new System.Drawing.Point(284, 4);
            this.lblNoRF.Name = "lblNoRF";
            this.lblNoRF.Size = new System.Drawing.Size(27, 15);
            this.lblNoRF.TabIndex = 5;
            this.lblNoRF.Text = "NO";
            this.lblNoRF.Visible = false;
            this.lblNoRF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTxtBoxReferenceFare_MouseDown);
            // 
            // lblYesRF
            // 
            this.lblYesRF.AutoSize = true;
            this.lblYesRF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYesRF.ForeColor = System.Drawing.Color.Green;
            this.lblYesRF.Location = new System.Drawing.Point(245, 4);
            this.lblYesRF.Name = "lblYesRF";
            this.lblYesRF.Size = new System.Drawing.Size(33, 15);
            this.lblYesRF.TabIndex = 3;
            this.lblYesRF.Text = "YES";
            this.lblYesRF.Visible = false;
            this.lblYesRF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTxtBoxReferenceFare_MouseDown);
            // 
            // lblNoHotel
            // 
            this.lblNoHotel.AutoSize = true;
            this.lblNoHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoHotel.ForeColor = System.Drawing.Color.Red;
            this.lblNoHotel.Location = new System.Drawing.Point(284, 4);
            this.lblNoHotel.Name = "lblNoHotel";
            this.lblNoHotel.Size = new System.Drawing.Size(27, 15);
            this.lblNoHotel.TabIndex = 6;
            this.lblNoHotel.Text = "NO";
            this.lblNoHotel.Visible = false;
            this.lblNoHotel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTxtBoxReferenceFare_MouseDown);
            // 
            // lblYesHotel
            // 
            this.lblYesHotel.AutoSize = true;
            this.lblYesHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYesHotel.ForeColor = System.Drawing.Color.Green;
            this.lblYesHotel.Location = new System.Drawing.Point(245, 4);
            this.lblYesHotel.Name = "lblYesHotel";
            this.lblYesHotel.Size = new System.Drawing.Size(33, 15);
            this.lblYesHotel.TabIndex = 4;
            this.lblYesHotel.Text = "YES";
            this.lblYesHotel.Visible = false;
            this.lblYesHotel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTxtBoxReferenceFare_MouseDown);
            // 
            // lblNoCar
            // 
            this.lblNoCar.AutoSize = true;
            this.lblNoCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCar.ForeColor = System.Drawing.Color.Red;
            this.lblNoCar.Location = new System.Drawing.Point(284, 4);
            this.lblNoCar.Name = "lblNoCar";
            this.lblNoCar.Size = new System.Drawing.Size(27, 15);
            this.lblNoCar.TabIndex = 6;
            this.lblNoCar.Text = "NO";
            this.lblNoCar.Visible = false;
            this.lblNoCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTxtBoxReferenceFare_MouseDown);
            // 
            // lblYesCar
            // 
            this.lblYesCar.AutoSize = true;
            this.lblYesCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYesCar.ForeColor = System.Drawing.Color.Green;
            this.lblYesCar.Location = new System.Drawing.Point(245, 4);
            this.lblYesCar.Name = "lblYesCar";
            this.lblYesCar.Size = new System.Drawing.Size(33, 15);
            this.lblYesCar.TabIndex = 4;
            this.lblYesCar.Text = "YES";
            this.lblYesCar.Visible = false;
            this.lblYesCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTxtBoxReferenceFare_MouseDown);
            // 
            // lblClientName
            // 
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.Color.White;
            this.lblClientName.Location = new System.Drawing.Point(154, 27);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(184, 26);
            this.lblClientName.TabIndex = 6;
            this.lblClientName.Text = "Client Name";
            this.lblClientName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblClientName.Click += new System.EventHandler(this.lblClientName_Click);
            this.lblClientName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblClientName_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(71)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.lblClientName);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.txtBoxSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 56);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(71)))), ((int)(((byte)(42)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(278, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 23);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(137, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "FareRef 2.0";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(71)))), ((int)(((byte)(42)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(308, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.richTxtBoxReferenceFare);
            this.panel2.Controls.Add(this.lblNoRF);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblYesRF);
            this.panel2.Location = new System.Drawing.Point(13, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 100);
            this.panel2.TabIndex = 8;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTxtBoxReferenceFare_MouseDown);
            // 
            // richTxtBoxReferenceFare
            // 
            this.richTxtBoxReferenceFare.Location = new System.Drawing.Point(8, 31);
            this.richTxtBoxReferenceFare.Name = "richTxtBoxReferenceFare";
            this.richTxtBoxReferenceFare.Size = new System.Drawing.Size(296, 59);
            this.richTxtBoxReferenceFare.TabIndex = 6;
            this.richTxtBoxReferenceFare.Text = "label3";
            this.richTxtBoxReferenceFare.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTxtBoxReferenceFare_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reference Fare / High Fare";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTxtBoxReferenceFare_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblNoLF);
            this.panel3.Controls.Add(this.richTxtBoxLF);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblYesLF);
            this.panel3.Location = new System.Drawing.Point(13, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 100);
            this.panel3.TabIndex = 9;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTxtBoxReferenceFare_MouseDown);
            // 
            // richTxtBoxLF
            // 
            this.richTxtBoxLF.Location = new System.Drawing.Point(8, 31);
            this.richTxtBoxLF.Name = "richTxtBoxLF";
            this.richTxtBoxLF.Size = new System.Drawing.Size(296, 59);
            this.richTxtBoxLF.TabIndex = 6;
            this.richTxtBoxLF.Text = "label3";
            this.richTxtBoxLF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTxtBoxReferenceFare_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Low Fare";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTxtBoxReferenceFare_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblNoHotel);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lblYesHotel);
            this.panel4.Location = new System.Drawing.Point(13, 283);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 26);
            this.panel4.TabIndex = 10;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTxtBoxReferenceFare_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hotel Standard Rate";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTxtBoxReferenceFare_MouseDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblNoCar);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.lblYesCar);
            this.panel5.Location = new System.Drawing.Point(13, 315);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(314, 26);
            this.panel5.TabIndex = 11;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTxtBoxReferenceFare_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Car Standard Rate";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTxtBoxReferenceFare_MouseDown);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(338, 364);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "FareRef 1.5";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label lblNoLF;
        private System.Windows.Forms.Label lblYesLF;
        private System.Windows.Forms.Label lblNoRF;
        private System.Windows.Forms.Label lblYesRF;
        private System.Windows.Forms.Label lblNoHotel;
        private System.Windows.Forms.Label lblYesHotel;
        private System.Windows.Forms.Label lblNoCar;
        private System.Windows.Forms.Label lblYesCar;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label richTxtBoxReferenceFare;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label richTxtBoxLF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
    }
}