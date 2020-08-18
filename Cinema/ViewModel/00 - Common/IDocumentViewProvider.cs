using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ViewModel
{
    public enum ViewType
    {
        None,
        Cinenma,
        Film
    };

    public interface IDocumentViewProvider
    {
        UserControl View { get; }
    }
}
