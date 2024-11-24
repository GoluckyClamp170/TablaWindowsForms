namespace Tabla
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
            panel1 = new Panel();
            richTextBoxresultados = new RichTextBox();
            textBoxnum = new TextBox();
            buttonver = new Button();
            labelpregunta = new Label();
            labeltitulo = new Label();
            labelnombre = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(richTextBoxresultados);
            panel1.Controls.Add(textBoxnum);
            panel1.Controls.Add(buttonver);
            panel1.Controls.Add(labelpregunta);
            panel1.Controls.Add(labeltitulo);
            panel1.Controls.Add(labelnombre);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 450);
            panel1.TabIndex = 0;
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxresultados.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxresultados.Location = new Point(344, 155);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(295, 225);
            richTextBoxresultados.TabIndex = 5;
            richTextBoxresultados.Text = "";
            // 
            // textBoxnum
            // 
            textBoxnum.BorderStyle = BorderStyle.FixedSingle;
            textBoxnum.Location = new Point(87, 215);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(140, 23);
            textBoxnum.TabIndex = 4;
            // 
            // buttonver
            // 
            buttonver.BackColor = Color.FromArgb(224, 224, 224);
            buttonver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonver.Location = new Point(87, 258);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(140, 64);
            buttonver.TabIndex = 3;
            buttonver.Text = "Mostrar Tabla";
            buttonver.UseVisualStyleBackColor = false;
            buttonver.Click += buttonver_Click;
            // 
            // labelpregunta
            // 
            labelpregunta.AutoSize = true;
            labelpregunta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelpregunta.Location = new Point(70, 172);
            labelpregunta.Name = "labelpregunta";
            labelpregunta.Size = new Size(166, 20);
            labelpregunta.TabIndex = 2;
            labelpregunta.Text = "¿Cual tabla quieres ver?";
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labeltitulo.Location = new Point(288, 76);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(140, 20);
            labeltitulo.TabIndex = 1;
            labeltitulo.Text = "Tabla de multiplicar";
            // 
            // labelnombre
            // 
            labelnombre.AutoSize = true;
            labelnombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelnombre.Location = new Point(246, 44);
            labelnombre.Name = "labelnombre";
            labelnombre.Size = new Size(218, 20);
            labelnombre.TabIndex = 0;
            labelnombre.Text = "Luis Donaldo Camarillo Medina";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(87, 344);
            button2.Name = "button2";
            button2.Size = new Size(140, 64);
            button2.TabIndex = 6;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonver;
        private Label labelpregunta;
        private Label labeltitulo;
        private Label labelnombre;
        private TextBox textBoxnum;
        private RichTextBox richTextBoxresultados;
        private Button button2;
    }
}
