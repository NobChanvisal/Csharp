namespace Show3
{
    partial class Form2
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
            label1 = new Label();
            lDlabelF2 = new Label();
            la_ShowID = new Label();
            NamelabelF2 = new Label();
            la_ShowName = new Label();
            QTYlabelF2 = new Label();
            la_ShowQTY = new Label();
            PricelabelF2 = new Label();
            la_ShowPrice = new Label();
            AmountlabelF2 = new Label();
            la_Sh_Amount = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Magenta;
            label1.Location = new Point(151, 50);
            label1.Name = "label1";
            label1.Size = new Size(58, 32);
            label1.TabIndex = 0;
            label1.Text = "Sell";
            // 
            // lDlabelF2
            // 
            lDlabelF2.AutoSize = true;
            lDlabelF2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lDlabelF2.Location = new Point(25, 112);
            lDlabelF2.Name = "lDlabelF2";
            lDlabelF2.Size = new Size(24, 20);
            lDlabelF2.TabIndex = 1;
            lDlabelF2.Text = "lD";
            // 
            // la_ShowID
            // 
            la_ShowID.AutoSize = true;
            la_ShowID.Location = new Point(116, 112);
            la_ShowID.Name = "la_ShowID";
            la_ShowID.Size = new Size(78, 20);
            la_ShowID.TabIndex = 2;
            la_ShowID.Text = "la_ShowID";
            // 
            // NamelabelF2
            // 
            NamelabelF2.AutoSize = true;
            NamelabelF2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NamelabelF2.Location = new Point(25, 148);
            NamelabelF2.Name = "NamelabelF2";
            NamelabelF2.Size = new Size(51, 20);
            NamelabelF2.TabIndex = 1;
            NamelabelF2.Text = "Name";
            // 
            // la_ShowName
            // 
            la_ShowName.AutoSize = true;
            la_ShowName.Location = new Point(116, 148);
            la_ShowName.Name = "la_ShowName";
            la_ShowName.Size = new Size(103, 20);
            la_ShowName.TabIndex = 2;
            la_ShowName.Text = "la_ShowName";
            // 
            // QTYlabelF2
            // 
            QTYlabelF2.AutoSize = true;
            QTYlabelF2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            QTYlabelF2.Location = new Point(25, 185);
            QTYlabelF2.Name = "QTYlabelF2";
            QTYlabelF2.Size = new Size(37, 20);
            QTYlabelF2.TabIndex = 1;
            QTYlabelF2.Text = "QTY";
            // 
            // la_ShowQTY
            // 
            la_ShowQTY.AutoSize = true;
            la_ShowQTY.Location = new Point(116, 185);
            la_ShowQTY.Name = "la_ShowQTY";
            la_ShowQTY.Size = new Size(89, 20);
            la_ShowQTY.TabIndex = 2;
            la_ShowQTY.Text = "la_ShowQTY";
            // 
            // PricelabelF2
            // 
            PricelabelF2.AutoSize = true;
            PricelabelF2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PricelabelF2.Location = new Point(25, 223);
            PricelabelF2.Name = "PricelabelF2";
            PricelabelF2.Size = new Size(43, 20);
            PricelabelF2.TabIndex = 1;
            PricelabelF2.Text = "Price";
            // 
            // la_ShowPrice
            // 
            la_ShowPrice.AutoSize = true;
            la_ShowPrice.Location = new Point(116, 223);
            la_ShowPrice.Name = "la_ShowPrice";
            la_ShowPrice.Size = new Size(95, 20);
            la_ShowPrice.TabIndex = 2;
            la_ShowPrice.Text = "la_ShowPrice";
            // 
            // AmountlabelF2
            // 
            AmountlabelF2.AutoSize = true;
            AmountlabelF2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AmountlabelF2.Location = new Point(25, 259);
            AmountlabelF2.Name = "AmountlabelF2";
            AmountlabelF2.Size = new Size(67, 20);
            AmountlabelF2.TabIndex = 1;
            AmountlabelF2.Text = "Amount";
            // 
            // la_Sh_Amount
            // 
            la_Sh_Amount.AutoSize = true;
            la_Sh_Amount.Location = new Point(116, 259);
            la_Sh_Amount.Name = "la_Sh_Amount";
            la_Sh_Amount.Size = new Size(102, 20);
            la_Sh_Amount.TabIndex = 2;
            la_Sh_Amount.Text = "la_Sh_Amount";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 509);
            Controls.Add(la_ShowQTY);
            Controls.Add(la_Sh_Amount);
            Controls.Add(QTYlabelF2);
            Controls.Add(AmountlabelF2);
            Controls.Add(la_ShowName);
            Controls.Add(la_ShowPrice);
            Controls.Add(NamelabelF2);
            Controls.Add(PricelabelF2);
            Controls.Add(la_ShowID);
            Controls.Add(lDlabelF2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lDlabelF2;
        private Label la_ShowID;
        private Label NamelabelF2;
        private Label la_ShowName;
        private Label QTYlabelF2;
        private Label la_ShowQTY;
        private Label PricelabelF2;
        private Label la_ShowPrice;
        private Label AmountlabelF2;
        private Label la_Sh_Amount;
    }
}