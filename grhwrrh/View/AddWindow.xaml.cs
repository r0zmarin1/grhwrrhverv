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
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        private readonly ObservableCollection<object> items;

        public AddWindow(System.Collections.ObjectModel.ObservableCollection<object> items)
        {
            InitializeComponent();
            DataContext = this;
            this.items = items;
        }

        private void GpuAdd(object sender, RoutedEventArgs e)
        {
            WindowNewGPU windowNewGPU = new WindowNewGPU(items);
            windowNewGPU.ShowDialog();
            items.Add(windowNewGPU.GPU);
        }

        private void CpuAdd(object sender, RoutedEventArgs e)
        {
            WindowNewCPU windowNewCPU = new WindowNewCPU(items);
            windowNewCPU.ShowDialog();
            items.Add(windowNewCPU.CPU);

        }

        private void RAMAdd(object sender, RoutedEventArgs e)
        {
            WindowNewRAM windowNewRAM = new WindowNewRAM(items);
            windowNewRAM.ShowDialog();
            items.Add(windowNewRAM.RAM);
        }

        private void MomAdd(object sender, RoutedEventArgs e)
        {
            WindowNewMom windowNewMom = new WindowNewMom(items);
            windowNewMom.ShowDialog();
            items.Add(windowNewMom.Mom);
        }

    }
}
