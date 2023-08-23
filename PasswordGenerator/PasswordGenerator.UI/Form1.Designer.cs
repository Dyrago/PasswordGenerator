namespace PasswordGenerator.UI
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
            UpperCase = new CheckBox();
            Digits = new CheckBox();
            SpecialChars = new CheckBox();
            Generate = new Button();
            PasswordField = new TextBox();
            PassLenght = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)PassLenght).BeginInit();
            SuspendLayout();
            // 
            // UpperCase
            // 
            UpperCase.AutoSize = true;
            UpperCase.Checked = true;
            UpperCase.CheckState = CheckState.Checked;
            UpperCase.Cursor = Cursors.Hand;
            UpperCase.Location = new Point(139, 66);
            UpperCase.Name = "UpperCase";
            UpperCase.Size = new Size(86, 19);
            UpperCase.TabIndex = 0;
            UpperCase.Text = "Upper Case";
            UpperCase.UseVisualStyleBackColor = true;
            UpperCase.CheckedChanged += UpperCase_CheckedChanged;
            // 
            // Digits
            // 
            Digits.AutoSize = true;
            Digits.Checked = true;
            Digits.CheckState = CheckState.Checked;
            Digits.Cursor = Cursors.Hand;
            Digits.Location = new Point(242, 69);
            Digits.Name = "Digits";
            Digits.Size = new Size(56, 19);
            Digits.TabIndex = 1;
            Digits.Text = "Digits";
            Digits.UseVisualStyleBackColor = true;
            Digits.CheckedChanged += Digits_CheckedChanged;
            // 
            // SpecialChars
            // 
            SpecialChars.AutoSize = true;
            SpecialChars.Checked = true;
            SpecialChars.CheckState = CheckState.Checked;
            SpecialChars.Cursor = Cursors.Hand;
            SpecialChars.Location = new Point(315, 69);
            SpecialChars.Name = "SpecialChars";
            SpecialChars.Size = new Size(122, 19);
            SpecialChars.TabIndex = 2;
            SpecialChars.Text = "Special Characters";
            SpecialChars.UseVisualStyleBackColor = true;
            SpecialChars.CheckedChanged += SpecialChars_CheckedChanged;
            // 
            // Generate
            // 
            Generate.Cursor = Cursors.Hand;
            Generate.Location = new Point(139, 122);
            Generate.Name = "Generate";
            Generate.Size = new Size(200, 23);
            Generate.TabIndex = 3;
            Generate.Text = "Generate Password";
            Generate.UseVisualStyleBackColor = true;
            Generate.Click += Generate_Click;
            // 
            // PasswordField
            // 
            PasswordField.BorderStyle = BorderStyle.None;
            PasswordField.ImeMode = ImeMode.On;
            PasswordField.Location = new Point(24, 32);
            PasswordField.Name = "PasswordField";
            PasswordField.ReadOnly = true;
            PasswordField.Size = new Size(422, 16);
            PasswordField.TabIndex = 4;
            PasswordField.TextAlign = HorizontalAlignment.Center;
            PasswordField.TextChanged += PasswordField_TextChanged;
            // 
            // PassLenght
            // 
            PassLenght.BorderStyle = BorderStyle.None;
            PassLenght.Cursor = Cursors.IBeam;
            PassLenght.Location = new Point(42, 65);
            PassLenght.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            PassLenght.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            PassLenght.Name = "PassLenght";
            PassLenght.Size = new Size(54, 19);
            PassLenght.TabIndex = 5;
            PassLenght.TextAlign = HorizontalAlignment.Center;
            PassLenght.Value = new decimal(new int[] { 8, 0, 0, 0 });
            PassLenght.ValueChanged += PassLenght_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 169);
            Controls.Add(PassLenght);
            Controls.Add(PasswordField);
            Controls.Add(Generate);
            Controls.Add(SpecialChars);
            Controls.Add(Digits);
            Controls.Add(UpperCase);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "PasswordGenerator";
            ((System.ComponentModel.ISupportInitialize)PassLenght).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox UpperCase;
        private CheckBox Digits;
        private CheckBox SpecialChars;
        private Button Generate;
        private TextBox PasswordField;
        private NumericUpDown PassLenght;
    }
}