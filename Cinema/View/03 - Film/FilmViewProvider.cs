﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ViewModel;

namespace View
{
    public class FilmViewProvider : IDocumentViewProvider
    {
        public UserControl View { get { return new FilmView(); } }
    }
}
