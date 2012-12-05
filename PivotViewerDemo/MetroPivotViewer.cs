using System;
using System.ComponentModel;
using System.Windows.Controls.Pivot;
using System.Windows.Threading;

namespace PivotViewerDemo
{
    public class MetroPivotViewer : PivotViewer, INotifyPropertyChanged
    {
        private readonly UiHelper layoutUpdatedFinished;

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (title == value) return;
                title = value;
                NotifyPropertyChanged("Title");
            }
        }

        private bool isLoading;
        public bool IsLoading
        {
            get { return isLoading; }
            set
            {
                if (isLoading == value) return;
                isLoading = value;
                NotifyPropertyChanged("IsLoading");
            }
        }

        public MetroPivotViewer()
        {
            layoutUpdatedFinished = new UiHelper();
            IsLoading = true;

            this.StateSynchronizationFinished += MetroPivotViewer_StateSynchronizationFinished;
            this.LayoutUpdated += MetroPivotViewer_LayoutUpdated;
        }

        void MetroPivotViewer_LayoutUpdated(object sender, EventArgs e)
        {
            layoutUpdatedFinished.Reset();
        }

        void MetroPivotViewer_StateSynchronizationFinished(object sender, EventArgs e)
        {
            layoutUpdatedFinished.SetTimeout(300, () =>
            {
                IsLoading = false;
                this.View = this.GraphView;
                NotifyItemsLoaded();
            });
        }

        public event EventHandler ItemsLoaded;
        public void NotifyItemsLoaded()
        {
            if (ItemsLoaded != null)
                ItemsLoaded(this, null);
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        #endregion

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }
    }

    public class UiHelper
    {
        private readonly DispatcherTimerContainingAction timer;

        public UiHelper()
        {
            timer = new DispatcherTimerContainingAction();
        }

        public void SetTimeout(int milliseconds, Action action)
        {
            timer.Interval = new TimeSpan(0, 0, 0, 0, milliseconds);
            timer.Action = action;
            timer.Tick += OnTimeout;
            timer.Start();
        }

        public void Reset()
        {
            timer.Stop();
            timer.Start();
        }

        private void OnTimeout(object sender, EventArgs arg)
        {
            timer.Stop();
            timer.Tick -= OnTimeout;
            timer.Action();
        }
    }

    public class DispatcherTimerContainingAction : DispatcherTimer
    {
        public Action Action { get; set; }
    }
 
}
