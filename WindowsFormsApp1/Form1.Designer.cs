namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.filePath = new System.Windows.Forms.TextBox();
            this.dogButton = new System.Windows.Forms.CheckBox();
            this.catButton = new System.Windows.Forms.CheckBox();
            this.birbButton = new System.Windows.Forms.CheckBox();
            this.Browse = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // filePath
            // 
            this.filePath.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePath.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.filePath.Location = new System.Drawing.Point(21, 31);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(370, 26);
            this.filePath.TabIndex = 0;
            this.filePath.Text = "Please type or browse to file path";
            this.filePath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dogButton
            // 
            this.dogButton.AutoSize = true;
            this.dogButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogButton.Location = new System.Drawing.Point(12, 139);
            this.dogButton.Name = "dogButton";
            this.dogButton.Size = new System.Drawing.Size(82, 28);
            this.dogButton.TabIndex = 1;
            this.dogButton.Text = "Doggo";
            this.dogButton.UseVisualStyleBackColor = true;
            this.dogButton.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // catButton
            // 
            this.catButton.AutoSize = true;
            this.catButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catButton.Location = new System.Drawing.Point(12, 285);
            this.catButton.Name = "catButton";
            this.catButton.Size = new System.Drawing.Size(81, 28);
            this.catButton.TabIndex = 2;
            this.catButton.Text = "Kitteh";
            this.catButton.UseVisualStyleBackColor = true;
            this.catButton.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // birbButton
            // 
            this.birbButton.AutoSize = true;
            this.birbButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birbButton.Location = new System.Drawing.Point(12, 432);
            this.birbButton.Name = "birbButton";
            this.birbButton.Size = new System.Drawing.Size(65, 28);
            this.birbButton.TabIndex = 3;
            this.birbButton.Text = "Birb";
            this.birbButton.UseVisualStyleBackColor = true;
            this.birbButton.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Browse
            // 
            this.Browse.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.Location = new System.Drawing.Point(397, 16);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 4;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(397, 45);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 129);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(148, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 129);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(148, 382);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 129);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 534);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.birbButton);
            this.Controls.Add(this.catButton);
            this.Controls.Add(this.dogButton);
            this.Controls.Add(this.filePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.CheckBox dogButton;
        private System.Windows.Forms.CheckBox catButton;
        private System.Windows.Forms.CheckBox birbButton;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

