using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using View;
using ViewModel;

namespace CinemaTool
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            InitilizeView();

            this.StartupUri = new Uri("pack://application:,,,/View;component/01 - Main/MainView.xaml");
        }

        private void InitilizeView()
        {
            DocumentViewProviderFactory.Instance.Providers.Add(ViewType.Cinenma, new CinemaViewProvider());

            DocumentViewProviderFactory.Instance.Providers.Add(ViewType.Film, new FilmViewProvider());
        }
    }
}
