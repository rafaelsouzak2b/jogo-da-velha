using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Da_Velha
{
   
    public partial class frmPrincipal : Form
    {
        public char vez = 'X';
        char[,] tabela = new char[3, 3];
        int x, y;
        int cont = 0;
        int pontosX = 0, pontosO = 0;
        public frmPrincipal()
        {
            InitializeComponent();
            groupBox1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            x = Convert.ToInt32(btn.Name[3].ToString());
            y = Convert.ToInt32(btn.Name[4].ToString());
            btn.Enabled = false;
            if (vez == 'X')
            {
                tabela[x, y] = vez;
                btn.Text = vez.ToString();
                Valida(vez);
                vez = 'O';
                
            }
            else
            {
                tabela[x, y] = vez;
                btn.Text = vez.ToString();
                Valida(vez);
                vez = 'X';


            }



            //btnLimpar.Focus();
            groupBox1.Focus();


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            limpa();
            pontosO = 0;
            pontosX = 0;
            groupBox1.Text = "X: 0 VS O: 0";


        }


        void Valida(char vez)
        {
            int encontra = 0;
            cont++;
            int onde_ganhou = 0;
            //primeira linha
            for (int x = 0; x < 3; x++)
                {

                    if (tabela[0, x] == vez)
                    {
                        encontra++;

                    }

                }

                if (encontra == 3)
                {

                // MessageBox.Show(vez + " ganhou");
                // limpa();
                onde_ganhou = 1;

                    
                }

            encontra = 0;
            //segunda linha
            for (int x = 0; x < 3; x++)
            {

                if (tabela[1, x] == vez)
                {
                    encontra++;

                }

            }

            if (encontra == 3)
            {

                // MessageBox.Show(vez + " ganhou");
                // limpa();
                onde_ganhou = 2;


            }


            encontra = 0;
            //terceira linha
            for (int x = 0; x < 3; x++)
            {

                if (tabela[2, x] == vez)
                {
                    encontra++;

                }

            }

            if (encontra == 3)
            {

                // MessageBox.Show(vez + " ganhou");
                // limpa();
                onde_ganhou = 3;


            }


            encontra = 0;
            //primeira coluna
            for (int x = 0; x < 3; x++)
            {

                if (tabela[x, 0] == vez)
                {
                    encontra++;

                }

            }

            if (encontra == 3)
            {

                // MessageBox.Show(vez + " ganhou");
                // limpa();
                onde_ganhou = 4;


            }


            encontra = 0;
            //segunda coluna
            for (int x = 0; x < 3; x++)
            {

                if (tabela[x, 1] == vez)
                {
                    encontra++;

                }

            }

            if (encontra == 3)
            {

                // MessageBox.Show(vez + " ganhou");
                // limpa();
                onde_ganhou = 5;


            }



            encontra = 0;
            //terceira coluna
            for (int x = 0; x < 3; x++)
            {

                if (tabela[x, 2] == vez)
                {
                    encontra++;

                }

            }

            if (encontra == 3)
            {

                // MessageBox.Show(vez + " ganhou");
                // limpa();
                onde_ganhou = 6;


            }

            encontra = 0;
            //diagonal1
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (x == y)
                    {
                        if (tabela[x, y] == vez)
                        {
                            encontra++;

                        }
                    }
                }
            }

            if (encontra == 3)
            {

                // MessageBox.Show(vez + " ganhou");
                // limpa();
                onde_ganhou = 7;


            }

            encontra = 0;
            //diagonal2
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (x + y == 2)
                    {
                        if (tabela[x, y] == vez)
                        {
                            encontra++;

                        }
                    }
                }
            }

            if (encontra == 3)
            {

                // MessageBox.Show(vez + " ganhou");
                // limpa();
                onde_ganhou = 8;


            }








            if (onde_ganhou == 1)
            {
                MessageBox.Show(vez + " ganhou na primeira linha!");
                if (vez == 'X')
                {
                    pontosX++;
                }
                else
                {

                    pontosO++;
                }
                groupBox1.Text = "X: " + pontosX + " VS O: " + pontosO;
                limpa();

            }
            if (onde_ganhou == 2)
            {
                MessageBox.Show(vez + " ganhou na segunda linha!");
                if (vez == 'X')
                {
                    pontosX++;
                }
                else
                {

                    pontosO++;
                }
                groupBox1.Text = "X: " + pontosX + " VS O: " + pontosO;
                limpa();
            }
            if(onde_ganhou == 3)
            {
                MessageBox.Show(vez + " ganhou na terceira linha!");
                if (vez == 'X')
                {
                    pontosX++;
                }
                else
                {

                    pontosO++;
                }
                groupBox1.Text = "X: " + pontosX + " VS O: " + pontosO;
                limpa();
            }
            if (onde_ganhou == 4)
            {
                MessageBox.Show(vez + " ganhou na primeira coluna!");
                if (vez == 'X')
                {
                    pontosX++;
                }
                else
                {

                    pontosO++;
                }
                groupBox1.Text = "X: " + pontosX + " VS O: " + pontosO;
                limpa();
            }
            if (onde_ganhou == 5)
            {
                MessageBox.Show(vez + " ganhou na segunda coluna!");
                if (vez == 'X')
                {
                    pontosX++;
                }
                else
                {

                    pontosO++;
                }
                groupBox1.Text = "X: " + pontosX + " VS O: " + pontosO;
                limpa();
            }
            if (onde_ganhou == 6)
            {
                MessageBox.Show(vez + " ganhou na terceira coluna!");
                if (vez == 'X')
                {
                    pontosX++;
                }
                else
                {

                    pontosO++;
                }
                groupBox1.Text = "X: " + pontosX + " VS O: " + pontosO;
                limpa();
            }
            if (onde_ganhou == 7)
            {
                MessageBox.Show(vez + " ganhou na diagona 1!");
                if (vez == 'X')
                {
                    pontosX++;
                }
                else
                {

                    pontosO++;
                }
                groupBox1.Text = "X: " + pontosX + " VS O: " + pontosO;
                limpa();
            }
            if (onde_ganhou == 8)
            {
                MessageBox.Show(vez + " ganhou na diagonal2!");
                if (vez == 'X')
                {
                    pontosX++;
                }
                else
                {

                    pontosO++;
                }
                groupBox1.Text = "X: " + pontosX + " VS O: " + pontosO;
                limpa();
            }
            if (onde_ganhou == 0 && cont == 9)
            {
                MessageBox.Show("Deu velha!");
                limpa();
            }



            }
           

           
        

        void limpa()
        {
            btn00.Text = "";
            btn01.Text = "";
            btn02.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn00.Enabled = true;
            btn01.Enabled = true;
            btn02.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn20.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;
            cont = 0;
            for(int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    tabela[x, y] = 'V';
                }
            }
            vez = 'X';
        }

    }
}
