using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
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
            numberinput = new TextBox();
            sumofdigits = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // numberinput
            // 
            numberinput.Location = new Point(264, 122);
            numberinput.Name = "numberinput";
            numberinput.Size = new Size(257, 27);
            numberinput.TabIndex = 0;
            numberinput.TextChanged += textBox1_TextChanged;
            numberinput.KeyPress += txt_sadece_sayi_KeyPress;
            // 
            // sumofdigits
            // 
            sumofdigits.Location = new Point(264, 203);
            sumofdigits.Name = "sumofdigits";
            sumofdigits.Size = new Size(257, 27);
            sumofdigits.TabIndex = 1;
            sumofdigits.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveBorder;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(264, 103);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(96, 20);
            textBox1.TabIndex = 2;
            textBox1.Text = " input number";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveBorder;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(264, 183);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(96, 20);
            textBox2.TabIndex = 3;
            textBox2.Text = " sum of digits";
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numberinput);
            Controls.Add(textBox1);
            Controls.Add(sumofdigits);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox numberinput;
        private TextBox sumofdigits;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}