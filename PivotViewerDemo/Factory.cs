using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PivotViewerDemo
{
    public class Factory
    {
        public static ObservableCollection<Price> GetData()
        {
            var data = Factory.BuildData();
            var filteredList = data.Where(x => x.CouponToday > 0 && (x.Barrier == 60 || x.Barrier == 70 || x.Barrier == 80));
            return new ObservableCollection<Price>(filteredList);
        }

        private static List<Price> BuildData()
        { 
            return new List<Price>() {   
              new Price { 
                Underlying="ABB N",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ABB N",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ABB N",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 1.74
            },
            new Price {
                Underlying="ABB N",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ABB N",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 2.12
            },
            new Price {
                Underlying="ABB N",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 5.73
            },
            new Price {
                Underlying="3M CO",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 2.69
            },
            new Price {
                Underlying="3M CO",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.57
            },
            new Price {
                Underlying="3M CO",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.64
            },
            new Price {
                Underlying="BALOISE HLDG N",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BALOISE HLDG N",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BALOISE HLDG N",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0.34
            },
            new Price {
                Underlying="BALOISE HLDG N",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BALOISE HLDG N",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 2.05
            },
            new Price {
                Underlying="BALOISE HLDG N",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 5.86
            },
            new Price {
                Underlying="ABB N",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 2.74
            },
            new Price {
                Underlying="ABB N",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 5.29
            },
            new Price {
                Underlying="ABB N",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 7.79
            },
            new Price {
                Underlying="RICHEMONT",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="RICHEMONT",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0.41
            },
            new Price {
                Underlying="RICHEMONT",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 5.8
            },
            new Price {
                Underlying="RICHEMONT",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0.93
            },
            new Price {
                Underlying="RICHEMONT",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 4.28
            },
            new Price {
                Underlying="RICHEMONT",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 9.05
            },
            new Price {
                Underlying="ABBOTT LABORATORIES",
                Maturity="12M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 1.41
            },
            new Price {
                Underlying="ABBOTT LABORATORIES",
                Maturity="12M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 2.98
            },
            new Price {
                Underlying="ABBOTT LABORATORIES",
                Maturity="12M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 5.09
            },
            new Price {
                Underlying="CLARIANT N",
                Maturity="3M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="CLARIANT N",
                Maturity="3M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 2.9
            },
            new Price {
                Underlying="CLARIANT N",
                Maturity="3M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 9.72
            },
            new Price {
                Underlying="CLARIANT N",
                Maturity="6M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 3.45
            },
            new Price {
                Underlying="CLARIANT N",
                Maturity="6M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 8.02
            },
            new Price {
                Underlying="CLARIANT N",
                Maturity="6M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 13.09
            },
            new Price {
                Underlying="ACTELION N",
                Maturity="12M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 3.16
            },
            new Price {
                Underlying="ACTELION N",
                Maturity="12M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 6.85
            },
            new Price {
                Underlying="ACTELION N",
                Maturity="12M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 9.87
            },
            new Price {
                Underlying="CS GROUP N",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="CS GROUP N",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 1.83
            },
            new Price {
                Underlying="CS GROUP N",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 8.06
            },
            new Price {
                Underlying="CS GROUP N",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 2.97
            },
            new Price {
                Underlying="CS GROUP N",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 6.88
            },
            new Price {
                Underlying="CS GROUP N",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 11.43
            },
            new Price {
                Underlying="ADECCO N",
                Maturity="12M",
                Barrier= 60,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 7.19
            },
            new Price {
                Underlying="ADECCO N",
                Maturity="12M",
                Barrier= 70,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 10.3
            },
            new Price {
                Underlying="ADECCO N",
                Maturity="12M",
                Barrier= 80,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 12.38
            },
            new Price {
                Underlying="JULIUS BAER GRP N",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="JULIUS BAER GRP N",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="JULIUS BAER GRP N",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 1.81
            },
            new Price {
                Underlying="JULIUS BAER GRP N",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0.27
            },
            new Price {
                Underlying="JULIUS BAER GRP N",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 3.01
            },
            new Price {
                Underlying="JULIUS BAER GRP N",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 7.51
            },
            new Price {
                Underlying="ADIDAS",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 2.67
            },
            new Price {
                Underlying="ADIDAS",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 5.24
            },
            new Price {
                Underlying="ADIDAS",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 7.71
            },
            new Price {
                Underlying="HOLCIM N",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="HOLCIM N",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="HOLCIM N",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 2.01
            },
            new Price {
                Underlying="HOLCIM N",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0.11
            },
            new Price {
                Underlying="HOLCIM N",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 2.35
            },
            new Price {
                Underlying="HOLCIM N",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 6.14
            },
            new Price {
                Underlying="AEGON",
                Maturity="12M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="EUR",
                CouponToday= (decimal) 9.1
            },
            new Price {
                Underlying="AEGON",
                Maturity="12M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="EUR",
                CouponToday= (decimal) 11.61
            },
            new Price {
                Underlying="AEGON",
                Maturity="12M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="EUR",
                CouponToday= (decimal) 13.25
            },
            new Price {
                Underlying="NESTLE N",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="NESTLE N",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="NESTLE N",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="NESTLE N",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="NESTLE N",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="NESTLE N",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0.96
            },
            new Price {
                Underlying="AEX",
                Maturity="12M",
                Barrier= 60,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 1.44
            },
            new Price {
                Underlying="AEX",
                Maturity="12M",
                Barrier= 70,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 3.12
            },
            new Price {
                Underlying="AEX",
                Maturity="12M",
                Barrier= 80,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 5.08
            },
            new Price {
                Underlying="NOVARTIS N",
                Maturity="3M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="NOVARTIS N",
                Maturity="3M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="NOVARTIS N",
                Maturity="3M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="NOVARTIS N",
                Maturity="6M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="NOVARTIS N",
                Maturity="6M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="NOVARTIS N",
                Maturity="6M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 1.08
            },
            new Price {
                Underlying="AIR LIQUIDE",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 2.2
            },
            new Price {
                Underlying="AIR LIQUIDE",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 4.37
            },
            new Price {
                Underlying="AIR LIQUIDE",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 6.63
            },
            new Price {
                Underlying="ADECCO N",
                Maturity="3M",
                Barrier= 60,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 0.55
            },
            new Price {
                Underlying="ADECCO N",
                Maturity="3M",
                Barrier= 70,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 5.49
            },
            new Price {
                Underlying="ADECCO N",
                Maturity="3M",
                Barrier= 80,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 14.37
            },
            new Price {
                Underlying="ADECCO N",
                Maturity="6M",
                Barrier= 60,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 4.88
            },
            new Price {
                Underlying="ADECCO N",
                Maturity="6M",
                Barrier= 70,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 10.04
            },
            new Price {
                Underlying="ADECCO N",
                Maturity="6M",
                Barrier= 80,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 15.46
            },
            new Price {
                Underlying="Akamai Technologies",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 8.88
            },
            new Price {
                Underlying="Akamai Technologies",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 11.73
            },
            new Price {
                Underlying="Akamai Technologies",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 13.49
            },
            new Price {
                Underlying="ROCHE HLDG G",
                Maturity="3M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ROCHE HLDG G",
                Maturity="3M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ROCHE HLDG G",
                Maturity="3M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ROCHE HLDG G",
                Maturity="6M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ROCHE HLDG G",
                Maturity="6M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ROCHE HLDG G",
                Maturity="6M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 2.06
            },
            new Price {
                Underlying="ALCATEL-LUCENT",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 20.82
            },
            new Price {
                Underlying="ALCATEL-LUCENT",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 22.34
            },
            new Price {
                Underlying="ALCATEL-LUCENT",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 22.98
            },
            new Price {
                Underlying="NOBEL BIOCARE N",
                Maturity="3M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="NOBEL BIOCARE N",
                Maturity="3M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 3.56
            },
            new Price {
                Underlying="NOBEL BIOCARE N",
                Maturity="3M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 11.86
            },
            new Price {
                Underlying="NOBEL BIOCARE N",
                Maturity="6M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 4.44
            },
            new Price {
                Underlying="NOBEL BIOCARE N",
                Maturity="6M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 9.96
            },
            new Price {
                Underlying="NOBEL BIOCARE N",
                Maturity="6M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 15.7
            },
            new Price {
                Underlying="ALCOA",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 8.24
            },
            new Price {
                Underlying="ALCOA",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 10.78
            },
            new Price {
                Underlying="ALCOA",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 12.55
            },
            new Price {
                Underlying="THE SWATCH GRP",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="THE SWATCH GRP",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="THE SWATCH GRP",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 2.41
            },
            new Price {
                Underlying="THE SWATCH GRP",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0.17
            },
            new Price {
                Underlying="THE SWATCH GRP",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 2.61
            },
            new Price {
                Underlying="THE SWATCH GRP",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 6.59
            },
            new Price {
                Underlying="ALLIANZ N",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 3.26
            },
            new Price {
                Underlying="ALLIANZ N",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 5.96
            },
            new Price {
                Underlying="ALLIANZ N",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 8.54
            },
            new Price {
                Underlying="SWISSCOM N",
                Maturity="3M",
                Barrier= 60,
                Sector="Telecom",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SWISSCOM N",
                Maturity="3M",
                Barrier= 70,
                Sector="Telecom",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SWISSCOM N",
                Maturity="3M",
                Barrier= 80,
                Sector="Telecom",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SWISSCOM N",
                Maturity="6M",
                Barrier= 60,
                Sector="Telecom",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SWISSCOM N",
                Maturity="6M",
                Barrier= 70,
                Sector="Telecom",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SWISSCOM N",
                Maturity="6M",
                Barrier= 80,
                Sector="Telecom",
                Currency="CHF",
                CouponToday= (decimal) 0.72
            },
            new Price {
                Underlying="ALTRIA GROUP INC",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 2.14
            },
            new Price {
                Underlying="ALTRIA GROUP INC",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 4.03
            },
            new Price {
                Underlying="ALTRIA GROUP INC",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 6.54
            },
            new Price {
                Underlying="SWISS LIFE HLDG N",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SWISS LIFE HLDG N",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SWISS LIFE HLDG N",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 3.3
            },
            new Price {
                Underlying="SWISS LIFE HLDG N",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0.52
            },
            new Price {
                Underlying="SWISS LIFE HLDG N",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 3.54
            },
            new Price {
                Underlying="SWISS LIFE HLDG N",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 8.47
            },
            new Price {
                Underlying="Amazon.com Inc",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 7.96
            },
            new Price {
                Underlying="Amazon.com Inc",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 10.49
            },
            new Price {
                Underlying="Amazon.com Inc",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 12.22
            },
            new Price {
                Underlying="SWISS RE N",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SWISS RE N",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0.08
            },
            new Price {
                Underlying="SWISS RE N",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 3.35
            },
            new Price {
                Underlying="SWISS RE N",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0.85
            },
            new Price {
                Underlying="SWISS RE N",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 3.55
            },
            new Price {
                Underlying="SWISS RE N",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 7.82
            },
            new Price {
                Underlying="AMERICA MOVIL ADR",
                Maturity="12M",
                Barrier= 60,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 2.82
            },
            new Price {
                Underlying="AMERICA MOVIL ADR",
                Maturity="12M",
                Barrier= 70,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 5.16
            },
            new Price {
                Underlying="AMERICA MOVIL ADR",
                Maturity="12M",
                Barrier= 80,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 7.5
            },
            new Price {
                Underlying="SYNGENTA N",
                Maturity="3M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SYNGENTA N",
                Maturity="3M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SYNGENTA N",
                Maturity="3M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SYNGENTA N",
                Maturity="6M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SYNGENTA N",
                Maturity="6M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0.7
            },
            new Price {
                Underlying="SYNGENTA N",
                Maturity="6M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 3.61
            },
            new Price {
                Underlying="AMERICAN EXPRESS CO",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 3.76
            },
            new Price {
                Underlying="AMERICAN EXPRESS CO",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 5.97
            },
            new Price {
                Underlying="AMERICAN EXPRESS CO",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 8.1
            },
            new Price {
                Underlying="UBS N",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="UBS N",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 1.29
            },
            new Price {
                Underlying="UBS N",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 6.17
            },
            new Price {
                Underlying="UBS N",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 1.53
            },
            new Price {
                Underlying="UBS N",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 4.62
            },
            new Price {
                Underlying="UBS N",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 8.88
            },
            new Price {
                Underlying="AMERICAN INTERNATIONAL GROUP INC",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 4.38
            },
            new Price {
                Underlying="AMERICAN INTERNATIONAL GROUP INC",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 7.21
            },
            new Price {
                Underlying="AMERICAN INTERNATIONAL GROUP INC",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 9.64
            },
            new Price {
                Underlying="SMI",
                Maturity="3M",
                Barrier= 60,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SMI",
                Maturity="3M",
                Barrier= 70,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SMI",
                Maturity="3M",
                Barrier= 80,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SMI",
                Maturity="6M",
                Barrier= 60,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SMI",
                Maturity="6M",
                Barrier= 70,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SMI",
                Maturity="6M",
                Barrier= 80,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 1.64
            },
            new Price {
                Underlying="AMGEN",
                Maturity="12M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="USD",
                CouponToday= (decimal) 3.62
            },
            new Price {
                Underlying="AMGEN",
                Maturity="12M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="USD",
                CouponToday= (decimal) 5.58
            },
            new Price {
                Underlying="AMGEN",
                Maturity="12M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="USD",
                CouponToday= (decimal) 7.6
            },
            new Price {
                Underlying="ZURICH INS GROUP N",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ZURICH INS GROUP N",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ZURICH INS GROUP N",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0.73
            },
            new Price {
                Underlying="ZURICH INS GROUP N",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0.09
            },
            new Price {
                Underlying="ZURICH INS GROUP N",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 2.57
            },
            new Price {
                Underlying="ZURICH INS GROUP N",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 7.2
            },
            new Price {
                Underlying="Anadarko Petroleum",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 8.75
            },
            new Price {
                Underlying="Anadarko Petroleum",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 11.29
            },
            new Price {
                Underlying="Anadarko Petroleum",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 12.92
            },
            new Price {
                Underlying="LONZA GRP N",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="LONZA GRP N",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="LONZA GRP N",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 1.96
            },
            new Price {
                Underlying="LONZA GRP N",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0.31
            },
            new Price {
                Underlying="LONZA GRP N",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 3.5
            },
            new Price {
                Underlying="LONZA GRP N",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 9.04
            },
            new Price {
                Underlying="Anglo American PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 6.26
            },
            new Price {
                Underlying="Anglo American PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 9.2
            },
            new Price {
                Underlying="Anglo American PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 11.24
            },
            new Price {
                Underlying="GEBERIT N",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GEBERIT N",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GEBERIT N",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0.18
            },
            new Price {
                Underlying="GEBERIT N",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GEBERIT N",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 1.07
            },
            new Price {
                Underlying="GEBERIT N",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 4.45
            },
            new Price {
                Underlying="ANHEUS.-BUSCH INBEV",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 3
            },
            new Price {
                Underlying="ANHEUS.-BUSCH INBEV",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 5.25
            },
            new Price {
                Underlying="ANHEUS.-BUSCH INBEV",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 7.42
            },
            new Price {
                Underlying="SONOVA HLDG N",
                Maturity="3M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SONOVA HLDG N",
                Maturity="3M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SONOVA HLDG N",
                Maturity="3M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 1.95
            },
            new Price {
                Underlying="SONOVA HLDG N",
                Maturity="6M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SONOVA HLDG N",
                Maturity="6M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 1.22
            },
            new Price {
                Underlying="SONOVA HLDG N",
                Maturity="6M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 5.2
            },
            new Price {
                Underlying="APPLE",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.43
            },
            new Price {
                Underlying="APPLE",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 9.67
            },
            new Price {
                Underlying="APPLE",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 12
            },
            new Price {
                Underlying="LOGITECH INTL N",
                Maturity="3M",
                Barrier= 60,
                Sector="Technololgy",
                Currency="CHF",
                CouponToday= (decimal) 1.28
            },
            new Price {
                Underlying="LOGITECH INTL N",
                Maturity="3M",
                Barrier= 70,
                Sector="Technololgy",
                Currency="CHF",
                CouponToday= (decimal) 7.12
            },
            new Price {
                Underlying="LOGITECH INTL N",
                Maturity="3M",
                Barrier= 80,
                Sector="Technololgy",
                Currency="CHF",
                CouponToday= (decimal) 17.02
            },
            new Price {
                Underlying="LOGITECH INTL N",
                Maturity="6M",
                Barrier= 60,
                Sector="Technololgy",
                Currency="CHF",
                CouponToday= (decimal) 6.87
            },
            new Price {
                Underlying="LOGITECH INTL N",
                Maturity="6M",
                Barrier= 70,
                Sector="Technololgy",
                Currency="CHF",
                CouponToday= (decimal) 13.12
            },
            new Price {
                Underlying="LOGITECH INTL N",
                Maturity="6M",
                Barrier= 80,
                Sector="Technololgy",
                Currency="CHF",
                CouponToday= (decimal) 18.45
            },
            new Price {
                Underlying="ARCELOR MITTAL",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 10.27
            },
            new Price {
                Underlying="ARCELOR MITTAL",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 12.78
            },
            new Price {
                Underlying="ARCELOR MITTAL",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 14.28
            },
            new Price {
                Underlying="GIVAUDAN N",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GIVAUDAN N",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GIVAUDAN N",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GIVAUDAN N",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GIVAUDAN N",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0.03
            },
            new Price {
                Underlying="GIVAUDAN N",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 2.58
            },
            new Price {
                Underlying="AstraZeneca PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Health Care",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="AstraZeneca PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Health Care",
                Currency="EUR",
                CouponToday= (decimal) 1.36
            },
            new Price {
                Underlying="AstraZeneca PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Health Care",
                Currency="EUR",
                CouponToday= (decimal) 3.81
            },
            new Price {
                Underlying="OC OERLIKON CORP N",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="OC OERLIKON CORP N",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0.13
            },
            new Price {
                Underlying="OC OERLIKON CORP N",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 5.1
            },
            new Price {
                Underlying="OC OERLIKON CORP N",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 1.72
            },
            new Price {
                Underlying="OC OERLIKON CORP N",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 5.82
            },
            new Price {
                Underlying="OC OERLIKON CORP N",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 11.35
            },
            new Price {
                Underlying="AT&T Inc. Reg. Shares",
                Maturity="12M",
                Barrier= 60,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 2.37
            },
            new Price {
                Underlying="AT&T Inc. Reg. Shares",
                Maturity="12M",
                Barrier= 70,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 4.13
            },
            new Price {
                Underlying="AT&T Inc. Reg. Shares",
                Maturity="12M",
                Barrier= 80,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 6.39
            },
            new Price {
                Underlying="KUEHNE+NAGEL INT N",
                Maturity="3M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="KUEHNE+NAGEL INT N",
                Maturity="3M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="KUEHNE+NAGEL INT N",
                Maturity="3M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 0.67
            },
            new Price {
                Underlying="KUEHNE+NAGEL INT N",
                Maturity="6M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="KUEHNE+NAGEL INT N",
                Maturity="6M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 1.51
            },
            new Price {
                Underlying="KUEHNE+NAGEL INT N",
                Maturity="6M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 5.33
            },
            new Price {
                Underlying="AXA",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 8.36
            },
            new Price {
                Underlying="AXA",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 10.79
            },
            new Price {
                Underlying="AXA",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 12.51
            },
            new Price {
                Underlying="STRAUMANN HLDG N",
                Maturity="3M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="STRAUMANN HLDG N",
                Maturity="3M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="STRAUMANN HLDG N",
                Maturity="3M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 2.99
            },
            new Price {
                Underlying="STRAUMANN HLDG N",
                Maturity="6M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="STRAUMANN HLDG N",
                Maturity="6M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 2.65
            },
            new Price {
                Underlying="STRAUMANN HLDG N",
                Maturity="6M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 9.22
            },
            new Price {
                Underlying="BALOISE HLDG N",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 2.11
            },
            new Price {
                Underlying="BALOISE HLDG N",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 4.47
            },
            new Price {
                Underlying="BALOISE HLDG N",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 7.02
            },
            new Price {
                Underlying="ALCOA",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 1.3
            },
            new Price {
                Underlying="ALCOA",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 5.43
            },
            new Price {
                Underlying="ALCOA",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 12.97
            },
            new Price {
                Underlying="ALCOA",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 4.82
            },
            new Price {
                Underlying="ALCOA",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 9.2
            },
            new Price {
                Underlying="ALCOA",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 13.94
            },
            new Price {
                Underlying="Banco Bradesco SA Sp. ADR",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 6.2
            },
            new Price {
                Underlying="Banco Bradesco SA Sp. ADR",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 8.82
            },
            new Price {
                Underlying="Banco Bradesco SA Sp. ADR",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 10.9
            },
            new Price {
                Underlying="S&P 500",
                Maturity="3M",
                Barrier= 60,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="S&P 500",
                Maturity="3M",
                Barrier= 70,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="S&P 500",
                Maturity="3M",
                Barrier= 80,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 2.36
            },
            new Price {
                Underlying="S&P 500",
                Maturity="6M",
                Barrier= 60,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 0.61
            },
            new Price {
                Underlying="S&P 500",
                Maturity="6M",
                Barrier= 70,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 2.36
            },
            new Price {
                Underlying="S&P 500",
                Maturity="6M",
                Barrier= 80,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 5.06
            },
            new Price {
                Underlying="BANCO SANTANDER R",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 9.41
            },
            new Price {
                Underlying="BANCO SANTANDER R",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 11.8
            },
            new Price {
                Underlying="BANCO SANTANDER R",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 13.45
            },
            new Price {
                Underlying="ACTELION N",
                Maturity="3M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ACTELION N",
                Maturity="3M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 1.23
            },
            new Price {
                Underlying="ACTELION N",
                Maturity="3M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 8.94
            },
            new Price {
                Underlying="ACTELION N",
                Maturity="6M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0.7
            },
            new Price {
                Underlying="ACTELION N",
                Maturity="6M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 4.96
            },
            new Price {
                Underlying="ACTELION N",
                Maturity="6M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 11.13
            },
            new Price {
                Underlying="BANK OF AMERICA",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 9.53
            },
            new Price {
                Underlying="BANK OF AMERICA",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 11.94
            },
            new Price {
                Underlying="BANK OF AMERICA",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 13.56
            },
            new Price {
                Underlying="NASDAQ 100",
                Maturity="3M",
                Barrier= 60,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="NASDAQ 100",
                Maturity="3M",
                Barrier= 70,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="NASDAQ 100",
                Maturity="3M",
                Barrier= 80,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 2.76
            },
            new Price {
                Underlying="NASDAQ 100",
                Maturity="6M",
                Barrier= 60,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 0.61
            },
            new Price {
                Underlying="NASDAQ 100",
                Maturity="6M",
                Barrier= 70,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 2.61
            },
            new Price {
                Underlying="NASDAQ 100",
                Maturity="6M",
                Barrier= 80,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 5.76
            },
            new Price {
                Underlying="Barclays PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 8.92
            },
            new Price {
                Underlying="Barclays PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 11.15
            },
            new Price {
                Underlying="Barclays PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 12.61
            },
            new Price {
                Underlying="CATERPILLAR INC",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="CATERPILLAR INC",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 1.9
            },
            new Price {
                Underlying="CATERPILLAR INC",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 7.68
            },
            new Price {
                Underlying="CATERPILLAR INC",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 3.17
            },
            new Price {
                Underlying="CATERPILLAR INC",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 6.7
            },
            new Price {
                Underlying="CATERPILLAR INC",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 11.19
            },
            new Price {
                Underlying="Barrick Gold Corp.",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 6.27
            },
            new Price {
                Underlying="Barrick Gold Corp.",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 9.76
            },
            new Price {
                Underlying="Barrick Gold Corp.",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 12.28
            },
            new Price {
                Underlying="BOEING CO",
                Maturity="3M",
                Barrier= 60,
                Sector="Transportation",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BOEING CO",
                Maturity="3M",
                Barrier= 70,
                Sector="Transportation",
                Currency="USD",
                CouponToday= (decimal) 1.03
            },
            new Price {
                Underlying="BOEING CO",
                Maturity="3M",
                Barrier= 80,
                Sector="Transportation",
                Currency="USD",
                CouponToday= (decimal) 4.74
            },
            new Price {
                Underlying="BOEING CO",
                Maturity="6M",
                Barrier= 60,
                Sector="Transportation",
                Currency="USD",
                CouponToday= (decimal) 1.63
            },
            new Price {
                Underlying="BOEING CO",
                Maturity="6M",
                Barrier= 70,
                Sector="Transportation",
                Currency="USD",
                CouponToday= (decimal) 4.03
            },
            new Price {
                Underlying="BOEING CO",
                Maturity="6M",
                Barrier= 80,
                Sector="Transportation",
                Currency="USD",
                CouponToday= (decimal) 7.8
            },
            new Price {
                Underlying="BASF",
                Maturity="12M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 3.09
            },
            new Price {
                Underlying="BASF",
                Maturity="12M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 5.96
            },
            new Price {
                Underlying="BASF",
                Maturity="12M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 8.63
            },
            new Price {
                Underlying="COCA-COLA CO",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="COCA-COLA CO",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="COCA-COLA CO",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 1.29
            },
            new Price {
                Underlying="COCA-COLA CO",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="COCA-COLA CO",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 1.05
            },
            new Price {
                Underlying="COCA-COLA CO",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 3.43
            },
            new Price {
                Underlying="BAYER N",
                Maturity="12M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 3.04
            },
            new Price {
                Underlying="BAYER N",
                Maturity="12M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 5.75
            },
            new Price {
                Underlying="BAYER N",
                Maturity="12M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 8.27
            },
            new Price {
                Underlying="CITIGROUP",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 3.17
            },
            new Price {
                Underlying="CITIGROUP",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 7.93
            },
            new Price {
                Underlying="CITIGROUP",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 15.49
            },
            new Price {
                Underlying="CITIGROUP",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 6.51
            },
            new Price {
                Underlying="CITIGROUP",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 10.95
            },
            new Price {
                Underlying="CITIGROUP",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 15.4
            },
            new Price {
                Underlying="BBVA R",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 8.78
            },
            new Price {
                Underlying="BBVA R",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 11.24
            },
            new Price {
                Underlying="BBVA R",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 12.91
            },
            new Price {
                Underlying="EXXON MOBIL",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="EXXON MOBIL",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="EXXON MOBIL",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 0.99
            },
            new Price {
                Underlying="EXXON MOBIL",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 0.24
            },
            new Price {
                Underlying="EXXON MOBIL",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 1.54
            },
            new Price {
                Underlying="EXXON MOBIL",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 3.86
            },
            new Price {
                Underlying="BG Group PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Oil & Gas",
                Currency="EUR",
                CouponToday= (decimal) 1.7
            },
            new Price {
                Underlying="BG Group PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Oil & Gas",
                Currency="EUR",
                CouponToday= (decimal) 4.2
            },
            new Price {
                Underlying="BG Group PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Oil & Gas",
                Currency="EUR",
                CouponToday= (decimal) 6.81
            },
            new Price {
                Underlying="GENERAL ELECTRIC",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GENERAL ELECTRIC",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 1.55
            },
            new Price {
                Underlying="GENERAL ELECTRIC",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 5.1
            },
            new Price {
                Underlying="GENERAL ELECTRIC",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 1.94
            },
            new Price {
                Underlying="GENERAL ELECTRIC",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.18
            },
            new Price {
                Underlying="GENERAL ELECTRIC",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 7.6
            },
            new Price {
                Underlying="BHP Billiton PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 3.86
            },
            new Price {
                Underlying="BHP Billiton PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 6.57
            },
            new Price {
                Underlying="BHP Billiton PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 8.89
            },
            new Price {
                Underlying="IBM",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="IBM",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="IBM",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 1.63
            },
            new Price {
                Underlying="IBM",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0.04
            },
            new Price {
                Underlying="IBM",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 1.47
            },
            new Price {
                Underlying="IBM",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.34
            },
            new Price {
                Underlying="BMW",
                Maturity="12M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 5.04
            },
            new Price {
                Underlying="BMW",
                Maturity="12M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 8.17
            },
            new Price {
                Underlying="BMW",
                Maturity="12M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 10.62
            },
            new Price {
                Underlying="INTEL",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="INTEL",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 1.48
            },
            new Price {
                Underlying="INTEL",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 5.72
            },
            new Price {
                Underlying="INTEL",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 1.6
            },
            new Price {
                Underlying="INTEL",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.25
            },
            new Price {
                Underlying="INTEL",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 8.41
            },
            new Price {
                Underlying="BNP PARIBAS",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 9.78
            },
            new Price {
                Underlying="BNP PARIBAS",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 12.25
            },
            new Price {
                Underlying="BNP PARIBAS",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 13.84
            },
            new Price {
                Underlying="HEWLETT-PACKARD",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 3.94
            },
            new Price {
                Underlying="HEWLETT-PACKARD",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 9.82
            },
            new Price {
                Underlying="HEWLETT-PACKARD",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 18.77
            },
            new Price {
                Underlying="HEWLETT-PACKARD",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 7.78
            },
            new Price {
                Underlying="HEWLETT-PACKARD",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 13.06
            },
            new Price {
                Underlying="HEWLETT-PACKARD",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 18.1
            },
            new Price {
                Underlying="BOEING CO",
                Maturity="12M",
                Barrier= 60,
                Sector="Transportation",
                Currency="USD",
                CouponToday= (decimal) 4.21
            },
            new Price {
                Underlying="BOEING CO",
                Maturity="12M",
                Barrier= 70,
                Sector="Transportation",
                Currency="USD",
                CouponToday= (decimal) 6.49
            },
            new Price {
                Underlying="BOEING CO",
                Maturity="12M",
                Barrier= 80,
                Sector="Transportation",
                Currency="USD",
                CouponToday= (decimal) 8.72
            },
            new Price {
                Underlying="JPMORGAN CHASE",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 0.64
            },
            new Price {
                Underlying="JPMORGAN CHASE",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 3.27
            },
            new Price {
                Underlying="JPMORGAN CHASE",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 8.56
            },
            new Price {
                Underlying="JPMORGAN CHASE",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 3.9
            },
            new Price {
                Underlying="JPMORGAN CHASE",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 7.08
            },
            new Price {
                Underlying="JPMORGAN CHASE",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 11.06
            },
            new Price {
                Underlying="BP PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Oil & Gas",
                Currency="EUR",
                CouponToday= (decimal) 1.65
            },
            new Price {
                Underlying="BP PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Oil & Gas",
                Currency="EUR",
                CouponToday= (decimal) 4.1
            },
            new Price {
                Underlying="BP PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Oil & Gas",
                Currency="EUR",
                CouponToday= (decimal) 6.88
            },
            new Price {
                Underlying="MCDONALD&apos;S",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="MCDONALD&apos;S",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="MCDONALD&apos;S",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="MCDONALD&apos;S",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="MCDONALD&apos;S",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0.3
            },
            new Price {
                Underlying="MCDONALD&apos;S",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 2.51
            },
            new Price {
                Underlying="BRISTOL MYERS SQUIBB CO",
                Maturity="12M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 3.07
            },
            new Price {
                Underlying="BRISTOL MYERS SQUIBB CO",
                Maturity="12M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 4.98
            },
            new Price {
                Underlying="BRISTOL MYERS SQUIBB CO",
                Maturity="12M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 7.14
            },
            new Price {
                Underlying="PFIZER",
                Maturity="3M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="PFIZER",
                Maturity="3M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="PFIZER",
                Maturity="3M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 1.85
            },
            new Price {
                Underlying="PFIZER",
                Maturity="6M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 0.48
            },
            new Price {
                Underlying="PFIZER",
                Maturity="6M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 1.98
            },
            new Price {
                Underlying="PFIZER",
                Maturity="6M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 4.78
            },
            new Price {
                Underlying="British American Tobacco PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="British American Tobacco PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 1.47
            },
            new Price {
                Underlying="British American Tobacco PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 4.06
            },
            new Price {
                Underlying="APPLE",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0.6
            },
            new Price {
                Underlying="APPLE",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.23
            },
            new Price {
                Underlying="APPLE",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 12.04
            },
            new Price {
                Underlying="APPLE",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 3.15
            },
            new Price {
                Underlying="APPLE",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 7.64
            },
            new Price {
                Underlying="APPLE",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 13.15
            },
            new Price {
                Underlying="BT Group PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Telecommunications",
                Currency="EUR",
                CouponToday= (decimal) 2.04
            },
            new Price {
                Underlying="BT Group PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Telecommunications",
                Currency="EUR",
                CouponToday= (decimal) 4.2
            },
            new Price {
                Underlying="BT Group PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Telecommunications",
                Currency="EUR",
                CouponToday= (decimal) 6.51
            },
            new Price {
                Underlying="MICROSOFT",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="MICROSOFT",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0.5
            },
            new Price {
                Underlying="MICROSOFT",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.09
            },
            new Price {
                Underlying="MICROSOFT",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0.9
            },
            new Price {
                Underlying="MICROSOFT",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 3.07
            },
            new Price {
                Underlying="MICROSOFT",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.95
            },
            new Price {
                Underlying="CAC 40",
                Maturity="12M",
                Barrier= 60,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 3.22
            },
            new Price {
                Underlying="CAC 40",
                Maturity="12M",
                Barrier= 70,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 5.51
            },
            new Price {
                Underlying="CAC 40",
                Maturity="12M",
                Barrier= 80,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 7.7
            },
            new Price {
                Underlying="WAL-MART STORES",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WAL-MART STORES",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WAL-MART STORES",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0.46
            },
            new Price {
                Underlying="WAL-MART STORES",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WAL-MART STORES",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0.76
            },
            new Price {
                Underlying="WAL-MART STORES",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 3.07
            },
            new Price {
                Underlying="CARREFOUR",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 6.52
            },
            new Price {
                Underlying="CARREFOUR",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 9.44
            },
            new Price {
                Underlying="CARREFOUR",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 11.53
            },
            new Price {
                Underlying="PROCTER&GAMBLE",
                Maturity="3M",
                Barrier= 60,
                Sector="Services",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="PROCTER&GAMBLE",
                Maturity="3M",
                Barrier= 70,
                Sector="Services",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="PROCTER&GAMBLE",
                Maturity="3M",
                Barrier= 80,
                Sector="Services",
                Currency="USD",
                CouponToday= (decimal) 0.64
            },
            new Price {
                Underlying="PROCTER&GAMBLE",
                Maturity="6M",
                Barrier= 60,
                Sector="Services",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="PROCTER&GAMBLE",
                Maturity="6M",
                Barrier= 70,
                Sector="Services",
                Currency="USD",
                CouponToday= (decimal) 0.83
            },
            new Price {
                Underlying="PROCTER&GAMBLE",
                Maturity="6M",
                Barrier= 80,
                Sector="Services",
                Currency="USD",
                CouponToday= (decimal) 2.5
            },
            new Price {
                Underlying="CATERPILLAR INC",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 5.73
            },
            new Price {
                Underlying="CATERPILLAR INC",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 8.38
            },
            new Price {
                Underlying="CATERPILLAR INC",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 10.54
            },
            new Price {
                Underlying="DAX",
                Maturity="3M",
                Barrier= 60,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DAX",
                Maturity="3M",
                Barrier= 70,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DAX",
                Maturity="3M",
                Barrier= 80,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 1.3
            },
            new Price {
                Underlying="DAX",
                Maturity="6M",
                Barrier= 60,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DAX",
                Maturity="6M",
                Barrier= 70,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 1.52
            },
            new Price {
                Underlying="DAX",
                Maturity="6M",
                Barrier= 80,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 4.21
            },
            new Price {
                Underlying="CEMEX ADR",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 15.36
            },
            new Price {
                Underlying="CEMEX ADR",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 16.75
            },
            new Price {
                Underlying="CEMEX ADR",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 17.5
            },
            new Price {
                Underlying="ESTX50 EURP",
                Maturity="3M",
                Barrier= 60,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ESTX50 EURP",
                Maturity="3M",
                Barrier= 70,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 0.21
            },
            new Price {
                Underlying="ESTX50 EURP",
                Maturity="3M",
                Barrier= 80,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 3.36
            },
            new Price {
                Underlying="ESTX50 EURP",
                Maturity="6M",
                Barrier= 60,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 1.03
            },
            new Price {
                Underlying="ESTX50 EURP",
                Maturity="6M",
                Barrier= 70,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 3.21
            },
            new Price {
                Underlying="ESTX50 EURP",
                Maturity="6M",
                Barrier= 80,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 6.71
            },
            new Price {
                Underlying="CHESAPEAKE ENERGY CORP",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 12.84
            },
            new Price {
                Underlying="CHESAPEAKE ENERGY CORP",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 14.85
            },
            new Price {
                Underlying="CHESAPEAKE ENERGY CORP",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 16.1
            },
            new Price {
                Underlying="ADIDAS",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ADIDAS",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ADIDAS",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 3.35
            },
            new Price {
                Underlying="ADIDAS",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0.38
            },
            new Price {
                Underlying="ADIDAS",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 2.87
            },
            new Price {
                Underlying="ADIDAS",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 6.91
            },
            new Price {
                Underlying="Chevron",
                Maturity="12M",
                Barrier= 60,
                Sector="Oil & Gas",
                Currency="USD",
                CouponToday= (decimal) 3.25
            },
            new Price {
                Underlying="Chevron",
                Maturity="12M",
                Barrier= 70,
                Sector="Oil & Gas",
                Currency="USD",
                CouponToday= (decimal) 5.24
            },
            new Price {
                Underlying="Chevron",
                Maturity="12M",
                Barrier= 80,
                Sector="Oil & Gas",
                Currency="USD",
                CouponToday= (decimal) 7.38
            },
            new Price {
                Underlying="ALLIANZ N",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ALLIANZ N",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ALLIANZ N",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 1.49
            },
            new Price {
                Underlying="ALLIANZ N",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 0.11
            },
            new Price {
                Underlying="ALLIANZ N",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 2.21
            },
            new Price {
                Underlying="ALLIANZ N",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 5.81
            },
            new Price {
                Underlying="CHINA MOBILE ADR",
                Maturity="12M",
                Barrier= 60,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 1.17
            },
            new Price {
                Underlying="CHINA MOBILE ADR",
                Maturity="12M",
                Barrier= 70,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 3.43
            },
            new Price {
                Underlying="CHINA MOBILE ADR",
                Maturity="12M",
                Barrier= 80,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 6.37
            },
            new Price {
                Underlying="BASF",
                Maturity="3M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BASF",
                Maturity="3M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BASF",
                Maturity="3M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 3.13
            },
            new Price {
                Underlying="BASF",
                Maturity="6M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 0.45
            },
            new Price {
                Underlying="BASF",
                Maturity="6M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 3.34
            },
            new Price {
                Underlying="BASF",
                Maturity="6M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 8.31
            },
            new Price {
                Underlying="Cia de Bebidas Das Americas (AMBEV) Sp. ADR",
                Maturity="12M",
                Barrier= 60,
                Sector="Consumer Goods",
                Currency="USD",
                CouponToday= (decimal) 1.8
            },
            new Price {
                Underlying="Cia de Bebidas Das Americas (AMBEV) Sp. ADR",
                Maturity="12M",
                Barrier= 70,
                Sector="Consumer Goods",
                Currency="USD",
                CouponToday= (decimal) 4.42
            },
            new Price {
                Underlying="Cia de Bebidas Das Americas (AMBEV) Sp. ADR",
                Maturity="12M",
                Barrier= 80,
                Sector="Consumer Goods",
                Currency="USD",
                CouponToday= (decimal) 7.32
            },
            new Price {
                Underlying="BAYER N",
                Maturity="3M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BAYER N",
                Maturity="3M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BAYER N",
                Maturity="3M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 3.1
            },
            new Price {
                Underlying="BAYER N",
                Maturity="6M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 0.69
            },
            new Price {
                Underlying="BAYER N",
                Maturity="6M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 3.43
            },
            new Price {
                Underlying="BAYER N",
                Maturity="6M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 7.85
            },
            new Price {
                Underlying="CISCO SYSTEMS INC",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 5.49
            },
            new Price {
                Underlying="CISCO SYSTEMS INC",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 8.46
            },
            new Price {
                Underlying="CISCO SYSTEMS INC",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 10.87
            },
            new Price {
                Underlying="BMW",
                Maturity="3M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BMW",
                Maturity="3M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 0.55
            },
            new Price {
                Underlying="BMW",
                Maturity="3M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 5.88
            },
            new Price {
                Underlying="BMW",
                Maturity="6M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 1.2
            },
            new Price {
                Underlying="BMW",
                Maturity="6M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 4.57
            },
            new Price {
                Underlying="BMW",
                Maturity="6M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 9.37
            },
            new Price {
                Underlying="CITIGROUP",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 8.66
            },
            new Price {
                Underlying="CITIGROUP",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 11.13
            },
            new Price {
                Underlying="CITIGROUP",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 12.79
            },
            new Price {
                Underlying="DAIMLER",
                Maturity="3M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DAIMLER",
                Maturity="3M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 0.12
            },
            new Price {
                Underlying="DAIMLER",
                Maturity="3M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 5.01
            },
            new Price {
                Underlying="DAIMLER",
                Maturity="6M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 1.7
            },
            new Price {
                Underlying="DAIMLER",
                Maturity="6M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 6.14
            },
            new Price {
                Underlying="DAIMLER",
                Maturity="6M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 12.58
            },
            new Price {
                Underlying="CLARIANT N",
                Maturity="12M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 6.84
            },
            new Price {
                Underlying="CLARIANT N",
                Maturity="12M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 9.95
            },
            new Price {
                Underlying="CLARIANT N",
                Maturity="12M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 12.06
            },
            new Price {
                Underlying="DEUTSCHE POST N",
                Maturity="3M",
                Barrier= 60,
                Sector="Services",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DEUTSCHE POST N",
                Maturity="3M",
                Barrier= 70,
                Sector="Services",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DEUTSCHE POST N",
                Maturity="3M",
                Barrier= 80,
                Sector="Services",
                Currency="EUR",
                CouponToday= (decimal) 1.89
            },
            new Price {
                Underlying="DEUTSCHE POST N",
                Maturity="6M",
                Barrier= 60,
                Sector="Services",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DEUTSCHE POST N",
                Maturity="6M",
                Barrier= 70,
                Sector="Services",
                Currency="EUR",
                CouponToday= (decimal) 2.04
            },
            new Price {
                Underlying="DEUTSCHE POST N",
                Maturity="6M",
                Barrier= 80,
                Sector="Services",
                Currency="EUR",
                CouponToday= (decimal) 5.69
            },
            new Price {
                Underlying="COCA-COLA CO",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 1.41
            },
            new Price {
                Underlying="COCA-COLA CO",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 3.18
            },
            new Price {
                Underlying="COCA-COLA CO",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 5.55
            },
            new Price {
                Underlying="COMMERZBANK",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 3.64
            },
            new Price {
                Underlying="COMMERZBANK",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 9.89
            },
            new Price {
                Underlying="COMMERZBANK",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 18.81
            },
            new Price {
                Underlying="COMMERZBANK",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 8.69
            },
            new Price {
                Underlying="COMMERZBANK",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 14.05
            },
            new Price {
                Underlying="COMMERZBANK",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 18.79
            },
            new Price {
                Underlying="Colgate Palmolive",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 1.67
            },
            new Price {
                Underlying="Colgate Palmolive",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 3.31
            },
            new Price {
                Underlying="Colgate Palmolive",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 5.36
            },
            new Price {
                Underlying="DEUTSCHE BANK N",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 0.87
            },
            new Price {
                Underlying="DEUTSCHE BANK N",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 5.38
            },
            new Price {
                Underlying="DEUTSCHE BANK N",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 13.29
            },
            new Price {
                Underlying="DEUTSCHE BANK N",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 5.31
            },
            new Price {
                Underlying="DEUTSCHE BANK N",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 9.98
            },
            new Price {
                Underlying="DEUTSCHE BANK N",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 14.6
            },
            new Price {
                Underlying="COMMERZBANK",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 10.69
            },
            new Price {
                Underlying="COMMERZBANK",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 13.43
            },
            new Price {
                Underlying="COMMERZBANK",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 15.09
            },
            new Price {
                Underlying="DEUTSCHE TELEKOM N",
                Maturity="3M",
                Barrier= 60,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DEUTSCHE TELEKOM N",
                Maturity="3M",
                Barrier= 70,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DEUTSCHE TELEKOM N",
                Maturity="3M",
                Barrier= 80,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 2.89
            },
            new Price {
                Underlying="DEUTSCHE TELEKOM N",
                Maturity="6M",
                Barrier= 60,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DEUTSCHE TELEKOM N",
                Maturity="6M",
                Barrier= 70,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 1.93
            },
            new Price {
                Underlying="DEUTSCHE TELEKOM N",
                Maturity="6M",
                Barrier= 80,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 5.52
            },
            new Price {
                Underlying="Companhia Siderurgica Nacional Sp. ADR",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 16.22
            },
            new Price {
                Underlying="Companhia Siderurgica Nacional Sp. ADR",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 18.29
            },
            new Price {
                Underlying="Companhia Siderurgica Nacional Sp. ADR",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 19.4
            },
            new Price {
                Underlying="E.ON N",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="E.ON N",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="E.ON N",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 1.27
            },
            new Price {
                Underlying="E.ON N",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="E.ON N",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 2.32
            },
            new Price {
                Underlying="E.ON N",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 7.02
            },
            new Price {
                Underlying="CONOCOPHILLIPS CO",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 3.91
            },
            new Price {
                Underlying="CONOCOPHILLIPS CO",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 5.98
            },
            new Price {
                Underlying="CONOCOPHILLIPS CO",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 8.12
            },
            new Price {
                Underlying="INFINEON TECHNO N",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 0.78
            },
            new Price {
                Underlying="INFINEON TECHNO N",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 5.63
            },
            new Price {
                Underlying="INFINEON TECHNO N",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 14.34
            },
            new Price {
                Underlying="INFINEON TECHNO N",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 5.78
            },
            new Price {
                Underlying="INFINEON TECHNO N",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 11.2
            },
            new Price {
                Underlying="INFINEON TECHNO N",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 16.47
            },
            new Price {
                Underlying="Continental AG",
                Maturity="12M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 6.66
            },
            new Price {
                Underlying="Continental AG",
                Maturity="12M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 9.51
            },
            new Price {
                Underlying="Continental AG",
                Maturity="12M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 11.58
            },
            new Price {
                Underlying="HENKEL VZ",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="HENKEL VZ",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="HENKEL VZ",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 1.21
            },
            new Price {
                Underlying="HENKEL VZ",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="HENKEL VZ",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 1.42
            },
            new Price {
                Underlying="HENKEL VZ",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 5.03
            },
            new Price {
                Underlying="CREDIT AGRICOLE",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 10.89
            },
            new Price {
                Underlying="CREDIT AGRICOLE",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 13.35
            },
            new Price {
                Underlying="CREDIT AGRICOLE",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 14.79
            },
            new Price {
                Underlying="DT.LUFTHANSA N",
                Maturity="3M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DT.LUFTHANSA N",
                Maturity="3M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DT.LUFTHANSA N",
                Maturity="3M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 3.4
            },
            new Price {
                Underlying="DT.LUFTHANSA N",
                Maturity="6M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 0.47
            },
            new Price {
                Underlying="DT.LUFTHANSA N",
                Maturity="6M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 2.94
            },
            new Price {
                Underlying="DT.LUFTHANSA N",
                Maturity="6M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 6.94
            },
            new Price {
                Underlying="CS GROUP N",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 6.33
            },
            new Price {
                Underlying="CS GROUP N",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 9.15
            },
            new Price {
                Underlying="CS GROUP N",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 11.23
            },
            new Price {
                Underlying="FRESENIUS MED CARE",
                Maturity="3M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="FRESENIUS MED CARE",
                Maturity="3M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="FRESENIUS MED CARE",
                Maturity="3M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="EUR",
                CouponToday= (decimal) 0.17
            },
            new Price {
                Underlying="FRESENIUS MED CARE",
                Maturity="6M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="FRESENIUS MED CARE",
                Maturity="6M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="EUR",
                CouponToday= (decimal) 0.4
            },
            new Price {
                Underlying="FRESENIUS MED CARE",
                Maturity="6M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="EUR",
                CouponToday= (decimal) 3.38
            },
            new Price {
                Underlying="DAIMLER",
                Maturity="12M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 5.22
            },
            new Price {
                Underlying="DAIMLER",
                Maturity="12M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 8.7
            },
            new Price {
                Underlying="DAIMLER",
                Maturity="12M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 11.39
            },
            new Price {
                Underlying="LINDE",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="LINDE",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="LINDE",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 1.25
            },
            new Price {
                Underlying="LINDE",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="LINDE",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 1.28
            },
            new Price {
                Underlying="LINDE",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 4.53
            },
            new Price {
                Underlying="DANONE",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 1.36
            },
            new Price {
                Underlying="DANONE",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 3.51
            },
            new Price {
                Underlying="DANONE",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 6.03
            },
            new Price {
                Underlying="METRO",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="METRO",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0.94
            },
            new Price {
                Underlying="METRO",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 6.87
            },
            new Price {
                Underlying="METRO",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 1.13
            },
            new Price {
                Underlying="METRO",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 4.65
            },
            new Price {
                Underlying="METRO",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 9.74
            },
            new Price {
                Underlying="DAX",
                Maturity="12M",
                Barrier= 60,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 1.7
            },
            new Price {
                Underlying="DAX",
                Maturity="12M",
                Barrier= 70,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 3.39
            },
            new Price {
                Underlying="DAX",
                Maturity="12M",
                Barrier= 80,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 5.24
            },
            new Price {
                Underlying="MUENCH RUECKVERS N",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="MUENCH RUECKVERS N",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="MUENCH RUECKVERS N",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 1.45
            },
            new Price {
                Underlying="MUENCH RUECKVERS N",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 0.07
            },
            new Price {
                Underlying="MUENCH RUECKVERS N",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 2.3
            },
            new Price {
                Underlying="MUENCH RUECKVERS N",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 6.55
            },
            new Price {
                Underlying="DAX",
                Maturity="12M",
                Barrier= 60,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 1.44
            },
            new Price {
                Underlying="DAX",
                Maturity="12M",
                Barrier= 70,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 3.12
            },
            new Price {
                Underlying="DAX",
                Maturity="12M",
                Barrier= 80,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 4.95
            },
            new Price {
                Underlying="NOKIA",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 11.75
            },
            new Price {
                Underlying="NOKIA",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 21.65
            },
            new Price {
                Underlying="NOKIA",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 31.52
            },
            new Price {
                Underlying="NOKIA",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 19.22
            },
            new Price {
                Underlying="NOKIA",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 25
            },
            new Price {
                Underlying="NOKIA",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 28.7
            },
            new Price {
                Underlying="DEERE & CO",
                Maturity="12M",
                Barrier= 60,
                Sector="Machinery / Farm",
                Currency="USD",
                CouponToday= (decimal) 5
            },
            new Price {
                Underlying="DEERE & CO",
                Maturity="12M",
                Barrier= 70,
                Sector="Machinery / Farm",
                Currency="USD",
                CouponToday= (decimal) 7.36
            },
            new Price {
                Underlying="DEERE & CO",
                Maturity="12M",
                Barrier= 80,
                Sector="Machinery / Farm",
                Currency="USD",
                CouponToday= (decimal) 9.42
            },
            new Price {
                Underlying="SAP",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SAP",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SAP",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 1.04
            },
            new Price {
                Underlying="SAP",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SAP",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 1.8
            },
            new Price {
                Underlying="SAP",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 5.15
            },
            new Price {
                Underlying="DELL INC",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 8.45
            },
            new Price {
                Underlying="DELL INC",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 11.9
            },
            new Price {
                Underlying="DELL INC",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 14.16
            },
            new Price {
                Underlying="K+S",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="K+S",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="K+S",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 2.48
            },
            new Price {
                Underlying="K+S",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="K+S",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 2.19
            },
            new Price {
                Underlying="K+S",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 6.23
            },
            new Price {
                Underlying="DEUTSCHE BANK N",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 8.1
            },
            new Price {
                Underlying="DEUTSCHE BANK N",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 10.86
            },
            new Price {
                Underlying="DEUTSCHE BANK N",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 12.66
            },
            new Price {
                Underlying="RWE -A-",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="RWE -A-",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="RWE -A-",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 1.27
            },
            new Price {
                Underlying="RWE -A-",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0.21
            },
            new Price {
                Underlying="RWE -A-",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 2.76
            },
            new Price {
                Underlying="RWE -A-",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 7.44
            },
            new Price {
                Underlying="DEUTSCHE POST N",
                Maturity="12M",
                Barrier= 60,
                Sector="Services",
                Currency="EUR",
                CouponToday= (decimal) 2.33
            },
            new Price {
                Underlying="DEUTSCHE POST N",
                Maturity="12M",
                Barrier= 70,
                Sector="Services",
                Currency="EUR",
                CouponToday= (decimal) 4.97
            },
            new Price {
                Underlying="DEUTSCHE POST N",
                Maturity="12M",
                Barrier= 80,
                Sector="Services",
                Currency="EUR",
                CouponToday= (decimal) 7.7
            },
            new Price {
                Underlying="THYSSENKRUPP",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="THYSSENKRUPP",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 3.64
            },
            new Price {
                Underlying="THYSSENKRUPP",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 12.53
            },
            new Price {
                Underlying="THYSSENKRUPP",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 3.46
            },
            new Price {
                Underlying="THYSSENKRUPP",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 8.59
            },
            new Price {
                Underlying="THYSSENKRUPP",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 14.39
            },
            new Price {
                Underlying="DEUTSCHE TELEKOM N",
                Maturity="12M",
                Barrier= 60,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 2.73
            },
            new Price {
                Underlying="DEUTSCHE TELEKOM N",
                Maturity="12M",
                Barrier= 70,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 5.87
            },
            new Price {
                Underlying="DEUTSCHE TELEKOM N",
                Maturity="12M",
                Barrier= 80,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 9.1
            },
            new Price {
                Underlying="SIEMENS N",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SIEMENS N",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SIEMENS N",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 2.02
            },
            new Price {
                Underlying="SIEMENS N",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SIEMENS N",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 1.75
            },
            new Price {
                Underlying="SIEMENS N",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 5.67
            },
            new Price {
                Underlying="Diageo PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0.2
            },
            new Price {
                Underlying="Diageo PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 1.59
            },
            new Price {
                Underlying="Diageo PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 3.59
            },
            new Price {
                Underlying="TUI N",
                Maturity="3M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 0.21
            },
            new Price {
                Underlying="TUI N",
                Maturity="3M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 3.7
            },
            new Price {
                Underlying="TUI N",
                Maturity="3M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 10.51
            },
            new Price {
                Underlying="TUI N",
                Maturity="6M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 4.67
            },
            new Price {
                Underlying="TUI N",
                Maturity="6M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 8.92
            },
            new Price {
                Underlying="TUI N",
                Maturity="6M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 13.51
            },
            new Price {
                Underlying="DKSH Holding Ltd",
                Maturity="12M",
                Barrier= 60,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DKSH Holding Ltd",
                Maturity="12M",
                Barrier= 70,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 0.19
            },
            new Price {
                Underlying="DKSH Holding Ltd",
                Maturity="12M",
                Barrier= 80,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 2.32
            },
            new Price {
                Underlying="AIR LIQUIDE",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="AIR LIQUIDE",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="AIR LIQUIDE",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 1.31
            },
            new Price {
                Underlying="AIR LIQUIDE",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="AIR LIQUIDE",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 1.71
            },
            new Price {
                Underlying="AIR LIQUIDE",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 5.03
            },
            new Price {
                Underlying="DT.LUFTHANSA N",
                Maturity="12M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 3.13
            },
            new Price {
                Underlying="DT.LUFTHANSA N",
                Maturity="12M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 5.85
            },
            new Price {
                Underlying="DT.LUFTHANSA N",
                Maturity="12M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 8.38
            },
            new Price {
                Underlying="AEGON",
                Maturity="3M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="EUR",
                CouponToday= (decimal) 0.93
            },
            new Price {
                Underlying="AEGON",
                Maturity="3M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="EUR",
                CouponToday= (decimal) 5.5
            },
            new Price {
                Underlying="AEGON",
                Maturity="3M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="EUR",
                CouponToday= (decimal) 13.47
            },
            new Price {
                Underlying="AEGON",
                Maturity="6M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="EUR",
                CouponToday= (decimal) 5.61
            },
            new Price {
                Underlying="AEGON",
                Maturity="6M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="EUR",
                CouponToday= (decimal) 10.23
            },
            new Price {
                Underlying="AEGON",
                Maturity="6M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="EUR",
                CouponToday= (decimal) 14.68
            },
            new Price {
                Underlying="DU PONT NEMOURS&CO",
                Maturity="12M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 3.87
            },
            new Price {
                Underlying="DU PONT NEMOURS&CO",
                Maturity="12M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 6.19
            },
            new Price {
                Underlying="DU PONT NEMOURS&CO",
                Maturity="12M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 8.47
            },
            new Price {
                Underlying="ALCATEL-LUCENT",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 30.14
            },
            new Price {
                Underlying="ALCATEL-LUCENT",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 40.4
            },
            new Price {
                Underlying="ALCATEL-LUCENT",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 48.26
            },
            new Price {
                Underlying="ALCATEL-LUCENT",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 26.53
            },
            new Price {
                Underlying="ALCATEL-LUCENT",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 31.76
            },
            new Price {
                Underlying="ALCATEL-LUCENT",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 34.69
            },
            new Price {
                Underlying="Dufry AG",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0.42
            },
            new Price {
                Underlying="Dufry AG",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 2.91
            },
            new Price {
                Underlying="Dufry AG",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 5.91
            },
            new Price {
                Underlying="CARREFOUR",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="CARREFOUR",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 3.32
            },
            new Price {
                Underlying="CARREFOUR",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 10.22
            },
            new Price {
                Underlying="CARREFOUR",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 3.52
            },
            new Price {
                Underlying="CARREFOUR",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 8
            },
            new Price {
                Underlying="CARREFOUR",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 13.26
            },
            new Price {
                Underlying="E.ON N",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 2.68
            },
            new Price {
                Underlying="E.ON N",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 5.44
            },
            new Price {
                Underlying="E.ON N",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 8.26
            },
            new Price {
                Underlying="AXA",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 0.15
            },
            new Price {
                Underlying="AXA",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 3.43
            },
            new Price {
                Underlying="AXA",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 9.7
            },
            new Price {
                Underlying="AXA",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 5.26
            },
            new Price {
                Underlying="AXA",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 9.73
            },
            new Price {
                Underlying="AXA",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 14.72
            },
            new Price {
                Underlying="eBay",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 6.81
            },
            new Price {
                Underlying="eBay",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 9.38
            },
            new Price {
                Underlying="eBay",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 11.24
            },
            new Price {
                Underlying="CREDIT AGRICOLE",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 6.87
            },
            new Price {
                Underlying="CREDIT AGRICOLE",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 14.32
            },
            new Price {
                Underlying="CREDIT AGRICOLE",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 23.07
            },
            new Price {
                Underlying="CREDIT AGRICOLE",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 10.88
            },
            new Price {
                Underlying="CREDIT AGRICOLE",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 16.07
            },
            new Price {
                Underlying="CREDIT AGRICOLE",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 20.16
            },
            new Price {
                Underlying="ELI LILLY & CO",
                Maturity="12M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 2.86
            },
            new Price {
                Underlying="ELI LILLY & CO",
                Maturity="12M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 4.95
            },
            new Price {
                Underlying="ELI LILLY & CO",
                Maturity="12M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 7.31
            },
            new Price {
                Underlying="DANONE",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DANONE",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DANONE",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0.2
            },
            new Price {
                Underlying="DANONE",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DANONE",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0.79
            },
            new Price {
                Underlying="DANONE",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 3.84
            },
            new Price {
                Underlying="EMC",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.01
            },
            new Price {
                Underlying="EMC",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 8.62
            },
            new Price {
                Underlying="EMC",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 10.64
            },
            new Price {
                Underlying="BNP PARIBAS",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 2.59
            },
            new Price {
                Underlying="BNP PARIBAS",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 8.16
            },
            new Price {
                Underlying="BNP PARIBAS",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 16.26
            },
            new Price {
                Underlying="BNP PARIBAS",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 7.78
            },
            new Price {
                Underlying="BNP PARIBAS",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 12.33
            },
            new Price {
                Underlying="BNP PARIBAS",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 16.35
            },
            new Price {
                Underlying="ENEL",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 5.01
            },
            new Price {
                Underlying="ENEL",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 7.6
            },
            new Price {
                Underlying="ENEL",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 9.72
            },
            new Price {
                Underlying="FRANCE TELECOM",
                Maturity="3M",
                Barrier= 60,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="FRANCE TELECOM",
                Maturity="3M",
                Barrier= 70,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 0.49
            },
            new Price {
                Underlying="FRANCE TELECOM",
                Maturity="3M",
                Barrier= 80,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 4.35
            },
            new Price {
                Underlying="FRANCE TELECOM",
                Maturity="6M",
                Barrier= 60,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 0.86
            },
            new Price {
                Underlying="FRANCE TELECOM",
                Maturity="6M",
                Barrier= 70,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 3.41
            },
            new Price {
                Underlying="FRANCE TELECOM",
                Maturity="6M",
                Barrier= 80,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 7.18
            },
            new Price {
                Underlying="ENI",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 3.94
            },
            new Price {
                Underlying="ENI",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 6.4
            },
            new Price {
                Underlying="ENI",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 8.7
            },
            new Price {
                Underlying="L&apos;OREAL",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="L&apos;OREAL",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="L&apos;OREAL",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 1.19
            },
            new Price {
                Underlying="L&apos;OREAL",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="L&apos;OREAL",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 1.6
            },
            new Price {
                Underlying="L&apos;OREAL",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 5.15
            },
            new Price {
                Underlying="ESTX50 EURP",
                Maturity="12M",
                Barrier= 60,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 3.06
            },
            new Price {
                Underlying="ESTX50 EURP",
                Maturity="12M",
                Barrier= 70,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 5.23
            },
            new Price {
                Underlying="ESTX50 EURP",
                Maturity="12M",
                Barrier= 80,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 7.52
            },
            new Price {
                Underlying="LVMH",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="LVMH",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="LVMH",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 3.35
            },
            new Price {
                Underlying="LVMH",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0.38
            },
            new Price {
                Underlying="LVMH",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 3.12
            },
            new Price {
                Underlying="LVMH",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 7.74
            },
            new Price {
                Underlying="ESTX50 EURP",
                Maturity="12M",
                Barrier= 60,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 2.79
            },
            new Price {
                Underlying="ESTX50 EURP",
                Maturity="12M",
                Barrier= 70,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 4.93
            },
            new Price {
                Underlying="ESTX50 EURP",
                Maturity="12M",
                Barrier= 80,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 7.19
            },
            new Price {
                Underlying="RENAULT",
                Maturity="3M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 0.99
            },
            new Price {
                Underlying="RENAULT",
                Maturity="3M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 5.7
            },
            new Price {
                Underlying="RENAULT",
                Maturity="3M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 13.86
            },
            new Price {
                Underlying="RENAULT",
                Maturity="6M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 6.07
            },
            new Price {
                Underlying="RENAULT",
                Maturity="6M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 10.98
            },
            new Price {
                Underlying="RENAULT",
                Maturity="6M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 15.6
            },
            new Price {
                Underlying="Eurasian Natural Resources Corp. PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 10.39
            },
            new Price {
                Underlying="Eurasian Natural Resources Corp. PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 13.24
            },
            new Price {
                Underlying="Eurasian Natural Resources Corp. PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 14.95
            },
            new Price {
                Underlying="SAINT GOBAIN",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 0.02
            },
            new Price {
                Underlying="SAINT GOBAIN",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 3.62
            },
            new Price {
                Underlying="SAINT GOBAIN",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 10.91
            },
            new Price {
                Underlying="SAINT GOBAIN",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 4.21
            },
            new Price {
                Underlying="SAINT GOBAIN",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 8.75
            },
            new Price {
                Underlying="SAINT GOBAIN",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 13.56
            },
            new Price {
                Underlying="EXXON MOBIL",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 2.18
            },
            new Price {
                Underlying="EXXON MOBIL",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 3.75
            },
            new Price {
                Underlying="EXXON MOBIL",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 5.65
            },
            new Price {
                Underlying="ROY.PHILIPS ELECTR",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ROY.PHILIPS ELECTR",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 0.07
            },
            new Price {
                Underlying="ROY.PHILIPS ELECTR",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 3.99
            },
            new Price {
                Underlying="ROY.PHILIPS ELECTR",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 1.4
            },
            new Price {
                Underlying="ROY.PHILIPS ELECTR",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 4.81
            },
            new Price {
                Underlying="ROY.PHILIPS ELECTR",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 9.78
            },
            new Price {
                Underlying="Facebook Inc",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 15.25
            },
            new Price {
                Underlying="Facebook Inc",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 17.86
            },
            new Price {
                Underlying="Facebook Inc",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 19.14
            },
            new Price {
                Underlying="ING GROEP",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 2.75
            },
            new Price {
                Underlying="ING GROEP",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 8.46
            },
            new Price {
                Underlying="ING GROEP",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 16.75
            },
            new Price {
                Underlying="ING GROEP",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 8.43
            },
            new Price {
                Underlying="ING GROEP",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 13.08
            },
            new Price {
                Underlying="ING GROEP",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 17.08
            },
            new Price {
                Underlying="Fiat",
                Maturity="12M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 12.69
            },
            new Price {
                Underlying="Fiat",
                Maturity="12M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 14.94
            },
            new Price {
                Underlying="Fiat",
                Maturity="12M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 16.15
            },
            new Price {
                Underlying="SCHNEIDER ELECTRIC",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 0.62
            },
            new Price {
                Underlying="SCHNEIDER ELECTRIC",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 4.96
            },
            new Price {
                Underlying="SCHNEIDER ELECTRIC",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 12.85
            },
            new Price {
                Underlying="SCHNEIDER ELECTRIC",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 4.57
            },
            new Price {
                Underlying="SCHNEIDER ELECTRIC",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 9.18
            },
            new Price {
                Underlying="SCHNEIDER ELECTRIC",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 13.92
            },
            new Price {
                Underlying="FRANCE TELECOM",
                Maturity="12M",
                Barrier= 60,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 3.87
            },
            new Price {
                Underlying="FRANCE TELECOM",
                Maturity="12M",
                Barrier= 70,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 6.83
            },
            new Price {
                Underlying="FRANCE TELECOM",
                Maturity="12M",
                Barrier= 80,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 9.56
            },
            new Price {
                Underlying="TOTAL",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="TOTAL",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="TOTAL",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 2.41
            },
            new Price {
                Underlying="TOTAL",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0.27
            },
            new Price {
                Underlying="TOTAL",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 2.51
            },
            new Price {
                Underlying="TOTAL",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 6.37
            },
            new Price {
                Underlying="FREEPORT MCMORAN COPPER & GOLD INC",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 9.83
            },
            new Price {
                Underlying="FREEPORT MCMORAN COPPER & GOLD INC",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 12.57
            },
            new Price {
                Underlying="FREEPORT MCMORAN COPPER & GOLD INC",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 14.34
            },
            new Price {
                Underlying="SANOFI-AVENTIS",
                Maturity="3M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SANOFI-AVENTIS",
                Maturity="3M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SANOFI-AVENTIS",
                Maturity="3M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 1.99
            },
            new Price {
                Underlying="SANOFI-AVENTIS",
                Maturity="6M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SANOFI-AVENTIS",
                Maturity="6M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 1.8
            },
            new Price {
                Underlying="SANOFI-AVENTIS",
                Maturity="6M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 5.14
            },
            new Price {
                Underlying="FRESENIUS MED CARE",
                Maturity="12M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="EUR",
                CouponToday= (decimal) 0.6
            },
            new Price {
                Underlying="FRESENIUS MED CARE",
                Maturity="12M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="EUR",
                CouponToday= (decimal) 2.58
            },
            new Price {
                Underlying="FRESENIUS MED CARE",
                Maturity="12M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="EUR",
                CouponToday= (decimal) 5.13
            },
            new Price {
                Underlying="STE GENERALE-A-",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 4.44
            },
            new Price {
                Underlying="STE GENERALE-A-",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 11.32
            },
            new Price {
                Underlying="STE GENERALE-A-",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 20.24
            },
            new Price {
                Underlying="STE GENERALE-A-",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 9.64
            },
            new Price {
                Underlying="STE GENERALE-A-",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 14.54
            },
            new Price {
                Underlying="STE GENERALE-A-",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 18.51
            },
            new Price {
                Underlying="FTSE 100",
                Maturity="12M",
                Barrier= 60,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 1.62
            },
            new Price {
                Underlying="FTSE 100",
                Maturity="12M",
                Barrier= 70,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 3.22
            },
            new Price {
                Underlying="FTSE 100",
                Maturity="12M",
                Barrier= 80,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 5.02
            },
            new Price {
                Underlying="UNILEVER CERT",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="UNILEVER CERT",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="UNILEVER CERT",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="UNILEVER CERT",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="UNILEVER CERT",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0.15
            },
            new Price {
                Underlying="UNILEVER CERT",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 2.52
            },
            new Price {
                Underlying="GAZPROM ADR",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 6.68
            },
            new Price {
                Underlying="GAZPROM ADR",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 9.49
            },
            new Price {
                Underlying="GAZPROM ADR",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 11.56
            },
            new Price {
                Underlying="VINCI",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="VINCI",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 0.89
            },
            new Price {
                Underlying="VINCI",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 6.68
            },
            new Price {
                Underlying="VINCI",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 2.2
            },
            new Price {
                Underlying="VINCI",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 6.49
            },
            new Price {
                Underlying="VINCI",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 12.24
            },
            new Price {
                Underlying="GDF SUEZ",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 2.86
            },
            new Price {
                Underlying="GDF SUEZ",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 5.35
            },
            new Price {
                Underlying="GDF SUEZ",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 7.79
            },
            new Price {
                Underlying="VIVENDI",
                Maturity="3M",
                Barrier= 60,
                Sector="telecom",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="VIVENDI",
                Maturity="3M",
                Barrier= 70,
                Sector="telecom",
                Currency="EUR",
                CouponToday= (decimal) 2
            },
            new Price {
                Underlying="VIVENDI",
                Maturity="3M",
                Barrier= 80,
                Sector="telecom",
                Currency="EUR",
                CouponToday= (decimal) 8.09
            },
            new Price {
                Underlying="VIVENDI",
                Maturity="6M",
                Barrier= 60,
                Sector="telecom",
                Currency="EUR",
                CouponToday= (decimal) 2.18
            },
            new Price {
                Underlying="VIVENDI",
                Maturity="6M",
                Barrier= 70,
                Sector="telecom",
                Currency="EUR",
                CouponToday= (decimal) 6.28
            },
            new Price {
                Underlying="VIVENDI",
                Maturity="6M",
                Barrier= 80,
                Sector="telecom",
                Currency="EUR",
                CouponToday= (decimal) 11.97
            },
            new Price {
                Underlying="GEBERIT N",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 1.54
            },
            new Price {
                Underlying="GEBERIT N",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 3.49
            },
            new Price {
                Underlying="GEBERIT N",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 5.7
            },
            new Price {
                Underlying="TRANSOCEAN N",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="TRANSOCEAN N",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="CHF",
                CouponToday= (decimal) 1.31
            },
            new Price {
                Underlying="TRANSOCEAN N",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="CHF",
                CouponToday= (decimal) 7.42
            },
            new Price {
                Underlying="TRANSOCEAN N",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="CHF",
                CouponToday= (decimal) 2.45
            },
            new Price {
                Underlying="TRANSOCEAN N",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="CHF",
                CouponToday= (decimal) 6.49
            },
            new Price {
                Underlying="TRANSOCEAN N",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="CHF",
                CouponToday= (decimal) 11.29
            },
            new Price {
                Underlying="GENERAL ELECTRIC",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.04
            },
            new Price {
                Underlying="GENERAL ELECTRIC",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.29
            },
            new Price {
                Underlying="GENERAL ELECTRIC",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 8.56
            },
            new Price {
                Underlying="GDF SUEZ",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GDF SUEZ",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GDF SUEZ",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 1.6
            },
            new Price {
                Underlying="GDF SUEZ",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GDF SUEZ",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 2.29
            },
            new Price {
                Underlying="GDF SUEZ",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 6.69
            },
            new Price {
                Underlying="GENERALI",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 6.78
            },
            new Price {
                Underlying="GENERALI",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 9.13
            },
            new Price {
                Underlying="GENERALI",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 10.87
            },
            new Price {
                Underlying="TELEFONICA",
                Maturity="3M",
                Barrier= 60,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="TELEFONICA",
                Maturity="3M",
                Barrier= 70,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 2.26
            },
            new Price {
                Underlying="TELEFONICA",
                Maturity="3M",
                Barrier= 80,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 7.73
            },
            new Price {
                Underlying="TELEFONICA",
                Maturity="6M",
                Barrier= 60,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 2.96
            },
            new Price {
                Underlying="TELEFONICA",
                Maturity="6M",
                Barrier= 70,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 6.5
            },
            new Price {
                Underlying="TELEFONICA",
                Maturity="6M",
                Barrier= 80,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 10.61
            },
            new Price {
                Underlying="Georg Fischer AG",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 2.5
            },
            new Price {
                Underlying="Georg Fischer AG",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 6.11
            },
            new Price {
                Underlying="Georg Fischer AG",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 9.3
            },
            new Price {
                Underlying="ARCELOR MITTAL",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 2.14
            },
            new Price {
                Underlying="ARCELOR MITTAL",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 8.46
            },
            new Price {
                Underlying="ARCELOR MITTAL",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 18.29
            },
            new Price {
                Underlying="ARCELOR MITTAL",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 7.74
            },
            new Price {
                Underlying="ARCELOR MITTAL",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 13.25
            },
            new Price {
                Underlying="ARCELOR MITTAL",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 18.06
            },
            new Price {
                Underlying="Gerdau SA COSG",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 10.1
            },
            new Price {
                Underlying="Gerdau SA COSG",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 12.87
            },
            new Price {
                Underlying="Gerdau SA COSG",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 14.55
            },
            new Price {
                Underlying="BBVA R",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 2.56
            },
            new Price {
                Underlying="BBVA R",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 7.92
            },
            new Price {
                Underlying="BBVA R",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 15.82
            },
            new Price {
                Underlying="BBVA R",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 7.77
            },
            new Price {
                Underlying="BBVA R",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 12.02
            },
            new Price {
                Underlying="BBVA R",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 15.97
            },
            new Price {
                Underlying="GIVAUDAN N",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0.56
            },
            new Price {
                Underlying="GIVAUDAN N",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 2.17
            },
            new Price {
                Underlying="GIVAUDAN N",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 4.26
            },
            new Price {
                Underlying="IBERDROLA",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 1.03
            },
            new Price {
                Underlying="IBERDROLA",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 5.57
            },
            new Price {
                Underlying="IBERDROLA",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 13.5
            },
            new Price {
                Underlying="IBERDROLA",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 4.32
            },
            new Price {
                Underlying="IBERDROLA",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 8.41
            },
            new Price {
                Underlying="IBERDROLA",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 12.88
            },
            new Price {
                Underlying="GlaxoSmithKline PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Health Care",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GlaxoSmithKline PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Health Care",
                Currency="EUR",
                CouponToday= (decimal) 1.23
            },
            new Price {
                Underlying="GlaxoSmithKline PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Health Care",
                Currency="EUR",
                CouponToday= (decimal) 3.63
            },
            new Price {
                Underlying="REPSOL YPF",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 1.83
            },
            new Price {
                Underlying="REPSOL YPF",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 7.39
            },
            new Price {
                Underlying="REPSOL YPF",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 16.53
            },
            new Price {
                Underlying="REPSOL YPF",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 6.35
            },
            new Price {
                Underlying="REPSOL YPF",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 11.09
            },
            new Price {
                Underlying="REPSOL YPF",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 15.77
            },
            new Price {
                Underlying="Goldcorp Inc.",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 7.87
            },
            new Price {
                Underlying="Goldcorp Inc.",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 11.01
            },
            new Price {
                Underlying="Goldcorp Inc.",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 13.08
            },
            new Price {
                Underlying="GENERALI",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 0.28
            },
            new Price {
                Underlying="GENERALI",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 3.73
            },
            new Price {
                Underlying="GENERALI",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 10.19
            },
            new Price {
                Underlying="GENERALI",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 4.3
            },
            new Price {
                Underlying="GENERALI",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 8.13
            },
            new Price {
                Underlying="GENERALI",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 12.21
            },
            new Price {
                Underlying="GOLDMAN SACHS GROUP INC",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 5.76
            },
            new Price {
                Underlying="GOLDMAN SACHS GROUP INC",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 8.12
            },
            new Price {
                Underlying="GOLDMAN SACHS GROUP INC",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 10.09
            },
            new Price {
                Underlying="UNICREDITO",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 2.93
            },
            new Price {
                Underlying="UNICREDITO",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 8.76
            },
            new Price {
                Underlying="UNICREDITO",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 17.07
            },
            new Price {
                Underlying="UNICREDITO",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 8.15
            },
            new Price {
                Underlying="UNICREDITO",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 13.07
            },
            new Price {
                Underlying="UNICREDITO",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 17.29
            },
            new Price {
                Underlying="GOOGLE-A",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 3.37
            },
            new Price {
                Underlying="GOOGLE-A",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.06
            },
            new Price {
                Underlying="GOOGLE-A",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 8.54
            },
            new Price {
                Underlying="INTESA",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 3.18
            },
            new Price {
                Underlying="INTESA",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 9.51
            },
            new Price {
                Underlying="INTESA",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 18.36
            },
            new Price {
                Underlying="INTESA",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 9.1
            },
            new Price {
                Underlying="INTESA",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 14.21
            },
            new Price {
                Underlying="INTESA",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 18.37
            },
            new Price {
                Underlying="HALLIBURTON CO",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 7.98
            },
            new Price {
                Underlying="HALLIBURTON CO",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 10.54
            },
            new Price {
                Underlying="HALLIBURTON CO",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 12.32
            },
            new Price {
                Underlying="ENI",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ENI",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ENI",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 3.01
            },
            new Price {
                Underlying="ENI",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0.55
            },
            new Price {
                Underlying="ENI",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 2.96
            },
            new Price {
                Underlying="ENI",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 6.7
            },
            new Price {
                Underlying="HDFC Bank Ltd Sp. ADR",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 3.4
            },
            new Price {
                Underlying="HDFC Bank Ltd Sp. ADR",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 6.26
            },
            new Price {
                Underlying="HDFC Bank Ltd Sp. ADR",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 8.83
            },
            new Price {
                Underlying="ENEL",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ENEL",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 1.09
            },
            new Price {
                Underlying="ENEL",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 5.92
            },
            new Price {
                Underlying="ENEL",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 1.5
            },
            new Price {
                Underlying="ENEL",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 4.49
            },
            new Price {
                Underlying="ENEL",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 8.51
            },
            new Price {
                Underlying="Helvetia Holding AG",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 2.43
            },
            new Price {
                Underlying="Helvetia Holding AG",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 5.29
            },
            new Price {
                Underlying="Helvetia Holding AG",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 8.13
            },
            new Price {
                Underlying="BANCO SANTANDER R",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 2.84
            },
            new Price {
                Underlying="BANCO SANTANDER R",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 8.43
            },
            new Price {
                Underlying="BANCO SANTANDER R",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 16.5
            },
            new Price {
                Underlying="BANCO SANTANDER R",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 8.05
            },
            new Price {
                Underlying="BANCO SANTANDER R",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 12.44
            },
            new Price {
                Underlying="BANCO SANTANDER R",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 16.51
            },
            new Price {
                Underlying="HENKEL VZ",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 1.25
            },
            new Price {
                Underlying="HENKEL VZ",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 3.45
            },
            new Price {
                Underlying="HENKEL VZ",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 5.97
            },
            new Price {
                Underlying="MERCK KGAA",
                Maturity="3M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="MERCK KGAA",
                Maturity="3M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="MERCK KGAA",
                Maturity="3M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 1.22
            },
            new Price {
                Underlying="MERCK KGAA",
                Maturity="6M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="MERCK KGAA",
                Maturity="6M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 1.45
            },
            new Price {
                Underlying="MERCK KGAA",
                Maturity="6M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 4.79
            },
            new Price {
                Underlying="Hennes & Mauritz",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 1.49
            },
            new Price {
                Underlying="Hennes & Mauritz",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 3.64
            },
            new Price {
                Underlying="Hennes & Mauritz",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 6.05
            },
            new Price {
                Underlying="VOLKSWAGEN",
                Maturity="3M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="VOLKSWAGEN",
                Maturity="3M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 0.96
            },
            new Price {
                Underlying="VOLKSWAGEN",
                Maturity="3M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 6.49
            },
            new Price {
                Underlying="VOLKSWAGEN",
                Maturity="6M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 2.12
            },
            new Price {
                Underlying="VOLKSWAGEN",
                Maturity="6M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 6.01
            },
            new Price {
                Underlying="VOLKSWAGEN",
                Maturity="6M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 11.14
            },
            new Price {
                Underlying="HEWLETT-PACKARD",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 11.03
            },
            new Price {
                Underlying="HEWLETT-PACKARD",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 14.19
            },
            new Price {
                Underlying="HEWLETT-PACKARD",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 16.02
            },
            new Price {
                Underlying="ANHEUS.-BUSCH INBEV",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ANHEUS.-BUSCH INBEV",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ANHEUS.-BUSCH INBEV",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 2.84
            },
            new Price {
                Underlying="ANHEUS.-BUSCH INBEV",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0.73
            },
            new Price {
                Underlying="ANHEUS.-BUSCH INBEV",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 3.3
            },
            new Price {
                Underlying="ANHEUS.-BUSCH INBEV",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 7.34
            },
            new Price {
                Underlying="HOLCIM N",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 2.48
            },
            new Price {
                Underlying="HOLCIM N",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 4.82
            },
            new Price {
                Underlying="HOLCIM N",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 7.1
            },
            new Price {
                Underlying="LAFARGE",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="LAFARGE",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 2.88
            },
            new Price {
                Underlying="LAFARGE",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 9.3
            },
            new Price {
                Underlying="LAFARGE",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 3.49
            },
            new Price {
                Underlying="LAFARGE",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 7.38
            },
            new Price {
                Underlying="LAFARGE",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 11.77
            },
            new Price {
                Underlying="HOME DEPTO INC",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 4.01
            },
            new Price {
                Underlying="HOME DEPTO INC",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 6.1
            },
            new Price {
                Underlying="HOME DEPTO INC",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 8.2
            },
            new Price {
                Underlying="BANK OF AMERICA",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 3.28
            },
            new Price {
                Underlying="BANK OF AMERICA",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 8.57
            },
            new Price {
                Underlying="BANK OF AMERICA",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 16.69
            },
            new Price {
                Underlying="BANK OF AMERICA",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 7.66
            },
            new Price {
                Underlying="BANK OF AMERICA",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 12.04
            },
            new Price {
                Underlying="BANK OF AMERICA",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 16.31
            },
            new Price {
                Underlying="HONEYWELL INTERNATIONAL INC",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.35
            },
            new Price {
                Underlying="HONEYWELL INTERNATIONAL INC",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.51
            },
            new Price {
                Underlying="HONEYWELL INTERNATIONAL INC",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 8.52
            },
            new Price {
                Underlying="NEWMONT MINING",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 0.35
            },
            new Price {
                Underlying="NEWMONT MINING",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 3.31
            },
            new Price {
                Underlying="NEWMONT MINING",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 10
            },
            new Price {
                Underlying="NEWMONT MINING",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 3.7
            },
            new Price {
                Underlying="NEWMONT MINING",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 7.88
            },
            new Price {
                Underlying="NEWMONT MINING",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 13.09
            },
            new Price {
                Underlying="HSBC Holdings PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 1
            },
            new Price {
                Underlying="HSBC Holdings PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 2.91
            },
            new Price {
                Underlying="HSBC Holdings PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 5.25
            },
            new Price {
                Underlying="GOOGLE-A",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GOOGLE-A",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0.51
            },
            new Price {
                Underlying="GOOGLE-A",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.62
            },
            new Price {
                Underlying="GOOGLE-A",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0.71
            },
            new Price {
                Underlying="GOOGLE-A",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 3.23
            },
            new Price {
                Underlying="GOOGLE-A",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 7.57
            },
            new Price {
                Underlying="IBERDROLA",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 6.82
            },
            new Price {
                Underlying="IBERDROLA",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 9.39
            },
            new Price {
                Underlying="IBERDROLA",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 11.41
            },
            new Price {
                Underlying="AMGEN",
                Maturity="3M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="AMGEN",
                Maturity="3M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="USD",
                CouponToday= (decimal) 1.48
            },
            new Price {
                Underlying="AMGEN",
                Maturity="3M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="USD",
                CouponToday= (decimal) 4.84
            },
            new Price {
                Underlying="AMGEN",
                Maturity="6M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="USD",
                CouponToday= (decimal) 1.65
            },
            new Price {
                Underlying="AMGEN",
                Maturity="6M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="USD",
                CouponToday= (decimal) 3.69
            },
            new Price {
                Underlying="AMGEN",
                Maturity="6M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="USD",
                CouponToday= (decimal) 6.88
            },
            new Price {
                Underlying="IBM",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 2.08
            },
            new Price {
                Underlying="IBM",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.07
            },
            new Price {
                Underlying="IBM",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.39
            },
            new Price {
                Underlying="3M CO",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="3M CO",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="3M CO",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 1.72
            },
            new Price {
                Underlying="3M CO",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0.37
            },
            new Price {
                Underlying="3M CO",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 1.98
            },
            new Price {
                Underlying="3M CO",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.89
            },
            new Price {
                Underlying="ICICI BANK ADR",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 7.76
            },
            new Price {
                Underlying="ICICI BANK ADR",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 10.3
            },
            new Price {
                Underlying="ICICI BANK ADR",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 12.03
            },
            new Price {
                Underlying="ALTRIA GROUP INC",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ALTRIA GROUP INC",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ALTRIA GROUP INC",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 1.09
            },
            new Price {
                Underlying="ALTRIA GROUP INC",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0.14
            },
            new Price {
                Underlying="ALTRIA GROUP INC",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 1.37
            },
            new Price {
                Underlying="ALTRIA GROUP INC",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 3.91
            },
            new Price {
                Underlying="Imperial Tobacco Group PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Imperial Tobacco Group PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 1.39
            },
            new Price {
                Underlying="Imperial Tobacco Group PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 4.28
            },
            new Price {
                Underlying="AMERICAN EXPRESS CO",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="AMERICAN EXPRESS CO",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 0.53
            },
            new Price {
                Underlying="AMERICAN EXPRESS CO",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 3.73
            },
            new Price {
                Underlying="AMERICAN EXPRESS CO",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 1.43
            },
            new Price {
                Underlying="AMERICAN EXPRESS CO",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 3.7
            },
            new Price {
                Underlying="AMERICAN EXPRESS CO",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 7.16
            },
            new Price {
                Underlying="INFINEON TECHNO N",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 8.49
            },
            new Price {
                Underlying="INFINEON TECHNO N",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 11.3
            },
            new Price {
                Underlying="INFINEON TECHNO N",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 13.08
            },
            new Price {
                Underlying="HOME DEPTO INC",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="HOME DEPTO INC",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0.94
            },
            new Price {
                Underlying="HOME DEPTO INC",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 4.35
            },
            new Price {
                Underlying="HOME DEPTO INC",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 1.64
            },
            new Price {
                Underlying="HOME DEPTO INC",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 3.81
            },
            new Price {
                Underlying="HOME DEPTO INC",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 7.24
            },
            new Price {
                Underlying="INFOSYS ADR",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.71
            },
            new Price {
                Underlying="INFOSYS ADR",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 9.22
            },
            new Price {
                Underlying="INFOSYS ADR",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 11.04
            },
            new Price {
                Underlying="HONEYWELL INTERNATIONAL INC",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="HONEYWELL INTERNATIONAL INC",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0.63
            },
            new Price {
                Underlying="HONEYWELL INTERNATIONAL INC",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 3.96
            },
            new Price {
                Underlying="HONEYWELL INTERNATIONAL INC",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 1.71
            },
            new Price {
                Underlying="HONEYWELL INTERNATIONAL INC",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.13
            },
            new Price {
                Underlying="HONEYWELL INTERNATIONAL INC",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 7.69
            },
            new Price {
                Underlying="ING GROEP",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 10.24
            },
            new Price {
                Underlying="ING GROEP",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 12.59
            },
            new Price {
                Underlying="ING GROEP",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 14.01
            },
            new Price {
                Underlying="WALT DISNEY COMPANY",
                Maturity="3M",
                Barrier= 60,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WALT DISNEY COMPANY",
                Maturity="3M",
                Barrier= 70,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 0.95
            },
            new Price {
                Underlying="WALT DISNEY COMPANY",
                Maturity="3M",
                Barrier= 80,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 4.84
            },
            new Price {
                Underlying="WALT DISNEY COMPANY",
                Maturity="6M",
                Barrier= 60,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 1.62
            },
            new Price {
                Underlying="WALT DISNEY COMPANY",
                Maturity="6M",
                Barrier= 70,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 4
            },
            new Price {
                Underlying="WALT DISNEY COMPANY",
                Maturity="6M",
                Barrier= 80,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 7.59
            },
            new Price {
                Underlying="INTEL",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.37
            },
            new Price {
                Underlying="INTEL",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.85
            },
            new Price {
                Underlying="INTEL",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 9.28
            },
            new Price {
                Underlying="VERIZON COMMUNICATIONS INC",
                Maturity="3M",
                Barrier= 60,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="VERIZON COMMUNICATIONS INC",
                Maturity="3M",
                Barrier= 70,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 0.14
            },
            new Price {
                Underlying="VERIZON COMMUNICATIONS INC",
                Maturity="3M",
                Barrier= 80,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 2.42
            },
            new Price {
                Underlying="VERIZON COMMUNICATIONS INC",
                Maturity="6M",
                Barrier= 60,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 0.49
            },
            new Price {
                Underlying="VERIZON COMMUNICATIONS INC",
                Maturity="6M",
                Barrier= 70,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 1.95
            },
            new Price {
                Underlying="VERIZON COMMUNICATIONS INC",
                Maturity="6M",
                Barrier= 80,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 4.68
            },
            new Price {
                Underlying="INTESA",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 11.23
            },
            new Price {
                Underlying="INTESA",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 13.71
            },
            new Price {
                Underlying="INTESA",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 15.14
            },
            new Price {
                Underlying="JOHNSON & JOHNSON",
                Maturity="3M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="JOHNSON & JOHNSON",
                Maturity="3M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="JOHNSON & JOHNSON",
                Maturity="3M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="JOHNSON & JOHNSON",
                Maturity="6M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="JOHNSON & JOHNSON",
                Maturity="6M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="JOHNSON & JOHNSON",
                Maturity="6M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="USD",
                CouponToday= (decimal) 1.36
            },
            new Price {
                Underlying="ITAU UNIBANCO ADR",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 6.46
            },
            new Price {
                Underlying="ITAU UNIBANCO ADR",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 9.19
            },
            new Price {
                Underlying="ITAU UNIBANCO ADR",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 11.23
            },
            new Price {
                Underlying="UNITED TECHNOOLOGIES CORP",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="UNITED TECHNOOLOGIES CORP",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 1.26
            },
            new Price {
                Underlying="UNITED TECHNOOLOGIES CORP",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.74
            },
            new Price {
                Underlying="UNITED TECHNOOLOGIES CORP",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 1.85
            },
            new Price {
                Underlying="UNITED TECHNOOLOGIES CORP",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.08
            },
            new Price {
                Underlying="UNITED TECHNOOLOGIES CORP",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 7.4
            },
            new Price {
                Underlying="JOHNSON & JOHNSON",
                Maturity="12M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="USD",
                CouponToday= (decimal) 0.24
            },
            new Price {
                Underlying="JOHNSON & JOHNSON",
                Maturity="12M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="USD",
                CouponToday= (decimal) 1.33
            },
            new Price {
                Underlying="JOHNSON & JOHNSON",
                Maturity="12M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="USD",
                CouponToday= (decimal) 3.32
            },
            new Price {
                Underlying="ORACLE CORP",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ORACLE CORP",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 1.01
            },
            new Price {
                Underlying="ORACLE CORP",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.79
            },
            new Price {
                Underlying="ORACLE CORP",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 1.91
            },
            new Price {
                Underlying="ORACLE CORP",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.48
            },
            new Price {
                Underlying="ORACLE CORP",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 8.24
            },
            new Price {
                Underlying="JPMORGAN CHASE",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 6.53
            },
            new Price {
                Underlying="JPMORGAN CHASE",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 8.87
            },
            new Price {
                Underlying="JPMORGAN CHASE",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 10.79
            },
            new Price {
                Underlying="DELL INC",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 1.7
            },
            new Price {
                Underlying="DELL INC",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.42
            },
            new Price {
                Underlying="DELL INC",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 15.01
            },
            new Price {
                Underlying="DELL INC",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 5.44
            },
            new Price {
                Underlying="DELL INC",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 10.5
            },
            new Price {
                Underlying="DELL INC",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 15.92
            },
            new Price {
                Underlying="JULIUS BAER GRP N",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 3.2
            },
            new Price {
                Underlying="JULIUS BAER GRP N",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 5.77
            },
            new Price {
                Underlying="JULIUS BAER GRP N",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 8.11
            },
            new Price {
                Underlying="GOLDMAN SACHS GROUP INC",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 0.77
            },
            new Price {
                Underlying="GOLDMAN SACHS GROUP INC",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 3.53
            },
            new Price {
                Underlying="GOLDMAN SACHS GROUP INC",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 8.9
            },
            new Price {
                Underlying="GOLDMAN SACHS GROUP INC",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 3.64
            },
            new Price {
                Underlying="GOLDMAN SACHS GROUP INC",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 6.84
            },
            new Price {
                Underlying="GOLDMAN SACHS GROUP INC",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 10.86
            },
            new Price {
                Underlying="K+S",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 2.95
            },
            new Price {
                Underlying="K+S",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 5.73
            },
            new Price {
                Underlying="K+S",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 8.39
            },
            new Price {
                Underlying="HALLIBURTON CO",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 1.18
            },
            new Price {
                Underlying="HALLIBURTON CO",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 5.12
            },
            new Price {
                Underlying="HALLIBURTON CO",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 12.47
            },
            new Price {
                Underlying="HALLIBURTON CO",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 5.35
            },
            new Price {
                Underlying="HALLIBURTON CO",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 9.56
            },
            new Price {
                Underlying="HALLIBURTON CO",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 14.08
            },
            new Price {
                Underlying="Kaba",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Kaba",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Kaba",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0.92
            },
            new Price {
                Underlying="WELLS FARGO & CO",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WELLS FARGO & CO",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 1.93
            },
            new Price {
                Underlying="WELLS FARGO & CO",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 6.48
            },
            new Price {
                Underlying="WELLS FARGO & CO",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 2.1
            },
            new Price {
                Underlying="WELLS FARGO & CO",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 4.8
            },
            new Price {
                Underlying="WELLS FARGO & CO",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 8.7
            },
            new Price {
                Underlying="KUEHNE+NAGEL INT N",
                Maturity="12M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 2.18
            },
            new Price {
                Underlying="KUEHNE+NAGEL INT N",
                Maturity="12M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 4.82
            },
            new Price {
                Underlying="KUEHNE+NAGEL INT N",
                Maturity="12M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 7.43
            },
            new Price {
                Underlying="MONDELEZ INTERNATIONAL INC",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="MONDELEZ INTERNATIONAL INC",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="MONDELEZ INTERNATIONAL INC",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0.35
            },
            new Price {
                Underlying="MONDELEZ INTERNATIONAL INC",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="MONDELEZ INTERNATIONAL INC",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0.43
            },
            new Price {
                Underlying="MONDELEZ INTERNATIONAL INC",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 2.77
            },
            new Price {
                Underlying="LAFARGE",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 6.28
            },
            new Price {
                Underlying="LAFARGE",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 8.9
            },
            new Price {
                Underlying="LAFARGE",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 10.83
            },
            new Price {
                Underlying="FREEPORT MCMORAN COPPER & GOLD INC",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 2.34
            },
            new Price {
                Underlying="FREEPORT MCMORAN COPPER & GOLD INC",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 7.62
            },
            new Price {
                Underlying="FREEPORT MCMORAN COPPER & GOLD INC",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 16.29
            },
            new Price {
                Underlying="FREEPORT MCMORAN COPPER & GOLD INC",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 7.21
            },
            new Price {
                Underlying="FREEPORT MCMORAN COPPER & GOLD INC",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 12.2
            },
            new Price {
                Underlying="FREEPORT MCMORAN COPPER & GOLD INC",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 16.98
            },
            new Price {
                Underlying="LINDE",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 1.34
            },
            new Price {
                Underlying="LINDE",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 3.51
            },
            new Price {
                Underlying="LINDE",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 6
            },
            new Price {
                Underlying="CONOCOPHILLIPS CO",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="CONOCOPHILLIPS CO",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 0.29
            },
            new Price {
                Underlying="CONOCOPHILLIPS CO",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 2.87
            },
            new Price {
                Underlying="CONOCOPHILLIPS CO",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 1.31
            },
            new Price {
                Underlying="CONOCOPHILLIPS CO",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 3.31
            },
            new Price {
                Underlying="CONOCOPHILLIPS CO",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 6.42
            },
            new Price {
                Underlying="Lindt & Sprungli",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Lindt & Sprungli",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0.71
            },
            new Price {
                Underlying="Lindt & Sprungli",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 3.05
            },
            new Price {
                Underlying="AMERICAN INTERNATIONAL GROUP INC",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="AMERICAN INTERNATIONAL GROUP INC",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 1.09
            },
            new Price {
                Underlying="AMERICAN INTERNATIONAL GROUP INC",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 5.81
            },
            new Price {
                Underlying="AMERICAN INTERNATIONAL GROUP INC",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 2.15
            },
            new Price {
                Underlying="AMERICAN INTERNATIONAL GROUP INC",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 5.47
            },
            new Price {
                Underlying="AMERICAN INTERNATIONAL GROUP INC",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 10.13
            },
            new Price {
                Underlying="LinkedIn Corp",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 14.42
            },
            new Price {
                Underlying="LinkedIn Corp",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 16.42
            },
            new Price {
                Underlying="LinkedIn Corp",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 17.45
            },
            new Price {
                Underlying="CHESAPEAKE ENERGY CORP",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 8.4
            },
            new Price {
                Underlying="CHESAPEAKE ENERGY CORP",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 15.14
            },
            new Price {
                Underlying="CHESAPEAKE ENERGY CORP",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 23.64
            },
            new Price {
                Underlying="CHESAPEAKE ENERGY CORP",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 12.39
            },
            new Price {
                Underlying="CHESAPEAKE ENERGY CORP",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 16.88
            },
            new Price {
                Underlying="CHESAPEAKE ENERGY CORP",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 20.69
            },
            new Price {
                Underlying="Lloyds Banking Group PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 8.26
            },
            new Price {
                Underlying="Lloyds Banking Group PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 10.49
            },
            new Price {
                Underlying="Lloyds Banking Group PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 11.96
            },
            new Price {
                Underlying="MORGAN STANLEY",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 4.93
            },
            new Price {
                Underlying="MORGAN STANLEY",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 11.04
            },
            new Price {
                Underlying="MORGAN STANLEY",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 19.61
            },
            new Price {
                Underlying="MORGAN STANLEY",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 9.33
            },
            new Price {
                Underlying="MORGAN STANLEY",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 14.08
            },
            new Price {
                Underlying="MORGAN STANLEY",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 18.33
            },
            new Price {
                Underlying="LOGITECH INTL N",
                Maturity="12M",
                Barrier= 60,
                Sector="Technololgy",
                Currency="CHF",
                CouponToday= (decimal) 9.16
            },
            new Price {
                Underlying="LOGITECH INTL N",
                Maturity="12M",
                Barrier= 70,
                Sector="Technololgy",
                Currency="CHF",
                CouponToday= (decimal) 12.46
            },
            new Price {
                Underlying="LOGITECH INTL N",
                Maturity="12M",
                Barrier= 80,
                Sector="Technololgy",
                Currency="CHF",
                CouponToday= (decimal) 14.32
            },
            new Price {
                Underlying="ABBOTT LABORATORIES",
                Maturity="3M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ABBOTT LABORATORIES",
                Maturity="3M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ABBOTT LABORATORIES",
                Maturity="3M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 0.81
            },
            new Price {
                Underlying="ABBOTT LABORATORIES",
                Maturity="6M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ABBOTT LABORATORIES",
                Maturity="6M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 0.98
            },
            new Price {
                Underlying="ABBOTT LABORATORIES",
                Maturity="6M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 3.35
            },
            new Price {
                Underlying="LONZA GRP N",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 3.37
            },
            new Price {
                Underlying="LONZA GRP N",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 6.41
            },
            new Price {
                Underlying="LONZA GRP N",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 9.13
            },
            new Price {
                Underlying="BRISTOL MYERS SQUIBB CO",
                Maturity="3M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BRISTOL MYERS SQUIBB CO",
                Maturity="3M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 0.08
            },
            new Price {
                Underlying="BRISTOL MYERS SQUIBB CO",
                Maturity="3M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 2.3
            },
            new Price {
                Underlying="BRISTOL MYERS SQUIBB CO",
                Maturity="6M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 0.77
            },
            new Price {
                Underlying="BRISTOL MYERS SQUIBB CO",
                Maturity="6M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 2.4
            },
            new Price {
                Underlying="BRISTOL MYERS SQUIBB CO",
                Maturity="6M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 5.23
            },
            new Price {
                Underlying="L&apos;OREAL",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 2.03
            },
            new Price {
                Underlying="L&apos;OREAL",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 4.1
            },
            new Price {
                Underlying="L&apos;OREAL",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 6.29
            },
            new Price {
                Underlying="ELI LILLY & CO",
                Maturity="3M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ELI LILLY & CO",
                Maturity="3M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 0.37
            },
            new Price {
                Underlying="ELI LILLY & CO",
                Maturity="3M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 3.55
            },
            new Price {
                Underlying="ELI LILLY & CO",
                Maturity="6M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 0.71
            },
            new Price {
                Underlying="ELI LILLY & CO",
                Maturity="6M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 2.67
            },
            new Price {
                Underlying="ELI LILLY & CO",
                Maturity="6M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 6.17
            },
            new Price {
                Underlying="LUKOIL ADR",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 4.31
            },
            new Price {
                Underlying="LUKOIL ADR",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 6.79
            },
            new Price {
                Underlying="LUKOIL ADR",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 9.09
            },
            new Price {
                Underlying="CISCO SYSTEMS INC",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0.55
            },
            new Price {
                Underlying="CISCO SYSTEMS INC",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 3.97
            },
            new Price {
                Underlying="CISCO SYSTEMS INC",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 11.16
            },
            new Price {
                Underlying="CISCO SYSTEMS INC",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 2.69
            },
            new Price {
                Underlying="CISCO SYSTEMS INC",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.38
            },
            new Price {
                Underlying="CISCO SYSTEMS INC",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 11.33
            },
            new Price {
                Underlying="LVMH",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 3.06
            },
            new Price {
                Underlying="LVMH",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 5.69
            },
            new Price {
                Underlying="LVMH",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 8.12
            },
            new Price {
                Underlying="Colgate Palmolive",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Colgate Palmolive",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Colgate Palmolive",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 1.64
            },
            new Price {
                Underlying="Colgate Palmolive",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Colgate Palmolive",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 1.2
            },
            new Price {
                Underlying="Colgate Palmolive",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 3.54
            },
            new Price {
                Underlying="MCDONALD&apos;S",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 1.1
            },
            new Price {
                Underlying="MCDONALD&apos;S",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 2.74
            },
            new Price {
                Underlying="MCDONALD&apos;S",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 5.16
            },
            new Price {
                Underlying="ROYAL DUTCH SHELL - A",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ROYAL DUTCH SHELL - A",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ROYAL DUTCH SHELL - A",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ROYAL DUTCH SHELL - A",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ROYAL DUTCH SHELL - A",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ROYAL DUTCH SHELL - A",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 2.11
            },
            new Price {
                Underlying="Merck & Co. Inc.",
                Maturity="12M",
                Barrier= 60,
                Sector="Health Care",
                Currency="USD",
                CouponToday= (decimal) 2.6
            },
            new Price {
                Underlying="Merck & Co. Inc.",
                Maturity="12M",
                Barrier= 70,
                Sector="Health Care",
                Currency="USD",
                CouponToday= (decimal) 4.39
            },
            new Price {
                Underlying="Merck & Co. Inc.",
                Maturity="12M",
                Barrier= 80,
                Sector="Health Care",
                Currency="USD",
                CouponToday= (decimal) 6.6
            },
            new Price {
                Underlying="AT&T Inc. Reg. Shares",
                Maturity="3M",
                Barrier= 60,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="AT&T Inc. Reg. Shares",
                Maturity="3M",
                Barrier= 70,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 0.22
            },
            new Price {
                Underlying="AT&T Inc. Reg. Shares",
                Maturity="3M",
                Barrier= 80,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 2.33
            },
            new Price {
                Underlying="AT&T Inc. Reg. Shares",
                Maturity="6M",
                Barrier= 60,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 0.51
            },
            new Price {
                Underlying="AT&T Inc. Reg. Shares",
                Maturity="6M",
                Barrier= 70,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 1.9
            },
            new Price {
                Underlying="AT&T Inc. Reg. Shares",
                Maturity="6M",
                Barrier= 80,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 4.52
            },
            new Price {
                Underlying="MERCK KGAA",
                Maturity="12M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 1.53
            },
            new Price {
                Underlying="MERCK KGAA",
                Maturity="12M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 3.56
            },
            new Price {
                Underlying="MERCK KGAA",
                Maturity="12M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 5.81
            },
            new Price {
                Underlying="MONSANTO",
                Maturity="3M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="MONSANTO",
                Maturity="3M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 1.7
            },
            new Price {
                Underlying="MONSANTO",
                Maturity="3M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 6.47
            },
            new Price {
                Underlying="MONSANTO",
                Maturity="6M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 2.06
            },
            new Price {
                Underlying="MONSANTO",
                Maturity="6M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 4.94
            },
            new Price {
                Underlying="MONSANTO",
                Maturity="6M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 9.01
            },
            new Price {
                Underlying="METRO",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 4.95
            },
            new Price {
                Underlying="METRO",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 8.45
            },
            new Price {
                Underlying="METRO",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 11.22
            },
            new Price {
                Underlying="Philip Morris Intl.",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Philip Morris Intl.",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Philip Morris Intl.",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 1.72
            },
            new Price {
                Underlying="Philip Morris Intl.",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0.22
            },
            new Price {
                Underlying="Philip Morris Intl.",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 1.76
            },
            new Price {
                Underlying="Philip Morris Intl.",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 4.78
            },
            new Price {
                Underlying="Meyer Burger Technology AG",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="CHF",
                CouponToday= (decimal) 1.67
            },
            new Price {
                Underlying="Meyer Burger Technology AG",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="CHF",
                CouponToday= (decimal) 5.84
            },
            new Price {
                Underlying="Meyer Burger Technology AG",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="CHF",
                CouponToday= (decimal) 9.77
            },
            new Price {
                Underlying="DU PONT NEMOURS&CO",
                Maturity="3M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DU PONT NEMOURS&CO",
                Maturity="3M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 0.83
            },
            new Price {
                Underlying="DU PONT NEMOURS&CO",
                Maturity="3M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 4.54
            },
            new Price {
                Underlying="DU PONT NEMOURS&CO",
                Maturity="6M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 1.4
            },
            new Price {
                Underlying="DU PONT NEMOURS&CO",
                Maturity="6M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 3.8
            },
            new Price {
                Underlying="DU PONT NEMOURS&CO",
                Maturity="6M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 7.55
            },
            new Price {
                Underlying="MICROSOFT",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 3.71
            },
            new Price {
                Underlying="MICROSOFT",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.17
            },
            new Price {
                Underlying="MICROSOFT",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 8.64
            },
            new Price {
                Underlying="CAC 40",
                Maturity="3M",
                Barrier= 60,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="CAC 40",
                Maturity="3M",
                Barrier= 70,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="CAC 40",
                Maturity="3M",
                Barrier= 80,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 3.61
            },
            new Price {
                Underlying="CAC 40",
                Maturity="6M",
                Barrier= 60,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 0.61
            },
            new Price {
                Underlying="CAC 40",
                Maturity="6M",
                Barrier= 70,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 2.91
            },
            new Price {
                Underlying="CAC 40",
                Maturity="6M",
                Barrier= 80,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 6.46
            },
            new Price {
                Underlying="MMC Norilsk Nickel Sp. ADR",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 7.19
            },
            new Price {
                Underlying="MMC Norilsk Nickel Sp. ADR",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 9.83
            },
            new Price {
                Underlying="MMC Norilsk Nickel Sp. ADR",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 11.73
            },
            new Price {
                Underlying="PORSCHE",
                Maturity="3M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="PORSCHE",
                Maturity="3M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 2.56
            },
            new Price {
                Underlying="PORSCHE",
                Maturity="3M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 9.91
            },
            new Price {
                Underlying="PORSCHE",
                Maturity="6M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 3.07
            },
            new Price {
                Underlying="PORSCHE",
                Maturity="6M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 7.27
            },
            new Price {
                Underlying="PORSCHE",
                Maturity="6M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 12.28
            },
            new Price {
                Underlying="MONDELEZ INTERNATIONAL INC",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0.91
            },
            new Price {
                Underlying="MONDELEZ INTERNATIONAL INC",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 2.41
            },
            new Price {
                Underlying="MONDELEZ INTERNATIONAL INC",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 4.63
            },
            new Price {
                Underlying="AEX",
                Maturity="3M",
                Barrier= 60,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="AEX",
                Maturity="3M",
                Barrier= 70,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="AEX",
                Maturity="3M",
                Barrier= 80,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 0.59
            },
            new Price {
                Underlying="AEX",
                Maturity="6M",
                Barrier= 60,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="AEX",
                Maturity="6M",
                Barrier= 70,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 1.19
            },
            new Price {
                Underlying="AEX",
                Maturity="6M",
                Barrier= 80,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 3.82
            },
            new Price {
                Underlying="MONSANTO",
                Maturity="12M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 4.94
            },
            new Price {
                Underlying="MONSANTO",
                Maturity="12M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 7.37
            },
            new Price {
                Underlying="MONSANTO",
                Maturity="12M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 9.46
            },
            new Price {
                Underlying="GAZPROM ADR",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GAZPROM ADR",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 1.95
            },
            new Price {
                Underlying="GAZPROM ADR",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 7.74
            },
            new Price {
                Underlying="GAZPROM ADR",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 2.7
            },
            new Price {
                Underlying="GAZPROM ADR",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 6.4
            },
            new Price {
                Underlying="GAZPROM ADR",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 10.84
            },
            new Price {
                Underlying="MORGAN STANLEY",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 10.87
            },
            new Price {
                Underlying="MORGAN STANLEY",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 13.31
            },
            new Price {
                Underlying="MORGAN STANLEY",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 14.82
            },
            new Price {
                Underlying="ROSNEFT GDR",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ROSNEFT GDR",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 1.03
            },
            new Price {
                Underlying="ROSNEFT GDR",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 4.51
            },
            new Price {
                Underlying="ROSNEFT GDR",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 2.09
            },
            new Price {
                Underlying="ROSNEFT GDR",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 4.87
            },
            new Price {
                Underlying="ROSNEFT GDR",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 8.95
            },
            new Price {
                Underlying="MUENCH RUECKVERS N",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 2.29
            },
            new Price {
                Underlying="MUENCH RUECKVERS N",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 4.75
            },
            new Price {
                Underlying="MUENCH RUECKVERS N",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 7.39
            },
            new Price {
                Underlying="PETROLEO BRASILEIRO ADR",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 1.8
            },
            new Price {
                Underlying="PETROLEO BRASILEIRO ADR",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 6.15
            },
            new Price {
                Underlying="PETROLEO BRASILEIRO ADR",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 13.82
            },
            new Price {
                Underlying="PETROLEO BRASILEIRO ADR",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 5.58
            },
            new Price {
                Underlying="PETROLEO BRASILEIRO ADR",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 9.44
            },
            new Price {
                Underlying="PETROLEO BRASILEIRO ADR",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 13.79
            },
            new Price {
                Underlying="NASDAQ 100",
                Maturity="12M",
                Barrier= 60,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 2.7
            },
            new Price {
                Underlying="NASDAQ 100",
                Maturity="12M",
                Barrier= 70,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 4.72
            },
            new Price {
                Underlying="NASDAQ 100",
                Maturity="12M",
                Barrier= 80,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 6.74
            },
            new Price {
                Underlying="DEERE & CO",
                Maturity="3M",
                Barrier= 60,
                Sector="Machinery / Farm",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DEERE & CO",
                Maturity="3M",
                Barrier= 70,
                Sector="Machinery / Farm",
                Currency="USD",
                CouponToday= (decimal) 1.82
            },
            new Price {
                Underlying="DEERE & CO",
                Maturity="3M",
                Barrier= 80,
                Sector="Machinery / Farm",
                Currency="USD",
                CouponToday= (decimal) 6.22
            },
            new Price {
                Underlying="DEERE & CO",
                Maturity="6M",
                Barrier= 60,
                Sector="Machinery / Farm",
                Currency="USD",
                CouponToday= (decimal) 2.58
            },
            new Price {
                Underlying="DEERE & CO",
                Maturity="6M",
                Barrier= 70,
                Sector="Machinery / Farm",
                Currency="USD",
                CouponToday= (decimal) 5.49
            },
            new Price {
                Underlying="DEERE & CO",
                Maturity="6M",
                Barrier= 80,
                Sector="Machinery / Farm",
                Currency="USD",
                CouponToday= (decimal) 9.41
            },
            new Price {
                Underlying="NESTLE N",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="NESTLE N",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0.85
            },
            new Price {
                Underlying="NESTLE N",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 2.8
            },
            new Price {
                Underlying="AMERICA MOVIL ADR",
                Maturity="3M",
                Barrier= 60,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="AMERICA MOVIL ADR",
                Maturity="3M",
                Barrier= 70,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="AMERICA MOVIL ADR",
                Maturity="3M",
                Barrier= 80,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 2.73
            },
            new Price {
                Underlying="AMERICA MOVIL ADR",
                Maturity="6M",
                Barrier= 60,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 0.77
            },
            new Price {
                Underlying="AMERICA MOVIL ADR",
                Maturity="6M",
                Barrier= 70,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 3.08
            },
            new Price {
                Underlying="AMERICA MOVIL ADR",
                Maturity="6M",
                Barrier= 80,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 6.87
            },
            new Price {
                Underlying="NEWMONT MINING",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 7.02
            },
            new Price {
                Underlying="NEWMONT MINING",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 9.96
            },
            new Price {
                Underlying="NEWMONT MINING",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 12.16
            },
            new Price {
                Underlying="LUKOIL ADR",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="LUKOIL ADR",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 1.36
            },
            new Price {
                Underlying="LUKOIL ADR",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 5.97
            },
            new Price {
                Underlying="LUKOIL ADR",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 1.68
            },
            new Price {
                Underlying="LUKOIL ADR",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 4.57
            },
            new Price {
                Underlying="LUKOIL ADR",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 8.88
            },
            new Price {
                Underlying="Nike",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 3.71
            },
            new Price {
                Underlying="Nike",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 6.02
            },
            new Price {
                Underlying="Nike",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 8.24
            },
            new Price {
                Underlying="ITAU UNIBANCO ADR",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 0.2
            },
            new Price {
                Underlying="ITAU UNIBANCO ADR",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 3.08
            },
            new Price {
                Underlying="ITAU UNIBANCO ADR",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 9.32
            },
            new Price {
                Underlying="ITAU UNIBANCO ADR",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 3.57
            },
            new Price {
                Underlying="ITAU UNIBANCO ADR",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 7.63
            },
            new Price {
                Underlying="ITAU UNIBANCO ADR",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 12.54
            },
            new Price {
                Underlying="Nikkei 225",
                Maturity="12M",
                Barrier= 60,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 1.44
            },
            new Price {
                Underlying="Nikkei 225",
                Maturity="12M",
                Barrier= 70,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 2.53
            },
            new Price {
                Underlying="Nikkei 225",
                Maturity="12M",
                Barrier= 80,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 4.32
            },
            new Price {
                Underlying="CHINA MOBILE ADR",
                Maturity="3M",
                Barrier= 60,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="CHINA MOBILE ADR",
                Maturity="3M",
                Barrier= 70,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="CHINA MOBILE ADR",
                Maturity="3M",
                Barrier= 80,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="CHINA MOBILE ADR",
                Maturity="6M",
                Barrier= 60,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="CHINA MOBILE ADR",
                Maturity="6M",
                Barrier= 70,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 0.32
            },
            new Price {
                Underlying="CHINA MOBILE ADR",
                Maturity="6M",
                Barrier= 80,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 3.26
            },
            new Price {
                Underlying="NOBEL BIOCARE N",
                Maturity="12M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 6.88
            },
            new Price {
                Underlying="NOBEL BIOCARE N",
                Maturity="12M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 10.03
            },
            new Price {
                Underlying="NOBEL BIOCARE N",
                Maturity="12M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 12.3
            },
            new Price {
                Underlying="CEMEX ADR",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 15.4
            },
            new Price {
                Underlying="CEMEX ADR",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 22.81
            },
            new Price {
                Underlying="CEMEX ADR",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 29.37
            },
            new Price {
                Underlying="CEMEX ADR",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 17.25
            },
            new Price {
                Underlying="CEMEX ADR",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 20.86
            },
            new Price {
                Underlying="CEMEX ADR",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 23.31
            },
            new Price {
                Underlying="NOKIA",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 18.24
            },
            new Price {
                Underlying="NOKIA",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 20.33
            },
            new Price {
                Underlying="NOKIA",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 21.27
            },
            new Price {
                Underlying="ICICI BANK ADR",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 0.06
            },
            new Price {
                Underlying="ICICI BANK ADR",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 3.18
            },
            new Price {
                Underlying="ICICI BANK ADR",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 9.85
            },
            new Price {
                Underlying="ICICI BANK ADR",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 4.29
            },
            new Price {
                Underlying="ICICI BANK ADR",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 8.57
            },
            new Price {
                Underlying="ICICI BANK ADR",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 13.17
            },
            new Price {
                Underlying="NOVARTIS N",
                Maturity="12M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="NOVARTIS N",
                Maturity="12M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0.49
            },
            new Price {
                Underlying="NOVARTIS N",
                Maturity="12M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 2.59
            },
            new Price {
                Underlying="FTSE 100",
                Maturity="3M",
                Barrier= 60,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="FTSE 100",
                Maturity="3M",
                Barrier= 70,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="FTSE 100",
                Maturity="3M",
                Barrier= 80,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 0.37
            },
            new Price {
                Underlying="FTSE 100",
                Maturity="6M",
                Barrier= 60,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="FTSE 100",
                Maturity="6M",
                Barrier= 70,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 1.1
            },
            new Price {
                Underlying="FTSE 100",
                Maturity="6M",
                Barrier= 80,
                Sector="Indices",
                Currency="EUR",
                CouponToday= (decimal) 3.46
            },
            new Price {
                Underlying="OC OERLIKON CORP N",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 5.53
            },
            new Price {
                Underlying="OC OERLIKON CORP N",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 8.51
            },
            new Price {
                Underlying="OC OERLIKON CORP N",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 10.76
            },
            new Price {
                Underlying="VALE SP ADR",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 1.36
            },
            new Price {
                Underlying="VALE SP ADR",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 5.35
            },
            new Price {
                Underlying="VALE SP ADR",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 12.36
            },
            new Price {
                Underlying="VALE SP ADR",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 5.09
            },
            new Price {
                Underlying="VALE SP ADR",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 9.58
            },
            new Price {
                Underlying="VALE SP ADR",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 14.44
            },
            new Price {
                Underlying="ORACLE CORP",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.85
            },
            new Price {
                Underlying="ORACLE CORP",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 7.06
            },
            new Price {
                Underlying="ORACLE CORP",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 9.02
            },
            new Price {
                Underlying="Hennes & Mauritz",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Hennes & Mauritz",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Hennes & Mauritz",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Hennes & Mauritz",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Hennes & Mauritz",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0.91
            },
            new Price {
                Underlying="Hennes & Mauritz",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 4.28
            },
            new Price {
                Underlying="Pernod-Ricard SA",
                Maturity="12M",
                Barrier= 60,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 2.32
            },
            new Price {
                Underlying="Pernod-Ricard SA",
                Maturity="12M",
                Barrier= 70,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 4.37
            },
            new Price {
                Underlying="Pernod-Ricard SA",
                Maturity="12M",
                Barrier= 80,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 6.45
            },
            new Price {
                Underlying="Telefon AB L.M. Ericsson LM -B-",
                Maturity="3M",
                Barrier= 60,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Telefon AB L.M. Ericsson LM -B-",
                Maturity="3M",
                Barrier= 70,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Telefon AB L.M. Ericsson LM -B-",
                Maturity="3M",
                Barrier= 80,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 2.62
            },
            new Price {
                Underlying="Telefon AB L.M. Ericsson LM -B-",
                Maturity="6M",
                Barrier= 60,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 0.95
            },
            new Price {
                Underlying="Telefon AB L.M. Ericsson LM -B-",
                Maturity="6M",
                Barrier= 70,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 4.22
            },
            new Price {
                Underlying="Telefon AB L.M. Ericsson LM -B-",
                Maturity="6M",
                Barrier= 80,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 9.21
            },
            new Price {
                Underlying="PETROLEO BRASILEIRO ADR",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 7.99
            },
            new Price {
                Underlying="PETROLEO BRASILEIRO ADR",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 10.64
            },
            new Price {
                Underlying="PETROLEO BRASILEIRO ADR",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 12.63
            },
            new Price {
                Underlying="INFOSYS ADR",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0.04
            },
            new Price {
                Underlying="INFOSYS ADR",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 3.12
            },
            new Price {
                Underlying="INFOSYS ADR",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 9.94
            },
            new Price {
                Underlying="INFOSYS ADR",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 2.95
            },
            new Price {
                Underlying="INFOSYS ADR",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.74
            },
            new Price {
                Underlying="INFOSYS ADR",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 11.36
            },
            new Price {
                Underlying="PFIZER",
                Maturity="12M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 2.84
            },
            new Price {
                Underlying="PFIZER",
                Maturity="12M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 4.69
            },
            new Price {
                Underlying="PFIZER",
                Maturity="12M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="USD",
                CouponToday= (decimal) 6.91
            },
            new Price {
                Underlying="Sandvik AB",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Sandvik AB",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 0.54
            },
            new Price {
                Underlying="Sandvik AB",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 4.75
            },
            new Price {
                Underlying="Sandvik AB",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 1.9
            },
            new Price {
                Underlying="Sandvik AB",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 5.49
            },
            new Price {
                Underlying="Sandvik AB",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 10.29
            },
            new Price {
                Underlying="Philip Morris Intl.",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 2.34
            },
            new Price {
                Underlying="Philip Morris Intl.",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 4.3
            },
            new Price {
                Underlying="Philip Morris Intl.",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 6.64
            },
            new Price {
                Underlying="Volvo AB -B-",
                Maturity="3M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Volvo AB -B-",
                Maturity="3M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Volvo AB -B-",
                Maturity="3M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 2.84
            },
            new Price {
                Underlying="Volvo AB -B-",
                Maturity="6M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 1.02
            },
            new Price {
                Underlying="Volvo AB -B-",
                Maturity="6M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 4.35
            },
            new Price {
                Underlying="Volvo AB -B-",
                Maturity="6M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 9.35
            },
            new Price {
                Underlying="PORSCHE",
                Maturity="12M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 5.96
            },
            new Price {
                Underlying="PORSCHE",
                Maturity="12M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 8.97
            },
            new Price {
                Underlying="PORSCHE",
                Maturity="12M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 11.23
            },
            new Price {
                Underlying="Nikkei 225",
                Maturity="3M",
                Barrier= 60,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Nikkei 225",
                Maturity="3M",
                Barrier= 70,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Nikkei 225",
                Maturity="3M",
                Barrier= 80,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 0.85
            },
            new Price {
                Underlying="Nikkei 225",
                Maturity="6M",
                Barrier= 60,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 0.21
            },
            new Price {
                Underlying="Nikkei 225",
                Maturity="6M",
                Barrier= 70,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 1.09
            },
            new Price {
                Underlying="Nikkei 225",
                Maturity="6M",
                Barrier= 80,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 3.03
            },
            new Price {
                Underlying="PPR",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 2.35
            },
            new Price {
                Underlying="PPR",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 4.83
            },
            new Price {
                Underlying="PPR",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 7.33
            },
            new Price {
                Underlying="Banco Bradesco SA Sp. ADR",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Banco Bradesco SA Sp. ADR",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 1.96
            },
            new Price {
                Underlying="Banco Bradesco SA Sp. ADR",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 7.31
            },
            new Price {
                Underlying="Banco Bradesco SA Sp. ADR",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 3.09
            },
            new Price {
                Underlying="Banco Bradesco SA Sp. ADR",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 6.63
            },
            new Price {
                Underlying="Banco Bradesco SA Sp. ADR",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 11.24
            },
            new Price {
                Underlying="PROCTER&GAMBLE",
                Maturity="12M",
                Barrier= 60,
                Sector="Services",
                Currency="USD",
                CouponToday= (decimal) 1.31
            },
            new Price {
                Underlying="PROCTER&GAMBLE",
                Maturity="12M",
                Barrier= 70,
                Sector="Services",
                Currency="USD",
                CouponToday= (decimal) 2.57
            },
            new Price {
                Underlying="PROCTER&GAMBLE",
                Maturity="12M",
                Barrier= 80,
                Sector="Services",
                Currency="USD",
                CouponToday= (decimal) 4.38
            },
            new Price {
                Underlying="Companhia Siderurgica Nacional Sp. ADR",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 10.26
            },
            new Price {
                Underlying="Companhia Siderurgica Nacional Sp. ADR",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 19.92
            },
            new Price {
                Underlying="Companhia Siderurgica Nacional Sp. ADR",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 29.63
            },
            new Price {
                Underlying="Companhia Siderurgica Nacional Sp. ADR",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 15.61
            },
            new Price {
                Underlying="Companhia Siderurgica Nacional Sp. ADR",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 20.61
            },
            new Price {
                Underlying="Companhia Siderurgica Nacional Sp. ADR",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 24.04
            },
            new Price {
                Underlying="Qualcomm",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 5.44
            },
            new Price {
                Underlying="Qualcomm",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 8.15
            },
            new Price {
                Underlying="Qualcomm",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 10.31
            },
            new Price {
                Underlying="MMC Norilsk Nickel Sp. ADR",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 0.39
            },
            new Price {
                Underlying="MMC Norilsk Nickel Sp. ADR",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 3.72
            },
            new Price {
                Underlying="MMC Norilsk Nickel Sp. ADR",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 10.14
            },
            new Price {
                Underlying="MMC Norilsk Nickel Sp. ADR",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 3.63
            },
            new Price {
                Underlying="MMC Norilsk Nickel Sp. ADR",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 7.44
            },
            new Price {
                Underlying="MMC Norilsk Nickel Sp. ADR",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 11.71
            },
            new Price {
                Underlying="Reckitt Benckiser",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Reckitt Benckiser",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0.9
            },
            new Price {
                Underlying="Reckitt Benckiser",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 2.97
            },
            new Price {
                Underlying="Sberbank of Russia OJSC Sp. ADR",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 0.5
            },
            new Price {
                Underlying="Sberbank of Russia OJSC Sp. ADR",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 3.65
            },
            new Price {
                Underlying="Sberbank of Russia OJSC Sp. ADR",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 9.46
            },
            new Price {
                Underlying="Sberbank of Russia OJSC Sp. ADR",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 3.62
            },
            new Price {
                Underlying="Sberbank of Russia OJSC Sp. ADR",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 7.1
            },
            new Price {
                Underlying="Sberbank of Russia OJSC Sp. ADR",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 11.01
            },
            new Price {
                Underlying="Reliance Industries Ltd Sp. GDR -144 A-",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 6.15
            },
            new Price {
                Underlying="Reliance Industries Ltd Sp. GDR -144 A-",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 8.75
            },
            new Price {
                Underlying="Reliance Industries Ltd Sp. GDR -144 A-",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 10.63
            },
            new Price {
                Underlying="Reliance Industries Ltd Sp. GDR -144 A-",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Reliance Industries Ltd Sp. GDR -144 A-",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 3.03
            },
            new Price {
                Underlying="Reliance Industries Ltd Sp. GDR -144 A-",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 9.81
            },
            new Price {
                Underlying="Reliance Industries Ltd Sp. GDR -144 A-",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 3.05
            },
            new Price {
                Underlying="Reliance Industries Ltd Sp. GDR -144 A-",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 7.03
            },
            new Price {
                Underlying="Reliance Industries Ltd Sp. GDR -144 A-",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 11.63
            },
            new Price {
                Underlying="RENAULT",
                Maturity="12M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 9.74
            },
            new Price {
                Underlying="RENAULT",
                Maturity="12M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 12.45
            },
            new Price {
                Underlying="RENAULT",
                Maturity="12M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 14.12
            },
            new Price {
                Underlying="Gerdau SA COSG",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 2.59
            },
            new Price {
                Underlying="Gerdau SA COSG",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 8.47
            },
            new Price {
                Underlying="Gerdau SA COSG",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 17.72
            },
            new Price {
                Underlying="Gerdau SA COSG",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 7.88
            },
            new Price {
                Underlying="Gerdau SA COSG",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 13.33
            },
            new Price {
                Underlying="Gerdau SA COSG",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="USD",
                CouponToday= (decimal) 18.14
            },
            new Price {
                Underlying="Renren Corp",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 9.44
            },
            new Price {
                Underlying="Renren Corp",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 13.05
            },
            new Price {
                Underlying="Renren Corp",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 14.97
            },
            new Price {
                Underlying="Surgutneftegaz Sp. ADR",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 3.41
            },
            new Price {
                Underlying="Surgutneftegaz Sp. ADR",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 8.12
            },
            new Price {
                Underlying="Surgutneftegaz Sp. ADR",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 14.48
            },
            new Price {
                Underlying="Surgutneftegaz Sp. ADR",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 6.6
            },
            new Price {
                Underlying="Surgutneftegaz Sp. ADR",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 10.16
            },
            new Price {
                Underlying="Surgutneftegaz Sp. ADR",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 13.58
            },
            new Price {
                Underlying="REPSOL YPF",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 9.31
            },
            new Price {
                Underlying="REPSOL YPF",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 11.8
            },
            new Price {
                Underlying="REPSOL YPF",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 13.47
            },
            new Price {
                Underlying="Tata Motors Ltd Sp. ADR",
                Maturity="3M",
                Barrier= 60,
                Sector="Transportation",
                Currency="USD",
                CouponToday= (decimal) 1.54
            },
            new Price {
                Underlying="Tata Motors Ltd Sp. ADR",
                Maturity="3M",
                Barrier= 70,
                Sector="Transportation",
                Currency="USD",
                CouponToday= (decimal) 6.1
            },
            new Price {
                Underlying="Tata Motors Ltd Sp. ADR",
                Maturity="3M",
                Barrier= 80,
                Sector="Transportation",
                Currency="USD",
                CouponToday= (decimal) 14.01
            },
            new Price {
                Underlying="Tata Motors Ltd Sp. ADR",
                Maturity="6M",
                Barrier= 60,
                Sector="Transportation",
                Currency="USD",
                CouponToday= (decimal) 5.66
            },
            new Price {
                Underlying="Tata Motors Ltd Sp. ADR",
                Maturity="6M",
                Barrier= 70,
                Sector="Transportation",
                Currency="USD",
                CouponToday= (decimal) 10.24
            },
            new Price {
                Underlying="Tata Motors Ltd Sp. ADR",
                Maturity="6M",
                Barrier= 80,
                Sector="Transportation",
                Currency="USD",
                CouponToday= (decimal) 14.83
            },
            new Price {
                Underlying="RICHEMONT",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 3.56
            },
            new Price {
                Underlying="RICHEMONT",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 6.4
            },
            new Price {
                Underlying="RICHEMONT",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 8.81
            },
            new Price {
                Underlying="Georg Fischer AG",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Georg Fischer AG",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Georg Fischer AG",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 3.33
            },
            new Price {
                Underlying="Georg Fischer AG",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Georg Fischer AG",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 2.85
            },
            new Price {
                Underlying="Georg Fischer AG",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 9.11
            },
            new Price {
                Underlying="Rieter Holding AG",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 3
            },
            new Price {
                Underlying="Rieter Holding AG",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 6.54
            },
            new Price {
                Underlying="Rieter Holding AG",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 9.37
            },
            new Price {
                Underlying="Rieter Holding AG",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Rieter Holding AG",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0.14
            },
            new Price {
                Underlying="Rieter Holding AG",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 7.07
            },
            new Price {
                Underlying="Rieter Holding AG",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0.25
            },
            new Price {
                Underlying="Rieter Holding AG",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 4.22
            },
            new Price {
                Underlying="Rieter Holding AG",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 10.3
            },
            new Price {
                Underlying="Rio Tinto PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 5.23
            },
            new Price {
                Underlying="Rio Tinto PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 8.12
            },
            new Price {
                Underlying="Rio Tinto PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 10.29
            },
            new Price {
                Underlying="Helvetia Holding AG",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Helvetia Holding AG",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Helvetia Holding AG",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 3.01
            },
            new Price {
                Underlying="Helvetia Holding AG",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 0.07
            },
            new Price {
                Underlying="Helvetia Holding AG",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 3.02
            },
            new Price {
                Underlying="Helvetia Holding AG",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 8.38
            },
            new Price {
                Underlying="ROCHE HLDG G",
                Maturity="12M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ROCHE HLDG G",
                Maturity="12M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 1.65
            },
            new Price {
                Underlying="ROCHE HLDG G",
                Maturity="12M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 4.24
            },
            new Price {
                Underlying="Barrick Gold Corp.",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Barrick Gold Corp.",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 2.77
            },
            new Price {
                Underlying="Barrick Gold Corp.",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 10.38
            },
            new Price {
                Underlying="Barrick Gold Corp.",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 2.59
            },
            new Price {
                Underlying="Barrick Gold Corp.",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 7.08
            },
            new Price {
                Underlying="Barrick Gold Corp.",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 12.96
            },
            new Price {
                Underlying="ROSNEFT GDR",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 4.86
            },
            new Price {
                Underlying="ROSNEFT GDR",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 7.14
            },
            new Price {
                Underlying="ROSNEFT GDR",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 9.21
            },
            new Price {
                Underlying="HDFC Bank Ltd Sp. ADR",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="HDFC Bank Ltd Sp. ADR",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 1.1
            },
            new Price {
                Underlying="HDFC Bank Ltd Sp. ADR",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 5.78
            },
            new Price {
                Underlying="HDFC Bank Ltd Sp. ADR",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 0.79
            },
            new Price {
                Underlying="HDFC Bank Ltd Sp. ADR",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 3.72
            },
            new Price {
                Underlying="HDFC Bank Ltd Sp. ADR",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 8.46
            },
            new Price {
                Underlying="ROY.PHILIPS ELECTR",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 4.08
            },
            new Price {
                Underlying="ROY.PHILIPS ELECTR",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 6.73
            },
            new Price {
                Underlying="ROY.PHILIPS ELECTR",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 9.02
            },
            new Price {
                Underlying="Goldcorp Inc.",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 0.41
            },
            new Price {
                Underlying="Goldcorp Inc.",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 4.42
            },
            new Price {
                Underlying="Goldcorp Inc.",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 12.87
            },
            new Price {
                Underlying="Goldcorp Inc.",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 4.21
            },
            new Price {
                Underlying="Goldcorp Inc.",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 9.2
            },
            new Price {
                Underlying="Goldcorp Inc.",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 14.67
            },
            new Price {
                Underlying="Royal Bank of Scotland Group P",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 7.57
            },
            new Price {
                Underlying="Royal Bank of Scotland Group P",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 10.18
            },
            new Price {
                Underlying="Royal Bank of Scotland Group P",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 11.89
            },
            new Price {
                Underlying="Vodafone Group PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Telecommunications",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Vodafone Group PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Telecommunications",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Vodafone Group PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Telecommunications",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Vodafone Group PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Telecommunications",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Vodafone Group PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Telecommunications",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Vodafone Group PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Telecommunications",
                Currency="EUR",
                CouponToday= (decimal) 1.58
            },
            new Price {
                Underlying="ROYAL DUTCH SHELL - A",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 0.64
            },
            new Price {
                Underlying="ROYAL DUTCH SHELL - A",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 2.26
            },
            new Price {
                Underlying="ROYAL DUTCH SHELL - A",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 4.63
            },
            new Price {
                Underlying="Rio Tinto PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Rio Tinto PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 0.7
            },
            new Price {
                Underlying="Rio Tinto PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 6.11
            },
            new Price {
                Underlying="Rio Tinto PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 1.73
            },
            new Price {
                Underlying="Rio Tinto PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 5.53
            },
            new Price {
                Underlying="Rio Tinto PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 10.51
            },
            new Price {
                Underlying="RWE -A-",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 2.87
            },
            new Price {
                Underlying="RWE -A-",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 5.62
            },
            new Price {
                Underlying="RWE -A-",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 8.28
            },
            new Price {
                Underlying="BP PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Oil & Gas",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BP PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Oil & Gas",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BP PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Oil & Gas",
                Currency="EUR",
                CouponToday= (decimal) 0.42
            },
            new Price {
                Underlying="BP PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Oil & Gas",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BP PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Oil & Gas",
                Currency="EUR",
                CouponToday= (decimal) 0.79
            },
            new Price {
                Underlying="BP PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Oil & Gas",
                Currency="EUR",
                CouponToday= (decimal) 4.42
            },
            new Price {
                Underlying="S&P 500",
                Maturity="12M",
                Barrier= 60,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 2.52
            },
            new Price {
                Underlying="S&P 500",
                Maturity="12M",
                Barrier= 70,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 4.26
            },
            new Price {
                Underlying="S&P 500",
                Maturity="12M",
                Barrier= 80,
                Sector="Indices",
                Currency="USD",
                CouponToday= (decimal) 6.1
            },
            new Price {
                Underlying="British American Tobacco PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="British American Tobacco PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="British American Tobacco PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="British American Tobacco PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="British American Tobacco PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="British American Tobacco PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 1.69
            },
            new Price {
                Underlying="SABMiller PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SABMiller PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 1.21
            },
            new Price {
                Underlying="SABMiller PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 3.08
            },
            new Price {
                Underlying="BHP Billiton PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BHP Billiton PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BHP Billiton PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 3.62
            },
            new Price {
                Underlying="BHP Billiton PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 0.7
            },
            new Price {
                Underlying="BHP Billiton PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 3.74
            },
            new Price {
                Underlying="BHP Billiton PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 8.38
            },
            new Price {
                Underlying="SAINT GOBAIN",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 7.83
            },
            new Price {
                Underlying="SAINT GOBAIN",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 10.84
            },
            new Price {
                Underlying="SAINT GOBAIN",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 12.86
            },
            new Price {
                Underlying="BG Group PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Oil & Gas",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BG Group PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Oil & Gas",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BG Group PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Oil & Gas",
                Currency="EUR",
                CouponToday= (decimal) 1.59
            },
            new Price {
                Underlying="BG Group PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Oil & Gas",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BG Group PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Oil & Gas",
                Currency="EUR",
                CouponToday= (decimal) 1.57
            },
            new Price {
                Underlying="BG Group PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Oil & Gas",
                Currency="EUR",
                CouponToday= (decimal) 6
            },
            new Price {
                Underlying="Sandvik AB",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 4.31
            },
            new Price {
                Underlying="Sandvik AB",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 7.09
            },
            new Price {
                Underlying="Sandvik AB",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 9.38
            },
            new Price {
                Underlying="AstraZeneca PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Health Care",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="AstraZeneca PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Health Care",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="AstraZeneca PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Health Care",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="AstraZeneca PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Health Care",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="AstraZeneca PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Health Care",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="AstraZeneca PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Health Care",
                Currency="EUR",
                CouponToday= (decimal) 1.45
            },
            new Price {
                Underlying="SANOFI-AVENTIS",
                Maturity="12M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 2.17
            },
            new Price {
                Underlying="SANOFI-AVENTIS",
                Maturity="12M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 4.55
            },
            new Price {
                Underlying="SANOFI-AVENTIS",
                Maturity="12M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="EUR",
                CouponToday= (decimal) 7.09
            },
            new Price {
                Underlying="TESCO PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Consumer Services",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="TESCO PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Consumer Services",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="TESCO PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Consumer Services",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="TESCO PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Consumer Services",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="TESCO PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Consumer Services",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="TESCO PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Consumer Services",
                Currency="EUR",
                CouponToday= (decimal) 1.63
            },
            new Price {
                Underlying="SAP",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 2.1
            },
            new Price {
                Underlying="SAP",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 4.26
            },
            new Price {
                Underlying="SAP",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 6.5
            },
            new Price {
                Underlying="Anglo American PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Anglo American PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 2.65
            },
            new Price {
                Underlying="Anglo American PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 9.72
            },
            new Price {
                Underlying="Anglo American PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 3.22
            },
            new Price {
                Underlying="Anglo American PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 7.77
            },
            new Price {
                Underlying="Anglo American PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Basic Materials",
                Currency="EUR",
                CouponToday= (decimal) 12.87
            },
            new Price {
                Underlying="Sberbank of Russia OJSC Sp. ADR",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 6.67
            },
            new Price {
                Underlying="Sberbank of Russia OJSC Sp. ADR",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 8.99
            },
            new Price {
                Underlying="Sberbank of Russia OJSC Sp. ADR",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 10.74
            },
            new Price {
                Underlying="SABMiller PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SABMiller PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SABMiller PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SABMiller PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SABMiller PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SABMiller PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 1.25
            },
            new Price {
                Underlying="Schindler",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Schindler",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 1.22
            },
            new Price {
                Underlying="Schindler",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 4.24
            },
            new Price {
                Underlying="GlaxoSmithKline PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Health Care",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GlaxoSmithKline PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Health Care",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GlaxoSmithKline PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Health Care",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GlaxoSmithKline PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Health Care",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GlaxoSmithKline PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Health Care",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="GlaxoSmithKline PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Health Care",
                Currency="EUR",
                CouponToday= (decimal) 1.01
            },
            new Price {
                Underlying="Schlumberger",
                Maturity="12M",
                Barrier= 60,
                Sector="Oil & Gas",
                Currency="USD",
                CouponToday= (decimal) 6.5
            },
            new Price {
                Underlying="Schlumberger",
                Maturity="12M",
                Barrier= 70,
                Sector="Oil & Gas",
                Currency="USD",
                CouponToday= (decimal) 8.96
            },
            new Price {
                Underlying="Schlumberger",
                Maturity="12M",
                Barrier= 80,
                Sector="Oil & Gas",
                Currency="USD",
                CouponToday= (decimal) 10.85
            },
            new Price {
                Underlying="HSBC Holdings PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="HSBC Holdings PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="HSBC Holdings PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="HSBC Holdings PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="HSBC Holdings PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 0.63
            },
            new Price {
                Underlying="HSBC Holdings PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 3.26
            },
            new Price {
                Underlying="SCHNEIDER ELECTRIC",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 8.29
            },
            new Price {
                Underlying="SCHNEIDER ELECTRIC",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 11.05
            },
            new Price {
                Underlying="SCHNEIDER ELECTRIC",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 12.86
            },
            new Price {
                Underlying="Royal Bank of Scotland Group P",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 0.32
            },
            new Price {
                Underlying="Royal Bank of Scotland Group P",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 4.53
            },
            new Price {
                Underlying="Royal Bank of Scotland Group P",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 12.55
            },
            new Price {
                Underlying="Royal Bank of Scotland Group P",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 4.92
            },
            new Price {
                Underlying="Royal Bank of Scotland Group P",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 9.7
            },
            new Price {
                Underlying="Royal Bank of Scotland Group P",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 14.41
            },
            new Price {
                Underlying="SGS SA",
                Maturity="12M",
                Barrier= 60,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 1.33
            },
            new Price {
                Underlying="SGS SA",
                Maturity="12M",
                Barrier= 70,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 3.1
            },
            new Price {
                Underlying="SGS SA",
                Maturity="12M",
                Barrier= 80,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 5.1
            },
            new Price {
                Underlying="Barclays PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 2.11
            },
            new Price {
                Underlying="Barclays PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 7.29
            },
            new Price {
                Underlying="Barclays PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 15.19
            },
            new Price {
                Underlying="Barclays PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 6.97
            },
            new Price {
                Underlying="Barclays PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 11.6
            },
            new Price {
                Underlying="Barclays PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 15.85
            },
            new Price {
                Underlying="SIEMENS N",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 1.82
            },
            new Price {
                Underlying="SIEMENS N",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 4.11
            },
            new Price {
                Underlying="SIEMENS N",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 6.64
            },
            new Price {
                Underlying="Imperial Tobacco Group PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Imperial Tobacco Group PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Imperial Tobacco Group PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Imperial Tobacco Group PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Imperial Tobacco Group PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Imperial Tobacco Group PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 1.66
            },
            new Price {
                Underlying="SIKA",
                Maturity="12M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 2.61
            },
            new Price {
                Underlying="SIKA",
                Maturity="12M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 5.36
            },
            new Price {
                Underlying="SIKA",
                Maturity="12M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 7.99
            },
            new Price {
                Underlying="BT Group PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Telecommunications",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BT Group PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Telecommunications",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BT Group PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Telecommunications",
                Currency="EUR",
                CouponToday= (decimal) 0.9
            },
            new Price {
                Underlying="BT Group PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Telecommunications",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="BT Group PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Telecommunications",
                Currency="EUR",
                CouponToday= (decimal) 1.28
            },
            new Price {
                Underlying="BT Group PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Telecommunications",
                Currency="EUR",
                CouponToday= (decimal) 4.95
            },
            new Price {
                Underlying="SMI",
                Maturity="12M",
                Barrier= 60,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 0.13
            },
            new Price {
                Underlying="SMI",
                Maturity="12M",
                Barrier= 70,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 1.42
            },
            new Price {
                Underlying="SMI",
                Maturity="12M",
                Barrier= 80,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 3.28
            },
            new Price {
                Underlying="Lloyds Banking Group PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 3.11
            },
            new Price {
                Underlying="Lloyds Banking Group PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 7.76
            },
            new Price {
                Underlying="Lloyds Banking Group PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 14.15
            },
            new Price {
                Underlying="Lloyds Banking Group PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 6.23
            },
            new Price {
                Underlying="Lloyds Banking Group PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 10.32
            },
            new Price {
                Underlying="Lloyds Banking Group PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 14.28
            },
            new Price {
                Underlying="SONOVA HLDG N",
                Maturity="12M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 1.71
            },
            new Price {
                Underlying="SONOVA HLDG N",
                Maturity="12M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 4.28
            },
            new Price {
                Underlying="SONOVA HLDG N",
                Maturity="12M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 6.9
            },
            new Price {
                Underlying="Standard Chartered PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Standard Chartered PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Standard Chartered PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 2.5
            },
            new Price {
                Underlying="Standard Chartered PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 0.22
            },
            new Price {
                Underlying="Standard Chartered PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 2.64
            },
            new Price {
                Underlying="Standard Chartered PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 6.74
            },
            new Price {
                Underlying="Standard Chartered PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 2.03
            },
            new Price {
                Underlying="Standard Chartered PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 4.36
            },
            new Price {
                Underlying="Standard Chartered PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 6.74
            },
            new Price {
                Underlying="Diageo PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Diageo PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Diageo PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Diageo PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Diageo PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Diageo PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 1.82
            },
            new Price {
                Underlying="Starbucks",
                Maturity="12M",
                Barrier= 60,
                Sector="ConsumerGoods",
                Currency="USD",
                CouponToday= (decimal) 4.77
            },
            new Price {
                Underlying="Starbucks",
                Maturity="12M",
                Barrier= 70,
                Sector="ConsumerGoods",
                Currency="USD",
                CouponToday= (decimal) 7.57
            },
            new Price {
                Underlying="Starbucks",
                Maturity="12M",
                Barrier= 80,
                Sector="ConsumerGoods",
                Currency="USD",
                CouponToday= (decimal) 9.95
            },
            new Price {
                Underlying="Facebook Inc",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 9.39
            },
            new Price {
                Underlying="Facebook Inc",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 19.79
            },
            new Price {
                Underlying="Facebook Inc",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 30.87
            },
            new Price {
                Underlying="Facebook Inc",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 16.08
            },
            new Price {
                Underlying="Facebook Inc",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 22.51
            },
            new Price {
                Underlying="Facebook Inc",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 26.68
            },
            new Price {
                Underlying="STE GENERALE-A-",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 10.96
            },
            new Price {
                Underlying="STE GENERALE-A-",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 13.29
            },
            new Price {
                Underlying="STE GENERALE-A-",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 14.67
            },
            new Price {
                Underlying="Renren Corp",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 1.11
            },
            new Price {
                Underlying="Renren Corp",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 8.79
            },
            new Price {
                Underlying="Renren Corp",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 21.46
            },
            new Price {
                Underlying="Renren Corp",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.56
            },
            new Price {
                Underlying="Renren Corp",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 13.86
            },
            new Price {
                Underlying="Renren Corp",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 19.81
            },
            new Price {
                Underlying="STRAUMANN HLDG N",
                Maturity="12M",
                Barrier= 60,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 2.25
            },
            new Price {
                Underlying="STRAUMANN HLDG N",
                Maturity="12M",
                Barrier= 70,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 6.01
            },
            new Price {
                Underlying="STRAUMANN HLDG N",
                Maturity="12M",
                Barrier= 80,
                Sector="Healthcare",
                Currency="CHF",
                CouponToday= (decimal) 9.32
            },
            new Price {
                Underlying="LinkedIn Corp",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 7.32
            },
            new Price {
                Underlying="LinkedIn Corp",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 16.05
            },
            new Price {
                Underlying="LinkedIn Corp",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 26.08
            },
            new Price {
                Underlying="LinkedIn Corp",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 13.77
            },
            new Price {
                Underlying="LinkedIn Corp",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 19.09
            },
            new Price {
                Underlying="LinkedIn Corp",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 22.85
            },
            new Price {
                Underlying="Sulzer AG",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 1.45
            },
            new Price {
                Underlying="Sulzer AG",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 4.49
            },
            new Price {
                Underlying="Sulzer AG",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 7.64
            },
            new Price {
                Underlying="Amazon.com Inc",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0.67
            },
            new Price {
                Underlying="Amazon.com Inc",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 3.92
            },
            new Price {
                Underlying="Amazon.com Inc",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 10.33
            },
            new Price {
                Underlying="Amazon.com Inc",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 5.01
            },
            new Price {
                Underlying="Amazon.com Inc",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 9.23
            },
            new Price {
                Underlying="Amazon.com Inc",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 13.73
            },
            new Price {
                Underlying="Surgutneftegaz Sp. ADR",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 8.14
            },
            new Price {
                Underlying="Surgutneftegaz Sp. ADR",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 10.19
            },
            new Price {
                Underlying="Surgutneftegaz Sp. ADR",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 11.73
            },
            new Price {
                Underlying="eBay",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0.65
            },
            new Price {
                Underlying="eBay",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 3.9
            },
            new Price {
                Underlying="eBay",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 10.39
            },
            new Price {
                Underlying="eBay",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 3.75
            },
            new Price {
                Underlying="eBay",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 7.59
            },
            new Price {
                Underlying="eBay",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 12.09
            },
            new Price {
                Underlying="SWISS LIFE HLDG N",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 2.94
            },
            new Price {
                Underlying="SWISS LIFE HLDG N",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 5.82
            },
            new Price {
                Underlying="SWISS LIFE HLDG N",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 8.49
            },
            new Price {
                Underlying="Yahoo",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Yahoo",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0.09
            },
            new Price {
                Underlying="Yahoo",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 3.59
            },
            new Price {
                Underlying="Yahoo",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 1.05
            },
            new Price {
                Underlying="Yahoo",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 3.74
            },
            new Price {
                Underlying="Yahoo",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 8.24
            },
            new Price {
                Underlying="SWISS RE N",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 3.12
            },
            new Price {
                Underlying="SWISS RE N",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 5.59
            },
            new Price {
                Underlying="SWISS RE N",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 7.98
            },
            new Price {
                Underlying="DKSH Holding Ltd",
                Maturity="3M",
                Barrier= 60,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DKSH Holding Ltd",
                Maturity="3M",
                Barrier= 70,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DKSH Holding Ltd",
                Maturity="3M",
                Barrier= 80,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DKSH Holding Ltd",
                Maturity="6M",
                Barrier= 60,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DKSH Holding Ltd",
                Maturity="6M",
                Barrier= 70,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DKSH Holding Ltd",
                Maturity="6M",
                Barrier= 80,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 0.6
            },
            new Price {
                Underlying="SWISSCOM N",
                Maturity="12M",
                Barrier= 60,
                Sector="Telecom",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SWISSCOM N",
                Maturity="12M",
                Barrier= 70,
                Sector="Telecom",
                Currency="CHF",
                CouponToday= (decimal) 0.55
            },
            new Price {
                Underlying="SWISSCOM N",
                Maturity="12M",
                Barrier= 80,
                Sector="Telecom",
                Currency="CHF",
                CouponToday= (decimal) 2.75
            },
            new Price {
                Underlying="Starbucks",
                Maturity="3M",
                Barrier= 60,
                Sector="ConsumerGoods",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Starbucks",
                Maturity="3M",
                Barrier= 70,
                Sector="ConsumerGoods",
                Currency="USD",
                CouponToday= (decimal) 1.39
            },
            new Price {
                Underlying="Starbucks",
                Maturity="3M",
                Barrier= 80,
                Sector="ConsumerGoods",
                Currency="USD",
                CouponToday= (decimal) 6.19
            },
            new Price {
                Underlying="Starbucks",
                Maturity="6M",
                Barrier= 60,
                Sector="ConsumerGoods",
                Currency="USD",
                CouponToday= (decimal) 1.66
            },
            new Price {
                Underlying="Starbucks",
                Maturity="6M",
                Barrier= 70,
                Sector="ConsumerGoods",
                Currency="USD",
                CouponToday= (decimal) 4.8
            },
            new Price {
                Underlying="Starbucks",
                Maturity="6M",
                Barrier= 80,
                Sector="ConsumerGoods",
                Currency="USD",
                CouponToday= (decimal) 9.49
            },
            new Price {
                Underlying="SYNGENTA N",
                Maturity="12M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0.93
            },
            new Price {
                Underlying="SYNGENTA N",
                Maturity="12M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 2.82
            },
            new Price {
                Underlying="SYNGENTA N",
                Maturity="12M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 5.1
            },
            new Price {
                Underlying="Schlumberger",
                Maturity="3M",
                Barrier= 60,
                Sector="Oil & Gas",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Schlumberger",
                Maturity="3M",
                Barrier= 70,
                Sector="Oil & Gas",
                Currency="USD",
                CouponToday= (decimal) 2.3
            },
            new Price {
                Underlying="Schlumberger",
                Maturity="3M",
                Barrier= 80,
                Sector="Oil & Gas",
                Currency="USD",
                CouponToday= (decimal) 8.02
            },
            new Price {
                Underlying="Schlumberger",
                Maturity="6M",
                Barrier= 60,
                Sector="Oil & Gas",
                Currency="USD",
                CouponToday= (decimal) 3.41
            },
            new Price {
                Underlying="Schlumberger",
                Maturity="6M",
                Barrier= 70,
                Sector="Oil & Gas",
                Currency="USD",
                CouponToday= (decimal) 7.01
            },
            new Price {
                Underlying="Schlumberger",
                Maturity="6M",
                Barrier= 80,
                Sector="Oil & Gas",
                Currency="USD",
                CouponToday= (decimal) 11.41
            },
            new Price {
                Underlying="Tata Motors Ltd Sp. ADR",
                Maturity="12M",
                Barrier= 60,
                Sector="Transportation",
                Currency="USD",
                CouponToday= (decimal) 8.3
            },
            new Price {
                Underlying="Tata Motors Ltd Sp. ADR",
                Maturity="12M",
                Barrier= 70,
                Sector="Transportation",
                Currency="USD",
                CouponToday= (decimal) 11.33
            },
            new Price {
                Underlying="Tata Motors Ltd Sp. ADR",
                Maturity="12M",
                Barrier= 80,
                Sector="Transportation",
                Currency="USD",
                CouponToday= (decimal) 13.29
            },
            new Price {
                Underlying="Chevron",
                Maturity="3M",
                Barrier= 60,
                Sector="Oil & Gas",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Chevron",
                Maturity="3M",
                Barrier= 70,
                Sector="Oil & Gas",
                Currency="USD",
                CouponToday= (decimal) 0.3
            },
            new Price {
                Underlying="Chevron",
                Maturity="3M",
                Barrier= 80,
                Sector="Oil & Gas",
                Currency="USD",
                CouponToday= (decimal) 2.97
            },
            new Price {
                Underlying="Chevron",
                Maturity="6M",
                Barrier= 60,
                Sector="Oil & Gas",
                Currency="USD",
                CouponToday= (decimal) 0.8
            },
            new Price {
                Underlying="Chevron",
                Maturity="6M",
                Barrier= 70,
                Sector="Oil & Gas",
                Currency="USD",
                CouponToday= (decimal) 2.57
            },
            new Price {
                Underlying="Chevron",
                Maturity="6M",
                Barrier= 80,
                Sector="Oil & Gas",
                Currency="USD",
                CouponToday= (decimal) 5.66
            },
            new Price {
                Underlying="Telefon AB L.M. Ericsson LM -B-",
                Maturity="12M",
                Barrier= 60,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 4.11
            },
            new Price {
                Underlying="Telefon AB L.M. Ericsson LM -B-",
                Maturity="12M",
                Barrier= 70,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 6.58
            },
            new Price {
                Underlying="Telefon AB L.M. Ericsson LM -B-",
                Maturity="12M",
                Barrier= 80,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 8.63
            },
            new Price {
                Underlying="Teva Pharmaceutical",
                Maturity="3M",
                Barrier= 60,
                Sector="Health Care",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Teva Pharmaceutical",
                Maturity="3M",
                Barrier= 70,
                Sector="Health Care",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Teva Pharmaceutical",
                Maturity="3M",
                Barrier= 80,
                Sector="Health Care",
                Currency="USD",
                CouponToday= (decimal) 2.2
            },
            new Price {
                Underlying="Teva Pharmaceutical",
                Maturity="6M",
                Barrier= 60,
                Sector="Health Care",
                Currency="USD",
                CouponToday= (decimal) 0.28
            },
            new Price {
                Underlying="Teva Pharmaceutical",
                Maturity="6M",
                Barrier= 70,
                Sector="Health Care",
                Currency="USD",
                CouponToday= (decimal) 2
            },
            new Price {
                Underlying="Teva Pharmaceutical",
                Maturity="6M",
                Barrier= 80,
                Sector="Health Care",
                Currency="USD",
                CouponToday= (decimal) 5.4
            },
            new Price {
                Underlying="TELEFONICA",
                Maturity="12M",
                Barrier= 60,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 5.12
            },
            new Price {
                Underlying="TELEFONICA",
                Maturity="12M",
                Barrier= 70,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 7.46
            },
            new Price {
                Underlying="TELEFONICA",
                Maturity="12M",
                Barrier= 80,
                Sector="Telecom",
                Currency="EUR",
                CouponToday= (decimal) 9.32
            },
            new Price {
                Underlying="Schindler",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Schindler",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Schindler",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Schindler",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Schindler",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Schindler",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 1.82
            },
            new Price {
                Underlying="TESCO PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Consumer Services",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="TESCO PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Consumer Services",
                Currency="EUR",
                CouponToday= (decimal) 1.33
            },
            new Price {
                Underlying="TESCO PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Consumer Services",
                Currency="EUR",
                CouponToday= (decimal) 3.8
            },
            new Price {
                Underlying="ESTX50 EURP",
                Maturity="3M",
                Barrier= 60,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="ESTX50 EURP",
                Maturity="3M",
                Barrier= 70,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 0.05
            },
            new Price {
                Underlying="ESTX50 EURP",
                Maturity="3M",
                Barrier= 80,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 3.18
            },
            new Price {
                Underlying="ESTX50 EURP",
                Maturity="6M",
                Barrier= 60,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 0.87
            },
            new Price {
                Underlying="ESTX50 EURP",
                Maturity="6M",
                Barrier= 70,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 3.05
            },
            new Price {
                Underlying="ESTX50 EURP",
                Maturity="6M",
                Barrier= 80,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 6.56
            },
            new Price {
                Underlying="Teva Pharmaceutical",
                Maturity="12M",
                Barrier= 60,
                Sector="Health Care",
                Currency="USD",
                CouponToday= (decimal) 2.26
            },
            new Price {
                Underlying="Teva Pharmaceutical",
                Maturity="12M",
                Barrier= 70,
                Sector="Health Care",
                Currency="USD",
                CouponToday= (decimal) 4.35
            },
            new Price {
                Underlying="Teva Pharmaceutical",
                Maturity="12M",
                Barrier= 80,
                Sector="Health Care",
                Currency="USD",
                CouponToday= (decimal) 6.78
            },
            new Price {
                Underlying="DAX",
                Maturity="3M",
                Barrier= 60,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DAX",
                Maturity="3M",
                Barrier= 70,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DAX",
                Maturity="3M",
                Barrier= 80,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 1.13
            },
            new Price {
                Underlying="DAX",
                Maturity="6M",
                Barrier= 60,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="DAX",
                Maturity="6M",
                Barrier= 70,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 1.36
            },
            new Price {
                Underlying="DAX",
                Maturity="6M",
                Barrier= 80,
                Sector="Indices",
                Currency="CHF",
                CouponToday= (decimal) 4.04
            },
            new Price {
                Underlying="THE SWATCH GRP",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 2.86
            },
            new Price {
                Underlying="THE SWATCH GRP",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 5.35
            },
            new Price {
                Underlying="THE SWATCH GRP",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 7.65
            },
            new Price {
                Underlying="Sulzer AG",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Sulzer AG",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Sulzer AG",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 2.79
            },
            new Price {
                Underlying="Sulzer AG",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Sulzer AG",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 1.7
            },
            new Price {
                Underlying="Sulzer AG",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 6.81
            },
            new Price {
                Underlying="THYSSENKRUPP",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 6.51
            },
            new Price {
                Underlying="THYSSENKRUPP",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 9.79
            },
            new Price {
                Underlying="THYSSENKRUPP",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 12.02
            },
            new Price {
                Underlying="Merck & Co. Inc.",
                Maturity="3M",
                Barrier= 60,
                Sector="Health Care",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Merck & Co. Inc.",
                Maturity="3M",
                Barrier= 70,
                Sector="Health Care",
                Currency="USD",
                CouponToday= (decimal) 0.3
            },
            new Price {
                Underlying="Merck & Co. Inc.",
                Maturity="3M",
                Barrier= 80,
                Sector="Health Care",
                Currency="USD",
                CouponToday= (decimal) 2.42
            },
            new Price {
                Underlying="Merck & Co. Inc.",
                Maturity="6M",
                Barrier= 60,
                Sector="Health Care",
                Currency="USD",
                CouponToday= (decimal) 0.72
            },
            new Price {
                Underlying="Merck & Co. Inc.",
                Maturity="6M",
                Barrier= 70,
                Sector="Health Care",
                Currency="USD",
                CouponToday= (decimal) 2.22
            },
            new Price {
                Underlying="Merck & Co. Inc.",
                Maturity="6M",
                Barrier= 80,
                Sector="Health Care",
                Currency="USD",
                CouponToday= (decimal) 4.96
            },
            new Price {
                Underlying="TOTAL",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 2.7
            },
            new Price {
                Underlying="TOTAL",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 5.15
            },
            new Price {
                Underlying="TOTAL",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 7.74
            },
            new Price {
                Underlying="Eurasian Natural Resources Corp. PLC",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 4.01
            },
            new Price {
                Underlying="Eurasian Natural Resources Corp. PLC",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 10.97
            },
            new Price {
                Underlying="Eurasian Natural Resources Corp. PLC",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 20.19
            },
            new Price {
                Underlying="Eurasian Natural Resources Corp. PLC",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 8.49
            },
            new Price {
                Underlying="Eurasian Natural Resources Corp. PLC",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 14.06
            },
            new Price {
                Underlying="Eurasian Natural Resources Corp. PLC",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="EUR",
                CouponToday= (decimal) 18.88
            },
            new Price {
                Underlying="TRANSOCEAN N",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="CHF",
                CouponToday= (decimal) 5.36
            },
            new Price {
                Underlying="TRANSOCEAN N",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="CHF",
                CouponToday= (decimal) 8.3
            },
            new Price {
                Underlying="TRANSOCEAN N",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="CHF",
                CouponToday= (decimal) 10.5
            },
            new Price {
                Underlying="Veolia Environnement",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 1
            },
            new Price {
                Underlying="Veolia Environnement",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 6.06
            },
            new Price {
                Underlying="Veolia Environnement",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 15.01
            },
            new Price {
                Underlying="Veolia Environnement",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 5.99
            },
            new Price {
                Underlying="Veolia Environnement",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 11.36
            },
            new Price {
                Underlying="Veolia Environnement",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 16.46
            },
            new Price {
                Underlying="TUI N",
                Maturity="12M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 7.13
            },
            new Price {
                Underlying="TUI N",
                Maturity="12M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 9.72
            },
            new Price {
                Underlying="TUI N",
                Maturity="12M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 11.55
            },
            new Price {
                Underlying="Meyer Burger Technology AG",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Meyer Burger Technology AG",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="CHF",
                CouponToday= (decimal) 1.09
            },
            new Price {
                Underlying="Meyer Burger Technology AG",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="CHF",
                CouponToday= (decimal) 11.39
            },
            new Price {
                Underlying="Meyer Burger Technology AG",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Meyer Burger Technology AG",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="CHF",
                CouponToday= (decimal) 4.16
            },
            new Price {
                Underlying="Meyer Burger Technology AG",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="CHF",
                CouponToday= (decimal) 11.67
            },
            new Price {
                Underlying="UBS N",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 4.07
            },
            new Price {
                Underlying="UBS N",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 6.61
            },
            new Price {
                Underlying="UBS N",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 8.79
            },
            new Price {
                Underlying="Cia de Bebidas Das Americas (AMBEV) Sp. ADR",
                Maturity="3M",
                Barrier= 60,
                Sector="Consumer Goods",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Cia de Bebidas Das Americas (AMBEV) Sp. ADR",
                Maturity="3M",
                Barrier= 70,
                Sector="Consumer Goods",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Cia de Bebidas Das Americas (AMBEV) Sp. ADR",
                Maturity="3M",
                Barrier= 80,
                Sector="Consumer Goods",
                Currency="USD",
                CouponToday= (decimal) 1.85
            },
            new Price {
                Underlying="Cia de Bebidas Das Americas (AMBEV) Sp. ADR",
                Maturity="6M",
                Barrier= 60,
                Sector="Consumer Goods",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Cia de Bebidas Das Americas (AMBEV) Sp. ADR",
                Maturity="6M",
                Barrier= 70,
                Sector="Consumer Goods",
                Currency="USD",
                CouponToday= (decimal) 1.61
            },
            new Price {
                Underlying="Cia de Bebidas Das Americas (AMBEV) Sp. ADR",
                Maturity="6M",
                Barrier= 80,
                Sector="Consumer Goods",
                Currency="USD",
                CouponToday= (decimal) 5.87
            },
            new Price {
                Underlying="UNICREDITO",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 11.24
            },
            new Price {
                Underlying="UNICREDITO",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 13.34
            },
            new Price {
                Underlying="UNICREDITO",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="EUR",
                CouponToday= (decimal) 14.56
            },
            new Price {
                Underlying="Continental AG",
                Maturity="3M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Continental AG",
                Maturity="3M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 1.61
            },
            new Price {
                Underlying="Continental AG",
                Maturity="3M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 8.1
            },
            new Price {
                Underlying="Continental AG",
                Maturity="6M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 3
            },
            new Price {
                Underlying="Continental AG",
                Maturity="6M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 7.2
            },
            new Price {
                Underlying="Continental AG",
                Maturity="6M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 12.12
            },
            new Price {
                Underlying="UNILEVER CERT",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0.53
            },
            new Price {
                Underlying="UNILEVER CERT",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 2.24
            },
            new Price {
                Underlying="UNILEVER CERT",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 4.64
            },
            new Price {
                Underlying="Lindt & Sprungli",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Lindt & Sprungli",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Lindt & Sprungli",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Lindt & Sprungli",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Lindt & Sprungli",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Lindt & Sprungli",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0.93
            },
            new Price {
                Underlying="UNITED TECHNOOLOGIES CORP",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.25
            },
            new Price {
                Underlying="UNITED TECHNOOLOGIES CORP",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.29
            },
            new Price {
                Underlying="UNITED TECHNOOLOGIES CORP",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 8.28
            },
            new Price {
                Underlying="SIKA",
                Maturity="3M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SIKA",
                Maturity="3M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SIKA",
                Maturity="3M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 3.88
            },
            new Price {
                Underlying="SIKA",
                Maturity="6M",
                Barrier= 60,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 0.75
            },
            new Price {
                Underlying="SIKA",
                Maturity="6M",
                Barrier= 70,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 3.76
            },
            new Price {
                Underlying="SIKA",
                Maturity="6M",
                Barrier= 80,
                Sector="Chemicals / Pharmaceuticals",
                Currency="CHF",
                CouponToday= (decimal) 8.32
            },
            new Price {
                Underlying="UPS",
                Maturity="12M",
                Barrier= 60,
                Sector="Services",
                Currency="USD",
                CouponToday= (decimal) 1.94
            },
            new Price {
                Underlying="UPS",
                Maturity="12M",
                Barrier= 70,
                Sector="Services",
                Currency="USD",
                CouponToday= (decimal) 3.83
            },
            new Price {
                Underlying="UPS",
                Maturity="12M",
                Barrier= 80,
                Sector="Services",
                Currency="USD",
                CouponToday= (decimal) 6.11
            },
            new Price {
                Underlying="SGS SA",
                Maturity="3M",
                Barrier= 60,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SGS SA",
                Maturity="3M",
                Barrier= 70,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SGS SA",
                Maturity="3M",
                Barrier= 80,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 0.46
            },
            new Price {
                Underlying="SGS SA",
                Maturity="6M",
                Barrier= 60,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="SGS SA",
                Maturity="6M",
                Barrier= 70,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 1.01
            },
            new Price {
                Underlying="SGS SA",
                Maturity="6M",
                Barrier= 80,
                Sector="Services",
                Currency="CHF",
                CouponToday= (decimal) 3.91
            },
            new Price {
                Underlying="VALE SP ADR",
                Maturity="12M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 7.7
            },
            new Price {
                Underlying="VALE SP ADR",
                Maturity="12M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 10.56
            },
            new Price {
                Underlying="VALE SP ADR",
                Maturity="12M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 12.61
            },
            new Price {
                Underlying="Dufry AG",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Dufry AG",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Dufry AG",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 1.61
            },
            new Price {
                Underlying="Dufry AG",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Dufry AG",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 0.75
            },
            new Price {
                Underlying="Dufry AG",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="CHF",
                CouponToday= (decimal) 5.12
            },
            new Price {
                Underlying="Veolia Environnement",
                Maturity="12M",
                Barrier= 60,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 10.57
            },
            new Price {
                Underlying="Veolia Environnement",
                Maturity="12M",
                Barrier= 70,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 13.89
            },
            new Price {
                Underlying="Veolia Environnement",
                Maturity="12M",
                Barrier= 80,
                Sector="Utilities",
                Currency="EUR",
                CouponToday= (decimal) 15.84
            },
            new Price {
                Underlying="PPR",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="PPR",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="PPR",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 1.05
            },
            new Price {
                Underlying="PPR",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="PPR",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 1.91
            },
            new Price {
                Underlying="PPR",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 6.09
            },
            new Price {
                Underlying="VERIZON COMMUNICATIONS INC",
                Maturity="12M",
                Barrier= 60,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 2.37
            },
            new Price {
                Underlying="VERIZON COMMUNICATIONS INC",
                Maturity="12M",
                Barrier= 70,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 4.21
            },
            new Price {
                Underlying="VERIZON COMMUNICATIONS INC",
                Maturity="12M",
                Barrier= 80,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 6.51
            },
            new Price {
                Underlying="UPS",
                Maturity="3M",
                Barrier= 60,
                Sector="Services",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="UPS",
                Maturity="3M",
                Barrier= 70,
                Sector="Services",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="UPS",
                Maturity="3M",
                Barrier= 80,
                Sector="Services",
                Currency="USD",
                CouponToday= (decimal) 1.13
            },
            new Price {
                Underlying="UPS",
                Maturity="6M",
                Barrier= 60,
                Sector="Services",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="UPS",
                Maturity="6M",
                Barrier= 70,
                Sector="Services",
                Currency="USD",
                CouponToday= (decimal) 1.38
            },
            new Price {
                Underlying="UPS",
                Maturity="6M",
                Barrier= 80,
                Sector="Services",
                Currency="USD",
                CouponToday= (decimal) 4.31
            },
            new Price {
                Underlying="VINCI",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 5.5
            },
            new Price {
                Underlying="VINCI",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 8.51
            },
            new Price {
                Underlying="VINCI",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="EUR",
                CouponToday= (decimal) 10.84
            },
            new Price {
                Underlying="Anadarko Petroleum",
                Maturity="3M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 0.21
            },
            new Price {
                Underlying="Anadarko Petroleum",
                Maturity="3M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 4.2
            },
            new Price {
                Underlying="Anadarko Petroleum",
                Maturity="3M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 13.11
            },
            new Price {
                Underlying="Anadarko Petroleum",
                Maturity="6M",
                Barrier= 60,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 5.33
            },
            new Price {
                Underlying="Anadarko Petroleum",
                Maturity="6M",
                Barrier= 70,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 10.36
            },
            new Price {
                Underlying="Anadarko Petroleum",
                Maturity="6M",
                Barrier= 80,
                Sector="Energy/Commodity",
                Currency="USD",
                CouponToday= (decimal) 15.45
            },
            new Price {
                Underlying="VIVENDI",
                Maturity="12M",
                Barrier= 60,
                Sector="telecom",
                Currency="EUR",
                CouponToday= (decimal) 5.48
            },
            new Price {
                Underlying="VIVENDI",
                Maturity="12M",
                Barrier= 70,
                Sector="telecom",
                Currency="EUR",
                CouponToday= (decimal) 8.4
            },
            new Price {
                Underlying="VIVENDI",
                Maturity="12M",
                Barrier= 80,
                Sector="telecom",
                Currency="EUR",
                CouponToday= (decimal) 10.73
            },
            new Price {
                Underlying="Akamai Technologies",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 1.48
            },
            new Price {
                Underlying="Akamai Technologies",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.92
            },
            new Price {
                Underlying="Akamai Technologies",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 16.42
            },
            new Price {
                Underlying="Akamai Technologies",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 7.38
            },
            new Price {
                Underlying="Akamai Technologies",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 12.95
            },
            new Price {
                Underlying="Akamai Technologies",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 17.85
            },
            new Price {
                Underlying="Vodafone Group PLC",
                Maturity="12M",
                Barrier= 60,
                Sector="Telecommunications",
                Currency="EUR",
                CouponToday= (decimal) 0.02
            },
            new Price {
                Underlying="Vodafone Group PLC",
                Maturity="12M",
                Barrier= 70,
                Sector="Telecommunications",
                Currency="EUR",
                CouponToday= (decimal) 1.73
            },
            new Price {
                Underlying="Vodafone Group PLC",
                Maturity="12M",
                Barrier= 80,
                Sector="Telecommunications",
                Currency="EUR",
                CouponToday= (decimal) 4.44
            },
            new Price {
                Underlying="Pernod-Ricard SA",
                Maturity="3M",
                Barrier= 60,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Pernod-Ricard SA",
                Maturity="3M",
                Barrier= 70,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Pernod-Ricard SA",
                Maturity="3M",
                Barrier= 80,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 2.7
            },
            new Price {
                Underlying="Pernod-Ricard SA",
                Maturity="6M",
                Barrier= 60,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 0.23
            },
            new Price {
                Underlying="Pernod-Ricard SA",
                Maturity="6M",
                Barrier= 70,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 2.41
            },
            new Price {
                Underlying="Pernod-Ricard SA",
                Maturity="6M",
                Barrier= 80,
                Sector="Consumer Goods",
                Currency="EUR",
                CouponToday= (decimal) 6.1
            },
            new Price {
                Underlying="VOLKSWAGEN",
                Maturity="12M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 4.79
            },
            new Price {
                Underlying="VOLKSWAGEN",
                Maturity="12M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 7.81
            },
            new Price {
                Underlying="VOLKSWAGEN",
                Maturity="12M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 10.19
            },
            new Price {
                Underlying="Kaba",
                Maturity="3M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Kaba",
                Maturity="3M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Kaba",
                Maturity="3M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Kaba",
                Maturity="6M",
                Barrier= 60,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Kaba",
                Maturity="6M",
                Barrier= 70,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Kaba",
                Maturity="6M",
                Barrier= 80,
                Sector="Utilities",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Volvo AB -B-",
                Maturity="12M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 4.45
            },
            new Price {
                Underlying="Volvo AB -B-",
                Maturity="12M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 6.97
            },
            new Price {
                Underlying="Volvo AB -B-",
                Maturity="12M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 9.02
            },
            new Price {
                Underlying="EMC",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0.3
            },
            new Price {
                Underlying="EMC",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 2.85
            },
            new Price {
                Underlying="EMC",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 8.27
            },
            new Price {
                Underlying="EMC",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 3.28
            },
            new Price {
                Underlying="EMC",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.91
            },
            new Price {
                Underlying="EMC",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 11.42
            },
            new Price {
                Underlying="WAL-MART STORES",
                Maturity="12M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 1.29
            },
            new Price {
                Underlying="WAL-MART STORES",
                Maturity="12M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 2.78
            },
            new Price {
                Underlying="WAL-MART STORES",
                Maturity="12M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 4.84
            },
            new Price {
                Underlying="Fiat",
                Maturity="3M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 3.95
            },
            new Price {
                Underlying="Fiat",
                Maturity="3M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 11.09
            },
            new Price {
                Underlying="Fiat",
                Maturity="3M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 20.75
            },
            new Price {
                Underlying="Fiat",
                Maturity="6M",
                Barrier= 60,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 9.81
            },
            new Price {
                Underlying="Fiat",
                Maturity="6M",
                Barrier= 70,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 15.52
            },
            new Price {
                Underlying="Fiat",
                Maturity="6M",
                Barrier= 80,
                Sector="Transportation",
                Currency="EUR",
                CouponToday= (decimal) 20.1
            },
            new Price {
                Underlying="WALT DISNEY COMPANY",
                Maturity="12M",
                Barrier= 60,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 3.77
            },
            new Price {
                Underlying="WALT DISNEY COMPANY",
                Maturity="12M",
                Barrier= 70,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 5.81
            },
            new Price {
                Underlying="WALT DISNEY COMPANY",
                Maturity="12M",
                Barrier= 80,
                Sector="Telecom",
                Currency="USD",
                CouponToday= (decimal) 7.82
            },
            new Price {
                Underlying="Nike",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Nike",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 0.96
            },
            new Price {
                Underlying="Nike",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 4.52
            },
            new Price {
                Underlying="Nike",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 1.24
            },
            new Price {
                Underlying="Nike",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 3.51
            },
            new Price {
                Underlying="Nike",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="USD",
                CouponToday= (decimal) 7.12
            },
            new Price {
                Underlying="WELLS FARGO & CO",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 5.03
            },
            new Price {
                Underlying="WELLS FARGO & CO",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 7.55
            },
            new Price {
                Underlying="WELLS FARGO & CO",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="USD",
                CouponToday= (decimal) 9.79
            },
            new Price {
                Underlying="Qualcomm",
                Maturity="3M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Qualcomm",
                Maturity="3M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 0.82
            },
            new Price {
                Underlying="Qualcomm",
                Maturity="3M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 5.95
            },
            new Price {
                Underlying="Qualcomm",
                Maturity="6M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 1.9
            },
            new Price {
                Underlying="Qualcomm",
                Maturity="6M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 5.33
            },
            new Price {
                Underlying="Qualcomm",
                Maturity="6M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 10.15
            },
            new Price {
                Underlying="WOF 01",
                Maturity="12M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 4.44
            },
            new Price {
                Underlying="WOF 01",
                Maturity="12M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 8.19
            },
            new Price {
                Underlying="WOF 01",
                Maturity="12M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 11.82
            },
            new Price {
                Underlying="Reckitt Benckiser",
                Maturity="3M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Reckitt Benckiser",
                Maturity="3M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Reckitt Benckiser",
                Maturity="3M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Reckitt Benckiser",
                Maturity="6M",
                Barrier= 60,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Reckitt Benckiser",
                Maturity="6M",
                Barrier= 70,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="Reckitt Benckiser",
                Maturity="6M",
                Barrier= 80,
                Sector="Retail",
                Currency="EUR",
                CouponToday= (decimal) 0.81
            },
            new Price {
                Underlying="WOF 02",
                Maturity="12M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 2.09
            },
            new Price {
                Underlying="WOF 02",
                Maturity="12M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 5.34
            },
            new Price {
                Underlying="WOF 02",
                Maturity="12M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 8.94
            },
            new Price {
                Underlying="WOF 06",
                Maturity="3M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 06",
                Maturity="3M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 06",
                Maturity="3M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 1.55
            },
            new Price {
                Underlying="WOF 06",
                Maturity="6M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 06",
                Maturity="6M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0.78
            },
            new Price {
                Underlying="WOF 06",
                Maturity="6M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 6.76
            },
            new Price {
                Underlying="WOF 03",
                Maturity="12M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 4.83
            },
            new Price {
                Underlying="WOF 03",
                Maturity="12M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 8.47
            },
            new Price {
                Underlying="WOF 03",
                Maturity="12M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 11.83
            },
            new Price {
                Underlying="WOF 01",
                Maturity="3M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 01",
                Maturity="3M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 01",
                Maturity="3M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 2.39
            },
            new Price {
                Underlying="WOF 01",
                Maturity="6M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0.08
            },
            new Price {
                Underlying="WOF 01",
                Maturity="6M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 3.81
            },
            new Price {
                Underlying="WOF 01",
                Maturity="6M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 9.72
            },
            new Price {
                Underlying="WOF 04",
                Maturity="12M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 04",
                Maturity="12M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0.44
            },
            new Price {
                Underlying="WOF 04",
                Maturity="12M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 3.55
            },
            new Price {
                Underlying="WOF 02",
                Maturity="3M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 02",
                Maturity="3M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 02",
                Maturity="3M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 02",
                Maturity="6M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 02",
                Maturity="6M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0.85
            },
            new Price {
                Underlying="WOF 02",
                Maturity="6M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 5.59
            },
            new Price {
                Underlying="WOF 05",
                Maturity="12M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 1.74
            },
            new Price {
                Underlying="WOF 05",
                Maturity="12M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 4.96
            },
            new Price {
                Underlying="WOF 05",
                Maturity="12M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 8.42
            },
            new Price {
                Underlying="WOF 07",
                Maturity="3M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 07",
                Maturity="3M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 07",
                Maturity="3M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 1.86
            },
            new Price {
                Underlying="WOF 07",
                Maturity="6M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 07",
                Maturity="6M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 3.43
            },
            new Price {
                Underlying="WOF 07",
                Maturity="6M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 9.04
            },
            new Price {
                Underlying="WOF 06",
                Maturity="12M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0.49
            },
            new Price {
                Underlying="WOF 06",
                Maturity="12M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 4.22
            },
            new Price {
                Underlying="WOF 06",
                Maturity="12M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 8.75
            },
            new Price {
                Underlying="WOF 08",
                Maturity="3M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 08",
                Maturity="3M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 08",
                Maturity="3M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0.6
            },
            new Price {
                Underlying="WOF 08",
                Maturity="6M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 08",
                Maturity="6M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 2.38
            },
            new Price {
                Underlying="WOF 08",
                Maturity="6M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 8.36
            },
            new Price {
                Underlying="WOF 07",
                Maturity="12M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 3.81
            },
            new Price {
                Underlying="WOF 07",
                Maturity="12M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 7.41
            },
            new Price {
                Underlying="WOF 07",
                Maturity="12M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 11.03
            },
            new Price {
                Underlying="WOF 04",
                Maturity="3M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 04",
                Maturity="3M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 04",
                Maturity="3M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 04",
                Maturity="6M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 04",
                Maturity="6M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 04",
                Maturity="6M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0.1
            },
            new Price {
                Underlying="WOF 08",
                Maturity="12M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 2.62
            },
            new Price {
                Underlying="WOF 08",
                Maturity="12M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 6.25
            },
            new Price {
                Underlying="WOF 08",
                Maturity="12M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 10.17
            },
            new Price {
                Underlying="WOF 03",
                Maturity="3M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 03",
                Maturity="3M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 03",
                Maturity="3M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 3.72
            },
            new Price {
                Underlying="WOF 03",
                Maturity="6M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0.44
            },
            new Price {
                Underlying="WOF 03",
                Maturity="6M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 4.43
            },
            new Price {
                Underlying="WOF 03",
                Maturity="6M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 10.35
            },
            new Price {
                Underlying="WOF 09",
                Maturity="12M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 2.4
            },
            new Price {
                Underlying="WOF 09",
                Maturity="12M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 6.05
            },
            new Price {
                Underlying="WOF 09",
                Maturity="12M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 10.14
            },
            new Price {
                Underlying="WOF 05",
                Maturity="3M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 05",
                Maturity="3M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 05",
                Maturity="3M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0.43
            },
            new Price {
                Underlying="WOF 05",
                Maturity="6M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 05",
                Maturity="6M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 1.1
            },
            new Price {
                Underlying="WOF 05",
                Maturity="6M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 6
            },
            new Price {
                Underlying="WOF 10",
                Maturity="12M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 7.67
            },
            new Price {
                Underlying="WOF 10",
                Maturity="12M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 11.72
            },
            new Price {
                Underlying="WOF 10",
                Maturity="12M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 15.17
            },
            new Price {
                Underlying="WOF 09",
                Maturity="3M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 09",
                Maturity="3M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 09",
                Maturity="3M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 09",
                Maturity="6M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 09",
                Maturity="6M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 1.01
            },
            new Price {
                Underlying="WOF 09",
                Maturity="6M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 6.32
            },
            new Price {
                Underlying="WOF 11",
                Maturity="12M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 5.63
            },
            new Price {
                Underlying="WOF 11",
                Maturity="12M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 9.44
            },
            new Price {
                Underlying="WOF 11",
                Maturity="12M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 12.9
            },
            new Price {
                Underlying="WOF 10",
                Maturity="3M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 10",
                Maturity="3M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 1.11
            },
            new Price {
                Underlying="WOF 10",
                Maturity="3M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 8.47
            },
            new Price {
                Underlying="WOF 10",
                Maturity="6M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 2.39
            },
            new Price {
                Underlying="WOF 10",
                Maturity="6M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 7.59
            },
            new Price {
                Underlying="WOF 10",
                Maturity="6M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 14.54
            },
            new Price {
                Underlying="WOF 12",
                Maturity="12M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 2.13
            },
            new Price {
                Underlying="WOF 12",
                Maturity="12M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 5.57
            },
            new Price {
                Underlying="WOF 12",
                Maturity="12M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 9.43
            },
            new Price {
                Underlying="WOF 11",
                Maturity="3M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 11",
                Maturity="3M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0.22
            },
            new Price {
                Underlying="WOF 11",
                Maturity="3M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 6.29
            },
            new Price {
                Underlying="WOF 11",
                Maturity="6M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 1.52
            },
            new Price {
                Underlying="WOF 11",
                Maturity="6M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 5.87
            },
            new Price {
                Underlying="WOF 11",
                Maturity="6M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 11.69
            },
            new Price {
                Underlying="WOF 13",
                Maturity="12M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 5.44
            },
            new Price {
                Underlying="WOF 13",
                Maturity="12M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 10.16
            },
            new Price {
                Underlying="WOF 13",
                Maturity="12M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 14.33
            },
            new Price {
                Underlying="WOF 14",
                Maturity="3M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 14",
                Maturity="3M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 14",
                Maturity="3M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 4.12
            },
            new Price {
                Underlying="WOF 14",
                Maturity="6M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0.42
            },
            new Price {
                Underlying="WOF 14",
                Maturity="6M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 4.23
            },
            new Price {
                Underlying="WOF 14",
                Maturity="6M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 9.82
            },
            new Price {
                Underlying="WOF 14",
                Maturity="12M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 4.45
            },
            new Price {
                Underlying="WOF 14",
                Maturity="12M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 8.46
            },
            new Price {
                Underlying="WOF 14",
                Maturity="12M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 12.54
            },
            new Price {
                Underlying="WOF 12",
                Maturity="3M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 12",
                Maturity="3M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 12",
                Maturity="3M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 12",
                Maturity="6M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 12",
                Maturity="6M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 1
            },
            new Price {
                Underlying="WOF 12",
                Maturity="6M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 6.19
            },
            new Price {
                Underlying="WOF 15",
                Maturity="12M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 5.88
            },
            new Price {
                Underlying="WOF 15",
                Maturity="12M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 9.24
            },
            new Price {
                Underlying="WOF 15",
                Maturity="12M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 12.41
            },
            new Price {
                Underlying="WOF 13",
                Maturity="3M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 13",
                Maturity="3M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 13",
                Maturity="3M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 3.85
            },
            new Price {
                Underlying="WOF 13",
                Maturity="6M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0.42
            },
            new Price {
                Underlying="WOF 13",
                Maturity="6M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 5.41
            },
            new Price {
                Underlying="WOF 13",
                Maturity="6M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 13.13
            },
            new Price {
                Underlying="WOF 16",
                Maturity="12M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 11.07
            },
            new Price {
                Underlying="WOF 16",
                Maturity="12M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 14.83
            },
            new Price {
                Underlying="WOF 16",
                Maturity="12M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 17.58
            },
            new Price {
                Underlying="WOF 15",
                Maturity="3M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 15",
                Maturity="3M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 15",
                Maturity="3M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 3.73
            },
            new Price {
                Underlying="WOF 15",
                Maturity="6M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 1.56
            },
            new Price {
                Underlying="WOF 15",
                Maturity="6M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 5.69
            },
            new Price {
                Underlying="WOF 15",
                Maturity="6M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 11.46
            },
            new Price {
                Underlying="WOF 17",
                Maturity="12M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 5.93
            },
            new Price {
                Underlying="WOF 17",
                Maturity="12M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 10.15
            },
            new Price {
                Underlying="WOF 17",
                Maturity="12M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 14.04
            },
            new Price {
                Underlying="WOF 16",
                Maturity="3M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 0.06
            },
            new Price {
                Underlying="WOF 16",
                Maturity="3M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 6.16
            },
            new Price {
                Underlying="WOF 16",
                Maturity="3M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 16.27
            },
            new Price {
                Underlying="WOF 16",
                Maturity="6M",
                Barrier= 55,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 7.49
            },
            new Price {
                Underlying="WOF 16",
                Maturity="6M",
                Barrier= 65,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 13.84
            },
            new Price {
                Underlying="WOF 16",
                Maturity="6M",
                Barrier= 75,
                Sector="European Stocks",
                Currency="EUR",
                CouponToday= (decimal) 20.19
            },
            new Price {
                Underlying="WOF 18",
                Maturity="12M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0.38
            },
            new Price {
                Underlying="WOF 18",
                Maturity="12M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 2.66
            },
            new Price {
                Underlying="WOF 18",
                Maturity="12M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 5.99
            },
            new Price {
                Underlying="WOF 17",
                Maturity="3M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 17",
                Maturity="3M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0.56
            },
            new Price {
                Underlying="WOF 17",
                Maturity="3M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 7.29
            },
            new Price {
                Underlying="WOF 17",
                Maturity="6M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 1.18
            },
            new Price {
                Underlying="WOF 17",
                Maturity="6M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 5.55
            },
            new Price {
                Underlying="WOF 17",
                Maturity="6M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 12.39
            },
            new Price {
                Underlying="WOF 19",
                Maturity="12M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 6.7
            },
            new Price {
                Underlying="WOF 19",
                Maturity="12M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 10.16
            },
            new Price {
                Underlying="WOF 19",
                Maturity="12M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 13.18
            },
            new Price {
                Underlying="WOF 20",
                Maturity="3M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 20",
                Maturity="3M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 20",
                Maturity="3M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 20",
                Maturity="6M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 20",
                Maturity="6M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0.43
            },
            new Price {
                Underlying="WOF 20",
                Maturity="6M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 3.59
            },
            new Price {
                Underlying="WOF 20",
                Maturity="12M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 1.27
            },
            new Price {
                Underlying="WOF 20",
                Maturity="12M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 3.53
            },
            new Price {
                Underlying="WOF 20",
                Maturity="12M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 6.52
            },
            new Price {
                Underlying="WOF 19",
                Maturity="3M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 19",
                Maturity="3M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0.77
            },
            new Price {
                Underlying="WOF 19",
                Maturity="3M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 6.96
            },
            new Price {
                Underlying="WOF 19",
                Maturity="6M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 2.71
            },
            new Price {
                Underlying="WOF 19",
                Maturity="6M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 7.18
            },
            new Price {
                Underlying="WOF 19",
                Maturity="6M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 12.96
            },
            new Price {
                Underlying="WOF 21",
                Maturity="12M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 6.66
            },
            new Price {
                Underlying="WOF 21",
                Maturity="12M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 10.01
            },
            new Price {
                Underlying="WOF 21",
                Maturity="12M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 13.04
            },
            new Price {
                Underlying="WOF 18",
                Maturity="3M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 18",
                Maturity="3M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 18",
                Maturity="3M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 18",
                Maturity="6M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 18",
                Maturity="6M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 18",
                Maturity="6M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 2.14
            },
            new Price {
                Underlying="WOF 22",
                Maturity="12M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 8.3
            },
            new Price {
                Underlying="WOF 22",
                Maturity="12M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 11.49
            },
            new Price {
                Underlying="WOF 22",
                Maturity="12M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 14.2
            },
            new Price {
                Underlying="WOF 21",
                Maturity="3M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 21",
                Maturity="3M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 1.13
            },
            new Price {
                Underlying="WOF 21",
                Maturity="3M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 7.47
            },
            new Price {
                Underlying="WOF 21",
                Maturity="6M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 2.18
            },
            new Price {
                Underlying="WOF 21",
                Maturity="6M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 6.29
            },
            new Price {
                Underlying="WOF 21",
                Maturity="6M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 12.04
            },
            new Price {
                Underlying="WOF 23",
                Maturity="12M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 7.11
            },
            new Price {
                Underlying="WOF 23",
                Maturity="12M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 11.68
            },
            new Price {
                Underlying="WOF 23",
                Maturity="12M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 15.58
            },
            new Price {
                Underlying="WOF 22",
                Maturity="3M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 22",
                Maturity="3M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 3.74
            },
            new Price {
                Underlying="WOF 22",
                Maturity="3M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 11.25
            },
            new Price {
                Underlying="WOF 22",
                Maturity="6M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 4.92
            },
            new Price {
                Underlying="WOF 22",
                Maturity="6M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 9.46
            },
            new Price {
                Underlying="WOF 22",
                Maturity="6M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 15.06
            },
            new Price {
                Underlying="WOF 24",
                Maturity="12M",
                Barrier= 55,
                Sector="Quanto",
                Currency="CHF",
                CouponToday= (decimal) 1.16
            },
            new Price {
                Underlying="WOF 24",
                Maturity="12M",
                Barrier= 65,
                Sector="Quanto",
                Currency="CHF",
                CouponToday= (decimal) 3.39
            },
            new Price {
                Underlying="WOF 24",
                Maturity="12M",
                Barrier= 75,
                Sector="Quanto",
                Currency="CHF",
                CouponToday= (decimal) 6.07
            },
            new Price {
                Underlying="WOF 23",
                Maturity="3M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 23",
                Maturity="3M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 2.69
            },
            new Price {
                Underlying="WOF 23",
                Maturity="3M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 11.02
            },
            new Price {
                Underlying="WOF 23",
                Maturity="6M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 2.71
            },
            new Price {
                Underlying="WOF 23",
                Maturity="6M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 8
            },
            new Price {
                Underlying="WOF 23",
                Maturity="6M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 15.23
            },
            new Price {
                Underlying="WOF 25",
                Maturity="12M",
                Barrier= 55,
                Sector="Quanto",
                Currency="EUR",
                CouponToday= (decimal) 1.38
            },
            new Price {
                Underlying="WOF 25",
                Maturity="12M",
                Barrier= 65,
                Sector="Quanto",
                Currency="EUR",
                CouponToday= (decimal) 3.61
            },
            new Price {
                Underlying="WOF 25",
                Maturity="12M",
                Barrier= 75,
                Sector="Quanto",
                Currency="EUR",
                CouponToday= (decimal) 6.28
            },
            new Price {
                Underlying="WOF 27",
                Maturity="3M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 27",
                Maturity="3M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 3.31
            },
            new Price {
                Underlying="WOF 27",
                Maturity="3M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 11.52
            },
            new Price {
                Underlying="WOF 27",
                Maturity="6M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 4.27
            },
            new Price {
                Underlying="WOF 27",
                Maturity="6M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 9.85
            },
            new Price {
                Underlying="WOF 27",
                Maturity="6M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 16.08
            },
            new Price {
                Underlying="WOF 26",
                Maturity="12M",
                Barrier= 55,
                Sector="Quanto",
                Currency="USD",
                CouponToday= (decimal) 1.81
            },
            new Price {
                Underlying="WOF 26",
                Maturity="12M",
                Barrier= 65,
                Sector="Quanto",
                Currency="USD",
                CouponToday= (decimal) 4.16
            },
            new Price {
                Underlying="WOF 26",
                Maturity="12M",
                Barrier= 75,
                Sector="Quanto",
                Currency="USD",
                CouponToday= (decimal) 6.86
            },
            new Price {
                Underlying="WOF 24",
                Maturity="3M",
                Barrier= 55,
                Sector="Quanto",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 24",
                Maturity="3M",
                Barrier= 65,
                Sector="Quanto",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 24",
                Maturity="3M",
                Barrier= 75,
                Sector="Quanto",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 24",
                Maturity="6M",
                Barrier= 55,
                Sector="Quanto",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 24",
                Maturity="6M",
                Barrier= 65,
                Sector="Quanto",
                Currency="CHF",
                CouponToday= (decimal) 0.69
            },
            new Price {
                Underlying="WOF 24",
                Maturity="6M",
                Barrier= 75,
                Sector="Quanto",
                Currency="CHF",
                CouponToday= (decimal) 4.03
            },
            new Price {
                Underlying="WOF 27",
                Maturity="12M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 7.93
            },
            new Price {
                Underlying="WOF 27",
                Maturity="12M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 11.61
            },
            new Price {
                Underlying="WOF 27",
                Maturity="12M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 14.44
            },
            new Price {
                Underlying="WOF 28",
                Maturity="3M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 28",
                Maturity="3M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 2.33
            },
            new Price {
                Underlying="WOF 28",
                Maturity="3M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 9.55
            },
            new Price {
                Underlying="WOF 28",
                Maturity="6M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 3.47
            },
            new Price {
                Underlying="WOF 28",
                Maturity="6M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 7.88
            },
            new Price {
                Underlying="WOF 28",
                Maturity="6M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 13.59
            },
            new Price {
                Underlying="WOF 28",
                Maturity="12M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 6.93
            },
            new Price {
                Underlying="WOF 28",
                Maturity="12M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 10.36
            },
            new Price {
                Underlying="WOF 28",
                Maturity="12M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 13.39
            },
            new Price {
                Underlying="WOF 25",
                Maturity="3M",
                Barrier= 55,
                Sector="Quanto",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 25",
                Maturity="3M",
                Barrier= 65,
                Sector="Quanto",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 25",
                Maturity="3M",
                Barrier= 75,
                Sector="Quanto",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 25",
                Maturity="6M",
                Barrier= 55,
                Sector="Quanto",
                Currency="EUR",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 25",
                Maturity="6M",
                Barrier= 65,
                Sector="Quanto",
                Currency="EUR",
                CouponToday= (decimal) 0.87
            },
            new Price {
                Underlying="WOF 25",
                Maturity="6M",
                Barrier= 75,
                Sector="Quanto",
                Currency="EUR",
                CouponToday= (decimal) 4.2
            },
            new Price {
                Underlying="WOF 29",
                Maturity="12M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 13.44
            },
            new Price {
                Underlying="WOF 29",
                Maturity="12M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 16.52
            },
            new Price {
                Underlying="WOF 29",
                Maturity="12M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 18.7
            },
            new Price {
                Underlying="WOF 29",
                Maturity="3M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 3.38
            },
            new Price {
                Underlying="WOF 29",
                Maturity="3M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 11.42
            },
            new Price {
                Underlying="WOF 29",
                Maturity="3M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 22.05
            },
            new Price {
                Underlying="WOF 29",
                Maturity="6M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 10.6
            },
            new Price {
                Underlying="WOF 29",
                Maturity="6M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 16.43
            },
            new Price {
                Underlying="WOF 29",
                Maturity="6M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 21.87
            },
            new Price {
                Underlying="WOF 30",
                Maturity="12M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 4.4
            },
            new Price {
                Underlying="WOF 30",
                Maturity="12M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 7.42
            },
            new Price {
                Underlying="WOF 30",
                Maturity="12M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 10.27
            },
            new Price {
                Underlying="WOF 26",
                Maturity="3M",
                Barrier= 55,
                Sector="Quanto",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 26",
                Maturity="3M",
                Barrier= 65,
                Sector="Quanto",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 26",
                Maturity="3M",
                Barrier= 75,
                Sector="Quanto",
                Currency="USD",
                CouponToday= (decimal) 0.15
            },
            new Price {
                Underlying="WOF 26",
                Maturity="6M",
                Barrier= 55,
                Sector="Quanto",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 26",
                Maturity="6M",
                Barrier= 65,
                Sector="Quanto",
                Currency="USD",
                CouponToday= (decimal) 1.17
            },
            new Price {
                Underlying="WOF 26",
                Maturity="6M",
                Barrier= 75,
                Sector="Quanto",
                Currency="USD",
                CouponToday= (decimal) 4.54
            },
            new Price {
                Underlying="WOF 31",
                Maturity="12M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 6
            },
            new Price {
                Underlying="WOF 31",
                Maturity="12M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 9.33
            },
            new Price {
                Underlying="WOF 31",
                Maturity="12M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 12.29
            },
            new Price {
                Underlying="WOF 32",
                Maturity="3M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 32",
                Maturity="3M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 0.08
            },
            new Price {
                Underlying="WOF 32",
                Maturity="3M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 6.62
            },
            new Price {
                Underlying="WOF 32",
                Maturity="6M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 1.85
            },
            new Price {
                Underlying="WOF 32",
                Maturity="6M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 6.31
            },
            new Price {
                Underlying="WOF 32",
                Maturity="6M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 12.31
            },
            new Price {
                Underlying="WOF 32",
                Maturity="12M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 6.86
            },
            new Price {
                Underlying="WOF 32",
                Maturity="12M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 10.32
            },
            new Price {
                Underlying="WOF 32",
                Maturity="12M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 13.16
            },
            new Price {
                Underlying="WOF 30",
                Maturity="3M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 30",
                Maturity="3M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 30",
                Maturity="3M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 3.76
            },
            new Price {
                Underlying="WOF 30",
                Maturity="6M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 0.88
            },
            new Price {
                Underlying="WOF 30",
                Maturity="6M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 4.26
            },
            new Price {
                Underlying="WOF 30",
                Maturity="6M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 9.42
            },
            new Price {
                Underlying="WOF 33",
                Maturity="12M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 7.76
            },
            new Price {
                Underlying="WOF 33",
                Maturity="12M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 11.69
            },
            new Price {
                Underlying="WOF 33",
                Maturity="12M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 14.73
            },
            new Price {
                Underlying="WOF 33",
                Maturity="3M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 33",
                Maturity="3M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 1.75
            },
            new Price {
                Underlying="WOF 33",
                Maturity="3M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 9.33
            },
            new Price {
                Underlying="WOF 33",
                Maturity="6M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 3.43
            },
            new Price {
                Underlying="WOF 33",
                Maturity="6M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 8.59
            },
            new Price {
                Underlying="WOF 33",
                Maturity="6M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 14.94
            },
            new Price {
                Underlying="WOF 34",
                Maturity="12M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 1.83
            },
            new Price {
                Underlying="WOF 34",
                Maturity="12M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 5.13
            },
            new Price {
                Underlying="WOF 34",
                Maturity="12M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 8.98
            },
            new Price {
                Underlying="WOF 31",
                Maturity="3M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 31",
                Maturity="3M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 31",
                Maturity="3M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 5.48
            },
            new Price {
                Underlying="WOF 31",
                Maturity="6M",
                Barrier= 55,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 1.39
            },
            new Price {
                Underlying="WOF 31",
                Maturity="6M",
                Barrier= 65,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 5.37
            },
            new Price {
                Underlying="WOF 31",
                Maturity="6M",
                Barrier= 75,
                Sector="ADR",
                Currency="USD",
                CouponToday= (decimal) 10.75
            },
            new Price {
                Underlying="WOF 35",
                Maturity="12M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 16.16
            },
            new Price {
                Underlying="WOF 35",
                Maturity="12M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 20
            },
            new Price {
                Underlying="WOF 35",
                Maturity="12M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 22.36
            },
            new Price {
                Underlying="WOF 34",
                Maturity="3M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 34",
                Maturity="3M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 34",
                Maturity="3M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 34",
                Maturity="6M",
                Barrier= 55,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 34",
                Maturity="6M",
                Barrier= 65,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 0.85
            },
            new Price {
                Underlying="WOF 34",
                Maturity="6M",
                Barrier= 75,
                Sector="Swiss Stocks",
                Currency="CHF",
                CouponToday= (decimal) 5.96
            },
            new Price {
                Underlying="WOF 36",
                Maturity="12M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 5.4
            },
            new Price {
                Underlying="WOF 36",
                Maturity="12M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 8.8
            },
            new Price {
                Underlying="WOF 36",
                Maturity="12M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 11.99
            },
            new Price {
                Underlying="WOF 35",
                Maturity="3M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 4.62
            },
            new Price {
                Underlying="WOF 35",
                Maturity="3M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 14.85
            },
            new Price {
                Underlying="WOF 35",
                Maturity="3M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 29.17
            },
            new Price {
                Underlying="WOF 35",
                Maturity="6M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 14.14
            },
            new Price {
                Underlying="WOF 35",
                Maturity="6M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 22.58
            },
            new Price {
                Underlying="WOF 35",
                Maturity="6M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 29.55
            },
            new Price {
                Underlying="WOF 37",
                Maturity="12M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 2.7
            },
            new Price {
                Underlying="WOF 37",
                Maturity="12M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 5.98
            },
            new Price {
                Underlying="WOF 37",
                Maturity="12M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 9.68
            },
            new Price {
                Underlying="WOF 36",
                Maturity="3M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 36",
                Maturity="3M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 36",
                Maturity="3M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 4.8
            },
            new Price {
                Underlying="WOF 36",
                Maturity="6M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 1.02
            },
            new Price {
                Underlying="WOF 36",
                Maturity="6M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 4.61
            },
            new Price {
                Underlying="WOF 36",
                Maturity="6M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 10.33
            },
            new Price {
                Underlying="WOF38",
                Maturity="12M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 6.09
            },
            new Price {
                Underlying="WOF38",
                Maturity="12M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 9.17
            },
            new Price {
                Underlying="WOF38",
                Maturity="12M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 11.88
            },
            new Price {
                Underlying="WOF38",
                Maturity="3M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF38",
                Maturity="3M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0.49
            },
            new Price {
                Underlying="WOF38",
                Maturity="3M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 6.39
            },
            new Price {
                Underlying="WOF38",
                Maturity="6M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 2.37
            },
            new Price {
                Underlying="WOF38",
                Maturity="6M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 6.26
            },
            new Price {
                Underlying="WOF38",
                Maturity="6M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 11.63
            },
            new Price {
                Underlying="Yahoo",
                Maturity="12M",
                Barrier= 60,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 4.4
            },
            new Price {
                Underlying="Yahoo",
                Maturity="12M",
                Barrier= 70,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 6.85
            },
            new Price {
                Underlying="Yahoo",
                Maturity="12M",
                Barrier= 80,
                Sector="Technology",
                Currency="USD",
                CouponToday= (decimal) 9.06
            },
            new Price {
                Underlying="WOF 37",
                Maturity="3M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 37",
                Maturity="3M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 37",
                Maturity="3M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 1.4
            },
            new Price {
                Underlying="WOF 37",
                Maturity="6M",
                Barrier= 55,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 0
            },
            new Price {
                Underlying="WOF 37",
                Maturity="6M",
                Barrier= 65,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 1.72
            },
            new Price {
                Underlying="WOF 37",
                Maturity="6M",
                Barrier= 75,
                Sector="US Stocks",
                Currency="USD",
                CouponToday= (decimal) 6.39
            },
            new Price {
                Underlying="ZURICH INS GROUP N",
                Maturity="12M",
                Barrier= 60,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 2.33
            },
            new Price {
                Underlying="ZURICH INS GROUP N",
                Maturity="12M",
                Barrier= 70,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 4.87
            },
            new Price {
                Underlying="ZURICH INS GROUP N",
                Maturity="12M",
                Barrier= 80,
                Sector="Financials",
                Currency="CHF",
                CouponToday= (decimal) 7.61
            }
       
                };
        }
    }
}
