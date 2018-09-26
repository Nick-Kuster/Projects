using FriendOrganizer.Ui.ViewModels;
using System;
using System.Windows;

namespace FriendOrganizer.Ui
{
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
            Loaded += MainWindow_loaded;
        }

        private async void MainWindow_loaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadAsync();
        }
    }
}
