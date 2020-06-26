namespace LEOPARDAIR_SYSTEM
{
    partial class ChangeSeatForm
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
            this.btnChangeSeat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbnKEDAH = new System.Windows.Forms.RadioButton();
            this.rbnSARAWAK = new System.Windows.Forms.RadioButton();
            this.rbnSABAH = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangeSeat
            // 
            this.btnChangeSeat.BackColor = System.Drawing.Color.Gray;
            this.btnChangeSeat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChangeSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSeat.Location = new System.Drawing.Point(299, 162);
            this.btnChangeSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeSeat.Name = "btnChangeSeat";
            this.btnChangeSeat.Size = new System.Drawing.Size(170, 38);
            this.btnChangeSeat.TabIndex = 9;
            this.btnChangeSeat.Text = "Change Seat";
            this.btnChangeSeat.UseVisualStyleBackColor = false;
            this.btnChangeSeat.Click += new System.EventHandler(this.btnChangeSeat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please select a Flight: ";
            // 
            // rbnKEDAH
            // 
            this.rbnKEDAH.AutoSize = true;
            this.rbnKEDAH.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnKEDAH.Location = new System.Drawing.Point(28, 152);
            this.rbnKEDAH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnKEDAH.Name = "rbnKEDAH";
            this.rbnKEDAH.Size = new System.Drawing.Size(172, 24);
            this.rbnKEDAH.TabIndex = 7;
            this.rbnKEDAH.TabStop = true;
            this.rbnKEDAH.Text = "KLIA 2 - LANGKAWI";
            this.rbnKEDAH.UseVisualStyleBackColor = true;
            // 
            // rbnSARAWAK
            // 
            this.rbnSARAWAK.AutoSize = true;
            this.rbnSARAWAK.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnSARAWAK.Location = new System.Drawing.Point(28, 118);
            this.rbnSARAWAK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnSARAWAK.Name = "rbnSARAWAK";
            this.rbnSARAWAK.Size = new System.Drawing.Size(160, 24);
            this.rbnSARAWAK.TabIndex = 6;
            this.rbnSARAWAK.TabStop = true;
            this.rbnSARAWAK.Text = "KLIA 2 - KUCHING";
            this.rbnSARAWAK.UseVisualStyleBackColor = true;
            // 
            // rbnSABAH
            // 
            this.rbnSABAH.AutoSize = true;
            this.rbnSABAH.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnSABAH.Location = new System.Drawing.Point(28, 84);
            this.rbnSABAH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnSABAH.Name = "rbnSABAH";
            this.rbnSABAH.Size = new System.Drawing.Size(212, 24);
            this.rbnSABAH.TabIndex = 5;
            this.rbnSABAH.TabStop = true;
            this.rbnSABAH.Text = "KLIA 2 - KOTA KINABALU";
            this.rbnSABAH.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "*Your previous points will be deducted!";
            // 
            // ChangeSeatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(481, 211);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChangeSeat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbnKEDAH);
            this.Controls.Add(this.rbnSARAWAK);
            this.Controls.Add(this.rbnSABAH);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChangeSeatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Seat Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeSeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbnKEDAH;
        private System.Windows.Forms.RadioButton rbnSARAWAK;
        private System.Windows.Forms.RadioButton rbnSABAH;
        private System.Windows.Forms.Label label2;
    }
}