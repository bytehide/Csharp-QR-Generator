namespace QRCodeGenerator
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
            TextBox1 = new TextBox();
            PictureBox1 = new PictureBox();
            Button1 = new Button();
            Button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(41, 27);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(300, 23);
            TextBox1.TabIndex = 0;
            TextBox1.TextChanged += TextBox1_TextChanged;
            // 
            // PictureBox1
            // 
            PictureBox1.Location = new Point(79, 140);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(225, 225);
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBox1.TabIndex = 1;
            PictureBox1.TabStop = false;
            PictureBox1.Click += PictureBox1_Click;
            // 
            // Button1
            // 
            Button1.Location = new Point(155, 77);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 2;
            Button1.Text = "Generate";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += BtnGenerate_Click;
            // 
            // Button2
            // 
            Button2.Location = new Point(155, 452);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 3;
            Button2.Text = "Save";
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += BtnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(384, 561);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(PictureBox1);
            Controls.Add(TextBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBox1;
        private PictureBox PictureBox1;
        private Button Button1;
        private Button Button2;
    }
}