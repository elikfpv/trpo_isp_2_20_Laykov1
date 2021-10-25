
namespace TRPO_ISP_2_20_Laykov_PR2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.textB1 = new System.Windows.Forms.TextBox();
            this.textB2 = new System.Windows.Forms.TextBox();
            this.pan1 = new System.Windows.Forms.Panel();
            this.radiotg = new System.Windows.Forms.RadioButton();
            this.radiocos = new System.Windows.Forms.RadioButton();
            this.radiosin = new System.Windows.Forms.RadioButton();
            this.PYSK = new System.Windows.Forms.Button();
            this.richTextB = new System.Windows.Forms.RichTextBox();
            this.maxabs = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textB3 = new System.Windows.Forms.TextBox();
            this.pan1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(12, 24);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(20, 13);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "X=";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(12, 58);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(20, 13);
            this.lab2.TabIndex = 2;
            this.lab2.Text = "Y=";
            // 
            // textB1
            // 
            this.textB1.Location = new System.Drawing.Point(38, 21);
            this.textB1.Name = "textB1";
            this.textB1.Size = new System.Drawing.Size(106, 20);
            this.textB1.TabIndex = 3;
            this.textB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textB1_KeyPress);
            // 
            // textB2
            // 
            this.textB2.Location = new System.Drawing.Point(38, 55);
            this.textB2.Name = "textB2";
            this.textB2.Size = new System.Drawing.Size(106, 20);
            this.textB2.TabIndex = 5;
            this.textB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textB2_KeyPress);
            // 
            // pan1
            // 
            this.pan1.Controls.Add(this.maxabs);
            this.pan1.Controls.Add(this.radiotg);
            this.pan1.Controls.Add(this.radiocos);
            this.pan1.Controls.Add(this.radiosin);
            this.pan1.Location = new System.Drawing.Point(190, 24);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(129, 106);
            this.pan1.TabIndex = 6;
            // 
            // radiotg
            // 
            this.radiotg.AutoSize = true;
            this.radiotg.Location = new System.Drawing.Point(27, 76);
            this.radiotg.Name = "radiotg";
            this.radiotg.Size = new System.Drawing.Size(63, 17);
            this.radiotg.TabIndex = 2;
            this.radiotg.Text = "u = tg(x)";
            this.radiotg.UseVisualStyleBackColor = true;
            // 
            // radiocos
            // 
            this.radiocos.AutoSize = true;
            this.radiocos.Location = new System.Drawing.Point(27, 53);
            this.radiocos.Name = "radiocos";
            this.radiocos.Size = new System.Drawing.Size(71, 17);
            this.radiocos.TabIndex = 1;
            this.radiocos.Text = "u = cos(x)";
            this.radiocos.UseVisualStyleBackColor = true;
            // 
            // radiosin
            // 
            this.radiosin.AutoSize = true;
            this.radiosin.Location = new System.Drawing.Point(27, 30);
            this.radiosin.Name = "radiosin";
            this.radiosin.Size = new System.Drawing.Size(67, 17);
            this.radiosin.TabIndex = 0;
            this.radiosin.Text = "u = sin(x)";
            this.radiosin.UseVisualStyleBackColor = true;
            // 
            // PYSK
            // 
            this.PYSK.Location = new System.Drawing.Point(75, 291);
            this.PYSK.Name = "PYSK";
            this.PYSK.Size = new System.Drawing.Size(230, 23);
            this.PYSK.TabIndex = 7;
            this.PYSK.Text = "ПУСК";
            this.PYSK.UseVisualStyleBackColor = true;
            this.PYSK.Click += new System.EventHandler(this.PYSK_Click);
            // 
            // richTextB
            // 
            this.richTextB.Location = new System.Drawing.Point(75, 177);
            this.richTextB.Name = "richTextB";
            this.richTextB.Size = new System.Drawing.Size(230, 108);
            this.richTextB.TabIndex = 8;
            this.richTextB.Text = "";
            // 
            // maxabs
            // 
            this.maxabs.AutoSize = true;
            this.maxabs.Location = new System.Drawing.Point(27, 7);
            this.maxabs.Name = "maxabs";
            this.maxabs.Size = new System.Drawing.Size(62, 17);
            this.maxabs.TabIndex = 3;
            this.maxabs.Text = "maxabs";
            this.maxabs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Z=";
            // 
            // textB3
            // 
            this.textB3.Location = new System.Drawing.Point(38, 94);
            this.textB3.Name = "textB3";
            this.textB3.Size = new System.Drawing.Size(106, 20);
            this.textB3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(372, 351);
            this.Controls.Add(this.textB3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextB);
            this.Controls.Add(this.PYSK);
            this.Controls.Add(this.pan1);
            this.Controls.Add(this.textB2);
            this.Controls.Add(this.textB1);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Практическая работа №2 (2 Вариант)";
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.TextBox textB1;
        private System.Windows.Forms.TextBox textB2;
        private System.Windows.Forms.Panel pan1;
        private System.Windows.Forms.RadioButton radiotg;
        private System.Windows.Forms.RadioButton radiocos;
        private System.Windows.Forms.RadioButton radiosin;
        private System.Windows.Forms.Button PYSK;
        private System.Windows.Forms.RichTextBox richTextB;
        private System.Windows.Forms.CheckBox maxabs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textB3;
    }
}

