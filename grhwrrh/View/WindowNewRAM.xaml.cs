using grhwrrh.Model.DTO;
using grhwrrh.ViewModel;
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
        public RAM NewRAM {  get; set; }
        public WindowNewRAM()
        {
            InitializeComponent();
            DataContext = this;
        }
      
    }
}
