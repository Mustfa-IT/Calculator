namespace TempForm2
{
    partial class Test
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
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // input_textBox
            // 
            this.input_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.input_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_textBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.input_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_textBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.input_textBox.Location = new System.Drawing.Point(0, 444);
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.input_textBox.Size = new System.Drawing.Size(800, 19);
            this.input_textBox.TabIndex = 0;
            this.input_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_textBox_KeyDown);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.listBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOutput.ForeColor = System.Drawing.SystemColors.Menu;
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 20;
            this.listBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.ScrollAlwaysVisible = true;
            this.listBoxOutput.Size = new System.Drawing.Size(800, 444);
            this.listBoxOutput.TabIndex = 1;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.input_textBox);
            this.Name = "Test";
            this.Text = "Console";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_textBox;
        private System.Windows.Forms.ListBox listBoxOutput;
    }
}