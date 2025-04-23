using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Input = new System.Windows.Forms.Label();
            this.Valuelabel = new System.Windows.Forms.Label();
            this.Encodebutton = new System.Windows.Forms.Button();
            this.Sortb = new System.Windows.Forms.Button();
            this.Textanswer = new System.Windows.Forms.Label();
            this.ASCII = new System.Windows.Forms.ListBox();
            this.Textinput = new System.Windows.Forms.TextBox();
            this.N = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Inputcode = new System.Windows.Forms.Button();
            this.Outputcode = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Location = new System.Drawing.Point(12, 20);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(121, 16);
            this.Input.TabIndex = 1;
            this.Input.Text = "Input data (A-Z <40)";
            // 
            // Valuelabel
            // 
            this.Valuelabel.AutoSize = true;
            this.Valuelabel.Location = new System.Drawing.Point(156, 20);
            this.Valuelabel.Name = "Valuelabel";
            this.Valuelabel.Size = new System.Drawing.Size(90, 16);
            this.Valuelabel.TabIndex = 2;
            this.Valuelabel.Text = "Encode value";
            // 
            // Encodebutton
            // 
            this.Encodebutton.Location = new System.Drawing.Point(24, 114);
            this.Encodebutton.Name = "Encodebutton";
            this.Encodebutton.Size = new System.Drawing.Size(100, 42);
            this.Encodebutton.TabIndex = 4;
            this.Encodebutton.Text = "Encode";
            this.Encodebutton.UseVisualStyleBackColor = true;
            this.Encodebutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sortb
            // 
            this.Sortb.Location = new System.Drawing.Point(159, 114);
            this.Sortb.Name = "Sortb";
            this.Sortb.Size = new System.Drawing.Size(95, 42);
            this.Sortb.TabIndex = 5;
            this.Sortb.Text = "Sort";
            this.Sortb.UseVisualStyleBackColor = true;
            this.Sortb.Click += new System.EventHandler(this.Sortb_Click_1);
            // 
            // Textanswer
            // 
            this.Textanswer.AutoSize = true;
            this.Textanswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Textanswer.Location = new System.Drawing.Point(362, 49);
            this.Textanswer.Name = "Textanswer";
            this.Textanswer.Size = new System.Drawing.Size(79, 18);
            this.Textanswer.TabIndex = 6;
            this.Textanswer.Text = "Answer = \" \"";
            // 
            // ASCII
            // 
            this.ASCII.FormattingEnabled = true;
            this.ASCII.ItemHeight = 16;
            this.ASCII.Location = new System.Drawing.Point(362, 114);
            this.ASCII.Name = "ASCII";
            this.ASCII.Size = new System.Drawing.Size(120, 100);
            this.ASCII.TabIndex = 7;
            // 
            // Textinput
            // 
            this.Textinput.Location = new System.Drawing.Point(15, 49);
            this.Textinput.MaxLength = 40;
            this.Textinput.Name = "Textinput";
            this.Textinput.Size = new System.Drawing.Size(118, 22);
            this.Textinput.TabIndex = 8;
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(159, 49);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(120, 22);
            this.N.TabIndex = 10;
            this.N.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Inputcode
            // 
            this.Inputcode.Location = new System.Drawing.Point(159, 162);
            this.Inputcode.Name = "Inputcode";
            this.Inputcode.Size = new System.Drawing.Size(95, 39);
            this.Inputcode.TabIndex = 11;
            this.Inputcode.Text = "Input Code";
            this.Inputcode.UseVisualStyleBackColor = true;
            this.Inputcode.Click += new System.EventHandler(this.Inputcode_Click_1);
            // 
            // Outputcode
            // 
            this.Outputcode.Location = new System.Drawing.Point(159, 207);
            this.Outputcode.Name = "Outputcode";
            this.Outputcode.Size = new System.Drawing.Size(95, 40);
            this.Outputcode.TabIndex = 12;
            this.Outputcode.Text = "Output Code";
            this.Outputcode.UseVisualStyleBackColor = true;
            this.Outputcode.Click += new System.EventHandler(this.Outputcode_Click_1);
            // 
            // Sort
            // 
            this.Sort.AutoSize = true;
            this.Sort.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Sort.Location = new System.Drawing.Point(362, 81);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(59, 18);
            this.Sort.TabIndex = 13;
            this.Sort.Text = "Sort = \" \"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(519, 252);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Outputcode);
            this.Controls.Add(this.Inputcode);
            this.Controls.Add(this.N);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Textinput);
            this.Controls.Add(this.ASCII);
            this.Controls.Add(this.Textanswer);
            this.Controls.Add(this.Sortb);
            this.Controls.Add(this.Encodebutton);
            this.Controls.Add(this.Valuelabel);
            this.Controls.Add(this.Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Comp 1551";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.Label Valuelabel;
        private System.Windows.Forms.Button Encodebutton;
        private System.Windows.Forms.Button Sortb;
        private System.Windows.Forms.ListBox ASCII;
        private System.Windows.Forms.TextBox Textinput;
        public System.Windows.Forms.Label Textanswer;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Inputcode;
        private System.Windows.Forms.Button Outputcode;
        public System.Windows.Forms.Label Sort;
    }
}

