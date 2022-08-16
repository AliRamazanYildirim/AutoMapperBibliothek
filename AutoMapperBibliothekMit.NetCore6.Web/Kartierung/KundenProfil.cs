using AutoMapper;
using AutoMapperBibliothekMit.NetCore6.Web.Düoe;
using AutoMapperBibliothekMit.NetCore6.Web.Models;

namespace AutoMapperBibliothekMit.NetCore6.Web.Kartierung
{
    public class KundenProfil : Profile
    {
        public KundenProfil()
        {
            CreateMap<Kunde, KundeDüo>().ReverseMap();
            //Anstatt wie unten geschrieben zu schreiben, können wir auf diese Weise schreiben.

            //CreateMap<Kunde, KundeDüo>();
            //CreateMap<KundeDüo, Kunde>();
        }
    }
}
