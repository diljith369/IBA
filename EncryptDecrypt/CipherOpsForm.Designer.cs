
namespace EncryptDecrypt
{
    partial class CipherOpsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CipherOpsForm));
            this.lblKey = new System.Windows.Forms.Label();
            this.lblIV = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.rdbEncrypt = new System.Windows.Forms.RadioButton();
            this.rdbDecrypt = new System.Windows.Forms.RadioButton();
            this.txtOps = new System.Windows.Forms.TextBox();
            this.lblOpText = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(30, 42);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(41, 19);
            this.lblKey.TabIndex = 0;
            this.lblKey.Text = "Key";
            // 
            // lblIV
            // 
            this.lblIV.AutoSize = true;
            this.lblIV.Location = new System.Drawing.Point(453, 39);
            this.lblIV.Name = "lblIV";
            this.lblIV.Size = new System.Drawing.Size(27, 19);
            this.lblIV.TabIndex = 2;
            this.lblIV.Text = "IV";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(33, 61);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(418, 26);
            this.txtKey.TabIndex = 0;
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(457, 61);
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(247, 26);
            this.txtIV.TabIndex = 1;
            // 
            // rdbEncrypt
            // 
            this.rdbEncrypt.AutoSize = true;
            this.rdbEncrypt.Location = new System.Drawing.Point(35, 167);
            this.rdbEncrypt.Name = "rdbEncrypt";
            this.rdbEncrypt.Size = new System.Drawing.Size(93, 23);
            this.rdbEncrypt.TabIndex = 3;
            this.rdbEncrypt.TabStop = true;
            this.rdbEncrypt.Text = "Encrypt";
            this.rdbEncrypt.UseVisualStyleBackColor = true;
            // 
            // rdbDecrypt
            // 
            this.rdbDecrypt.AutoSize = true;
            this.rdbDecrypt.Location = new System.Drawing.Point(134, 167);
            this.rdbDecrypt.Name = "rdbDecrypt";
            this.rdbDecrypt.Size = new System.Drawing.Size(91, 23);
            this.rdbDecrypt.TabIndex = 4;
            this.rdbDecrypt.TabStop = true;
            this.rdbDecrypt.Text = "Decrypt";
            this.rdbDecrypt.UseVisualStyleBackColor = true;
            // 
            // txtOps
            // 
            this.txtOps.Location = new System.Drawing.Point(34, 119);
            this.txtOps.Name = "txtOps";
            this.txtOps.Size = new System.Drawing.Size(670, 26);
            this.txtOps.TabIndex = 2;
            // 
            // lblOpText
            // 
            this.lblOpText.AutoSize = true;
            this.lblOpText.Location = new System.Drawing.Point(31, 97);
            this.lblOpText.Name = "lblOpText";
            this.lblOpText.Size = new System.Drawing.Size(147, 19);
            this.lblOpText.TabIndex = 8;
            this.lblOpText.Text = "Operational Text";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(30, 205);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(62, 19);
            this.Result.TabIndex = 10;
            this.Result.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(33, 227);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(670, 26);
            this.txtResult.TabIndex = 9;
            // 
            // btnResult
            // 
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Location = new System.Drawing.Point(254, 167);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(112, 27);
            this.btnResult.TabIndex = 5;
            this.btnResult.Text = "Get Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // CipherOpsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(738, 289);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblOpText);
            this.Controls.Add(this.txtOps);
            this.Controls.Add(this.rdbDecrypt);
            this.Controls.Add(this.rdbEncrypt);
            this.Controls.Add(this.txtIV);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblIV);
            this.Controls.Add(this.lblKey);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CipherOpsForm";
            this.Text = "Cipher Operation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblIV;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.RadioButton rdbEncrypt;
        private System.Windows.Forms.RadioButton rdbDecrypt;
        private System.Windows.Forms.TextBox txtOps;
        private System.Windows.Forms.Label lblOpText;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnResult;
    }
}

