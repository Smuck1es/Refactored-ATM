namespace ATM
{
    partial class Account_Info
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
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_bal_txt = new System.Windows.Forms.TextBox();
            this.svg_bal_txt = new System.Windows.Forms.TextBox();
            this.chk_withdraw_btn = new System.Windows.Forms.Button();
            this.svg_withdraw_btn = new System.Windows.Forms.Button();
            this.transfer_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.from_txt = new System.Windows.Forms.TextBox();
            this.to_txt = new System.Windows.Forms.TextBox();
            this.chkbal_lbl = new System.Windows.Forms.Label();
            this.svgbal_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(672, 379);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(116, 59);
            this.btn_LogOut.TabIndex = 0;
            this.btn_LogOut.Text = "LogOut";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Checkings Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Savings Balance:";
            // 
            // chk_bal_txt
            // 
            this.chk_bal_txt.Location = new System.Drawing.Point(144, 135);
            this.chk_bal_txt.Name = "chk_bal_txt";
            this.chk_bal_txt.Size = new System.Drawing.Size(95, 20);
            this.chk_bal_txt.TabIndex = 3;
            this.chk_bal_txt.TextChanged += new System.EventHandler(this.chk_bal_txt_TextChanged);
            // 
            // svg_bal_txt
            // 
            this.svg_bal_txt.Location = new System.Drawing.Point(498, 135);
            this.svg_bal_txt.Name = "svg_bal_txt";
            this.svg_bal_txt.Size = new System.Drawing.Size(95, 20);
            this.svg_bal_txt.TabIndex = 4;
            // 
            // chk_withdraw_btn
            // 
            this.chk_withdraw_btn.Location = new System.Drawing.Point(30, 135);
            this.chk_withdraw_btn.Name = "chk_withdraw_btn";
            this.chk_withdraw_btn.Size = new System.Drawing.Size(108, 56);
            this.chk_withdraw_btn.TabIndex = 5;
            this.chk_withdraw_btn.Text = "Withdraw";
            this.chk_withdraw_btn.UseVisualStyleBackColor = true;
            this.chk_withdraw_btn.Click += new System.EventHandler(this.chk_withdraw_btn_Click);
            // 
            // svg_withdraw_btn
            // 
            this.svg_withdraw_btn.Location = new System.Drawing.Point(391, 135);
            this.svg_withdraw_btn.Name = "svg_withdraw_btn";
            this.svg_withdraw_btn.Size = new System.Drawing.Size(101, 56);
            this.svg_withdraw_btn.TabIndex = 6;
            this.svg_withdraw_btn.Text = "Withdraw";
            this.svg_withdraw_btn.UseVisualStyleBackColor = true;
            this.svg_withdraw_btn.Click += new System.EventHandler(this.svg_withdraw_btn_Click);
            // 
            // transfer_btn
            // 
            this.transfer_btn.Location = new System.Drawing.Point(17, 272);
            this.transfer_btn.Name = "transfer_btn";
            this.transfer_btn.Size = new System.Drawing.Size(168, 95);
            this.transfer_btn.TabIndex = 9;
            this.transfer_btn.Text = "Transfer";
            this.transfer_btn.UseVisualStyleBackColor = true;
            this.transfer_btn.Click += new System.EventHandler(this.transfer_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "From:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "To:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // from_txt
            // 
            this.from_txt.Location = new System.Drawing.Point(291, 274);
            this.from_txt.Name = "from_txt";
            this.from_txt.Size = new System.Drawing.Size(100, 20);
            this.from_txt.TabIndex = 12;
            // 
            // to_txt
            // 
            this.to_txt.Location = new System.Drawing.Point(291, 310);
            this.to_txt.Name = "to_txt";
            this.to_txt.Size = new System.Drawing.Size(100, 20);
            this.to_txt.TabIndex = 13;
            // 
            // chkbal_lbl
            // 
            this.chkbal_lbl.AutoSize = true;
            this.chkbal_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbal_lbl.Location = new System.Drawing.Point(221, 72);
            this.chkbal_lbl.Name = "chkbal_lbl";
            this.chkbal_lbl.Size = new System.Drawing.Size(18, 20);
            this.chkbal_lbl.TabIndex = 14;
            this.chkbal_lbl.Text = "0";
            // 
            // svgbal_lbl
            // 
            this.svgbal_lbl.AutoSize = true;
            this.svgbal_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svgbal_lbl.Location = new System.Drawing.Point(575, 71);
            this.svgbal_lbl.Name = "svgbal_lbl";
            this.svgbal_lbl.Size = new System.Drawing.Size(18, 20);
            this.svgbal_lbl.TabIndex = 15;
            this.svgbal_lbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Amount:";
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(291, 347);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(100, 20);
            this.amount_txt.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(448, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "To transfer type either \'\'checkings\" or \"savings\"";
            // 
            // Account_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.svgbal_lbl);
            this.Controls.Add(this.chkbal_lbl);
            this.Controls.Add(this.to_txt);
            this.Controls.Add(this.from_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.transfer_btn);
            this.Controls.Add(this.svg_withdraw_btn);
            this.Controls.Add(this.chk_withdraw_btn);
            this.Controls.Add(this.svg_bal_txt);
            this.Controls.Add(this.chk_bal_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_LogOut);
            this.Name = "Account_Info";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Account_Info_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox chk_bal_txt;
        private System.Windows.Forms.TextBox svg_bal_txt;
        private System.Windows.Forms.Button chk_withdraw_btn;
        private System.Windows.Forms.Button svg_withdraw_btn;
        private System.Windows.Forms.Button transfer_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox from_txt;
        private System.Windows.Forms.TextBox to_txt;
        private System.Windows.Forms.Label chkbal_lbl;
        private System.Windows.Forms.Label svgbal_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}