using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Launcher.CrossCutting.Config
{
    public interface IView
    {
        /// <summary>
        /// Evento disparado a cada alteração no processo de download de arquivo
        /// </summary>
        DownloadProgressChangedEventHandler DownloadProgressChangedEventHandler { get; set; }

        /// <summary>
        /// Evento disparado na finalização do download
        /// </summary>
        AsyncCompletedEventHandler DownloadFileCompletedEventHandler { get; set; }
    }
}
