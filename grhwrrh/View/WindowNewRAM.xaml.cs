using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace grhwrrh.View
{
    /// <summary>
    /// Логика взаимодействия для WindowNewRAM.xaml
    /// </summary>
    public partial class WindowNewRAM : Window
    {
        private readonly ObservableCollection<object> items;

        public RAM RAM { get; set; } = new RAM();

        public WindowNewRAM(System.Collections.ObjectModel.ObservableCollection<object> items)
        {
            InitializeComponent();
            DataContext = this;
            this.items = items;

        }
      
    }
}
