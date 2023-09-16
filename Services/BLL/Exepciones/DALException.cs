using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Exepciones
{
    public class DALException : Exception
    {
        #region Singleton
        private readonly static DALException _instance = new DALException();


        public static DALException Current
        {
            get
            {
                return _instance;
            }
        }

        #endregion


        public DALException(bool IsBusinessException = false)
        {
            this.IsDALException = IsBusinessException;
        }

        public DALException(string message, bool IsBusinessException = false) : base(message)
        {
            this.IsDALException = IsBusinessException;
        }


        public bool IsDALException { get; private set; }
        public DALException(Exception ex) : base("DAL Exception", ex)
        {

        }
        public DALException(string message, Exception ex, bool IsDALException = false) : base(message, ex)
        {
            this.IsDALException = IsDALException;
        }
    }
}