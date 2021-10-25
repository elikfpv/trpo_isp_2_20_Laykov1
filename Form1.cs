using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_ISP_2_20_Laykov_PR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


         private void PYSK_Click(object sender, EventArgs e)
        {

            if (textB1.Text == string.Empty)
            return;
            if (textB2.Text == string.Empty)
            return; // чтобы кнопка не работала, если не введено никаких значений
            
            



            double X = double.Parse(textB1.Text);
            double Y = double.Parse(textB2.Text);
            double Z = double.Parse(textB3.Text);

             double Max;
            double AbsX = Math.Abs(X);
            double AbsY = Math.Abs(Y);
            double AbsZ = Math.Abs(Z);
            
            if (radiosin.Checked)
                X = Math.Sin(X);

            if (radiocos.Checked)
                X = Math.Cos(X);

            if (radiotg.Checked)
                X = Math.Tan(X);

            if (maxabs.Checked)

            {
                Max = AbsX;
                if (Max < AbsY)
                    Max = AbsY;
                if (Max < AbsZ)
                    Max = AbsZ;
            }
            else
            {
                Max = X;
                if (Max < Y)
                    Max = Y;
                if (Max < Z)
                    Max = Z;
            }

            string name = "Проверочная работа №2 студента группы ИСП-2-20 Лайкова Е.И.";
            string xyyy = string.Format("X = {0}, Y = {1} Z = {2}", X, Y, Z);
            string bform = string.Format("Max = {0:F3}", Max);
            richTextB.Text = name + "\n" + xyyy + "\n" + bform; 
        }

        private void textB1_KeyPress(object sender, KeyPressEventArgs e)
        {
          if 
                (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
          else 
                e.Handled = true;
            
        }

        private void textB2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if
                (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
