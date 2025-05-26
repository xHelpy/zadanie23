namespace generacjahasla
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userSurname = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.generatePassword = new System.Windows.Forms.Button();
            this.characterAmount = new System.Windows.Forms.TextBox();
            this.specialCharacters = new System.Windows.Forms.CheckBox();
            this.numbers = new System.Windows.Forms.CheckBox();
            this.letters = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.userSurname);
            this.groupBox1.Controls.Add(this.userName);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane Pracownika";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tester",
            "Starszy Programista",
            "Młodszy Programista",
            "Kierownik"});
            this.comboBox1.Location = new System.Drawing.Point(143, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(23, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stanowisko";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // userSurname
            // 
            this.userSurname.AutoSize = true;
            this.userSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userSurname.Location = new System.Drawing.Point(23, 79);
            this.userSurname.Name = "userSurname";
            this.userSurname.Size = new System.Drawing.Size(76, 20);
            this.userSurname.TabIndex = 3;
            this.userSurname.Text = "Nazwisko";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userName.Location = new System.Drawing.Point(23, 42);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(39, 20);
            this.userName.TabIndex = 2;
            this.userName.Text = "Imię";
            this.userName.Click += new System.EventHandler(this.userName_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zatwierdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.generatePassword);
            this.groupBox2.Controls.Add(this.characterAmount);
            this.groupBox2.Controls.Add(this.specialCharacters);
            this.groupBox2.Controls.Add(this.numbers);
            this.groupBox2.Controls.Add(this.letters);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(380, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 180);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generacja hasła";
            // 
            // generatePassword
            // 
            this.generatePassword.Location = new System.Drawing.Point(99, 151);
            this.generatePassword.Name = "generatePassword";
            this.generatePassword.Size = new System.Drawing.Size(103, 23);
            this.generatePassword.TabIndex = 11;
            this.generatePassword.Text = "Generuj Hasło";
            this.generatePassword.UseVisualStyleBackColor = true;
            this.generatePassword.Click += new System.EventHandler(this.generatePassword_Click);
            // 
            // characterAmount
            // 
            this.characterAmount.Location = new System.Drawing.Point(119, 50);
            this.characterAmount.Name = "characterAmount";
            this.characterAmount.Size = new System.Drawing.Size(100, 20);
            this.characterAmount.TabIndex = 10;
            this.characterAmount.TextChanged += new System.EventHandler(this.characterAmount_TextChanged);
            // 
            // specialCharacters
            // 
            this.specialCharacters.AutoSize = true;
            this.specialCharacters.Location = new System.Drawing.Point(24, 127);
            this.specialCharacters.Name = "specialCharacters";
            this.specialCharacters.Size = new System.Drawing.Size(103, 17);
            this.specialCharacters.TabIndex = 9;
            this.specialCharacters.Text = "Znaki Specjalne";
            this.specialCharacters.UseVisualStyleBackColor = true;
            this.specialCharacters.CheckedChanged += new System.EventHandler(this.specialCharacters_CheckedChanged);
            // 
            // numbers
            // 
            this.numbers.AutoSize = true;
            this.numbers.Location = new System.Drawing.Point(24, 104);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(49, 17);
            this.numbers.TabIndex = 8;
            this.numbers.Text = "Cyfry";
            this.numbers.UseVisualStyleBackColor = true;
            this.numbers.CheckedChanged += new System.EventHandler(this.numbers_CheckedChanged);
            // 
            // letters
            // 
            this.letters.AutoSize = true;
            this.letters.Location = new System.Drawing.Point(24, 80);
            this.letters.Name = "letters";
            this.letters.Size = new System.Drawing.Size(115, 17);
            this.letters.TabIndex = 7;
            this.letters.Text = "Małe i wielkie litery";
            this.letters.UseVisualStyleBackColor = true;
            this.letters.CheckedChanged += new System.EventHandler(this.letters_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(20, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ile znaków?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label userSurname;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox specialCharacters;
        private System.Windows.Forms.CheckBox numbers;
        private System.Windows.Forms.CheckBox letters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox characterAmount;
        private System.Windows.Forms.Button generatePassword;
    }
}

