using GalaSoft.MvvmLight;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Tools;

namespace ViewModel
{
    public class CinemaViewModel : AViewModel
    {
        private ObservableCollection<CinemaItem> _cinemas;
        public ObservableCollection<CinemaItem> Cinemas
        {
            get { return _cinemas; }
            set
            {
                this._cinemas = value;
                this.RaisePropertyChanged();
            }
        }
        public CinemaViewModel() 
        {
            LoadCinemas();
            this.Import = new ActionCommand(OnImport, param => { return true; });
            this.CreateFiles = new ActionCommand(OnCreateFiles, param => { return true; });
        }

        private void LoadCinemas()
        {
            IEnumerable<CinemaItem> l_cinemas = DataManagerFactory.Instance.LoadCinemas() as IEnumerable<CinemaItem>;
            this.Cinemas = new ObservableCollection<CinemaItem>(l_cinemas);
        }

        protected override void OnImport(object parameter)
        {
            using (OpenFileDialog l_openFileDialog = new OpenFileDialog())
            {
                l_openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

                if (l_openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }

        protected override void OnCreateFiles(object parameter)
        {

        }
    }
}
