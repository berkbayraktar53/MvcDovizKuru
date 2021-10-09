using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DovizKuru.Models
{
    public class DovizKuruModel
    {
        public string CurrencyCode { get; set; }
        public string Unit { get; set; }
        public string Isim { get; set; }
        public string ForexBuying { get; set; }
        public string ForexSelling { get; set; }
    }
}