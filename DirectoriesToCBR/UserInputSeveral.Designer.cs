namespace DirectoriesToCBR
{
    partial class UserInputSeveral
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
            this.edtUserInput = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.edtQtdVolumes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edtQtdVolumes)).BeginInit();
            this.SuspendLayout();
            // 
            // edtUserInput
            // 
            this.edtUserInput.Location = new System.Drawing.Point(12, 18);
            this.edtUserInput.Name = "edtUserInput";
            this.edtUserInput.Size = new System.Drawing.Size(192, 20);
            this.edtUserInput.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 2);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(39, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Prefixo";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(298, 15);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(63, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // edtQtdVolumes
            // 
            this.edtQtdVolumes.Location = new System.Drawing.Point(210, 18);
            this.edtQtdVolumes.Name = "edtQtdVolumes";
            this.edtQtdVolumes.Size = new System.Drawing.Size(82, 20);
            this.edtQtdVolumes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Qtd. de Volumes";
            // 
            // UserInputSeveral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 50);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtQtdVolumes);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.edtUserInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInputSeveral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.edtQtdVolumes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtUserInput;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown edtQtdVolumes;
        private System.Windows.Forms.Label label1;
    }
}