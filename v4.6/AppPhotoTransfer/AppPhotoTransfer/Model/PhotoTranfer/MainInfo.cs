using AppPhotoTransfer.EnumTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPhotoTransfer.Model.PhotoTranfer
{
    class MainInfo
    {
        #region [DELEGATES]
        public delegate void DelegateEscreverConsoleLog(string text, TipoConsoleLog tipoConsoleLog, bool gravarLog = false, string nomeProcesso = "", Exception exception = null);
        public DelegateEscreverConsoleLog EscreverConsoleLog { get; set; }
        #endregion

        private MainInfo() { }

        public static MainInfo FCInfo()
        {
            return CriaInstancia.instancia;
        }

        private class CriaInstancia
        {
            internal static readonly MainInfo instancia = new MainInfo();
        }
    }
}
