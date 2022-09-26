namespace vbEngC
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
            this.nameTbox = new System.Windows.Forms.TextBox();
            this.rollTbox = new System.Windows.Forms.TextBox();
            this.gradeTbox = new System.Windows.Forms.TextBox();
            this.sectionTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.insertBtn = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTbox
            // 
            this.nameTbox.Location = new System.Drawing.Point(149, 38);
            this.nameTbox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.Size = new System.Drawing.Size(105, 23);
            this.nameTbox.TabIndex = 0;
            // 
            // rollTbox
            // 
            this.rollTbox.Location = new System.Drawing.Point(149, 68);
            this.rollTbox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rollTbox.Name = "rollTbox";
            this.rollTbox.Size = new System.Drawing.Size(105, 23);
            this.rollTbox.TabIndex = 1;
            // 
            // gradeTbox
            // 
            this.gradeTbox.Location = new System.Drawing.Point(149, 101);
            this.gradeTbox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gradeTbox.Name = "gradeTbox";
            this.gradeTbox.Size = new System.Drawing.Size(105, 23);
            this.gradeTbox.TabIndex = 2;
            // 
            // sectionTbox
            // 
            this.sectionTbox.Location = new System.Drawing.Point(149, 137);
            this.sectionTbox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.sectionTbox.Name = "sectionTbox";
            this.sectionTbox.Size = new System.Drawing.Size(105, 23);
            this.sectionTbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Roll No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Section";
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(56, 184);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(77, 21);
            this.insertBtn.TabIndex = 8;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(175, 184);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(77, 21);
            this.selectBtn.TabIndex = 9;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(56, 228);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(77, 21);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(175, 228);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(77, 21);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 280);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sectionTbox);
            this.Controls.Add(this.gradeTbox);
            this.Controls.Add(this.rollTbox);
            this.Controls.Add(this.nameTbox);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTbox;
        private TextBox rollTbox;
        private TextBox gradeTbox;
        private TextBox sectionTbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button insertBtn;
        private Button selectBtn;
        private Button updateBtn;
        private Button deleteBtn;
    }
}