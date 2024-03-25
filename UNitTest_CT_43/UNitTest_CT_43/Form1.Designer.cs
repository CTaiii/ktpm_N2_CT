
namespace UNitTest_CT_43
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
            this.lb1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.lbkq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(74, 99);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(29, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Số 1";
            this.lb1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(191, 92);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(113, 20);
            this.tb1.TabIndex = 1;
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(68, 318);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(107, 40);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "Cộng";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(229, 318);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(107, 40);
            this.bt2.TabIndex = 3;
            this.bt2.Text = "Trừ";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(407, 318);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(107, 40);
            this.bt3.TabIndex = 4;
            this.bt3.Text = "Nhân";
            this.bt3.UseVisualStyleBackColor = true;
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(582, 318);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(107, 40);
            this.bt4.TabIndex = 5;
            this.bt4.Text = "Chia";
            this.bt4.UseVisualStyleBackColor = true;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(191, 153);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(113, 20);
            this.tb2.TabIndex = 7;
            this.tb2.TextChanged += new System.EventHandler(this.tb2_TextChanged);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(74, 160);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(29, 13);
            this.lb2.TabIndex = 6;
            this.lb2.Text = "Số 2";
            this.lb2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(191, 215);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(113, 20);
            this.tb3.TabIndex = 9;
            this.tb3.TextChanged += new System.EventHandler(this.tb3_TextChanged);
            // 
            // lbkq
            // 
            this.lbkq.AutoSize = true;
            this.lbkq.Location = new System.Drawing.Point(74, 222);
            this.lbkq.Name = "lbkq";
            this.lbkq.Size = new System.Drawing.Size(22, 13);
            this.lbkq.TabIndex = 8;
            this.lbkq.Text = "KQ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.lbkq);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label lbkq;
    }
}

