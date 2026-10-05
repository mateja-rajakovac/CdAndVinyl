namespace CdAndVinyl
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
            txtInputType = new TextBox();
            txtInputArtist = new TextBox();
            txtInputTitle = new TextBox();
            this.txtTitle = new Label();
            txtArtist = new Label();
            txtType = new Label();
            SuspendLayout();
            // 
            // txtInputType
            // 
            txtInputType.Location = new Point(159, 531);
            txtInputType.Name = "txtInputType";
            txtInputType.Size = new Size(311, 23);
            txtInputType.TabIndex = 0;
            txtInputType.TextChanged += txtInputType_TextChanged;
            // 
            // txtInputArtist
            // 
            txtInputArtist.Location = new Point(159, 502);
            txtInputArtist.Name = "txtInputArtist";
            txtInputArtist.Size = new Size(311, 23);
            txtInputArtist.TabIndex = 1;
            txtInputArtist.TextChanged += txtInputArtist_TextChanged;
            // 
            // txtInputTitle
            // 
            txtInputTitle.Location = new Point(159, 473);
            txtInputTitle.Name = "txtInputTitle";
            txtInputTitle.Size = new Size(311, 23);
            txtInputTitle.TabIndex = 3;
            txtInputTitle.TextChanged += txtInputTitle_TextChanged;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Location = new Point(90, 476);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new Size(63, 15);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.Text = "Input-Title";
            // 
            // txtArtist
            // 
            txtArtist.AutoSize = true;
            txtArtist.Location = new Point(85, 505);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(68, 15);
            txtArtist.TabIndex = 5;
            txtArtist.Text = "Input-Artist";
            // 
            // txtType
            // 
            txtType.AutoSize = true;
            txtType.Location = new Point(38, 534);
            txtType.Name = "txtType";
            txtType.Size = new Size(115, 15);
            txtType.TabIndex = 6;
            txtType.Text = "Input-Medium-Type";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(562, 586);
            Controls.Add(txtType);
            Controls.Add(txtArtist);
            Controls.Add(this.txtTitle);
            Controls.Add(txtInputTitle);
            Controls.Add(txtInputArtist);
            Controls.Add(txtInputType);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInputType;
        private TextBox txtInputArtist;
        private TextBox txtInputTitle;
        private Label txtArtist;
        private Label txtTitle;
        private Label txtType;
    }
}
