using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Exepciones
{
    public class UIException : Exception
    {
        #region Singleton
        private readonly static UIException _instance = new UIException();

        public static UIException Current
        {
            get
            {
                return _instance;
            }
        }

        private UIException()
        {
            //Implement here the initialization code
        }
        #endregion
        public UIException(String message) : base(message)
        {

        }
    }
}
