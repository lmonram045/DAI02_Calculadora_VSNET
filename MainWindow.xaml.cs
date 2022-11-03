﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EjemploDAM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String operando1;
        private String operando2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BotonCE_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Content = "0";
            operando1 = "0";
        }

        private void BotonC_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Content = "0";
        }

        private void Boton1_Click(object sender, RoutedEventArgs e)
        {
            if (Pantalla.Content.Equals("0"))
            {
                Pantalla.Content = "1";
            }
            else
            {
                Pantalla.Content += "1";
            }
        }
    }
}
