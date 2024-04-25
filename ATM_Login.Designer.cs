namespace ATM
{
    partial class ATM_Login
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
            this.cust_num = new System.Windows.Forms.Label();
            this.cust_pin = new System.Windows.Forms.Label();
            this.custnum_txt = new System.Windows.Forms.TextBox();
            this.custpin_txt = new System.Windows.Forms.TextBox();
            this.atmlog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cust_num
            // 
            this.cust_num.AutoSize = true;
            this.cust_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_num.Location = new System.Drawing.Point(126, 134);
            this.cust_num.Name = "cust_num";
            this.cust_num.Size = new System.Drawing.Size(138, 20);
            this.cust_num.TabIndex = 0;
            this.cust_num.Text = "Customer Number";
            // 
            // cust_pin
            // 
            this.cust_pin.AutoSize = true;
            this.cust_pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_pin.Location = new System.Drawing.Point(176, 176);
            this.cust_pin.Name = "cust_pin";
            this.cust_pin.Size = new System.Drawing.Size(35, 20);
            this.cust_pin.TabIndex = 1;
            this.cust_pin.Text = "PIN";
            this.cust_pin.Click += new System.EventHandler(this.cust_pin_Click);
            // 
            // custnum_txt
            // 
            this.custnum_txt.Location = new System.Drawing.Point(294, 134);
            this.custnum_txt.Name = "custnum_txt";
            this.custnum_txt.Size = new System.Drawing.Size(173, 20);
            this.custnum_txt.TabIndex = 2;
            // 
            // custpin_txt
            // 
            this.custpin_txt.Location = new System.Drawing.Point(294, 176);
            this.custpin_txt.Name = "custpin_txt";
            this.custpin_txt.Size = new System.Drawing.Size(173, 20);
            this.custpin_txt.TabIndex = 3;
            // 
            // atmlog
            // 
            this.atmlog.Location = new System.Drawing.Point(305, 220);
            this.atmlog.Name = "atmlog";
            this.atmlog.Size = new System.Drawing.Size(146, 53);
            this.atmlog.TabIndex = 4;
            this.atmlog.Text = "Login";
            this.atmlog.UseVisualStyleBackColor = true;
            this.atmlog.Click += new System.EventHandler(this.atmlog_Click);
            // 
            // ATM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.atmlog);
            this.Controls.Add(this.custpin_txt);
            this.Controls.Add(this.custnum_txt);
            this.Controls.Add(this.cust_pin);
            this.Controls.Add(this.cust_num);
            this.Name = "ATM_Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cust_num;
        private System.Windows.Forms.Label cust_pin;
        private System.Windows.Forms.TextBox custnum_txt;
        private System.Windows.Forms.TextBox custpin_txt;
        private System.Windows.Forms.Button atmlog;
    }
}

