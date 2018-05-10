using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Launcher.CrossCutting.Config
{
    public class ModelDTO
    {
        public string UrlXML { get; set; }

        public string UrlArquivoAtualizacao { get; set; }
        public string HashValidacao { get; set; }

        public string UrlBanner1 { get; set; }
        public string UrlBanner2 { get; set; }

        public string TextoBotaoGO { get; set; }
        public string TituloForm { get; set; }
    }
}
