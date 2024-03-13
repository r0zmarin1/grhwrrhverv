using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace grhwrrh.ViewModel
{
    public class MainWindowVM : BaseVM
    {
        public ObservableCollection<object> Items { get; set; } = new();


    }

}
