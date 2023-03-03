namespace FirstHomeWorkPart2
{
    partial class Form2AboutProgram
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
            this.pictureBoxForm2 = new System.Windows.Forms.PictureBox();
            this.label1Form2 = new System.Windows.Forms.Label();
            this.labelForm2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxForm2
            // 
            this.pictureBoxForm2.Image = global::FirstHomeWorkPart2.Properties.Resources.notepad_icon1;
            this.pictureBoxForm2.Location = new System.Drawing.Point(138, 11);
            this.pictureBoxForm2.Name = "pictureBoxForm2";
            this.pictureBoxForm2.Size = new System.Drawing.Size(128, 133);
            this.pictureBoxForm2.TabIndex = 0;
            this.pictureBoxForm2.TabStop = false;
            // 
            // label1Form2
            // 
            this.label1Form2.AutoSize = true;
            this.label1Form2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1Form2.Location = new System.Drawing.Point(89, 218);
            this.label1Form2.Name = "label1Form2";
            this.label1Form2.Size = new System.Drawing.Size(231, 55);
            this.label1Form2.TabIndex = 1;
            this.label1Form2.Text = "Notebook";
            // 
            // labelForm2
            // 
            this.labelForm2.AutoSize = true;
            this.labelForm2.Location = new System.Drawing.Point(15, 218);
            this.labelForm2.Name = "labelForm2";
            this.labelForm2.Size = new System.Drawing.Size(0, 15);
            this.labelForm2.TabIndex = 3;
            // 
            // Form2AboutProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(414, 431);
            this.Controls.Add(this.labelForm2);
            this.Controls.Add(this.label1Form2);
            this.Controls.Add(this.pictureBoxForm2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(430, 470);
            this.MinimumSize = new System.Drawing.Size(430, 470);
            this.Name = "Form2AboutProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Блокнот: сведения";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxForm2;
        private System.Windows.Forms.Label label1Form2;
        private System.Windows.Forms.Label labelForm2;
    }
}