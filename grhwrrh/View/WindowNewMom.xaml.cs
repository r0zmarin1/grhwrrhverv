﻿using grhwrrh.Model.DTO;
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
    /// Логика взаимодействия для WindowNewMom.xaml
    /// </summary>
    public partial class WindowNewMom : Window
    {    
        public Mom NewMom { get; set; } = new();
        public WindowNewMom()
        {
            InitializeComponent();
            DataContext = this; 

        }
      
    }
}
