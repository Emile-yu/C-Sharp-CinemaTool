using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class DocumentViewProviderFactory
    {
        #region member public

        public Dictionary<ViewType, IDocumentViewProvider> Providers { get; private set; }

        #endregion

        #region member static
        private static DocumentViewProviderFactory _instance = null;
        public static DocumentViewProviderFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DocumentViewProviderFactory();
                }
                return _instance;
            }
        }
        #endregion

        #region constructor
        private DocumentViewProviderFactory()
        {
            Providers = new Dictionary<ViewType, IDocumentViewProvider>();
        }
        #endregion


    }
}
