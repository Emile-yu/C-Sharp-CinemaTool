using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum DataType
    {
        None,
        Cinema,
        Film
    };

    public class DataManagerFactory
    {
        private static String _outputDirectory = "UtilsOutput";

        #region singleton
        private static DataManagerFactory _instance = null;
        public static DataManagerFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataManagerFactory();
                }
                return _instance;
            }
        }
        #endregion

        #region private members

        private CinemaDataManager _cinemaDataManager;

        private Dictionary<DataType, IEnumerable<AItem>> Provider;

        #endregion

        #region constructor
        public DataManagerFactory()
        {
            _cinemaDataManager = new CinemaDataManager(_outputDirectory);

            Provider = new Dictionary<DataType, IEnumerable<AItem>>();
        }
        #endregion

        public IEnumerable<AItem> LoadCinemas()
        {
            IEnumerable<AItem> l_cinemas;
            Provider.TryGetValue(DataType.Cinema, out l_cinemas);
            if (l_cinemas == null)
            {
                l_cinemas = _cinemaDataManager.Load();
                Provider.Add(DataType.Cinema, l_cinemas);
            }
            return l_cinemas;
        }
    }
}
