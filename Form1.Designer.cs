namespace AITest1
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
            textBoxText = new TextBox();
            pictureBoxGenerated = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGenerated).BeginInit();
            SuspendLayout();
            // 
            // textBoxText
            // 
            textBoxText.Location = new Point(12, 12);
            textBoxText.Multiline = true;
            textBoxText.Name = "textBoxText";
            textBoxText.Size = new Size(298, 100);
            textBoxText.TabIndex = 0;
            // 
            // pictureBoxGenerated
            // 
            pictureBoxGenerated.Location = new Point(316, 12);
            pictureBoxGenerated.Name = "pictureBoxGenerated";
            pictureBoxGenerated.Size = new Size(472, 426);
            pictureBoxGenerated.TabIndex = 1;
            pictureBoxGenerated.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(105, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBoxGenerated);
            Controls.Add(textBoxText);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxGenerated).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxText;
        private PictureBox pictureBoxGenerated;
        private Button button1;
    }
}