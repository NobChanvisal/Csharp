namespace Show3
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
            IDlabel = new Label();
            txtID = new TextBox();
            Namelabel = new Label();
            txtName = new TextBox();
            Pricelabel = new Label();
            txtPrice = new TextBox();
            Amountlabel = new Label();
            txtAmount = new TextBox();
            QTYlabel = new Label();
            txtQTY = new TextBox();
            bttSell = new Button();
            bttShowSell = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // IDlabel
            // 
            IDlabel.AutoSize = true;
            IDlabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            IDlabel.Location = new Point(22, 126);
            IDlabel.Name = "IDlabel";
            IDlabel.Size = new Size(28, 23);
            IDlabel.TabIndex = 0;
            IDlabel.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(122, 125);
            txtID.Name = "txtID";
            txtID.Size = new Size(230, 27);
            txtID.TabIndex = 1;
            // 
            // Namelabel
            // 
            Namelabel.AutoSize = true;
            Namelabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Namelabel.Location = new Point(22, 176);
            Namelabel.Name = "Namelabel";
            Namelabel.Size = new Size(57, 23);
            Namelabel.TabIndex = 0;
            Namelabel.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(122, 175);
            txtName.Name = "txtName";
            txtName.Size = new Size(230, 27);
            txtName.TabIndex = 1;
            // 
            // Pricelabel
            // 
            Pricelabel.AutoSize = true;
            Pricelabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Pricelabel.Location = new Point(22, 272);
            Pricelabel.Name = "Pricelabel";
            Pricelabel.Size = new Size(49, 23);
            Pricelabel.TabIndex = 0;
            Pricelabel.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(122, 271);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(230, 27);
            txtPrice.TabIndex = 1;
            txtPrice.Leave += txtPrice_Leave;
            // 
            // Amountlabel
            // 
            Amountlabel.AutoSize = true;
            Amountlabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Amountlabel.Location = new Point(22, 322);
            Amountlabel.Name = "Amountlabel";
            Amountlabel.Size = new Size(75, 23);
            Amountlabel.TabIndex = 0;
            Amountlabel.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(122, 321);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(230, 27);
            txtAmount.TabIndex = 1;
            txtAmount.Leave += txtAmount_Leave;
            // 
            // QTYlabel
            // 
            QTYlabel.AutoSize = true;
            QTYlabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            QTYlabel.Location = new Point(22, 221);
            QTYlabel.Name = "QTYlabel";
            QTYlabel.Size = new Size(42, 23);
            QTYlabel.TabIndex = 0;
            QTYlabel.Text = "QTY";
            // 
            // txtQTY
            // 
            txtQTY.Location = new Point(122, 220);
            txtQTY.Name = "txtQTY";
            txtQTY.Size = new Size(230, 27);
            txtQTY.TabIndex = 1;
            txtQTY.Leave += txtQTY_Leave;
            // 
            // bttSell
            // 
            bttSell.BackColor = SystemColors.HotTrack;
            bttSell.Font = new Font("Snap ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            bttSell.ForeColor = SystemColors.Control;
            bttSell.Location = new Point(22, 384);
            bttSell.Name = "bttSell";
            bttSell.Size = new Size(90, 38);
            bttSell.TabIndex = 2;
            bttSell.Text = "Sell";
            bttSell.UseVisualStyleBackColor = false;
            bttSell.Click += bttSell_Click;
            // 
            // bttShowSell
            // 
            bttShowSell.BackColor = Color.Firebrick;
            bttShowSell.Font = new Font("Snap ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            bttShowSell.ForeColor = SystemColors.Control;
            bttShowSell.Location = new Point(221, 384);
            bttShowSell.Name = "bttShowSell";
            bttShowSell.Size = new Size(131, 38);
            bttShowSell.TabIndex = 2;
            bttShowSell.Text = "Show Sell";
            bttShowSell.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(132, 46);
            label1.Name = "label1";
            label1.Size = new Size(129, 29);
            label1.TabIndex = 3;
            label1.Text = "Product";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(375, 494);
            Controls.Add(label1);
            Controls.Add(bttShowSell);
            Controls.Add(bttSell);
            Controls.Add(txtAmount);
            Controls.Add(Amountlabel);
            Controls.Add(txtPrice);
            Controls.Add(Pricelabel);
            Controls.Add(txtQTY);
            Controls.Add(QTYlabel);
            Controls.Add(txtName);
            Controls.Add(Namelabel);
            Controls.Add(txtID);
            Controls.Add(IDlabel);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDlabel;
        private TextBox txtID;
        private Label Namelabel;
        private TextBox txtName;
        private Label Pricelabel;
        private TextBox txtPrice;
        private Label Amountlabel;
        private TextBox txtAmount;
        private Label QTYlabel;
        private TextBox txtQTY;
        private Button bttSell;
        private Button bttShowSell;
        private Label label1;
    }
}