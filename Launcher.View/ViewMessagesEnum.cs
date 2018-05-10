using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Launcher.View
{
    public enum ViewMessagesEnum
    {
        //Padrão
        [Description("1.0.0.0")]
        Padrao_HashValidacao,

        [Description("Iniciar")]
        Padrao_TextoBotaoGO,

        [Description("Simple Launcher MVC")]
        Padrao_TituloForm,

        //Mensagens
        [Description("Pronto para iniciar!")]
        Mensagem_Pronto,

        [Description("Iniciando . . .")]
        Mensagem_Iniciando,

        //Atualização
        [Description("Não foi possível verificar as atualizações, pois o servidor de atualizações não foi encontrado.")]
        Mensagem_Atualizacao_Erro,

        [Description("Verificando atualizações . . .")]
        Mensagem_Atualizacao_Verificando,

        //Download
        [Description("Baixado: {0} de Total: {1}")]
        Mensagem_Baixar_Arquivo,

        [Description("Erro ao tentar baixar o arquivo!")]
        Mensagem_Baixar_Erro,

        //Banner
        [Description("Servidor Offline")]
        Mensagem_Banner_Atualizacao_Erro,

        [Description("Imagem Não Encontrada")]
        Mensagem_Banner_Download_Erro,
    }
}
