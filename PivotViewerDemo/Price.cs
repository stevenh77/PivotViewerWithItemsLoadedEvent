using System;
using System.ComponentModel;
using System.Windows.Media;

namespace PivotViewerDemo
{
    // Our Price object implements INPC which means it can react to data changes.  
    //  INPC could be removed to potentially improve performance.
    public class Price : INotifyPropertyChanged
    {
        private int barrier;
        public int Barrier
        {
            get { return barrier; }
            set { barrier = value; NotifyProperty("Barrier"); }
        }

        private decimal couponToday;
        public decimal CouponToday
        {
            get { return couponToday; }
            set { couponToday = value; NotifyProperty("CouponToday"); }
        }
        
        private string currency;
        public string Currency
        {
            get { return currency; }
            set { currency = value; NotifyProperty("Currency"); }
        }

        private string maturity;
        public string Maturity
        {
            get { return maturity; }
            set { maturity = value; NotifyProperty("Maturity"); }
        }

        private string sector;
        public string Sector
        {
            get { return sector; }
            set { sector = value; NotifyProperty("Sector"); }
        }

        private ValueSortByCoupon sectorSort;
        public ValueSortByCoupon SectorSort
        {
            get { return sectorSort ?? (sectorSort = new ValueSortByCoupon(Sector, CouponToday)); }
        }

        private string underlying;
        public string Underlying
        {
            get { return underlying; }
            set { underlying = value; NotifyProperty("Underlying"); }
        }

        public SolidColorBrush MaturityColour
        {
            get
            {
                switch (Maturity)
                {
                    case "3M":
                        return YellowBrush;

                    case "6M":
                        return BlueBrush;

                    case "12M":
                        return GreenBrush;

                    default:
                        return WhiteBrush;
                }
            }
        }

        public static SolidColorBrush YellowBrush = new SolidColorBrush(Color.FromArgb(220, 249, 169, 56));
        public static SolidColorBrush BlueBrush = new SolidColorBrush(Color.FromArgb(220, 89, 171, 195));
        public static SolidColorBrush GreenBrush = new SolidColorBrush(Color.FromArgb(220, 81, 163, 81));
        public static SolidColorBrush WhiteBrush = new SolidColorBrush(Colors.White);

        public override string ToString()
        {
            return string.Format("Barrier: {0}, CouponToday: {1}, Currency: {2}, Maturity: {3}, Sector: {4}, Underlying: {5}", barrier, couponToday, currency, maturity, sector, underlying);
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyProperty(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        #endregion
    }

public class ValueSortByCoupon : IComparable
{
    private string Value { get; set; }
    private decimal Coupon { get; set; }

    public ValueSortByCoupon(string sector, decimal coupon)
    {
        this.Value = sector;
        this.Coupon = coupon;
    }

    public int CompareTo(object rhs)
    {
        var other = (ValueSortByCoupon)rhs;
        var result = this.Value == other.Value
                    ? other.Coupon.CompareTo(this.Coupon)
                    : this.Value.CompareTo(other.Value);
        return result;
    }

    public override string ToString()
    {
        return Value;
    }
}
}