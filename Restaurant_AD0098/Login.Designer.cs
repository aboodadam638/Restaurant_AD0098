
namespace Restaurant_AD0098
{
    partial class frmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnjuices = new System.Windows.Forms.Button();
            this.btnBreakfast = new System.Windows.Forms.Button();
            this.btnsweets = new System.Windows.Forms.Button();
            this.btnLunch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btndatabase = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btndatabase);
            this.panel1.Controls.Add(this.btnjuices);
            this.panel1.Controls.Add(this.btnBreakfast);
            this.panel1.Controls.Add(this.btnsweets);
            this.panel1.Controls.Add(this.btnLunch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 95);
            this.panel1.TabIndex = 0;
            // 
            // btnjuices
            // 
            this.btnjuices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnjuices.Font = new System.Drawing.Font("Showcard Gothic", 11.25F);
            this.btnjuices.Location = new System.Drawing.Point(297, 22);
            this.btnjuices.Name = "btnjuices";
            this.btnjuices.Size = new System.Drawing.Size(69, 49);
            this.btnjuices.TabIndex = 3;
            this.btnjuices.Text = "juices";
            this.btnjuices.UseVisualStyleBackColor = false;
            this.btnjuices.Click += new System.EventHandler(this.btnForm4_Click_1);
            // 
            // btnBreakfast
            // 
            this.btnBreakfast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBreakfast.Font = new System.Drawing.Font("Showcard Gothic", 11.25F);
            this.btnBreakfast.Location = new System.Drawing.Point(199, 22);
            this.btnBreakfast.Name = "btnBreakfast";
            this.btnBreakfast.Size = new System.Drawing.Size(69, 49);
            this.btnBreakfast.TabIndex = 0;
            this.btnBreakfast.Text = "Breakfast";
            this.btnBreakfast.UseVisualStyleBackColor = false;
            this.btnBreakfast.Click += new System.EventHandler(this.btnForm1_Click_1);
            // 
            // btnsweets
            // 
            this.btnsweets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsweets.Font = new System.Drawing.Font("Showcard Gothic", 11.25F);
            this.btnsweets.Location = new System.Drawing.Point(100, 22);
            this.btnsweets.Name = "btnsweets";
            this.btnsweets.Size = new System.Drawing.Size(83, 49);
            this.btnsweets.TabIndex = 2;
            this.btnsweets.Text = "sweets";
            this.btnsweets.UseVisualStyleBackColor = false;
            this.btnsweets.Click += new System.EventHandler(this.btnForm3_Click_1);
            // 
            // btnLunch
            // 
            this.btnLunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLunch.Font = new System.Drawing.Font("Showcard Gothic", 11.25F);
            this.btnLunch.Location = new System.Drawing.Point(11, 22);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(67, 49);
            this.btnLunch.TabIndex = 1;
            this.btnLunch.Text = "Lunch";
            this.btnLunch.UseVisualStyleBackColor = false;
            this.btnLunch.Click += new System.EventHandler(this.btnForm2_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 266);
            this.panel3.TabIndex = 2;
            // 
            // btndatabase
            // 
            this.btndatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndatabase.Font = new System.Drawing.Font("Showcard Gothic", 11.25F);
            this.btndatabase.Location = new System.Drawing.Point(402, 22);
            this.btndatabase.Name = "btndatabase";
            this.btndatabase.Size = new System.Drawing.Size(59, 49);
            this.btndatabase.TabIndex = 4;
            this.btndatabase.Text = "DataBase";
            this.btndatabase.UseVisualStyleBackColor = false;
            this.btndatabase.Click += new System.EventHandler(this.btndatabase_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 361);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnjuices;
        private System.Windows.Forms.Button btnsweets;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button btnBreakfast;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btndatabase;
    }
}