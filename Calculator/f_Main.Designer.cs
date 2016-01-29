namespace Calculator
{
    partial class f_Main
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
            this.scr = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.num_7 = new System.Windows.Forms.Button();
            this.num_8 = new System.Windows.Forms.Button();
            this.num_9 = new System.Windows.Forms.Button();
            this.op_add = new System.Windows.Forms.Button();
            this.num_4 = new System.Windows.Forms.Button();
            this.num_5 = new System.Windows.Forms.Button();
            this.num_6 = new System.Windows.Forms.Button();
            this.op_sub = new System.Windows.Forms.Button();
            this.num_1 = new System.Windows.Forms.Button();
            this.num_2 = new System.Windows.Forms.Button();
            this.num_3 = new System.Windows.Forms.Button();
            this.op_mul = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.num_0 = new System.Windows.Forms.Button();
            this.op_Equal = new System.Windows.Forms.Button();
            this.op_div = new System.Windows.Forms.Button();
            this.Neg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scr
            // 
            this.scr.BackColor = System.Drawing.Color.White;
            this.scr.Enabled = false;
            this.scr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scr.Location = new System.Drawing.Point(12, 14);
            this.scr.Name = "scr";
            this.scr.ReadOnly = true;
            this.scr.Size = new System.Drawing.Size(218, 29);
            this.scr.TabIndex = 0;
            this.scr.Text = "0";
            this.scr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(12, 59);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(50, 50);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // num_7
            // 
            this.num_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_7.Location = new System.Drawing.Point(12, 115);
            this.num_7.Name = "num_7";
            this.num_7.Size = new System.Drawing.Size(50, 50);
            this.num_7.TabIndex = 1;
            this.num_7.Text = "7";
            this.num_7.UseVisualStyleBackColor = true;
            this.num_7.Click += new System.EventHandler(this.number_Click);
            // 
            // num_8
            // 
            this.num_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_8.Location = new System.Drawing.Point(68, 115);
            this.num_8.Name = "num_8";
            this.num_8.Size = new System.Drawing.Size(50, 50);
            this.num_8.TabIndex = 1;
            this.num_8.Text = "8";
            this.num_8.UseVisualStyleBackColor = true;
            this.num_8.Click += new System.EventHandler(this.number_Click);
            // 
            // num_9
            // 
            this.num_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_9.Location = new System.Drawing.Point(124, 115);
            this.num_9.Name = "num_9";
            this.num_9.Size = new System.Drawing.Size(50, 50);
            this.num_9.TabIndex = 1;
            this.num_9.Text = "9";
            this.num_9.UseVisualStyleBackColor = true;
            this.num_9.Click += new System.EventHandler(this.number_Click);
            // 
            // op_add
            // 
            this.op_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_add.Location = new System.Drawing.Point(180, 115);
            this.op_add.Name = "op_add";
            this.op_add.Size = new System.Drawing.Size(50, 50);
            this.op_add.TabIndex = 1;
            this.op_add.Text = "+";
            this.op_add.UseVisualStyleBackColor = true;
            this.op_add.Click += new System.EventHandler(this.operator_Click);
            // 
            // num_4
            // 
            this.num_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_4.Location = new System.Drawing.Point(12, 171);
            this.num_4.Name = "num_4";
            this.num_4.Size = new System.Drawing.Size(50, 50);
            this.num_4.TabIndex = 1;
            this.num_4.Text = "4";
            this.num_4.UseVisualStyleBackColor = true;
            this.num_4.Click += new System.EventHandler(this.number_Click);
            // 
            // num_5
            // 
            this.num_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_5.Location = new System.Drawing.Point(68, 171);
            this.num_5.Name = "num_5";
            this.num_5.Size = new System.Drawing.Size(50, 50);
            this.num_5.TabIndex = 1;
            this.num_5.Text = "5";
            this.num_5.UseVisualStyleBackColor = true;
            this.num_5.Click += new System.EventHandler(this.number_Click);
            // 
            // num_6
            // 
            this.num_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_6.Location = new System.Drawing.Point(124, 171);
            this.num_6.Name = "num_6";
            this.num_6.Size = new System.Drawing.Size(50, 50);
            this.num_6.TabIndex = 1;
            this.num_6.Text = "6";
            this.num_6.UseVisualStyleBackColor = true;
            this.num_6.Click += new System.EventHandler(this.number_Click);
            // 
            // op_sub
            // 
            this.op_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_sub.Location = new System.Drawing.Point(180, 171);
            this.op_sub.Name = "op_sub";
            this.op_sub.Size = new System.Drawing.Size(50, 50);
            this.op_sub.TabIndex = 1;
            this.op_sub.Text = "-";
            this.op_sub.UseVisualStyleBackColor = true;
            this.op_sub.Click += new System.EventHandler(this.operator_Click);
            // 
            // num_1
            // 
            this.num_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_1.Location = new System.Drawing.Point(12, 227);
            this.num_1.Name = "num_1";
            this.num_1.Size = new System.Drawing.Size(50, 50);
            this.num_1.TabIndex = 1;
            this.num_1.Text = "1";
            this.num_1.UseVisualStyleBackColor = true;
            this.num_1.Click += new System.EventHandler(this.number_Click);
            // 
            // num_2
            // 
            this.num_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_2.Location = new System.Drawing.Point(68, 227);
            this.num_2.Name = "num_2";
            this.num_2.Size = new System.Drawing.Size(50, 50);
            this.num_2.TabIndex = 1;
            this.num_2.Text = "2";
            this.num_2.UseVisualStyleBackColor = true;
            this.num_2.Click += new System.EventHandler(this.number_Click);
            // 
            // num_3
            // 
            this.num_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_3.Location = new System.Drawing.Point(124, 227);
            this.num_3.Name = "num_3";
            this.num_3.Size = new System.Drawing.Size(50, 50);
            this.num_3.TabIndex = 1;
            this.num_3.Text = "3";
            this.num_3.UseVisualStyleBackColor = true;
            this.num_3.Click += new System.EventHandler(this.number_Click);
            // 
            // op_mul
            // 
            this.op_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_mul.Location = new System.Drawing.Point(180, 227);
            this.op_mul.Name = "op_mul";
            this.op_mul.Size = new System.Drawing.Size(50, 50);
            this.op_mul.TabIndex = 1;
            this.op_mul.Text = "x";
            this.op_mul.UseVisualStyleBackColor = true;
            this.op_mul.Click += new System.EventHandler(this.operator_Click);
            // 
            // Dot
            // 
            this.Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dot.Location = new System.Drawing.Point(12, 283);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(50, 50);
            this.Dot.TabIndex = 1;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.number_Click);
            // 
            // num_0
            // 
            this.num_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_0.Location = new System.Drawing.Point(68, 283);
            this.num_0.Name = "num_0";
            this.num_0.Size = new System.Drawing.Size(50, 50);
            this.num_0.TabIndex = 1;
            this.num_0.Text = "0";
            this.num_0.UseVisualStyleBackColor = true;
            this.num_0.Click += new System.EventHandler(this.number_Click);
            // 
            // op_Equal
            // 
            this.op_Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_Equal.Location = new System.Drawing.Point(124, 283);
            this.op_Equal.Name = "op_Equal";
            this.op_Equal.Size = new System.Drawing.Size(50, 50);
            this.op_Equal.TabIndex = 1;
            this.op_Equal.Text = "=";
            this.op_Equal.UseVisualStyleBackColor = true;
            this.op_Equal.Click += new System.EventHandler(this.operator_Click);
            // 
            // op_div
            // 
            this.op_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_div.Location = new System.Drawing.Point(180, 283);
            this.op_div.Name = "op_div";
            this.op_div.Size = new System.Drawing.Size(50, 50);
            this.op_div.TabIndex = 1;
            this.op_div.Text = "/";
            this.op_div.UseVisualStyleBackColor = true;
            this.op_div.Click += new System.EventHandler(this.operator_Click);
            // 
            // Neg
            // 
            this.Neg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Neg.Location = new System.Drawing.Point(180, 59);
            this.Neg.Name = "Neg";
            this.Neg.Size = new System.Drawing.Size(50, 50);
            this.Neg.TabIndex = 1;
            this.Neg.Text = "(-)";
            this.Neg.UseVisualStyleBackColor = true;
            this.Neg.Click += new System.EventHandler(this.Neg_Click);
            // 
            // f_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 344);
            this.Controls.Add(this.op_div);
            this.Controls.Add(this.op_Equal);
            this.Controls.Add(this.num_0);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.op_mul);
            this.Controls.Add(this.num_3);
            this.Controls.Add(this.num_2);
            this.Controls.Add(this.num_1);
            this.Controls.Add(this.op_sub);
            this.Controls.Add(this.num_6);
            this.Controls.Add(this.num_5);
            this.Controls.Add(this.num_4);
            this.Controls.Add(this.op_add);
            this.Controls.Add(this.num_9);
            this.Controls.Add(this.Neg);
            this.Controls.Add(this.num_8);
            this.Controls.Add(this.num_7);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.scr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "f_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máy tính bỏ túi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox scr;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button num_7;
        private System.Windows.Forms.Button num_8;
        private System.Windows.Forms.Button num_9;
        private System.Windows.Forms.Button op_add;
        private System.Windows.Forms.Button num_4;
        private System.Windows.Forms.Button num_5;
        private System.Windows.Forms.Button num_6;
        private System.Windows.Forms.Button op_sub;
        private System.Windows.Forms.Button num_1;
        private System.Windows.Forms.Button num_2;
        private System.Windows.Forms.Button num_3;
        private System.Windows.Forms.Button op_mul;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button num_0;
        private System.Windows.Forms.Button op_Equal;
        private System.Windows.Forms.Button op_div;
        private System.Windows.Forms.Button Neg;
    }
}

