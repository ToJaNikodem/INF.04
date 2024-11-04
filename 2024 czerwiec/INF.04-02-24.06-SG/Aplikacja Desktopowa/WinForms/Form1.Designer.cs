namespace WinForms
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
            PreviousBtn = new Button();
            nextBtn = new Button();
            pictureBox1 = new PictureBox();
            artistName = new Label();
            albumName = new Label();
            songsNumber = new Label();
            yearOfRelease = new Label();
            downloadNumber = new Label();
            downloadBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PreviousBtn
            // 
            PreviousBtn.Image = Properties.Resources.obraz3;
            PreviousBtn.Location = new Point(32, 155);
            PreviousBtn.Name = "PreviousBtn";
            PreviousBtn.Size = new Size(102, 70);
            PreviousBtn.TabIndex = 0;
            PreviousBtn.UseVisualStyleBackColor = true;
            PreviousBtn.Click += PreviousBtn_Click;
            // 
            // nextBtn
            // 
            nextBtn.Image = Properties.Resources.obraz2;
            nextBtn.Location = new Point(1214, 155);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(102, 70);
            nextBtn.TabIndex = 1;
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.obraz;
            pictureBox1.Location = new Point(166, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // artistName
            // 
            artistName.AutoSize = true;
            artistName.Font = new Font("Segoe UI", 50F);
            artistName.ForeColor = Color.White;
            artistName.Location = new Point(388, 30);
            artistName.Name = "artistName";
            artistName.Size = new Size(214, 89);
            artistName.TabIndex = 3;
            artistName.Text = "label1";
            // 
            // albumName
            // 
            albumName.AutoSize = true;
            albumName.Font = new Font("Segoe UI", 30F);
            albumName.ForeColor = Color.White;
            albumName.Location = new Point(388, 127);
            albumName.Name = "albumName";
            albumName.Size = new Size(130, 54);
            albumName.TabIndex = 4;
            albumName.Text = "label2";
            // 
            // songsNumber
            // 
            songsNumber.AutoSize = true;
            songsNumber.Font = new Font("Segoe UI", 20F);
            songsNumber.ForeColor = Color.FromArgb(97, 217, 24);
            songsNumber.Location = new Point(388, 208);
            songsNumber.Name = "songsNumber";
            songsNumber.Size = new Size(90, 37);
            songsNumber.TabIndex = 5;
            songsNumber.Text = "label3";
            // 
            // yearOfRelease
            // 
            yearOfRelease.AutoSize = true;
            yearOfRelease.Font = new Font("Segoe UI", 20F);
            yearOfRelease.ForeColor = Color.FromArgb(97, 217, 24);
            yearOfRelease.Location = new Point(591, 208);
            yearOfRelease.Name = "yearOfRelease";
            yearOfRelease.Size = new Size(90, 37);
            yearOfRelease.TabIndex = 6;
            yearOfRelease.Text = "label4";
            // 
            // downloadNumber
            // 
            downloadNumber.AutoSize = true;
            downloadNumber.Font = new Font("Segoe UI", 20F);
            downloadNumber.ForeColor = Color.FromArgb(97, 217, 24);
            downloadNumber.Location = new Point(180, 290);
            downloadNumber.Name = "downloadNumber";
            downloadNumber.Size = new Size(90, 37);
            downloadNumber.TabIndex = 7;
            downloadNumber.Text = "label5";
            // 
            // downloadBtn
            // 
            downloadBtn.BackColor = Color.FromArgb(97, 217, 24);
            downloadBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            downloadBtn.Location = new Point(378, 282);
            downloadBtn.Name = "downloadBtn";
            downloadBtn.Size = new Size(159, 53);
            downloadBtn.TabIndex = 8;
            downloadBtn.Text = "Pobierz";
            downloadBtn.UseVisualStyleBackColor = false;
            downloadBtn.Click += downloadBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1350, 450);
            Controls.Add(downloadBtn);
            Controls.Add(downloadNumber);
            Controls.Add(yearOfRelease);
            Controls.Add(songsNumber);
            Controls.Add(albumName);
            Controls.Add(artistName);
            Controls.Add(pictureBox1);
            Controls.Add(nextBtn);
            Controls.Add(PreviousBtn);
            Name = "Form1";
            Text = "MojeDźwięki";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PreviousBtn;
        private Button nextBtn;
        private PictureBox pictureBox1;
        private Label artistName;
        private Label albumName;
        private Label songsNumber;
        private Label yearOfRelease;
        private Label downloadNumber;
        private Button downloadBtn;
    }
}
