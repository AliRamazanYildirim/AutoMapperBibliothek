using Microsoft.EntityFrameworkCore;

namespace AutoMapperBibliothekMit.NetCore6.Web.Models
{
    
    public class KreditKarte
    {
        public string Nummer { get; set; }
        public DateTime GültigesDatum  { get; set; }
    }
}
