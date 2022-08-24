using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetim.Model
{
    using System;
    using System.Collections.Generic;

    public partial class SiteSakinleri
    {
        public int Id { get; set; }
        public string Blok { get; set; }
        public Nullable<int> DaireNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
    }
}
