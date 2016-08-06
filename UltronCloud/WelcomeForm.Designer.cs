namespace UltronCloud
{
    partial class WelcomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.buttonAddIntegration = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to UltronCloud";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDesc
            // 
            this.labelDesc.Location = new System.Drawing.Point(12, 101);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(384, 61);
            this.labelDesc.TabIndex = 1;
            this.labelDesc.Text = "UltronCloud is a nice way of keeping all of your cloud services together.\r\nWhat a" +
    "re you waiting for? Let\'s begin!";
            // 
            // buttonAddIntegration
            // 
            this.buttonAddIntegration.Location = new System.Drawing.Point(12, 182);
            this.buttonAddIntegration.Name = "buttonAddIntegration";
            this.buttonAddIntegration.Size = new System.Drawing.Size(384, 22);
            this.buttonAddIntegration.TabIndex = 2;
            this.buttonAddIntegration.Text = "Add an integration";
            this.buttonAddIntegration.UseVisualStyleBackColor = true;
            this.buttonAddIntegration.Click += new System.EventHandler(this.buttonAddIntegration_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(12, 206);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(384, 22);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // WelcomeForm
            // 
            this.AcceptButton = this.buttonAddIntegration;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(408, 240);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAddIntegration);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeForm";
            this.ShowIcon = false;
            this.Text = "Welcome to UltronCloud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Button buttonAddIntegration;
        private System.Windows.Forms.Button buttonClose;
    }
}

