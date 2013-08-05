﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OnlineRadio.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Source> sources;

        public MainWindow()
        {
            InitializeComponent();

            sources = new ObservableCollection<Source>();
            SelectSourceCombo.ItemsSource = sources;
        }

        private void PlaySourceBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StopSourceBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddSourceBtn_Click(object sender, RoutedEventArgs e)
        {
            SourceWindow window = new SourceWindow();
            window.Owner = this;
            window.Title = "Add new source";
            if (window.ShowDialog() == true)
            {
                sources.Add(window.SourceResult);
            }
        }

        private void EditSourceBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveSourceBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}