
namespace CurrencyConverter
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.inputBoxLabel = new System.Windows.Forms.Label();
            this.usdRadioButton = new System.Windows.Forms.RadioButton();
            this.eurRadioButton = new System.Windows.Forms.RadioButton();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputBoxLabel = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.radioButtonLabel = new System.Windows.Forms.Label();
            this.jpyRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(152, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency Converter";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(214, 128);
            this.inputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(218, 23);
            this.inputBox.TabIndex = 1;
            // 
            // inputBoxLabel
            // 
            this.inputBoxLabel.AutoSize = true;
            this.inputBoxLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputBoxLabel.Location = new System.Drawing.Point(215, 112);
            this.inputBoxLabel.Name = "inputBoxLabel";
            this.inputBoxLabel.Size = new System.Drawing.Size(30, 14);
            this.inputBoxLabel.TabIndex = 2;
            this.inputBoxLabel.Text = "IDR";
            // 
            // usdRadioButton
            // 
            this.usdRadioButton.AutoSize = true;
            this.usdRadioButton.Location = new System.Drawing.Point(214, 183);
            this.usdRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usdRadioButton.Name = "usdRadioButton";
            this.usdRadioButton.Size = new System.Drawing.Size(47, 19);
            this.usdRadioButton.TabIndex = 3;
            this.usdRadioButton.TabStop = true;
            this.usdRadioButton.Text = "USD";
            this.usdRadioButton.UseVisualStyleBackColor = true;
            // 
            // eurRadioButton
            // 
            this.eurRadioButton.AutoSize = true;
            this.eurRadioButton.Location = new System.Drawing.Point(386, 183);
            this.eurRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eurRadioButton.Name = "eurRadioButton";
            this.eurRadioButton.Size = new System.Drawing.Size(46, 19);
            this.eurRadioButton.TabIndex = 4;
            this.eurRadioButton.TabStop = true;
            this.eurRadioButton.Text = "EUR";
            this.eurRadioButton.UseVisualStyleBackColor = true;
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.SystemColors.Control;
            this.convertButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertButton.Location = new System.Drawing.Point(280, 226);
            this.convertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(82, 22);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outputBoxLabel
            // 
            this.outputBoxLabel.AutoSize = true;
            this.outputBoxLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.outputBoxLabel.Location = new System.Drawing.Point(215, 265);
            this.outputBoxLabel.Name = "outputBoxLabel";
            this.outputBoxLabel.Size = new System.Drawing.Size(46, 14);
            this.outputBoxLabel.TabIndex = 8;
            this.outputBoxLabel.Text = "Result";
            // 
            // outputBox
            // 
            this.outputBox.Enabled = false;
            this.outputBox.Location = new System.Drawing.Point(215, 281);
            this.outputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(217, 23);
            this.outputBox.TabIndex = 7;
            // 
            // radioButtonLabel
            // 
            this.radioButtonLabel.AutoSize = true;
            this.radioButtonLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.radioButtonLabel.Location = new System.Drawing.Point(214, 166);
            this.radioButtonLabel.Name = "radioButtonLabel";
            this.radioButtonLabel.Size = new System.Drawing.Size(75, 15);
            this.radioButtonLabel.TabIndex = 5;
            this.radioButtonLabel.Text = "Choose One!";
            // 
            // jpyRadioButton
            // 
            this.jpyRadioButton.AutoSize = true;
            this.jpyRadioButton.Location = new System.Drawing.Point(301, 184);
            this.jpyRadioButton.Name = "jpyRadioButton";
            this.jpyRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.jpyRadioButton.Size = new System.Drawing.Size(43, 19);
            this.jpyRadioButton.TabIndex = 9;
            this.jpyRadioButton.TabStop = true;
            this.jpyRadioButton.Text = "JPY";
            this.jpyRadioButton.UseVisualStyleBackColor = true;
            this.jpyRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.jpyRadioButton);
            this.Controls.Add(this.outputBoxLabel);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.radioButtonLabel);
            this.Controls.Add(this.eurRadioButton);
            this.Controls.Add(this.usdRadioButton);
            this.Controls.Add(this.inputBoxLabel);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label inputBoxLabel;
        private System.Windows.Forms.RadioButton usdRadioButton;
        private System.Windows.Forms.RadioButton eurRadioButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label outputBoxLabel;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label radioButtonLabel;
        private System.Windows.Forms.RadioButton jpyRadioButton;
    }
}

