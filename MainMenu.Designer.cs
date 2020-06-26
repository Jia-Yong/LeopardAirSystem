namespace LEOPARDAIR_SYSTEM
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnChangeSeat = new System.Windows.Forms.Button();
            this.btnRedeem = new System.Windows.Forms.Button();
            this.btnbookflight = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Franklin Gothic Medium", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblWelcome.Location = new System.Drawing.Point(197, 40);
            this.lblWelcome.MaximumSize = new System.Drawing.Size(500, 500);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(500, 122);
            this.lblWelcome.TabIndex = 21;
            this.lblWelcome.Text = "LeopardAir Ticketing System";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnChangeSeat
            // 
            this.btnChangeSeat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnChangeSeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeSeat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeSeat.Location = new System.Drawing.Point(354, 418);
            this.btnChangeSeat.Name = "btnChangeSeat";
            this.btnChangeSeat.Size = new System.Drawing.Size(171, 57);
            this.btnChangeSeat.TabIndex = 20;
            this.btnChangeSeat.Text = "Change Seat";
            this.btnChangeSeat.UseVisualStyleBackColor = false;
            this.btnChangeSeat.Click += new System.EventHandler(this.btnChangeSeat_Click);
            // 
            // btnRedeem
            // 
            this.btnRedeem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRedeem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedeem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRedeem.Location = new System.Drawing.Point(354, 326);
            this.btnRedeem.Name = "btnRedeem";
            this.btnRedeem.Size = new System.Drawing.Size(171, 57);
            this.btnRedeem.TabIndex = 19;
            this.btnRedeem.Text = "Redeem Seat";
            this.btnRedeem.UseVisualStyleBackColor = false;
            this.btnRedeem.Click += new System.EventHandler(this.btnRedeem_Click);
            // 
            // btnbookflight
            // 
            this.btnbookflight.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnbookflight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbookflight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbookflight.Location = new System.Drawing.Point(354, 236);
            this.btnbookflight.Name = "btnbookflight";
            this.btnbookflight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnbookflight.Size = new System.Drawing.Size(171, 57);
            this.btnbookflight.TabIndex = 18;
            this.btnbookflight.Text = "Book Flight";
            this.btnbookflight.UseVisualStyleBackColor = false;
            this.btnbookflight.Click += new System.EventHandler(this.btnbookflight_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DimGray;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.Location = new System.Drawing.Point(12, 481);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(112, 49);
            this.btnLogOut.TabIndex = 22;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 542);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnChangeSeat);
            this.Controls.Add(this.btnRedeem);
            this.Controls.Add(this.btnbookflight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeopardAir Ticketing System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        public System.Windows.Forms.Button btnChangeSeat;
        public System.Windows.Forms.Button btnRedeem;
        public System.Windows.Forms.Button btnbookflight;
        private System.Windows.Forms.Button btnLogOut;
    }
}