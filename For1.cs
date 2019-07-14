using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class СоцПлата : Form
    {
        public СоцПлата()
        {
            InitializeComponent();
        }
        int мдр, чел, дох, индексгорода, Нтн, Нп, Нд;
        float жку, с, к, сд, пм, ПМтн, ПМп, ПМд;

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.consultant.ru/document/cons_doc_LAW_45158/");
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
                индексгорода = comboBox1.SelectedIndex;


          







            Нд = Convert.ToInt32(textBox4.Text);
            Нп = Convert.ToInt32(textBox3.Text);
            Нтн = Convert.ToInt32(textBox5.Text);
            чел = Нд + Нп + Нтн;







            if (чел == 0)
            {
                MessageBox.Show("Укажите членов семьи!", "Ответ");
                return;
            }









            switch (индексгорода)
                {
                    case -1:
                        MessageBox.Show("Укажите регион","Ответ");
                        break;

                    case 0:


                       


                        мдр = 15;
                        if (чел == 1)
                            жку = 2317.69f;
                        else if (чел == 2)
                            жку = 1790.07f;
                        else if (чел == 3)
                            жку = 1640.40f;
                        else if (чел == 4)
                            жку = 1438.51f;
                        else if (чел == 5)
                            жку = 1303.16f;
                        else if (чел > 5)
                            жку = 1236.61f;

                        ПМтн = 6315;
                        ПМп = 4831;
                        ПМд = 5877;
                        пм = ((ПМтн * Нтн) + (ПМп * Нп) + (ПМд * Нд)) / (Нд + Нп + Нтн);

                  
                        

                        дох = Convert.ToInt32(textBox2.Text);
                        сд = дох / чел;
                        к = сд / пм;
                   
                        
                        if ((дох / чел) > 8000)
                            с = (float)(жку * чел - (мдр * дох) / 100);
                        else
                            с = (float)(жку * чел - (мдр * дох * к) / 100);
                        if (с > 0)
                            MessageBox.Show(Convert.ToString(с),"Результат");
                        else
                            MessageBox.Show("Субсидия не полагается.","Ответ");

                        break;
                    case 1:
                       

                        мдр = 15;
                        if (чел == 1)
                            жку = 2417.69f;
                        else if (чел == 2)
                            жку = 1890.07f;
                        else if (чел == 3)
                            жку = 1940.40f;
                        else if (чел == 4)
                            жку = 1538.51f;
                        else if (чел == 5)
                            жку = 1403.16f;
                        else if (чел > 5)
                            жку = 1336.61f;

                        ПМтн = 6315;
                        ПМп = 4831;
                        ПМд = 5877;
                        пм = ((ПМтн * Нтн) + (ПМп * Нп) + (ПМд * Нд)) / (Нд + Нп + Нтн);
                    
                        


                        сд = дох / чел;
                        к = сд / пм;

                    

                    дох = Convert.ToInt32(textBox2.Text);
                        if ((дох / чел) > 8000)
                            с = (float)(жку * чел - (мдр * дох) / 100);
                        else
                            с = (float)(жку * чел - (мдр * дох * к) / 100);
                    if (с > 0)
                        MessageBox.Show(Convert.ToString(с),"Результат");
                    else
                        MessageBox.Show("Субсидия не полагается.","Ответ");

                        break;
                case 2:




                    мдр = 15;
                    if (чел == 1)
                        жку = 2107.69f;
                    else if (чел == 2)
                        жку = 1590.07f;
                    else if (чел == 3)
                        жку = 1440.40f;
                    else if (чел == 4)
                        жку = 1238.51f;
                    else if (чел == 5)
                        жку = 1203.16f;
                    else if (чел > 5)
                        жку = 1146.61f;

                    ПМтн = 6315;
                    ПМп = 4831;
                    ПМд = 5877;
                    пм = ((ПМтн * Нтн) + (ПМп * Нп) + (ПМд * Нд)) / (Нд + Нп + Нтн);

                   

                    дох = Convert.ToInt32(textBox2.Text);
                    сд = дох / чел;
                    к = сд / пм;
                   
                    if ((дох / чел) > 8000)
                        с = (float)(жку * чел - (мдр * дох) / 100);
                    else
                        с = (float)(жку * чел - (мдр * дох * к) / 100);
                    if (с > 0)
                        MessageBox.Show(Convert.ToString(с), "Результат");
                    else
                        MessageBox.Show("Субсидия не полагается.", "Ответ");

                    break;
            }


            }
        }


    }
   
  

