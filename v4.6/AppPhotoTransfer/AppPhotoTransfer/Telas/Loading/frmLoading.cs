using System;
using System.Collections;
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

namespace AppPhotoTransfer.Telas.Loading
{
    public partial class frmLoading : Form
    {
        Dictionary<string, string> dictionary;
        string destino = "";
        public frmLoading()
        {
            InitializeComponent();
        }

        public frmLoading(Dictionary<string, string> dict)
        {
            InitializeComponent();
            dictionary = dict;
        }

        public void StartProcesso()
        {
            int count = 0;
            DirectoryInfo dir = new DirectoryInfo(dictionary["OrigemPictures"]);
            //Criamos uma pasta com o nome Individuais.
            destino = $"{dictionary["DestinoPictures"]}\\{dictionary["KeyPhoto"]}";
            Directory.CreateDirectory(destino);
            pbLoading.Maximum = dir.GetFiles("*.jpg").Length;
            pbLoading.Step = 1;
            //pbLoading.PerformStep();
            pbLoading.Value = count;
            lblStatus.Text = $"{lblStatus.Text} {dictionary["KeyPhoto"]}";
            lblStatus.Refresh();
            Thread.Sleep(2000);
            foreach (FileInfo f in dir.GetFiles("*.jpg"))
            {
                File.Copy(f.FullName, destino + "\\" + f.Name);
                count++;
                pbLoading.Value = count;
                //double porcento = (pbLoading.Maximum / 100);
                //lblPorcentagem.Text = $"{porcento}%";
                //lblPorcentagem.Refresh();
                lblContagem.Text = $"{count}/{pbLoading.Maximum}";
                lblContagem.Refresh();
            }
            lblStatus.Text = $"Fotos:";
            lblContagem.Text = "0/0";
            pbLoading.Value = 0;
            lblStatus.Refresh();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            StartProcesso();
        }
    }
}
