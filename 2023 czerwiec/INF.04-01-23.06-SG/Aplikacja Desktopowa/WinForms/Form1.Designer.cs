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
            groupBox1 = new GroupBox();
            parcel = new RadioButton();
            letter = new RadioButton();
            postcard = new RadioButton();
            groupBox2 = new GroupBox();
            city = new TextBox();
            postcode = new TextBox();
            street = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            checkPriceBtn = new Button();
            price = new Label();
            submitBtn = new Button();
            pictureBox = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(parcel);
            groupBox1.Controls.Add(letter);
            groupBox1.Controls.Add(postcard);
            groupBox1.Location = new Point(34, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 116);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rodzaj przesyłki";
            // 
            // parcel
            // 
            parcel.AutoSize = true;
            parcel.Location = new Point(18, 81);
            parcel.Name = "parcel";
            parcel.Size = new Size(61, 19);
            parcel.TabIndex = 2;
            parcel.Text = "Paczka";
            parcel.UseVisualStyleBackColor = true;
            // 
            // letter
            // 
            letter.AutoSize = true;
            letter.Location = new Point(18, 56);
            letter.Name = "letter";
            letter.Size = new Size(43, 19);
            letter.TabIndex = 1;
            letter.TabStop = true;
            letter.Text = "List";
            letter.UseVisualStyleBackColor = true;
            // 
            // postcard
            // 
            postcard.AutoSize = true;
            postcard.Checked = true;
            postcard.Location = new Point(18, 31);
            postcard.Name = "postcard";
            postcard.Size = new Size(82, 19);
            postcard.TabIndex = 0;
            postcard.TabStop = true;
            postcard.Text = "Pocztówka";
            postcard.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(city);
            groupBox2.Controls.Add(postcode);
            groupBox2.Controls.Add(street);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(319, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(263, 210);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dane adresowe";
            // 
            // city
            // 
            city.Location = new Point(20, 159);
            city.Name = "city";
            city.Size = new Size(216, 23);
            city.TabIndex = 5;
            // 
            // postcode
            // 
            postcode.Location = new Point(20, 103);
            postcode.Name = "postcode";
            postcode.Size = new Size(100, 23);
            postcode.TabIndex = 4;
            // 
            // street
            // 
            street.Location = new Point(20, 49);
            street.Name = "street";
            street.Size = new Size(216, 23);
            street.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 141);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Miasto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 85);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Kod pocztowy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 31);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Ulica z numerem";
            // 
            // checkPriceBtn
            // 
            checkPriceBtn.Location = new Point(34, 158);
            checkPriceBtn.Name = "checkPriceBtn";
            checkPriceBtn.Size = new Size(200, 23);
            checkPriceBtn.TabIndex = 2;
            checkPriceBtn.Text = "Sprawdź Cenę";
            checkPriceBtn.UseVisualStyleBackColor = true;
            checkPriceBtn.Click += checkPriceBtn_Click;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            price.Location = new Point(152, 203);
            price.Name = "price";
            price.Size = new Size(73, 30);
            price.TabIndex = 4;
            price.Text = "Cena: ";
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(34, 287);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(548, 23);
            submitBtn.TabIndex = 5;
            submitBtn.Text = "Zatwierdź";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.pocztowka;
            pictureBox.Location = new Point(34, 203);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(100, 50);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox);
            Controls.Add(submitBtn);
            Controls.Add(price);
            Controls.Add(checkPriceBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Nadaj Przesyłkę";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton parcel;
        private RadioButton letter;
        private RadioButton postcard;
        private GroupBox groupBox2;
        private TextBox city;
        private TextBox postcode;
        private TextBox street;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button checkPriceBtn;
        private Label price;
        private Button submitBtn;
        private PictureBox pictureBox;
    }
}
