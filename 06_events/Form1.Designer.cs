namespace _06_events
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVideEncode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVideEncode
            // 
            this.btnVideEncode.Location = new System.Drawing.Point(306, 277);
            this.btnVideEncode.Name = "btnVideEncode";
            this.btnVideEncode.Size = new System.Drawing.Size(157, 59);
            this.btnVideEncode.TabIndex = 0;
            this.btnVideEncode.Text = "Video Encode";
            this.btnVideEncode.UseVisualStyleBackColor = true;
            this.btnVideEncode.Click += new System.EventHandler(this.EventOfClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVideEncode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnVideEncode;
        private Button button1;
    }
}