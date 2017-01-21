namespace OrdenAlfabético
{
    partial class OrdenAlfabético
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
            this.OrdenarCadenabutton = new System.Windows.Forms.Button();
            this.CadenatextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrdenCadenatextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrdenarCadenabutton
            // 
            this.OrdenarCadenabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdenarCadenabutton.Location = new System.Drawing.Point(420, 133);
            this.OrdenarCadenabutton.Margin = new System.Windows.Forms.Padding(4);
            this.OrdenarCadenabutton.Name = "OrdenarCadenabutton";
            this.OrdenarCadenabutton.Size = new System.Drawing.Size(168, 28);
            this.OrdenarCadenabutton.TabIndex = 17;
            this.OrdenarCadenabutton.Text = "Ordenar Cadena";
            this.OrdenarCadenabutton.UseVisualStyleBackColor = true;
            this.OrdenarCadenabutton.Click += new System.EventHandler(this.Ordenarbutton_Click);
            // 
            // CadenatextBox
            // 
            this.CadenatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadenatextBox.Location = new System.Drawing.Point(39, 64);
            this.CadenatextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CadenatextBox.Name = "CadenatextBox";
            this.CadenatextBox.Size = new System.Drawing.Size(164, 27);
            this.CadenatextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cadena:";
            // 
            // OrdenCadenatextBox
            // 
            this.OrdenCadenatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdenCadenatextBox.Location = new System.Drawing.Point(39, 133);
            this.OrdenCadenatextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OrdenCadenatextBox.Name = "OrdenCadenatextBox";
            this.OrdenCadenatextBox.Size = new System.Drawing.Size(360, 27);
            this.OrdenCadenatextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Orden de la cadena:";
            // 
            // OrdenAlfabético
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 216);
            this.Controls.Add(this.OrdenarCadenabutton);
            this.Controls.Add(this.CadenatextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrdenCadenatextBox);
            this.Controls.Add(this.label2);
            this.Name = "OrdenAlfabético";
            this.Text = "Orden Alfabético";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrdenarCadenabutton;
        private System.Windows.Forms.TextBox CadenatextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrdenCadenatextBox;
        private System.Windows.Forms.Label label2;
    }
}

