namespace Capitulo8
{
    partial class Cadena
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.OraciontextBox = new System.Windows.Forms.TextBox();
            this.DigiteCadenaOracionlabel1 = new System.Windows.Forms.Label();
            this.Oracionbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(35, 112);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(237, 84);
            this.listBox.TabIndex = 13;
            // 
            // OraciontextBox
            // 
            this.OraciontextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OraciontextBox.Location = new System.Drawing.Point(35, 55);
            this.OraciontextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OraciontextBox.Name = "OraciontextBox";
            this.OraciontextBox.Size = new System.Drawing.Size(345, 27);
            this.OraciontextBox.TabIndex = 12;
            // 
            // DigiteCadenaOracionlabel1
            // 
            this.DigiteCadenaOracionlabel1.AutoSize = true;
            this.DigiteCadenaOracionlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DigiteCadenaOracionlabel1.Location = new System.Drawing.Point(31, 31);
            this.DigiteCadenaOracionlabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DigiteCadenaOracionlabel1.Name = "DigiteCadenaOracionlabel1";
            this.DigiteCadenaOracionlabel1.Size = new System.Drawing.Size(153, 20);
            this.DigiteCadenaOracionlabel1.TabIndex = 11;
            this.DigiteCadenaOracionlabel1.Text = "Escriba la Oracion:";
            // 
            // Oracionbutton
            // 
            this.Oracionbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oracionbutton.Location = new System.Drawing.Point(280, 112);
            this.Oracionbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Oracionbutton.Name = "Oracionbutton";
            this.Oracionbutton.Size = new System.Drawing.Size(123, 28);
            this.Oracionbutton.TabIndex = 10;
            this.Oracionbutton.Text = "Oracion";
            this.Oracionbutton.UseVisualStyleBackColor = true;
            this.Oracionbutton.Click += new System.EventHandler(this.Oracionbutton_Click);
            // 
            // Cadena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 235);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.OraciontextBox);
            this.Controls.Add(this.DigiteCadenaOracionlabel1);
            this.Controls.Add(this.Oracionbutton);
            this.Name = "Cadena";
            this.Text = "Cadena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox OraciontextBox;
        private System.Windows.Forms.Label DigiteCadenaOracionlabel1;
        private System.Windows.Forms.Button Oracionbutton;
    }
}

