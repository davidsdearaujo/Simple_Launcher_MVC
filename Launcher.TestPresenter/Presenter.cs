using Launcher.CrossCutting;
using Launcher.CrossCutting.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Web.Script.Serialization;
using System.Net;
using System.Text;

namespace Launcher.TestPresenter
{
    public class Presenter : IPresenter
    {
        CrossCutting.Utils Util = new CrossCutting.Utils();

        public ModelDTO CarregarModel(string url)
        {
            string conteudo = (File.Exists(url)) ? File.ReadAllText(url) : Util.DownloadStringByURL(url);
            return new JavaScriptSerializer().Deserialize<ModelDTO>(conteudo);
        }

        public bool VerificaAtualizacoes(IView view, ModelDTO model)
        {
            bool atualizado = false;
            using (var util = new UtilAssembly())
            {
                var versaoAtual = util.AssemblyVersion;
                atualizado = (model.HashValidacao.Equals(versaoAtual));
                if (!atualizado)
                {
                    Atualizar(view, model);
                }
            }
            return atualizado;
        }

        public void Atualizar(IView view, ModelDTO model)
        {
            //Baixar atualizações
            Util.DownloadFileByURL(model.UrlArquivoAtualizacao, model.HashValidacao, view);
        }

        public void TratamentoArquivoBaixado(IView view, AsyncCompletedEventArgs e)
        {
            //Descompacta e atualiza
        }

        public void Iniciar(IView view, ModelDTO model)
        {
            //Inicia a aplicação
        }
    }
}
