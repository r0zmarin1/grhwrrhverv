using System.IO;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace grhwrrh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<object> Items { get; set; } = new();
        public MainWindow()
        {
            InitializeComponent();
            Items.Add(new PPK { Name = "RTX3060", Description = "короче ваще классная жесть", Price = 40002, Image = File.ReadAllBytes("1.jpg") });
            DataContext = this;
        }

        

    }}