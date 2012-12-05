using System;
using System.Windows;
using System.Windows.Controls.Pivot;

namespace PivotViewerDemo
{
    public class AdornerCommand : IPivotViewerUICommand
    {
        private readonly Price price;

        public AdornerCommand(Price price)
        {
            this.price = price;
        }

        #region IPivotViewerUICommand

        public string DisplayName
        {
            get { return "Book price"; }
        }

        public Uri Icon
        {
            get { return null; }
        }

        public object ToolTip
        {
            get { return "Click this to book the price"; }
        }

        #endregion

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            MessageBox.Show(string.Format("Boom!{0}{0}{1}", Environment.NewLine, price.ToString()));
        }
    }
}
