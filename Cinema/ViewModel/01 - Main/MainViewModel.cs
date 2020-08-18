using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private UserControl _activeView;
        public UserControl ActiveView
        {
            get { return this._activeView; }
            set
            {
                this._activeView = value;
                this.RaisePropertyChanged();
            }
        }


        public MainViewModel()
        {
            IDocumentViewProvider _view;
            DocumentViewProviderFactory.Instance.Providers.TryGetValue(ViewType.Cinenma, out _view);
            if (_view != null)
            {
                ActiveView = _view.View;
            }
        }
    }
}
