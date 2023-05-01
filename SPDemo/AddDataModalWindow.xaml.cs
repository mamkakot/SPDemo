using System.Windows;

namespace SPDemo;

public partial class AddDataModalWindow : Window
{
    public AddDataModalWindow(ETrN eTrN)
    {
        InitializeComponent();

        InstalledSealTextBox.Text = eTrN.Route.InstalledSeal;
        var sas = eTrN.Route.RoutePoints.Find(point => point.Gln.Base.Equals(eTrN.RoutePoint.Gln.Base));
        ContainerQuantityDataGrid.ItemsSource = sas.ContainerList;
    }
}