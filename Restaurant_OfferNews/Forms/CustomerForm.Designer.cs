namespace Restaurant_OfferNews.Forms
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.customerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cutomerIdLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerFormCloseButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.customerTableButton = new System.Windows.Forms.Button();
            this.itemFormButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customerPhoneTextBox);
            this.panel1.Controls.Add(this.customerNameTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cutomerIdLabel);
            this.panel1.Location = new System.Drawing.Point(213, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 209);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // customerPhoneTextBox
            // 
            this.customerPhoneTextBox.Location = new System.Drawing.Point(173, 129);
            this.customerPhoneTextBox.Multiline = true;
            this.customerPhoneTextBox.Name = "customerPhoneTextBox";
            this.customerPhoneTextBox.Size = new System.Drawing.Size(256, 28);
            this.customerPhoneTextBox.TabIndex = 6;
            this.customerPhoneTextBox.TextChanged += new System.EventHandler(this.customerPhoneTextBox_TextChanged);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(173, 77);
            this.customerNameTextBox.Multiline = true;
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(256, 28);
            this.customerNameTextBox.TabIndex = 5;
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.customerNameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cutomerIdLabel
            // 
            this.cutomerIdLabel.AutoSize = true;
            this.cutomerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutomerIdLabel.Location = new System.Drawing.Point(40, 34);
            this.cutomerIdLabel.Name = "cutomerIdLabel";
            this.cutomerIdLabel.Size = new System.Drawing.Size(0, 24);
            this.cutomerIdLabel.TabIndex = 2;
            this.cutomerIdLabel.Click += new System.EventHandler(this.cutomerIdLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // customerFormCloseButton
            // 
            this.customerFormCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerFormCloseButton.ForeColor = System.Drawing.Color.Red;
            this.customerFormCloseButton.Location = new System.Drawing.Point(623, 30);
            this.customerFormCloseButton.Name = "customerFormCloseButton";
            this.customerFormCloseButton.Size = new System.Drawing.Size(75, 25);
            this.customerFormCloseButton.TabIndex = 4;
            this.customerFormCloseButton.Text = "close";
            this.customerFormCloseButton.UseVisualStyleBackColor = true;
            this.customerFormCloseButton.Click += new System.EventHandler(this.customerFormCloseButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(0, 164);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 32);
            this.button4.TabIndex = 6;
            this.button4.Text = "Order Form";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Black;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(0, 48);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(148, 32);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.updateButton);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.customerTableButton);
            this.panel2.Controls.Add(this.itemFormButton);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.homeButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 485);
            this.panel2.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Black;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.Location = new System.Drawing.Point(0, 342);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(148, 32);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Black;
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.Location = new System.Drawing.Point(0, 279);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(148, 32);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Black;
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(0, 222);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(148, 32);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // customerTableButton
            // 
            this.customerTableButton.BackColor = System.Drawing.Color.Black;
            this.customerTableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customerTableButton.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.customerTableButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.customerTableButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.customerTableButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.customerTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTableButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.customerTableButton.Image = ((System.Drawing.Image)(resources.GetObject("customerTableButton.Image")));
            this.customerTableButton.Location = new System.Drawing.Point(0, 404);
            this.customerTableButton.Name = "customerTableButton";
            this.customerTableButton.Size = new System.Drawing.Size(148, 32);
            this.customerTableButton.TabIndex = 8;
            this.customerTableButton.Text = "Customer Table";
            this.customerTableButton.UseVisualStyleBackColor = false;
            this.customerTableButton.Click += new System.EventHandler(this.customerTableButton_Click);
            // 
            // itemFormButton
            // 
            this.itemFormButton.BackColor = System.Drawing.Color.Black;
            this.itemFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemFormButton.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.itemFormButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.itemFormButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.itemFormButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.itemFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemFormButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.itemFormButton.Image = ((System.Drawing.Image)(resources.GetObject("itemFormButton.Image")));
            this.itemFormButton.Location = new System.Drawing.Point(0, 107);
            this.itemFormButton.Name = "itemFormButton";
            this.itemFormButton.Size = new System.Drawing.Size(148, 32);
            this.itemFormButton.TabIndex = 7;
            this.itemFormButton.Text = "Item Form";
            this.itemFormButton.UseVisualStyleBackColor = false;
            this.itemFormButton.Click += new System.EventHandler(this.itemFormButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(148, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(654, 564);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(148, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(562, 15);
            this.panel3.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(163, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(118, 125);
            this.panel5.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(0, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Restaurant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(19, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "HRIOVI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 485);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.customerFormCloseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customerFormCloseButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button customerTableButton;
        private System.Windows.Forms.Button itemFormButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.TextBox customerPhoneTextBox;
        public System.Windows.Forms.TextBox customerNameTextBox;
        public System.Windows.Forms.Label cutomerIdLabel;
    }
}