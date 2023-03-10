using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxApp.Model
{
    public class Ergebnis
    {
        public float Betrag { get; set; }
        public float BetragBrutto { get; set; }
        public float BetragNetto { get; set; }
        public float BetragUst { get; set; } 
        public bool IsNetto { get; set; }
        public float UstProzenz { get; set; }
        public bool IsSelected { get; set; }
    }
}
