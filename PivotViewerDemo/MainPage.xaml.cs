using System.Windows.Controls.Pivot;

namespace PivotViewerDemo
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.pivotViewer.ItemsSource = Factory.GetData();
        }

        private void GetCommands(object sender, PivotViewerCommandsRequestedEventArgs e)
        {
            e.Commands.Add(new AdornerCommand(e.Item as Price));
        }
    }
}
