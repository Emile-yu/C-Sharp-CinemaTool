using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Tools;

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

        private ICommand _showCinemas;
        public ICommand ShowCinemas
        {
            get { return this._showCinemas; }
            set
            {
                this._showCinemas = value;
                this.RaisePropertyChanged();
            }
        }

        private ICommand _showFilms;
        public ICommand ShowFilms
        {
            get { return this._showFilms; }
            set
            {
                this._showFilms = value;
                this.RaisePropertyChanged();
            }
        }


        public MainViewModel()
        {
            this.ShowCinemas = new ActionCommand(OnShowCinemas);

            this.ShowFilms = new ActionCommand(OnShowFilms);
        }

        private void OnShowCinemas(object parameter)
        {
            IDocumentViewProvider _view;
            DocumentViewProviderFactory.Instance.Providers.TryGetValue(ViewType.Cinenma, out _view);
            if (_view != null)
            {
                ActiveView = _view.View;
            }
        }

        private void OnShowFilms(object parameter)
        {
            IDocumentViewProvider _view;
            DocumentViewProviderFactory.Instance.Providers.TryGetValue(ViewType.Film, out _view);
            if (_view != null)
            {
                ActiveView = _view.View;
            }
        }
    }
}
