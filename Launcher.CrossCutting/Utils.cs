using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using Launcher.CrossCutting.Config;
using System.Windows.Forms;

namespace Launcher.CrossCutting
{
    public class Utils
    {
        /// <summary>
        /// Responsável por baixar uma imagem, passando a URL como parâmetro
        /// </summary>
        /// <param name="url">URL da imagem</param>
        /// <returns></returns>
        public Image DownloadImage(string url)
        {
            Image retorno;

            using (var wc = new WebClient())
            {
                using (var imgStream = new MemoryStream(wc.DownloadData(url)))
                {
                    var objImage = Image.FromStream(imgStream);
                    retorno = objImage;

                }
            }

            return retorno;
        }

        /// <summary>
        /// Responsável por retornar o código-fonte HTML de uma URL
        /// </summary>
        /// <param name="url">URL de destino</param>
        /// <returns></returns>
        public string DownloadStringByURL(string url)
        {
            string retorno;

            using (var wc = new WebClient())
            {
                retorno = wc.DownloadString(url);
            }

            return retorno;
        }

        /// <summary>
        /// Responsável por baixar um arquivo
        /// </summary>
        /// <param name="url">URL do arquivo</param>
        /// <param name="fileName">Nome do arquivo que será criado</param>
        /// <param name="view">Quando esse parâmetro é informado, o download é assíncrono e interage com a progressBarInfo e a labelInfo</param>
        public void DownloadFileByURL(string url, string fileName, IView view = null)
        {
            using (var wc = new WebClient())
            {
                if (view == null)
                {
                    wc.DownloadFile(url, fileName);
                }
                else
                {
                    wc.DownloadProgressChanged += view.DownloadProgressChangedEventHandler;
                    wc.DownloadFileCompleted += view.DownloadFileCompletedEventHandler;
                    wc.DownloadFileAsync(new Uri(url), fileName);
                }

            }
        }
    }
}
