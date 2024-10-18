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
            position = new ComboBox();
            surname = new TextBox();
            name = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            generatePasswordBtn = new Button();
            specialCharacters = new CheckBox();
            digits = new CheckBox();
            capitalLetters = new CheckBox();
            passwordLength = new TextBox();
            label4 = new Label();
            submitBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(position);
            groupBox1.Controls.Add(surname);
            groupBox1.Controls.Add(name);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(34, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 214);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane pracownika";
            // 
            // position
            // 
            position.FormattingEnabled = true;
            position.Items.AddRange(new object[] { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" });
            position.Location = new Point(117, 107);
            position.Name = "position";
            position.Size = new Size(138, 23);
            position.TabIndex = 5;
            // 
            // surname
            // 
            surname.Location = new Point(117, 70);
            surname.Name = "surname";
            surname.Size = new Size(138, 23);
            surname.TabIndex = 4;
            // 
            // name
            // 
            name.Location = new Point(117, 32);
            name.Name = "name";
            name.Size = new Size(138, 23);
            name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 110);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Stanowisko";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 73);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 35);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(generatePasswordBtn);
            groupBox2.Controls.Add(specialCharacters);
            groupBox2.Controls.Add(digits);
            groupBox2.Controls.Add(capitalLetters);
            groupBox2.Controls.Add(passwordLength);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(371, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(288, 214);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Generowanie hasła";
            // 
            // generatePasswordBtn
            // 
            generatePasswordBtn.BackColor = Color.SteelBlue;
            generatePasswordBtn.ForeColor = Color.White;
            generatePasswordBtn.Location = new Point(91, 175);
            generatePasswordBtn.Name = "generatePasswordBtn";
            generatePasswordBtn.Size = new Size(113, 23);
            generatePasswordBtn.TabIndex = 5;
            generatePasswordBtn.Text = "Generuj hasło";
            generatePasswordBtn.UseVisualStyleBackColor = false;
            generatePasswordBtn.Click += generatePasswordBtn_Click;
            // 
            // specialCharacters
            // 
            specialCharacters.AutoSize = true;
            specialCharacters.Location = new Point(25, 140);
            specialCharacters.Name = "specialCharacters";
            specialCharacters.Size = new Size(107, 19);
            specialCharacters.TabIndex = 4;
            specialCharacters.Text = "Znaki specjalne";
            specialCharacters.UseVisualStyleBackColor = true;
            // 
            // digits
            // 
            digits.AutoSize = true;
            digits.Location = new Point(25, 106);
            digits.Name = "digits";
            digits.Size = new Size(54, 19);
            digits.TabIndex = 3;
            digits.Text = "Cyfry";
            digits.UseVisualStyleBackColor = true;
            // 
            // capitalLetters
            // 
            capitalLetters.AutoSize = true;
            capitalLetters.Checked = true;
            capitalLetters.CheckState = CheckState.Checked;
            capitalLetters.Location = new Point(25, 72);
            capitalLetters.Name = "capitalLetters";
            capitalLetters.Size = new Size(126, 19);
            capitalLetters.TabIndex = 2;
            capitalLetters.Text = "Małe i wielkie litery";
            capitalLetters.UseVisualStyleBackColor = true;
            // 
            // passwordLength
            // 
            passwordLength.Location = new Point(113, 32);
            passwordLength.Name = "passwordLength";
            passwordLength.Size = new Size(138, 23);
            passwordLength.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 35);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 0;
            label4.Text = "Ile znaków?";
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.SteelBlue;
            submitBtn.ForeColor = Color.White;
            submitBtn.Location = new Point(247, 261);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(192, 23);
            submitBtn.TabIndex = 2;
            submitBtn.Text = "Zatwierdź";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(submitBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Dodaj pracownika";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private ComboBox position;
        private TextBox surname;
        private TextBox name;
        private CheckBox capitalLetters;
        private TextBox passwordLength;
        private CheckBox specialCharacters;
        private CheckBox digits;
        private Button generatePasswordBtn;
        private Button submitBtn;
    }
}
