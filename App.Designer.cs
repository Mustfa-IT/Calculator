namespace TempForm2
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.input_txtBox = new System.Windows.Forms.TextBox();
            this.backspace_btn = new System.Windows.Forms.Button();
            this.div_btn = new System.Windows.Forms.Button();
            this.mul_btn = new System.Windows.Forms.Button();
            this.mins_btn = new System.Windows.Forms.Button();
            this.plus_btn = new System.Windows.Forms.Button();
            this.equal_btn = new System.Windows.Forms.Button();
            this.nine_btn = new System.Windows.Forms.Button();
            this.eight_btn = new System.Windows.Forms.Button();
            this.seven_btn = new System.Windows.Forms.Button();
            this.six_btn = new System.Windows.Forms.Button();
            this.five_btn = new System.Windows.Forms.Button();
            this.four_btn = new System.Windows.Forms.Button();
            this.three_btn = new System.Windows.Forms.Button();
            this.two_btn = new System.Windows.Forms.Button();
            this.one_btn = new System.Windows.Forms.Button();
            this.zero_btn = new System.Windows.Forms.Button();
            this.dot_btn = new System.Windows.Forms.Button();
            this.AC_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_txtBox
            // 
            this.input_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_txtBox.Location = new System.Drawing.Point(15, 12);
            this.input_txtBox.Name = "input_txtBox";
            this.input_txtBox.Size = new System.Drawing.Size(346, 38);
            this.input_txtBox.TabIndex = 0;
            this.input_txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_txtBox_KeyDown);
            // 
            // backspace_btn
            // 
            this.backspace_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.backspace_btn.Image = ((System.Drawing.Image)(resources.GetObject("backspace_btn.Image")));
            this.backspace_btn.Location = new System.Drawing.Point(279, 59);
            this.backspace_btn.Name = "backspace_btn";
            this.backspace_btn.Size = new System.Drawing.Size(82, 60);
            this.backspace_btn.TabIndex = 1;
            this.backspace_btn.UseVisualStyleBackColor = false;
            this.backspace_btn.Click += new System.EventHandler(this.backspace_btn_Click);
            // 
            // div_btn
            // 
            this.div_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.div_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div_btn.ForeColor = System.Drawing.Color.Transparent;
            this.div_btn.Location = new System.Drawing.Point(279, 125);
            this.div_btn.Name = "div_btn";
            this.div_btn.Size = new System.Drawing.Size(82, 60);
            this.div_btn.TabIndex = 1;
            this.div_btn.Text = "÷";
            this.div_btn.UseVisualStyleBackColor = false;
            this.div_btn.Click += new System.EventHandler(this.div_btn_Click);
            // 
            // mul_btn
            // 
            this.mul_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.mul_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul_btn.ForeColor = System.Drawing.Color.Transparent;
            this.mul_btn.Location = new System.Drawing.Point(279, 191);
            this.mul_btn.Name = "mul_btn";
            this.mul_btn.Padding = new System.Windows.Forms.Padding(2, 0, 0, 5);
            this.mul_btn.Size = new System.Drawing.Size(82, 60);
            this.mul_btn.TabIndex = 1;
            this.mul_btn.Text = "x";
            this.mul_btn.UseVisualStyleBackColor = false;
            this.mul_btn.Click += new System.EventHandler(this.mul_btn_Click);
            // 
            // mins_btn
            // 
            this.mins_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.mins_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mins_btn.ForeColor = System.Drawing.Color.Transparent;
            this.mins_btn.Location = new System.Drawing.Point(279, 257);
            this.mins_btn.Name = "mins_btn";
            this.mins_btn.Size = new System.Drawing.Size(82, 60);
            this.mins_btn.TabIndex = 1;
            this.mins_btn.Text = "-";
            this.mins_btn.UseVisualStyleBackColor = false;
            this.mins_btn.Click += new System.EventHandler(this.mins_btn_Click);
            // 
            // plus_btn
            // 
            this.plus_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.plus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_btn.ForeColor = System.Drawing.Color.Transparent;
            this.plus_btn.Location = new System.Drawing.Point(279, 323);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(82, 60);
            this.plus_btn.TabIndex = 1;
            this.plus_btn.Text = "+";
            this.plus_btn.UseVisualStyleBackColor = false;
            this.plus_btn.Click += new System.EventHandler(this.plus_btn_Click);
            // 
            // equal_btn
            // 
            this.equal_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.equal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal_btn.ForeColor = System.Drawing.Color.Transparent;
            this.equal_btn.Location = new System.Drawing.Point(279, 389);
            this.equal_btn.Name = "equal_btn";
            this.equal_btn.Size = new System.Drawing.Size(82, 60);
            this.equal_btn.TabIndex = 1;
            this.equal_btn.Text = "=";
            this.equal_btn.UseVisualStyleBackColor = false;
            this.equal_btn.Click += new System.EventHandler(this.equal_btn_Click);
            // 
            // nine_btn
            // 
            this.nine_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.nine_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine_btn.ForeColor = System.Drawing.Color.Transparent;
            this.nine_btn.Location = new System.Drawing.Point(191, 191);
            this.nine_btn.Name = "nine_btn";
            this.nine_btn.Size = new System.Drawing.Size(82, 60);
            this.nine_btn.TabIndex = 1;
            this.nine_btn.Text = "9";
            this.nine_btn.UseVisualStyleBackColor = false;
            this.nine_btn.Click += new System.EventHandler(this.nine_btn_Click);
            // 
            // eight_btn
            // 
            this.eight_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.eight_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight_btn.ForeColor = System.Drawing.Color.Transparent;
            this.eight_btn.Location = new System.Drawing.Point(103, 191);
            this.eight_btn.Name = "eight_btn";
            this.eight_btn.Size = new System.Drawing.Size(82, 60);
            this.eight_btn.TabIndex = 1;
            this.eight_btn.Text = "8";
            this.eight_btn.UseVisualStyleBackColor = false;
            this.eight_btn.Click += new System.EventHandler(this.eight_btn_Click);
            // 
            // seven_btn
            // 
            this.seven_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.seven_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven_btn.ForeColor = System.Drawing.Color.Transparent;
            this.seven_btn.Location = new System.Drawing.Point(15, 191);
            this.seven_btn.Name = "seven_btn";
            this.seven_btn.Size = new System.Drawing.Size(82, 60);
            this.seven_btn.TabIndex = 1;
            this.seven_btn.Text = "7";
            this.seven_btn.UseVisualStyleBackColor = false;
            this.seven_btn.Click += new System.EventHandler(this.seven_btn_Click);
            // 
            // six_btn
            // 
            this.six_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.six_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six_btn.ForeColor = System.Drawing.Color.Transparent;
            this.six_btn.Location = new System.Drawing.Point(191, 257);
            this.six_btn.Name = "six_btn";
            this.six_btn.Size = new System.Drawing.Size(82, 60);
            this.six_btn.TabIndex = 1;
            this.six_btn.Text = "6";
            this.six_btn.UseVisualStyleBackColor = false;
            this.six_btn.Click += new System.EventHandler(this.six_btn_Click);
            // 
            // five_btn
            // 
            this.five_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.five_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five_btn.ForeColor = System.Drawing.Color.Transparent;
            this.five_btn.Location = new System.Drawing.Point(103, 257);
            this.five_btn.Name = "five_btn";
            this.five_btn.Size = new System.Drawing.Size(82, 60);
            this.five_btn.TabIndex = 1;
            this.five_btn.Text = "5";
            this.five_btn.UseVisualStyleBackColor = false;
            this.five_btn.Click += new System.EventHandler(this.five_btn_Click);
            // 
            // four_btn
            // 
            this.four_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.four_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four_btn.ForeColor = System.Drawing.Color.Transparent;
            this.four_btn.Location = new System.Drawing.Point(15, 257);
            this.four_btn.Name = "four_btn";
            this.four_btn.Size = new System.Drawing.Size(82, 60);
            this.four_btn.TabIndex = 1;
            this.four_btn.Text = "4";
            this.four_btn.UseVisualStyleBackColor = false;
            this.four_btn.Click += new System.EventHandler(this.four_btn_Click);
            // 
            // three_btn
            // 
            this.three_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.three_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three_btn.ForeColor = System.Drawing.Color.Transparent;
            this.three_btn.Location = new System.Drawing.Point(191, 323);
            this.three_btn.Name = "three_btn";
            this.three_btn.Size = new System.Drawing.Size(82, 60);
            this.three_btn.TabIndex = 1;
            this.three_btn.Text = "3";
            this.three_btn.UseVisualStyleBackColor = false;
            this.three_btn.Click += new System.EventHandler(this.three_btn_Click);
            // 
            // two_btn
            // 
            this.two_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.two_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two_btn.ForeColor = System.Drawing.Color.Transparent;
            this.two_btn.Location = new System.Drawing.Point(103, 323);
            this.two_btn.Name = "two_btn";
            this.two_btn.Size = new System.Drawing.Size(82, 60);
            this.two_btn.TabIndex = 1;
            this.two_btn.Text = "2";
            this.two_btn.UseVisualStyleBackColor = false;
            this.two_btn.Click += new System.EventHandler(this.two_btn_Click);
            // 
            // one_btn
            // 
            this.one_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.one_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one_btn.ForeColor = System.Drawing.Color.Transparent;
            this.one_btn.Location = new System.Drawing.Point(15, 323);
            this.one_btn.Name = "one_btn";
            this.one_btn.Size = new System.Drawing.Size(82, 60);
            this.one_btn.TabIndex = 1;
            this.one_btn.Text = "1";
            this.one_btn.UseVisualStyleBackColor = false;
            this.one_btn.Click += new System.EventHandler(this.one_btn_Click);
            // 
            // zero_btn
            // 
            this.zero_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.zero_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero_btn.ForeColor = System.Drawing.Color.Transparent;
            this.zero_btn.Location = new System.Drawing.Point(103, 389);
            this.zero_btn.Name = "zero_btn";
            this.zero_btn.Size = new System.Drawing.Size(82, 60);
            this.zero_btn.TabIndex = 1;
            this.zero_btn.Text = "0";
            this.zero_btn.UseVisualStyleBackColor = false;
            this.zero_btn.Click += new System.EventHandler(this.zero_btn_Click);
            // 
            // dot_btn
            // 
            this.dot_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.dot_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot_btn.ForeColor = System.Drawing.Color.Transparent;
            this.dot_btn.Location = new System.Drawing.Point(191, 389);
            this.dot_btn.Name = "dot_btn";
            this.dot_btn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.dot_btn.Size = new System.Drawing.Size(82, 60);
            this.dot_btn.TabIndex = 1;
            this.dot_btn.Text = ".";
            this.dot_btn.UseVisualStyleBackColor = false;
            this.dot_btn.Click += new System.EventHandler(this.dot_btn_Click);
            // 
            // AC_btn
            // 
            this.AC_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.AC_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AC_btn.ForeColor = System.Drawing.Color.Transparent;
            this.AC_btn.Location = new System.Drawing.Point(15, 389);
            this.AC_btn.Name = "AC_btn";
            this.AC_btn.Size = new System.Drawing.Size(82, 60);
            this.AC_btn.TabIndex = 1;
            this.AC_btn.Text = "AC";
            this.AC_btn.UseVisualStyleBackColor = false;
            this.AC_btn.Click += new System.EventHandler(this.AC_btn_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(365, 461);
            this.Controls.Add(this.equal_btn);
            this.Controls.Add(this.plus_btn);
            this.Controls.Add(this.mins_btn);
            this.Controls.Add(this.AC_btn);
            this.Controls.Add(this.one_btn);
            this.Controls.Add(this.four_btn);
            this.Controls.Add(this.seven_btn);
            this.Controls.Add(this.zero_btn);
            this.Controls.Add(this.two_btn);
            this.Controls.Add(this.five_btn);
            this.Controls.Add(this.eight_btn);
            this.Controls.Add(this.dot_btn);
            this.Controls.Add(this.three_btn);
            this.Controls.Add(this.six_btn);
            this.Controls.Add(this.nine_btn);
            this.Controls.Add(this.mul_btn);
            this.Controls.Add(this.div_btn);
            this.Controls.Add(this.backspace_btn);
            this.Controls.Add(this.input_txtBox);
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_txtBox;
        private System.Windows.Forms.Button backspace_btn;
        private System.Windows.Forms.Button div_btn;
        private System.Windows.Forms.Button mul_btn;
        private System.Windows.Forms.Button mins_btn;
        private System.Windows.Forms.Button plus_btn;
        private System.Windows.Forms.Button equal_btn;
        private System.Windows.Forms.Button nine_btn;
        private System.Windows.Forms.Button eight_btn;
        private System.Windows.Forms.Button seven_btn;
        private System.Windows.Forms.Button six_btn;
        private System.Windows.Forms.Button five_btn;
        private System.Windows.Forms.Button four_btn;
        private System.Windows.Forms.Button three_btn;
        private System.Windows.Forms.Button two_btn;
        private System.Windows.Forms.Button one_btn;
        private System.Windows.Forms.Button zero_btn;
        private System.Windows.Forms.Button dot_btn;
        private System.Windows.Forms.Button AC_btn;
    }
}

