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

namespace SPDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var units = new List<Unit>
            {
                new()
                {
                    Name = "Производство кондитерское КФ Шелен", Units = new List<Unit>
                    {
                        new() { Name = "Склад ГП кондитерский заморозка КФ Шелен" },
                        new() { Name = "Склад ГП кондитерский основной КФ Шелен" },
                        new() { Name = "Склад материалов Кондитерский цех КФ Шелен" },
                        new() { Name = "Склад сырья Кондитерский КФ Шелен" },
                        new() { Name = "Цех Кондитерский КФ Шелен" }
                    }
                },

                new()
                {
                    Name = "Производство кулинарное КФ Шелен", Units = new List<Unit>
                    {
                        new() { Name = "Склад ГП  кулинарный заморозка КФ Шелен" },
                        new() { Name = "Склад ГП  кулинарный охлаждёнка КФ Шелен" },
                        new() { Name = "Склад материалов Кулинарный цех КФ Шелен" },
                        new() { Name = "Склад сырья Кулинарный КФ Шелен" },
                    }
                },

                new()
                {
                    Name = "Производство мясное КФ Шелен", Units = new List<Unit>
                    {
                        new() { Name = "Склад ГП мяса птицы основной КФ Шелен" },
                        new() { Name = "Склад ГП мяса птицы транзит КФ Шелен" },
                        new() { Name = "Склад ГП мясной охлажденка КФ Шелен" },
                        new() { Name = "Склад ГП мясной заморозка КФ Шелен" },
                        new() { Name = "Склад ГП рыбный охлажденка КФ Шелен" },
                        new() { Name = "Склад материалов Мясной цех КФ Шелен" },
                        new() { Name = "Склад сырья мяса птицы основной КФ Шелен" },
                        new() { Name = "Склад сырья мяса птицы специи КФ Шелен" },
                        new() { Name = "Склад сырья мясной КФ Шелен" },
                        new() { Name = "Склад сырья мясной специи КФ Шелен" },
                        new() { Name = "Цех мяса птицы КФ Шелен" },
                        new() { Name = "Цех мясной КФ Шелен" },
                    }
                },
                new()
                {
                    Name = "Производство пекарное КФ Шелен", Units = new List<Unit>
                    {
                        new() { Name = "Склад ГП пекарный дополнительный КФ Шелен" },
                        new() { Name = "Склад ГП пекарный основной КФ Шелен" },
                        new() { Name = "Склад материалов Цех пекарный КФ Шелен" },
                        new() { Name = "Склад сырья пекарный КФ Шелен" },
                        new() { Name = "Цех пекарный КФ Шелен" },
                    }
                },
            };


            var units2 = new List<Unit>
            {
                new() { Name = "Склад ГП пекарный дополнительный КФ Шелен" },
                new() { Name = "Склад ГП пекарный основной КФ Шелен" },
                new() { Name = "Склад материалов Цех пекарный КФ Шелен" },
                new() { Name = "Склад сырья пекарный КФ Шелен" },
                new() { Name = "Цех пекарный КФ Шелен" },
            };

            var units3 = new List<Unit>
            {
                new() { Name = "Склад ГП пекарный дополнительный КФ Шелен" },
                new() { Name = "Склад ГП пекарный основной КФ Шелен" },
                new() { Name = "Склад материалов Цех пекарный КФ Шелен" },
                new() { Name = "Склад сырья пекарный КФ Шелен" },
                new() { Name = "Цех пекарный КФ Шелен" },
            };

            var routePoints = new List<RoutePoint>
            {
                new() { Name = "К57", Gln = new Gln { Base = "1234 5678 1257", Child = "" } },
                new() { Name = "К58", Gln = new Gln { Base = "1234 5678 1258", Child = "" } },
                new() { Name = "К317", Gln = new Gln { Base = "1234 5678 1317", Child = "" } },
                new() { Name = "К112", Gln = new Gln { Base = "1234 5678 1112", Child = "" } },
            };

            var routePoints2 = new List<RoutePoint>
            {
                new() { Name = "К57", Gln = new Gln { Base = "1234 5678 1257", Child = "" } },
                new() { Name = "К58", Gln = new Gln { Base = "1234 5678 1258", Child = "" } },
                new()
                {
                    Name = "К58 цех пекарный", Gln = new Gln { Base = "1234 5678 1235", Child = "3421 5678 0058" }
                },
                new()
                {
                    Name = "К58 цех кулинарный", Gln = new Gln { Base = "1234 5678 1235", Child = "3421 5678 0058" }
                },
            };

            var routes = new List<Route>
            {
                new() { Name = "Рейс СП 0001", RoutePoints = routePoints, Units = units },
                new()
                {
                    Name = "Рейс СП 0002", RoutePoints = routePoints2,
                    Units = new List<Unit> { new() { Name = "Все пандусы", Units = units2 } }
                },
                new()
                {
                    Name = "Рейс СП 0003", RoutePoints = routePoints,
                    Units = new List<Unit> { new() { Name = "Все пандусы", Units = units3 } }
                },
                new() { Name = "Рейс СП 0004", RoutePoints = routePoints, Units = units },
                new() { Name = "Рейс СП 0005", RoutePoints = routePoints, Units = units },
            };

            RoutesComboBox.ItemsSource = routes;
            RoutesComboBox.SelectedIndex = 0;
        }

        private void RoutesComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cb = (ComboBox)sender;
            var selectedRoute = (Route)cb.SelectedItem;
            PointsListView.ItemsSource = selectedRoute.RoutePoints;
            TextBoxInstalledSeal.Text = selectedRoute.InstalledSeal;

            UnitsTreeView.Visibility = Visibility.Hidden;
            ContainerQuantityDataGrid.Visibility = Visibility.Hidden;
            ButtonSave.Visibility = Visibility.Hidden;
        }

        private void PointsListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedRoute = (Route)RoutesComboBox.SelectedItem;
            UnitsTreeView.ItemsSource = selectedRoute.Units;

            UnitsTreeView.Visibility = Visibility.Visible;
            ContainerQuantityDataGrid.Visibility = Visibility.Hidden;
            ButtonSave.Visibility = Visibility.Hidden;
        }

        private void ButtonSave_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var unit = UnitsTreeView.SelectedItem as Unit;
                unit.ContainerList = ContainerQuantityDataGrid.ItemsSource as List<ContainerQuantity>;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void ButtonCreate_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedRoute = (Route)RoutesComboBox.SelectedItem;
            selectedRoute.InstalledSeal = TextBoxInstalledSeal.Text;
            MessageBox.Show("ЭТрН созданы");
        }

        private void UnitsTreeView_OnSelectionChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            try
            {
                var unit = UnitsTreeView.SelectedItem as Unit;
                var containers = new List<Container>
                {
                    new() { Name = "Ведро" },
                    new() { Name = "Посылка" },
                    new() { Name = "Коробка" }
                };

                try
                {
                    var cl = unit.ContainerList ??
                             containers.Select(container => new ContainerQuantity { Container = container }).ToList();
                    ContainerQuantityDataGrid.ItemsSource = cl;
                    ContainerQuantityDataGrid.Visibility = Visibility.Visible;
                    ButtonSave.Visibility = Visibility.Visible;
                }
                catch (NullReferenceException exception)
                {
                    Console.WriteLine(exception);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}