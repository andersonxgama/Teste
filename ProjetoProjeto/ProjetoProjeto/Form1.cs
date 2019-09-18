using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoProjeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTeste_Click(object sender, EventArgs e)
        {
            btnTeste.Enabled = false;

            GerarArquivo();

            Thread.Sleep(1000);
            Application.DoEvents();

            btnTeste.Enabled = true;
        }

        private void GerarArquivo()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            path = path + "\\Teste.txt";

            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine("-- TESTE ---");
            }
        }
    }
}