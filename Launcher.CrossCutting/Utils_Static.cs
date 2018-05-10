using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Launcher.CrossCutting
{
    public static class Utils_Static
    {
        public static void RunInvoke<T>(this T sender, Action<T> acao) where T : Control
        {
            if (sender.InvokeRequired)
            {
                sender.BeginInvoke((MethodInvoker)delegate
                {
                    acao(sender);
                });
            }
            else
            {
                acao(sender);
            }
        }

        public static string GetDescription(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
}

