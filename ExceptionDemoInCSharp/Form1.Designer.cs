namespace ExceptionDemoInCSharp
{
    partial class frmExceptionHandling
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
            this.txtANumber = new System.Windows.Forms.TextBox();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtANumber
            // 
            this.txtANumber.Location = new System.Drawing.Point(164, 12);
            this.txtANumber.Name = "txtANumber";
            this.txtANumber.Size = new System.Drawing.Size(100, 22);
            this.txtANumber.TabIndex = 0;
            this.txtANumber.Text = "enter a number";
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(295, 12);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(75, 23);
            this.btnClickMe.TabIndex = 1;
            this.btnClickMe.Text = "Click Me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(164, 41);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(48, 17);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            // 
            // frmExceptionHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 428);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.txtANumber);
            this.Name = "frmExceptionHandling";
            this.Text = "frmExceptionHandling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtANumber;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Label lblResult;
    }
}

