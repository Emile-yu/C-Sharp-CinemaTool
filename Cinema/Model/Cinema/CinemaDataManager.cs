using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Tools;

namespace Model
{
    public class CinemaDataManager : ADataManager
    {
        private static String _parcFile = "parc_carthage.csv";

        private String[] _parcHeader;
        #region constructor
        public CinemaDataManager(String outputDirectory) : base(outputDirectory)
        {
           
        }
        #endregion

        public override IEnumerable<AItem> Load()
        {
            List<CinemaItem> l_cinemas = new List<CinemaItem>();
            
            // check the parc file
            String l_parcFilePath = Path.Combine(ConfigManager.Instance.DataPath, _parcFile);
            if (!File.Exists(l_parcFilePath))
            {
                MessageBox.Show(String.Format("Le fichier {0} n'existe pas", l_parcFilePath));
                return null;
            }

            // gets the last week name
            String l_lastWeekName = this.GetLastWeekName();

            // check the cinema file
            String l_cinemaFilePath = Path.Combine(ConfigManager.Instance.DataPath, String.Format("Cinema{0}.csv", l_lastWeekName));
            if (!File.Exists(l_cinemaFilePath))
            {
                MessageBox.Show(String.Format("Le fichier {0} n'existe pas", l_cinemaFilePath));
                return null;
            }

            // check the cinema list file
            String l_cinemaListFilePath = Path.Combine(ConfigManager.Instance.DataPath, String.Format("ListeCinema{0}.csv", l_lastWeekName));
            if (!File.Exists(l_cinemaListFilePath))
            {
                MessageBox.Show(String.Format("Le fichier {0} n'existe pas", l_cinemaListFilePath));
                return null;
            }

            IEnumerable<String[]> l_lines = null;

            // gets the parc lines
            try
            {
                l_lines = File.ReadAllLines(l_parcFilePath, Encoding.GetEncoding("iso-8859-1")).Select(l => l.Split(';'));
            }
            catch (Exception)
            {
                MessageBox.Show(String.Format("Erreur de lecture du fichier {0}. Il est peut-être ouvert.", l_parcFilePath));
            }
            if (l_lines != null)
            {
                // loads the cinemas
                Int32 l_lineIdx = 0;
                foreach (String[] l_line in l_lines)
                {
                    // the first line is the header
                    if (l_lineIdx == 0)
                        this._parcHeader = l_line;
                    else
                    {
                        CinemaItem l_cinema = new CinemaItem();
                        if (!l_cinema.LoadFromParcLine(l_line))
                        {
                            MessageBox.Show("Format du cinéma depuis le parc invalide");
                            return null;
                        }

                        l_cinemas.Add(l_cinema);
                    }

                    l_lineIdx++;
                }
            }

            // gets the cinemas lines
            try
            {
                l_lines = File.ReadAllLines(l_cinemaFilePath, Encoding.GetEncoding("iso-8859-1")).Select(l => l.Split(';'));
            }
            catch (Exception)
            {
                MessageBox.Show(String.Format("Erreur de lecture du fichier {0}. Il est peut-être ouvert.", l_cinemaFilePath));
            }
            if (l_lines != null)
            {
                // updates the cinemas
                Int32 l_lineIdx = 0;
                foreach (String[] l_line in l_lines)
                {
                    // gets the rentrak code
                    Int32 l_rentrakCode = 0;
                    if (!Int32.TryParse(l_line[0], out l_rentrakCode))
                    {
                        MessageBox.Show(String.Format("Format du cinéma de la ligne {0} depuis le fichier {1} invalide", l_lineIdx + 1, l_cinemaFilePath));
                        return null;
                    }

                    // look for the cinema in the parc
                    CinemaItem l_cinema = l_cinemas.Where(c => c.RentrakCode == l_rentrakCode).FirstOrDefault();
                    if (l_cinema == null)
                    {
                        //MessageBox.Show(String.Format("Le cinéma {0} n'existe pas dans le parc", l_rentrakCode));
                        l_cinema = new CinemaItem();
                        l_cinema.RentrakCode = l_rentrakCode;

                        l_cinemas.Add(l_cinema);
                    }

                    // updates the cinema
                    if (!l_cinema.UpdateFromCinemaLine(l_line, l_lineIdx))
                    {
                        MessageBox.Show(String.Format("Format du cinéma de la ligne {0} depuis le fichier {1} invalide", l_lineIdx + 1, l_cinemaFilePath));
                        return null;
                    }

                    l_lineIdx++;
                }
            }

            // gets the cinemas list lines
            try
            {
                l_lines = File.ReadAllLines(l_cinemaListFilePath, Encoding.GetEncoding("iso-8859-1")).Select(l => l.Split(';'));
            }
            catch (Exception)
            {
                MessageBox.Show(String.Format("Erreur de lecture du fichier {0}. Il est peut-être ouvert.", l_cinemaListFilePath));
            }
            if (l_lines != null)
            {
                // updates the cinemas
                Int32 l_lineIdx = 0;
                foreach (String[] l_line in l_lines)
                {
                    // gets the rentrak code
                    Int32 l_rentrakCode = 0;
                    if (!Int32.TryParse(l_line[0], out l_rentrakCode))
                    {
                        MessageBox.Show(String.Format("Format du cinéma de la ligne {0} depuis le fichier {1} invalide", l_lineIdx + 1, l_cinemaListFilePath));
                        return null;
                    }

                    // look for the cinema in the parc
                    CinemaItem l_cinema = l_cinemas.Where(c => c.RentrakCode == l_rentrakCode).FirstOrDefault();
                    if (l_cinema == null)
                    {
                        //MessageBox.Show(String.Format("Le cinéma {0} n'existe pas dans le parc", l_rentrakCode));
                        l_cinema = new CinemaItem();
                        l_cinema.RentrakCode = l_rentrakCode;

                        l_cinemas.Add(l_cinema);
                    }

                    // updates the cinema
                    if (!l_cinema.UpdateFromCinemaListLine(l_line, l_lineIdx))
                    {
                        MessageBox.Show(String.Format("Format du cinéma de la ligne {0} depuis le fichier {1} invalide", l_lineIdx + 1, l_cinemaFilePath));
                        return null;
                    }

                    l_lineIdx++;
                }
            }

            return l_cinemas;
        }

        public override bool CreateFiles(IEnumerable<AItem> cinemas)
        {
            return true;
        }

        public override IEnumerable<AItem> ImportCinemas(IEnumerable<AItem> sourceCinemas, String filename)
        {
            List<CinemaItem> l_cinemas = new List<CinemaItem>();
            return l_cinemas;
        }
    }
}
