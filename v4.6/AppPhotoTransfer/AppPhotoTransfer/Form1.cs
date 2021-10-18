using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TasksPartialNameSpace = System.Threading.Tasks;
using System.Threading;
using Microsoft.WindowsAPICodePack.Dialogs;
using AppPhotoTransfer.Telas.Loading;
using AppPhotoTransfer.Model.Auxiliar;
using AppPhotoTransfer.EnumTypes;
using static AppPhotoTransfer.Model.PhotoTranfer.MainInfo;
using AppPhotoTransfer.Model.PhotoTranfer;
using System.Threading.Tasks;
using System.Reflection;

namespace AppPhotoTransfer
{
    public partial class Form1 : Form
    {
        public static ListBoxLog listBoxLog;
        private delegate void Processar();
        Dictionary<string, string> keyValues;
        string destino = "";

        public Form1()
        {
            InitializeComponent();

            btnCopiar.Click += StartProcesso;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxLog = new ListBoxLog(listBox1);
            CarregarMainInfo();
            FCInfo().EscreverConsoleLog("CONSOLE LOG INICIADO", TipoConsoleLog.Info);
            CarregaDiretorios();

        }

        private void pesqCaminhoOrigem_Click(object sender, EventArgs e)
        {
            var task = TasksPartialNameSpace.Task.Factory.StartNew((() =>
            {
                Invoke(new Processar(() =>
                {
                    /*
                    CommonOpenFileDialog dialog = new CommonOpenFileDialog();
                    dialog.InitialDirectory = "";
                    dialog.IsFolderPicker = true;

                    if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                    {
                        txtOrigem.Text = dialog.FileName;
                    }
                    */
                    DialogResult result = FolderOrigem.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        txtOrigem.Text = FolderOrigem.SelectedPath;
                    }
                    if (Directory.Exists($"{txtOrigem.Text}\\Prints"))
                    {
                        txtOrigemPersonalizadas.Text = $"{txtOrigem.Text}\\prints";
                        btnOrigemPersonalizadas.Enabled = false;
                    }
                }));

            }));

        }
        private void btnOrigemPersonalizadas_Click(object sender, EventArgs e)
        {
            var task = TasksPartialNameSpace.Task.Factory.StartNew((() =>
            {
                Invoke(new Processar(() =>
                {
                    DialogResult result = FolderOrigem.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        //txtOrigemPersonalizadas.Text = FolderOrigem.SelectedPath;
                        txtOrigemPersonalizadas.Text = $"{txtOrigem.Text}\\Prints";
                    }
                }));

            }));

        }

        private void pesqCaminhoDestino_Click(object sender, EventArgs e)
        {
            var task = TasksPartialNameSpace.Task.Factory.StartNew((() =>
            {
                Invoke(new Processar(() =>
                {
                    DialogResult result = FolderDestino.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        txtDestino.Text = FolderDestino.SelectedPath;
                        btnCopiar.Enabled = true;
                    }
                }));

            }));

        }

        private void StartProcesso(object sender, EventArgs e)
        {
            try
            {
                var task = TasksPartialNameSpace.Task.Factory.StartNew((() =>
                {
                    var result = ValidaDiretorios();

                    if (result)
                    {
                        Invoke(new Processar(() =>
                        {
                            keyValues = new Dictionary<string, string>();
                            keyValues.Add("KeyPhoto", "Individuais");
                            keyValues.Add("OrigemPictures", txtOrigem.Text);
                            keyValues.Add("DestinoPictures", txtDestino.Text);
                        }));
                        Loading();

                        Invoke(new Processar(() =>
                        {
                            keyValues = new Dictionary<string, string>();
                            keyValues.Add("KeyPhoto", "Personalizadas");
                            keyValues.Add("OrigemPictures", txtOrigemPersonalizadas.Text);
                            keyValues.Add("DestinoPictures", txtDestino.Text);
                        }));
                        Loading();
                    }

                }));
                SalvarDiretorios();
            }
            catch (Exception ex)
            {
                FCInfo().EscreverConsoleLog(string.Format("Erro: {0}", ex.Message), TipoConsoleLog.Erro, true, MethodBase.GetCurrentMethod().Name, ex);
            }

        }

        private bool ValidaDiretorios()
        {
            try
            {
                if (string.IsNullOrEmpty(txtOrigem.Text))
                {
                    MessageBox.Show("Preencha o Campo Diretorio origem Individuais!");
                    return false;
                }
                else if (string.IsNullOrEmpty(txtOrigemPersonalizadas.Text))
                {
                    MessageBox.Show("Preencha o Campo Diretorio origem Personalizadas!");
                    return false;
                }
                else if (string.IsNullOrEmpty(txtDestino.Text))
                {
                    MessageBox.Show("Preencha o Campo Diretorio Destino!");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                FCInfo().EscreverConsoleLog(string.Format("Erro: {0}", ex.Message), TipoConsoleLog.Erro, true, MethodBase.GetCurrentMethod().Name, ex);
                return false;
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                txtOrigem.Text = "";
                txtOrigemPersonalizadas.Text = "";
                txtDestino.Text = "";
                btnCopiar.Enabled = false;
                FCInfo().EscreverConsoleLog("Campo diretorio Limpo!", TipoConsoleLog.Info);
            }
            catch (Exception ex)
            {
                FCInfo().EscreverConsoleLog(string.Format("Erro: {0}", ex.Message), TipoConsoleLog.Erro, true, MethodBase.GetCurrentMethod().Name, ex);
            }
        }
        private void SalvarDiretorios()
        {
            try
            {
                Properties.Settings.Default.OrigemIndividuais = txtOrigem.Text;
                Properties.Settings.Default.OrigemPersonalizadas = txtOrigemPersonalizadas.Text;
                Properties.Settings.Default.DestinoFotos = txtDestino.Text;
                Properties.Settings.Default.Save();
                FCInfo().EscreverConsoleLog("Diretorios Salvos!", TipoConsoleLog.Info);
            }
            catch (Exception ex)
            {
                FCInfo().EscreverConsoleLog(string.Format("Erro: {0}", ex.Message), TipoConsoleLog.Erro, true, MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        private void CarregaDiretorios()
        {
            try
            {
                txtOrigem.Text = Properties.Settings.Default.OrigemIndividuais;
                txtOrigemPersonalizadas.Text = Properties.Settings.Default.OrigemPersonalizadas;
                if (!string.IsNullOrEmpty(Properties.Settings.Default.DestinoFotos))
                {
                    txtDestino.Text = Properties.Settings.Default.DestinoFotos;
                    btnCopiar.Enabled = true;
                }
                FCInfo().EscreverConsoleLog("Diretorios Carregados", TipoConsoleLog.Info);
            }
            catch (Exception ex)
            {

                FCInfo().EscreverConsoleLog(string.Format("Erro: {0}", ex.Message), TipoConsoleLog.Erro, true, MethodBase.GetCurrentMethod().Name, ex);
            }

        }

        private void Loading()
        {
            try
            {
                MainInfo.FCInfo().EscreverConsoleLog("Processo Iniciado", TipoConsoleLog.Info);
                int count = 0, total = 0;
                DirectoryInfo dir = new DirectoryInfo(keyValues["OrigemPictures"]);
                //Criamos uma pasta com o nome Individuais.
                destino = $"{keyValues["DestinoPictures"]}\\{keyValues["KeyPhoto"]}";
                Directory.CreateDirectory(destino);
                MainInfo.FCInfo().EscreverConsoleLog($"Pasta: {keyValues["KeyPhoto"]} criada no Diretorio {keyValues["DestinoPictures"]}", TipoConsoleLog.Info);
                total = dir.GetFiles("*.jpg").Length;
                MainInfo.FCInfo().EscreverConsoleLog($"Total de Imagens: {total}", TipoConsoleLog.Info);
                MainInfo.FCInfo().EscreverConsoleLog("AGUARDE...", TipoConsoleLog.Info);
                Thread.Sleep(2000);
                MainInfo.FCInfo().EscreverConsoleLog("Copia Iniciada...", TipoConsoleLog.Info);
                foreach (FileInfo f in dir.GetFiles("*.jpg"))
                {
                    if (f.LastWriteTime.Hour > DateTime.Parse(mtbHoraFoto.Text).Hour)
                    {
                        File.Copy(f.FullName, destino + "\\" + f.Name);
                        MainInfo.FCInfo().EscreverConsoleLog($"Nome Arquivo: {f.Name}", TipoConsoleLog.Info);
                        count++;

                    }
                }
                FCInfo().EscreverConsoleLog($"Tranferidos: {count}/{total}", TipoConsoleLog.Info);
            }
            catch (Exception ex)
            {
                FCInfo().EscreverConsoleLog(string.Format("Erro: {0}", ex.Message), TipoConsoleLog.Erro, true, MethodBase.GetCurrentMethod().Name, ex);
            }
        }
        private void CarregarMainInfo()
        {
            this.ParametrizarDelegates();
        }
        private void ParametrizarDelegates()
        {
            FCInfo().EscreverConsoleLog = new MainInfo.DelegateEscreverConsoleLog(this.EscreverConsoleLog);
        }

        private void EscreverConsoleLog(string mensagem, TipoConsoleLog tipoConsoleLog, bool gravarLog = false, string nomeProcesso = "", Exception exception = null)
        {
            listBoxLog.Log(tipoConsoleLog, mensagem);
        }
    }
}
