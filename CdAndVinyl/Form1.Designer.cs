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
            txtTitle = new Label();
            txtArtist = new Label();
            txtType = new Label();
            btInput = new Button();
            SuspendLayout();
            // 
            // txtInputType
            // 
            txtInputType.Location = new Point(133, 531);
            txtInputType.Name = "txtInputType";
            txtInputType.Size = new Size(311, 23);
            txtInputType.TabIndex = 0;
            txtInputType.TextChanged += txtInputType_TextChanged;
            // 
            // txtInputArtist
            // 
            txtInputArtist.Location = new Point(133, 502);
            txtInputArtist.Name = "txtInputArtist";
            txtInputArtist.Size = new Size(311, 23);
            txtInputArtist.TabIndex = 1;
            txtInputArtist.TextChanged += txtInputArtist_TextChanged;
            // 
            // txtInputTitle
            // 
            txtInputTitle.Location = new Point(133, 473);
            txtInputTitle.Name = "txtInputTitle";
            txtInputTitle.Size = new Size(311, 23);
            txtInputTitle.TabIndex = 3;
            txtInputTitle.TextChanged += txtInputTitle_TextChanged;
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Location = new Point(64, 476);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(63, 15);
            txtTitle.TabIndex = 4;
            txtTitle.Text = "Input-Title";
            // 
            // txtArtist
            // 
            txtArtist.AutoSize = true;
            txtArtist.Location = new Point(59, 505);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(68, 15);
            txtArtist.TabIndex = 5;
            txtArtist.Text = "Input-Artist";
            // 
            // txtType
            // 
            txtType.AutoSize = true;
            txtType.Location = new Point(12, 534);
            txtType.Name = "txtType";
            txtType.Size = new Size(115, 15);
            txtType.TabIndex = 6;
            txtType.Text = "Input-Medium-Type";
            // 
            // btInput
            // 
            btInput.Location = new Point(462, 505);
            btInput.Name = "btInput";
            btInput.Size = new Size(85, 23);
            btInput.TabIndex = 7;
            btInput.Text = "Input choice";
            btInput.UseVisualStyleBackColor = true;
            btInput.Click += btInput_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(562, 586);
            Controls.Add(btInput);
            Controls.Add(txtType);
            Controls.Add(txtArtist);
            Controls.Add(txtTitle);
            Controls.Add(txtInputTitle);
            Controls.Add(txtInputArtist);
            Controls.Add(txtInputType);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
        private Button btInput;
    }
}
