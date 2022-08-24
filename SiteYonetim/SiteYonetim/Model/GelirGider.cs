using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetim.Model
{
    using System;
    using System.Collections.Generic;

    public partial class GelirGider
    {
        public int ID { get; set; }
        public string GelirGiderTuru { get; set; }
        public Nullable<decimal> GelirGiderTutar { get; set; }
        public string GelirGiderAciklama { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string KaydedenKisi { get; set; }
    }
}