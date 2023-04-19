namespace AccountsApp
{
    partial class frmAccounts
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
            this.grpAccountDetails = new System.Windows.Forms.GroupBox();
            this.grpTypeOfAccount = new System.Windows.Forms.GroupBox();
            this.rbtnSavings = new System.Windows.Forms.RadioButton();
            this.rbtnChecking = new System.Windows.Forms.RadioButton();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtDailyWithdrawLimit = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblDailyWithdrawLimit = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblSearchByAccountNumber = new System.Windows.Forms.Label();
            this.txtSearchByAccountNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpAccountDetails.SuspendLayout();
            this.grpTypeOfAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccountDetails
            // 
            this.grpAccountDetails.Controls.Add(this.grpTypeOfAccount);
            this.grpAccountDetails.Controls.Add(this.txtInterestRate);
            this.grpAccountDetails.Controls.Add(this.txtDailyWithdrawLimit);
            this.grpAccountDetails.Controls.Add(this.txtBalance);
            this.grpAccountDetails.Controls.Add(this.txtClientName);
            this.grpAccountDetails.Controls.Add(this.txtAccountNumber);
            this.grpAccountDetails.Controls.Add(this.lblInterestRate);
            this.grpAccountDetails.Controls.Add(this.lblDailyWithdrawLimit);
            this.grpAccountDetails.Controls.Add(this.lblBalance);
            this.grpAccountDetails.Controls.Add(this.lblClientName);
            this.grpAccountDetails.Controls.Add(this.lblAccountNumber);
            this.grpAccountDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccountDetails.Location = new System.Drawing.Point(64, 135);
            this.grpAccountDetails.Name = "grpAccountDetails";
            this.grpAccountDetails.Size = new System.Drawing.Size(1277, 637);
            this.grpAccountDetails.TabIndex = 0;
            this.grpAccountDetails.TabStop = false;
            this.grpAccountDetails.Text = "Account Details";
            // 
            // grpTypeOfAccount
            // 
            this.grpTypeOfAccount.Controls.Add(this.rbtnSavings);
            this.grpTypeOfAccount.Controls.Add(this.rbtnChecking);
            this.grpTypeOfAccount.Location = new System.Drawing.Point(771, 89);
            this.grpTypeOfAccount.Name = "grpTypeOfAccount";
            this.grpTypeOfAccount.Size = new System.Drawing.Size(404, 260);
            this.grpTypeOfAccount.TabIndex = 10;
            this.grpTypeOfAccount.TabStop = false;
            this.grpTypeOfAccount.Text = "TypeOfAccount";
            // 
            // rbtnSavings
            // 
            this.rbtnSavings.AutoSize = true;
            this.rbtnSavings.Checked = true;
            this.rbtnSavings.Location = new System.Drawing.Point(33, 166);
            this.rbtnSavings.Name = "rbtnSavings";
            this.rbtnSavings.Size = new System.Drawing.Size(142, 35);
            this.rbtnSavings.TabIndex = 1;
            this.rbtnSavings.TabStop = true;
            this.rbtnSavings.Text = "Savings";
            this.rbtnSavings.UseVisualStyleBackColor = true;
            this.rbtnSavings.CheckedChanged += new System.EventHandler(this.rbtnSavings_CheckedChanged);
            // 
            // rbtnChecking
            // 
            this.rbtnChecking.AutoSize = true;
            this.rbtnChecking.Checked = true;
            this.rbtnChecking.Location = new System.Drawing.Point(33, 79);
            this.rbtnChecking.Name = "rbtnChecking";
            this.rbtnChecking.Size = new System.Drawing.Size(159, 35);
            this.rbtnChecking.TabIndex = 0;
            this.rbtnChecking.TabStop = true;
            this.rbtnChecking.Text = "Checking";
            this.rbtnChecking.UseVisualStyleBackColor = true;
            this.rbtnChecking.CheckedChanged += new System.EventHandler(this.rbtnChecking_CheckedChanged);
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(322, 552);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(214, 38);
            this.txtInterestRate.TabIndex = 9;
            // 
            // txtDailyWithdrawLimit
            // 
            this.txtDailyWithdrawLimit.Location = new System.Drawing.Point(322, 432);
            this.txtDailyWithdrawLimit.Name = "txtDailyWithdrawLimit";
            this.txtDailyWithdrawLimit.Size = new System.Drawing.Size(214, 38);
            this.txtDailyWithdrawLimit.TabIndex = 8;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(322, 318);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(214, 38);
            this.txtBalance.TabIndex = 7;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(322, 209);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(214, 38);
            this.txtClientName.TabIndex = 6;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(322, 89);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(214, 38);
            this.txtAccountNumber.TabIndex = 5;
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(90, 552);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(179, 31);
            this.lblInterestRate.TabIndex = 4;
            this.lblInterestRate.Text = "Interest Rate:";
            // 
            // lblDailyWithdrawLimit
            // 
            this.lblDailyWithdrawLimit.AutoSize = true;
            this.lblDailyWithdrawLimit.Location = new System.Drawing.Point(6, 432);
            this.lblDailyWithdrawLimit.Name = "lblDailyWithdrawLimit";
            this.lblDailyWithdrawLimit.Size = new System.Drawing.Size(267, 31);
            this.lblDailyWithdrawLimit.TabIndex = 3;
            this.lblDailyWithdrawLimit.Text = "Daily Withdraw Limit:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(149, 318);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(120, 31);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(98, 209);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(171, 31);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Client Name:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(45, 89);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(224, 31);
            this.lblAccountNumber.TabIndex = 0;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.Location = new System.Drawing.Point(981, 791);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(360, 69);
            this.btnCreateAccount.TabIndex = 11;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblSearchByAccountNumber
            // 
            this.lblSearchByAccountNumber.AutoSize = true;
            this.lblSearchByAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByAccountNumber.Location = new System.Drawing.Point(484, 67);
            this.lblSearchByAccountNumber.Name = "lblSearchByAccountNumber";
            this.lblSearchByAccountNumber.Size = new System.Drawing.Size(356, 31);
            this.lblSearchByAccountNumber.TabIndex = 12;
            this.lblSearchByAccountNumber.Text = "Search By Account Number:";
            // 
            // txtSearchByAccountNumber
            // 
            this.txtSearchByAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByAccountNumber.Location = new System.Drawing.Point(855, 64);
            this.txtSearchByAccountNumber.Name = "txtSearchByAccountNumber";
            this.txtSearchByAccountNumber.Size = new System.Drawing.Size(285, 38);
            this.txtSearchByAccountNumber.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1179, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(162, 69);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 886);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchByAccountNumber);
            this.Controls.Add(this.lblSearchByAccountNumber);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.grpAccountDetails);
            this.Name = "frmAccounts";
            this.Text = "Bank Accounts";
            this.grpAccountDetails.ResumeLayout(false);
            this.grpAccountDetails.PerformLayout();
            this.grpTypeOfAccount.ResumeLayout(false);
            this.grpTypeOfAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccountDetails;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblDailyWithdrawLimit;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.GroupBox grpTypeOfAccount;
        private System.Windows.Forms.RadioButton rbtnSavings;
        private System.Windows.Forms.RadioButton rbtnChecking;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtDailyWithdrawLimit;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblSearchByAccountNumber;
        private System.Windows.Forms.TextBox txtSearchByAccountNumber;
        private System.Windows.Forms.Button btnSearch;
    }
}

