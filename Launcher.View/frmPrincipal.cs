using Launcher.CrossCutting;
using Launcher.CrossCutting.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Launcher.View
{
    public partial class frmPrincipal<TPresenter> : Form, IView where TPresenter : IPresenter, new()
    {
        public ModelDTO Model { get; set; }
        public TPresenter Presenter { get; set; } = new TPresenter();

        public DownloadProgressChangedEventHandler DownloadProgressChangedEventHandler { get; set; }
        public AsyncCompletedEventHandler DownloadFileCompletedEventHandler { get; set; }

        private BackgroundWorker bwInicio { get; set; }
        private BackgroundWorker bwBanners { get; set; }
        private BackgroundWorker bwVerificarAtualizacoes { get; set; }

        private void ShowWait()
        {
            buttonGO.RunInvoke(btn => btn.Enabled = false);
        }

        private void HideWait()
        {
            buttonGO.RunInvoke(btn =>
            {
                btn.Enabled = true;
                progressBarInfo.Value = 100;
            });
        }

        #region EventosForm

        public frmPrincipal(string linkXML, bool multiProgressBar)
        {
            //Preencher Model com valores padrão
            Model = new ModelDTO();
            Model.UrlXML = linkXML;
            Model.HashValidacao = ViewMessagesEnum.Padrao_HashValidacao.GetDescription();
            Model.TextoBotaoGO = ViewMessagesEnum.Padrao_TextoBotaoGO.GetDescription();
            Model.TituloForm = ViewMessagesEnum.Padrao_TituloForm.GetDescription();

            //On Download Progress Changed
            DownloadProgressChangedEventHandler = DownloadProgressChanged;

            //On Download Completed
            DownloadFileCompletedEventHandler = DownloadFileCompleted;

            InitializeComponent();

            //Esconde a progressBarPrincipal se multiProgressBar = false
            progressBarPrincipal.Visible = labelProgressPrincipal.Visible = multiProgressBar;

            bwInicio = new BackgroundWorker();
            bwInicio.DoWork += bwInicio_DoWork;
            bwInicio.RunWorkerCompleted += bwInicio_RunWorkerCompleted;

            bwBanners = new BackgroundWorker();
            bwBanners.DoWork += bwBanners_DoWork;

            bwVerificarAtualizacoes = new BackgroundWorker();
            bwVerificarAtualizacoes.DoWork += bwVerificaAtualizacoes_DoWork;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ShowWait();
            bwInicio.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ShowWait();
            labelProgressInfo.Text = ViewMessagesEnum.Mensagem_Iniciando.GetDescription();
            Presenter.Iniciar(this, Model);
        }

        private void bwBanners_DoWork(object sender, DoWorkEventArgs e)
        {
            //Preenche as informações na tela
            var utils = new Launcher.CrossCutting.Utils();
            try
            {
                var imgBanner01 = utils.DownloadImage(Model.UrlBanner1);
                var imgBanner02 = utils.DownloadImage(Model.UrlBanner2);
                picBanner01.RunInvoke(pic => pic.BackgroundImage = imgBanner01);
                picBanner02.RunInvoke(pic => pic.BackgroundImage = imgBanner02);
            }
            catch (Exception ex)
            {
                labelBanner1.RunInvoke(lbl =>
                {
                    lbl.Text = labelBanner2.Text = ViewMessagesEnum.Mensagem_Banner_Atualizacao_Erro.GetDescription();
                    lbl.Visible = labelBanner2.Visible = true;
                });
            }
        }

        private void bwInicio_DoWork(object sender, DoWorkEventArgs e)
        {
            //Carregar informações do XML
            try
            {
                Model = Presenter.CarregarModel(Model.UrlXML);
            }
            catch
            {
                e.Cancel = true;
            }

            buttonGO.RunInvoke(btn => btn.Text = Model.TextoBotaoGO);
            this.RunInvoke(frm => frm.Text = Model.TituloForm);
        }

        private void bwVerificaAtualizacoes_DoWork(object sender, DoWorkEventArgs e)
        {
            //Verifica atualizações
            labelProgressInfo.RunInvoke(lbl => lbl.Text = ViewMessagesEnum.Mensagem_Atualizacao_Verificando.GetDescription());
            if (Presenter.VerificaAtualizacoes(this, Model))
            {
                //Se estiver atualizado, executa o método de finalização 
                DownloadFileCompletedEventHandler(this, new AsyncCompletedEventArgs(null, false, null));
            }
        }

        private void bwInicio_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                labelProgressInfo.RunInvoke(lbl =>
                {
                    lbl.Text = ViewMessagesEnum.Mensagem_Atualizacao_Erro.GetDescription();
                    labelBanner1.Text = labelBanner2.Text = ViewMessagesEnum.Mensagem_Banner_Atualizacao_Erro.GetDescription();
                    labelBanner1.Visible = labelBanner2.Visible = true;
                });
            }
            else
            {

                bwVerificarAtualizacoes.RunWorkerAsync();
                bwBanners.RunWorkerAsync();
            }
        }


        private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                labelProgressInfo.Text = string.Format(ViewMessagesEnum.Mensagem_Baixar_Arquivo.GetDescription(), e.BytesReceived, e.TotalBytesToReceive);
                progressBarInfo.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }

        private void DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                Presenter.TratamentoArquivoBaixado(this, e);
                if (e.Error == null)
                {
                    labelProgressInfo.Text = ViewMessagesEnum.Mensagem_Pronto.GetDescription();
                    this.HideWait();
                }
                else
                {
                    labelProgressInfo.Text = ViewMessagesEnum.Mensagem_Baixar_Erro.GetDescription();
                }
            });
        }
    }
    #endregion
}
