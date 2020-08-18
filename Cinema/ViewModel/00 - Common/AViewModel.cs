using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public abstract class AViewModel : ViewModelBase
    {
        private ICommand _import;
        public ICommand Import
        {
            get { return this._import; }
            set
            {
                this._import = value;
                this.RaisePropertyChanged();
            }
        }

        private ICommand _createFiles;
        public ICommand CreateFiles
        {
            get { return this._createFiles; }
            set
            {
                this._createFiles = value;
                this.RaisePropertyChanged();
            }
        }

        #region methode abstract

        protected abstract void OnImport(object parameter);

        protected abstract void OnCreateFiles(object parameter);
        #endregion
    }
}
