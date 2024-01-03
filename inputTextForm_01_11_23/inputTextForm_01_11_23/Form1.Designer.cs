namespace inputTextForm_01_11_23
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
            txtInformation = new Label();
            textBox1 = new TextBox();
            showButton = new Button();
            form2Button = new Button();
            SuspendLayout();
            // 
            // txtInformation
            // 
            txtInformation.AutoSize = true;
            txtInformation.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInformation.ForeColor = Color.MidnightBlue;
            txtInformation.Location = new Point(155, 63);
            txtInformation.Name = "txtInformation";
            txtInformation.Size = new Size(149, 26);
            txtInformation.TabIndex = 0;
            txtInformation.Text = "Information";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 106);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 147);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // showButton
            // 
            showButton.BackColor = Color.PaleVioletRed;
            showButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            showButton.ForeColor = SystemColors.ControlText;
            showButton.Location = new Point(109, 292);
            showButton.Name = "showButton";
            showButton.Size = new Size(95, 36);
            showButton.TabIndex = 2;
            showButton.Text = "Show";
            showButton.UseVisualStyleBackColor = false;
            showButton.Click += showButton_Click;
            // 
            // form2Button
            // 
            form2Button.BackColor = Color.PaleVioletRed;
            form2Button.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            form2Button.Location = new Point(270, 292);
            form2Button.Name = "form2Button";
            form2Button.Size = new Size(94, 36);
            form2Button.TabIndex = 2;
            form2Button.Text = "Form2";
            form2Button.UseVisualStyleBackColor = false;
            form2Button.Click += form2Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 468);
            Controls.Add(form2Button);
            Controls.Add(showButton);
            Controls.Add(textBox1);
            Controls.Add(txtInformation);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtInformation;
        private TextBox textBox1;
        private Button showButton;
        private Button form2Button;
    }
}