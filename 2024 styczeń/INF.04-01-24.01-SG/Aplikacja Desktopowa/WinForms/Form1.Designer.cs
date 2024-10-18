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
            groupBox = new GroupBox();
            hazelEyes = new RadioButton();
            greenEyes = new RadioButton();
            blueEyes = new RadioButton();
            numberBox = new TextBox();
            nameBox = new TextBox();
            surnameBox = new TextBox();
            number = new Label();
            name = new Label();
            surname = new Label();
            submitBtn = new Button();
            personImage = new PictureBox();
            fingerprintImage = new PictureBox();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)personImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fingerprintImage).BeginInit();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(hazelEyes);
            groupBox.Controls.Add(greenEyes);
            groupBox.Controls.Add(blueEyes);
            groupBox.Location = new Point(38, 156);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(284, 139);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Kolor oczu";
            // 
            // hazelEyes
            // 
            hazelEyes.AutoSize = true;
            hazelEyes.Location = new Point(18, 101);
            hazelEyes.Name = "hazelEyes";
            hazelEyes.Size = new Size(57, 19);
            hazelEyes.TabIndex = 2;
            hazelEyes.Text = "piwne";
            hazelEyes.UseVisualStyleBackColor = true;
            // 
            // greenEyes
            // 
            greenEyes.AutoSize = true;
            greenEyes.Location = new Point(18, 67);
            greenEyes.Name = "greenEyes";
            greenEyes.Size = new Size(62, 19);
            greenEyes.TabIndex = 1;
            greenEyes.Text = "zielone";
            greenEyes.UseVisualStyleBackColor = true;
            // 
            // blueEyes
            // 
            blueEyes.AutoSize = true;
            blueEyes.Checked = true;
            blueEyes.Location = new Point(18, 33);
            blueEyes.Name = "blueEyes";
            blueEyes.Size = new Size(77, 19);
            blueEyes.TabIndex = 0;
            blueEyes.TabStop = true;
            blueEyes.Text = "niebieskie";
            blueEyes.UseVisualStyleBackColor = true;
            // 
            // numberBox
            // 
            numberBox.BackColor = Color.Azure;
            numberBox.Location = new Point(123, 31);
            numberBox.Name = "numberBox";
            numberBox.Size = new Size(199, 23);
            numberBox.TabIndex = 1;
            numberBox.Leave += numberBox_Leave;
            // 
            // nameBox
            // 
            nameBox.BackColor = Color.Azure;
            nameBox.Location = new Point(123, 71);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(199, 23);
            nameBox.TabIndex = 2;
            // 
            // surnameBox
            // 
            surnameBox.BackColor = Color.Azure;
            surnameBox.Location = new Point(123, 106);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(199, 23);
            surnameBox.TabIndex = 3;
            // 
            // number
            // 
            number.AutoSize = true;
            number.Location = new Point(38, 34);
            number.Name = "number";
            number.Size = new Size(44, 15);
            number.TabIndex = 4;
            number.Text = "Numer";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(38, 74);
            name.Name = "name";
            name.Size = new Size(30, 15);
            name.TabIndex = 5;
            name.Text = "Imię";
            // 
            // surname
            // 
            surname.AutoSize = true;
            surname.Location = new Point(38, 109);
            surname.Name = "surname";
            surname.Size = new Size(57, 15);
            surname.TabIndex = 6;
            surname.Text = "Nazwisko";
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.Azure;
            submitBtn.Location = new Point(512, 257);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(114, 38);
            submitBtn.TabIndex = 7;
            submitBtn.Text = "OK";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // personImage
            // 
            personImage.Image = Properties.Resources._000_zdjecie;
            personImage.Location = new Point(368, 31);
            personImage.Name = "personImage";
            personImage.Size = new Size(180, 180);
            personImage.SizeMode = PictureBoxSizeMode.Zoom;
            personImage.TabIndex = 8;
            personImage.TabStop = false;
            // 
            // fingerprintImage
            // 
            fingerprintImage.Image = Properties.Resources._000_odcisk;
            fingerprintImage.Location = new Point(584, 31);
            fingerprintImage.Name = "fingerprintImage";
            fingerprintImage.Size = new Size(180, 180);
            fingerprintImage.SizeMode = PictureBoxSizeMode.Zoom;
            fingerprintImage.TabIndex = 9;
            fingerprintImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(fingerprintImage);
            Controls.Add(personImage);
            Controls.Add(submitBtn);
            Controls.Add(surname);
            Controls.Add(name);
            Controls.Add(number);
            Controls.Add(surnameBox);
            Controls.Add(nameBox);
            Controls.Add(numberBox);
            Controls.Add(groupBox);
            Name = "Form1";
            Text = "Wprowadzenie danych do paszportu.";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)personImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)fingerprintImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox;
        private RadioButton hazelEyes;
        private RadioButton greenEyes;
        private RadioButton blueEyes;
        private TextBox numberBox;
        private TextBox nameBox;
        private TextBox surnameBox;
        private Label number;
        private Label name;
        private Label surname;
        private Button submitBtn;
        private PictureBox personImage;
        private PictureBox fingerprintImage;
    }
}
