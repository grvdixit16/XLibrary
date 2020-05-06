using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XLibrary.Models.DbModels
{
    public class TaxRates : SharedDbModel
    {
        public decimal TaxRate { get; set; }
        public string Label { get; set; }
        public string TaxDescription { get; set; }
    }
}