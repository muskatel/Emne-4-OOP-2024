﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibraryInsideExisting;

namespace WpfApp1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    NumberCruncher nc;
    public MainWindow()
    {
        InitializeComponent();
        NumberCruncher nc = new NumberCruncher(37, 109);
        TextBlock b = new TextBlock();
        b.Text = nc.Output().ToString();
    }
}