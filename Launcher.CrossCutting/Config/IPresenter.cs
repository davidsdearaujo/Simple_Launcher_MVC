using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Launcher.CrossCutting.Config
{
    public interface IPresenter
    {
        /// <summary>
        /// Responsável por preencher a Model
        /// </summary>
        /// <param name="url">URL ou PATH do arquivo de configuração JSON</param>
        /// <returns></returns>
        ModelDTO CarregarModel(string url);

        /// <summary>
        /// Responsável por verificar as atualizações, utilizando as informações da Model
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model">Model preenchida pelo método "CarregarModel"</param>
        /// <returns>Retorna se a aplicação  está atualizada</returns>
        bool VerificaAtualizacoes(IView view, ModelDTO model);

        /// <summary>
        /// Responsável por realizar todo o processo de instalação da atualização
        /// </summary>
        /// <param name="view"></param>
        /// <param name="path">Caminho onde o arquivo foi salvo</param>
        /// <param name="e">Argumentos recebidos pelo evento "AsyncCoompleted"</param>
        void TratamentoArquivoBaixado(IView view, AsyncCompletedEventArgs e);

        /// <summary>
        /// Responsável por iniciar a aplicação
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model"></param>
        void Iniciar(IView view, ModelDTO model);
    }
}
