namespace QuadEqual
{
    partial class QuadCalc
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_x1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_x2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_comment = new System.Windows.Forms.Label();
            this.button_solve = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Коэффициенты уравнения";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "a=";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(39, 60);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(100, 20);
            this.textBox_a.TabIndex = 2;
            this.textBox_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_a_KeyPress);
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(39, 90);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(100, 20);
            this.textBox_b.TabIndex = 4;
            this.textBox_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_b_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "b=";
            // 
            // textBox_c
            // 
            this.textBox_c.Location = new System.Drawing.Point(39, 120);
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.Size = new System.Drawing.Size(100, 20);
            this.textBox_c.TabIndex = 6;
            this.textBox_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_c_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "c=";
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(39, 162);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(100, 23);
            this.button_reset.TabIndex = 7;
            this.button_reset.Text = "Сброс";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(155, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "x1=";
            // 
            // textBox_x1
            // 
            this.textBox_x1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_x1.Location = new System.Drawing.Point(188, 60);
            this.textBox_x1.Name = "textBox_x1";
            this.textBox_x1.ReadOnly = true;
            this.textBox_x1.Size = new System.Drawing.Size(100, 20);
            this.textBox_x1.TabIndex = 9;
            this.textBox_x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(310, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "x2=";
            // 
            // textBox_x2
            // 
            this.textBox_x2.Location = new System.Drawing.Point(343, 60);
            this.textBox_x2.Name = "textBox_x2";
            this.textBox_x2.ReadOnly = true;
            this.textBox_x2.Size = new System.Drawing.Size(100, 20);
            this.textBox_x2.TabIndex = 11;
            this.textBox_x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(188, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 35);
            this.label7.TabIndex = 12;
            this.label7.Text = "Корни уравнения";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_comment
            // 
            this.label_comment.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_comment.Location = new System.Drawing.Point(188, 97);
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(218, 62);
            this.label_comment.TabIndex = 13;
            this.label_comment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_solve
            // 
            this.button_solve.Location = new System.Drawing.Point(188, 162);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(90, 23);
            this.button_solve.TabIndex = 14;
            this.button_solve.Text = "Решить";
            this.button_solve.UseVisualStyleBackColor = true;
            this.button_solve.Click += new System.EventHandler(this.button_solve_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(353, 162);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(90, 23);
            this.button_close.TabIndex = 15;
            this.button_close.Text = "Закрыть";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // QuadCalc
            // 
            this.AcceptButton = this.button_solve;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 197);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_solve);
            this.Controls.Add(this.label_comment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_x2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_x1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuadCalc";
            this.Text = "Решение квадратного уравнения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_c;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_x1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_x2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_comment;
        private System.Windows.Forms.Button button_solve;
        private System.Windows.Forms.Button button_close;
    }
}

