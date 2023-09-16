using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Exepciones
{
    public class ExceptionManager
    {
        #region Singleton
        private readonly static ExceptionManager _instance = new ExceptionManager();

        public static ExceptionManager Current
        {
            get
            {
                return _instance;
            }
        }

        private ExceptionManager()
        {
            //Implement here the initialization code
        }
        #endregion

        public void Handle(Exception ex)
        {
            LoggerBLL.WriteLog(ex.InnerException.Message,System.Diagnostics.Tracing.EventLevel.Warning,"");
            Console.WriteLine("Ocurrio un error inesperado");
        }
    }
}
