using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace grhwrrh
{
    /// <summary>
    /// Логика взаимодействия для WindowNewCPU.xaml
    /// </summary>
    public partial class WindowNewCPU : Window
    {
        private readonly ObservableCollection<object> items;

        public CPU CPU { get; set; } = new CPU();

        public WindowNewCPU(System.Collections.ObjectModel.ObservableCollection<object> items)
        {
            InitializeComponent();
            DataContext = this;
            this.items = items;

        }

      
    }
}
