namespace Simple_Calculator
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.Silver;
            this.zero.Location = new System.Drawing.Point(29, 358);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(155, 61);
            this.zero.TabIndex = 0;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.ButtonClick);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.Color.Silver;
            this.dot.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dot.Location = new System.Drawing.Point(190, 359);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(74, 61);
            this.dot.TabIndex = 1;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.ButtonClick);
            // 
            // equal
            // 
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.equal.Location = new System.Drawing.Point(275, 291);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(64, 129);
            this.equal.TabIndex = 2;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.EqualsClick);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.Silver;
            this.one.Location = new System.Drawing.Point(29, 291);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(74, 61);
            this.one.TabIndex = 3;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.ButtonClick);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.Silver;
            this.two.Location = new System.Drawing.Point(109, 291);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(74, 61);
            this.two.TabIndex = 4;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.ButtonClick);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.Silver;
            this.three.Location = new System.Drawing.Point(190, 292);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(74, 61);
            this.three.TabIndex = 5;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.ButtonClick);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.Silver;
            this.four.Location = new System.Drawing.Point(29, 224);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(74, 61);
            this.four.TabIndex = 9;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.ButtonClick);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.Silver;
            this.five.Location = new System.Drawing.Point(109, 224);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(74, 61);
            this.five.TabIndex = 10;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.ButtonClick);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.Silver;
            this.six.Location = new System.Drawing.Point(190, 225);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(74, 61);
            this.six.TabIndex = 11;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.ButtonClick);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.Silver;
            this.seven.Location = new System.Drawing.Point(29, 160);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(74, 61);
            this.seven.TabIndex = 6;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.ButtonClick);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.Silver;
            this.eight.Location = new System.Drawing.Point(109, 160);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(74, 61);
            this.eight.TabIndex = 7;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.ButtonClick);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.Silver;
            this.nine.Location = new System.Drawing.Point(190, 161);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(74, 61);
            this.nine.TabIndex = 8;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.ButtonClick);
            // 
            // add
            // 
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add.Location = new System.Drawing.Point(275, 225);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(64, 61);
            this.add.TabIndex = 12;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.OperatorClick);
            // 
            // sub
            // 
            this.sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sub.Location = new System.Drawing.Point(275, 160);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(64, 61);
            this.sub.TabIndex = 13;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.OperatorClick);
            // 
            // del
            // 
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.del.Location = new System.Drawing.Point(267, 87);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(72, 61);
            this.del.TabIndex = 17;
            this.del.Text = "DEL";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.ButtonDel);
            // 
            // clear
            // 
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clear.Location = new System.Drawing.Point(187, 87);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(74, 61);
            this.clear.TabIndex = 16;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.ButtonClear);
            // 
            // multi
            // 
            this.multi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.multi.Location = new System.Drawing.Point(109, 87);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(74, 61);
            this.multi.TabIndex = 15;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.OperatorClick);
            // 
            // div
            // 
            this.div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.div.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.div.Location = new System.Drawing.Point(29, 87);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(74, 61);
            this.div.TabIndex = 14;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.OperatorClick);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.result.Location = new System.Drawing.Point(29, 27);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(310, 50);
            this.result.TabIndex = 18;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(365, 454);
            this.Controls.Add(this.result);
            this.Controls.Add(this.del);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.div);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button equal;

        private System.Windows.Forms.TextBox result;


        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button div;

        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button add;

        private System.Windows.Forms.Button zero;

        #endregion
    }
}