using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace Tools
{
    public class ConfigManager
    {
        private static String _fileConfig = @".\Config.xml";

        #region the sigleton
        private static ConfigManager _instance;
        public static ConfigManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConfigManager();
                }
                return _instance;
            }
        }
        #endregion

        #region properties public

        public String DataPath { get; private set; }

        #endregion

        private ConfigManager()
        {
            Deserialize();
        }

        private void Deserialize()
        {
            if (!File.Exists(_fileConfig))
            {
                MessageBox.Show("Fichier de configuration {0} non présent", _fileConfig);
            }
            try
            {
                using (var reader = new StreamReader(_fileConfig))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(config));
                    config _config = (config)serializer.Deserialize(reader);
                    if (_config.path != null)
                    {
                        this.DataPath = _config.path.datapath;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
