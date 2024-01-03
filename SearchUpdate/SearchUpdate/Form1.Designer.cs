namespace SearchUpdate
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelShift = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.bttInsert = new System.Windows.Forms.Button();
            this.bttSearch = new System.Windows.Forms.Button();
            this.bttUpdate = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(91, 99);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(91, 168);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(91, 231);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(52, 20);
            this.labelClass.TabIndex = 2;
            this.labelClass.Text = "Class";
            // 
            // labelShift
            // 
            this.labelShift.AutoSize = true;
            this.labelShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShift.Location = new System.Drawing.Point(91, 296);
            this.labelShift.Name = "labelShift";
            this.labelShift.Size = new System.Drawing.Size(43, 20);
            this.labelShift.TabIndex = 3;
            this.labelShift.Text = "Shift";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(204, 93);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(301, 27);
            this.txtID.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(204, 161);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 27);
            this.txtName.TabIndex = 5;
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(204, 224);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(301, 27);
            this.txtClass.TabIndex = 6;
            // 
            // txtShift
            // 
            this.txtShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShift.Location = new System.Drawing.Point(204, 289);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(301, 27);
            this.txtShift.TabIndex = 7;
            // 
            // bttInsert
            // 
            this.bttInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttInsert.Location = new System.Drawing.Point(32, 362);
            this.bttInsert.Name = "bttInsert";
            this.bttInsert.Size = new System.Drawing.Size(85, 39);
            this.bttInsert.TabIndex = 8;
            this.bttInsert.Text = "Insert";
            this.bttInsert.UseVisualStyleBackColor = false;
            this.bttInsert.Click += new System.EventHandler(this.bttInsert_Click);
            // 
            // bttSearch
            // 
            this.bttSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttSearch.Location = new System.Drawing.Point(156, 362);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(85, 39);
            this.bttSearch.TabIndex = 9;
            this.bttSearch.Text = "Search";
            this.bttSearch.UseVisualStyleBackColor = false;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // bttUpdate
            // 
            this.bttUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttUpdate.Location = new System.Drawing.Point(285, 362);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(85, 39);
            this.bttUpdate.TabIndex = 10;
            this.bttUpdate.Text = "Update";
            this.bttUpdate.UseVisualStyleBackColor = false;
            this.bttUpdate.Click += new System.EventHandler(this.bttUpdate_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttDelete.Location = new System.Drawing.Point(420, 362);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(85, 39);
            this.bttDelete.TabIndex = 11;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = false;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttShow
            // 
            this.bttShow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttShow.Location = new System.Drawing.Point(554, 362);
            this.bttShow.Name = "bttShow";
            this.bttShow.Size = new System.Drawing.Size(85, 39);
            this.bttShow.TabIndex = 12;
            this.bttShow.Text = "Show";
            this.bttShow.UseVisualStyleBackColor = false;
            this.bttShow.Click += new System.EventHandler(this.bttShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 449);
            this.Controls.Add(this.bttShow);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttUpdate);
            this.Controls.Add(this.bttSearch);
            this.Controls.Add(this.bttInsert);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelShift);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelShift;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.Button bttInsert;
        private System.Windows.Forms.Button bttSearch;
        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttShow;
    }
}

