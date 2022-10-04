namespace Tim_Hortons_Cash_Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.sCoffee = new System.Windows.Forms.Label();
            this.SmallCoffeeInput = new System.Windows.Forms.NumericUpDown();
            this.lCoffee = new System.Windows.Forms.Label();
            this.mCoffee = new System.Windows.Forms.Label();
            this.mediumCoffeeInput = new System.Windows.Forms.NumericUpDown();
            this.largeCoffeeOutput = new System.Windows.Forms.NumericUpDown();
            this.recieptOutput = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.TextBox();
            this.taxOutput = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.TextBox();
            this.BlackLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tenderedOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.TextBox();
            this.printReceiptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SmallCoffeeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumCoffeeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeCoffeeOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tim Hortons ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sCoffee
            // 
            this.sCoffee.AutoSize = true;
            this.sCoffee.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sCoffee.Location = new System.Drawing.Point(22, 54);
            this.sCoffee.Name = "sCoffee";
            this.sCoffee.Size = new System.Drawing.Size(140, 27);
            this.sCoffee.TabIndex = 1;
            this.sCoffee.Text = "Small Coffee";
            // 
            // SmallCoffeeInput
            // 
            this.SmallCoffeeInput.Location = new System.Drawing.Point(192, 62);
            this.SmallCoffeeInput.Name = "SmallCoffeeInput";
            this.SmallCoffeeInput.Size = new System.Drawing.Size(120, 22);
            this.SmallCoffeeInput.TabIndex = 2;
            // 
            // lCoffee
            // 
            this.lCoffee.AutoSize = true;
            this.lCoffee.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCoffee.Location = new System.Drawing.Point(22, 114);
            this.lCoffee.Name = "lCoffee";
            this.lCoffee.Size = new System.Drawing.Size(140, 27);
            this.lCoffee.TabIndex = 3;
            this.lCoffee.Text = "Large Coffee";
            // 
            // mCoffee
            // 
            this.mCoffee.AutoSize = true;
            this.mCoffee.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCoffee.Location = new System.Drawing.Point(-7, 85);
            this.mCoffee.Name = "mCoffee";
            this.mCoffee.Size = new System.Drawing.Size(169, 27);
            this.mCoffee.TabIndex = 4;
            this.mCoffee.Text = "Medium Coffee";
            // 
            // mediumCoffeeInput
            // 
            this.mediumCoffeeInput.Location = new System.Drawing.Point(192, 90);
            this.mediumCoffeeInput.Name = "mediumCoffeeInput";
            this.mediumCoffeeInput.Size = new System.Drawing.Size(120, 22);
            this.mediumCoffeeInput.TabIndex = 5;
            // 
            // largeCoffeeOutput
            // 
            this.largeCoffeeOutput.Location = new System.Drawing.Point(192, 118);
            this.largeCoffeeOutput.Name = "largeCoffeeOutput";
            this.largeCoffeeOutput.Size = new System.Drawing.Size(120, 22);
            this.largeCoffeeOutput.TabIndex = 6;
            // 
            // recieptOutput
            // 
            this.recieptOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.recieptOutput.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptOutput.Location = new System.Drawing.Point(447, 62);
            this.recieptOutput.Name = "recieptOutput";
            this.recieptOutput.Size = new System.Drawing.Size(317, 379);
            this.recieptOutput.TabIndex = 7;
            this.recieptOutput.Click += new System.EventHandler(this.label2_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(175, 146);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(160, 37);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(33, 189);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(103, 27);
            this.subtotalLabel.TabIndex = 9;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(75, 216);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(61, 27);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax: ";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.Enabled = false;
            this.subtotalOutput.Location = new System.Drawing.Point(142, 194);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(100, 22);
            this.subtotalOutput.TabIndex = 11;
            // 
            // taxOutput
            // 
            this.taxOutput.Enabled = false;
            this.taxOutput.Location = new System.Drawing.Point(142, 221);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(100, 22);
            this.taxOutput.TabIndex = 12;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(60, 243);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(76, 27);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.Text = "Total: ";
            // 
            // totalOutput
            // 
            this.totalOutput.Enabled = false;
            this.totalOutput.Location = new System.Drawing.Point(142, 249);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 22);
            this.totalOutput.TabIndex = 14;
            // 
            // BlackLabel
            // 
            this.BlackLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BlackLabel.Location = new System.Drawing.Point(-5, 270);
            this.BlackLabel.Name = "BlackLabel";
            this.BlackLabel.Size = new System.Drawing.Size(269, 16);
            this.BlackLabel.TabIndex = 15;
            this.BlackLabel.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tendered: ";
            // 
            // tenderedOutput
            // 
            this.tenderedOutput.Location = new System.Drawing.Point(142, 291);
            this.tenderedOutput.Name = "tenderedOutput";
            this.tenderedOutput.Size = new System.Drawing.Size(100, 22);
            this.tenderedOutput.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calculate Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(33, 358);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(100, 27);
            this.changeLabel.TabIndex = 19;
            this.changeLabel.Text = "Change: ";
            // 
            // changeOutput
            // 
            this.changeOutput.Enabled = false;
            this.changeOutput.Location = new System.Drawing.Point(142, 361);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(100, 22);
            this.changeOutput.TabIndex = 20;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptButton.Location = new System.Drawing.Point(12, 401);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(230, 40);
            this.printReceiptButton.TabIndex = 21;
            this.printReceiptButton.Text = "Print Receipt ";
            this.printReceiptButton.UseVisualStyleBackColor = true;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tenderedOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BlackLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.recieptOutput);
            this.Controls.Add(this.largeCoffeeOutput);
            this.Controls.Add(this.mediumCoffeeInput);
            this.Controls.Add(this.mCoffee);
            this.Controls.Add(this.lCoffee);
            this.Controls.Add(this.SmallCoffeeInput);
            this.Controls.Add(this.sCoffee);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SmallCoffeeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumCoffeeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeCoffeeOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sCoffee;
        private System.Windows.Forms.NumericUpDown SmallCoffeeInput;
        private System.Windows.Forms.Label lCoffee;
        private System.Windows.Forms.Label mCoffee;
        private System.Windows.Forms.NumericUpDown mediumCoffeeInput;
        private System.Windows.Forms.NumericUpDown largeCoffeeOutput;
        private System.Windows.Forms.Label recieptOutput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.TextBox subtotalOutput;
        private System.Windows.Forms.TextBox taxOutput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalOutput;
        private System.Windows.Forms.Label BlackLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tenderedOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.TextBox changeOutput;
        private System.Windows.Forms.Button printReceiptButton;
    }
}

