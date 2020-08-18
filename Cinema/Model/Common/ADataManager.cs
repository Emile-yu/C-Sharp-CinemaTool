using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace Model
{
    public abstract class ADataManager
    {
        protected String _outputDirectory;

        #region abstract fonctions

        public abstract IEnumerable<AItem> Load();

        public abstract bool CreateFiles(IEnumerable<AItem> cinemas);

        public abstract IEnumerable<AItem> ImportCinemas(IEnumerable<AItem> sourceCinemas, String filename);

        #endregion
        #region constructor
        public ADataManager(String outputDirectory)
        {
            this._outputDirectory = outputDirectory;
        }
        #endregion
        protected String GetLastWeekName()
        {
            String[] l_files = Directory.GetFiles(ConfigManager.Instance.DataPath, "Cinema??S??.csv");
            if (l_files == null || !l_files.Any())
                return null;

            Int32 l_year = 0, l_week = 0;
            foreach (String l_filePath in l_files)
            {
                String l_filename = Path.GetFileNameWithoutExtension(l_filePath);
                String l_weekName = l_filename.Replace("Cinema", String.Empty);

                String[] l_split = l_weekName.Split('S');
                if (l_split.Count() == 2)
                {
                    Int32 l_tmpYear = 0, l_tmpWeek = 0;
                    if (Int32.TryParse(l_split[0], out l_tmpYear) && Int32.TryParse(l_split[1], out l_tmpWeek))
                    {
                        if (l_tmpYear > l_year)
                        {
                            l_year = l_tmpYear;
                            l_week = l_tmpWeek;
                        }
                        else if (l_tmpYear == l_year && l_tmpWeek > l_week)
                            l_week = l_tmpWeek;
                    }
                }
            }

            return (l_year > 0 && l_week > 0 ? String.Format("{0}S{1}", l_year, l_week) : null);
        }

    }
}
