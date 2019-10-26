namespace GGACRDummyTool
{
    partial class Form1
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
            this.btnSaveRecording = new System.Windows.Forms.Button();
            this.btnLoadRecording = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveRecording
            // 
            this.btnSaveRecording.Location = new System.Drawing.Point(12, 12);
            this.btnSaveRecording.Name = "btnSaveRecording";
            this.btnSaveRecording.Size = new System.Drawing.Size(96, 23);
            this.btnSaveRecording.TabIndex = 0;
            this.btnSaveRecording.Text = "Save Recording";
            this.btnSaveRecording.UseVisualStyleBackColor = true;
            this.btnSaveRecording.Click += new System.EventHandler(this.btnSaveRecording_Click);
            // 
            // btnLoadRecording
            // 
            this.btnLoadRecording.Location = new System.Drawing.Point(114, 12);
            this.btnLoadRecording.Name = "btnLoadRecording";
            this.btnLoadRecording.Size = new System.Drawing.Size(95, 23);
            this.btnLoadRecording.TabIndex = 1;
            this.btnLoadRecording.Text = "Load Recording";
            this.btnLoadRecording.UseVisualStyleBackColor = true;
            this.btnLoadRecording.Click += new System.EventHandler(this.btnLoadRecording_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 49);
            this.Controls.Add(this.btnLoadRecording);
            this.Controls.Add(this.btnSaveRecording);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveRecording;
        private System.Windows.Forms.Button btnLoadRecording;
    }
}

