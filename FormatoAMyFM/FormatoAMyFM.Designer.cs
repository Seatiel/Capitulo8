namespace FormatoAMyFM
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
            this.FormatoHoralabel3 = new System.Windows.Forms.Label();
            this.FormatotextBox = new System.Windows.Forms.TextBox();
            this.HoratextBox = new System.Windows.Forms.TextBox();
            this.DigiteHoralabel = new System.Windows.Forms.Label();
            this.Formatobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormatoHoralabel3
            // 
            this.FormatoHoralabel3.AutoSize = true;
            this.FormatoHoralabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormatoHoralabel3.Location = new System.Drawing.Point(55, 86);
            this.FormatoHoralabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormatoHoralabel3.Name = "FormatoHoralabel3";
            this.FormatoHoralabel3.Size = new System.Drawing.Size(76, 20);
            this.FormatoHoralabel3.TabIndex = 19;
            this.FormatoHoralabel3.Text = "Formato:";
            // 
            // FormatotextBox
            // 
            this.FormatotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormatotextBox.Location = new System.Drawing.Point(139, 88);
            this.FormatotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FormatotextBox.Name = "FormatotextBox";
            this.FormatotextBox.Size = new System.Drawing.Size(59, 27);
            this.FormatotextBox.TabIndex = 18;
            // 
            // HoratextBox
            // 
            this.HoratextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoratextBox.Location = new System.Drawing.Point(139, 50);
            this.HoratextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HoratextBox.Name = "HoratextBox";
            this.HoratextBox.Size = new System.Drawing.Size(132, 27);
            this.HoratextBox.TabIndex = 17;
            // 
            // DigiteHoralabel
            // 
            this.DigiteHoralabel.AutoSize = true;
            this.DigiteHoralabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DigiteHoralabel.Location = new System.Drawing.Point(80, 53);
            this.DigiteHoralabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DigiteHoralabel.Name = "DigiteHoralabel";
            this.DigiteHoralabel.Size = new System.Drawing.Size(51, 20);
            this.DigiteHoralabel.TabIndex = 16;
            this.DigiteHoralabel.Text = "Hora:";
            // 
            // Formatobutton
            // 
            this.Formatobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formatobutton.Location = new System.Drawing.Point(320, 88);
            this.Formatobutton.Margin = new System.Windows.Forms.Padding(4);
            this.Formatobutton.Name = "Formatobutton";
            this.Formatobutton.Size = new System.Drawing.Size(118, 28);
            this.Formatobutton.TabIndex = 15;
            this.Formatobutton.Text = "Cambiar";
            this.Formatobutton.UseVisualStyleBackColor = true;
            this.Formatobutton.Click += new System.EventHandler(this.Formatobutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 151);
            this.Controls.Add(this.FormatoHoralabel3);
            this.Controls.Add(this.FormatotextBox);
            this.Controls.Add(this.HoratextBox);
            this.Controls.Add(this.DigiteHoralabel);
            this.Controls.Add(this.Formatobutton);
            this.Name = "Form1";
            this.Text = "Formato AM/FM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormatoHoralabel3;
        private System.Windows.Forms.TextBox FormatotextBox;
        private System.Windows.Forms.TextBox HoratextBox;
        private System.Windows.Forms.Label DigiteHoralabel;
        private System.Windows.Forms.Button Formatobutton;
    }
}

