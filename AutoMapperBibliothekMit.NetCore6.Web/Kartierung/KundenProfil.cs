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
            //CreateMap<KundeDüo, Kunde>();

            //Wie werden zwei Objekte mit unterschiedlichen Eigenschaftsnamen zugeordnet?

            //Wie unten geschrieben können wir  definieren.Aber es wird nicht empfohlen,
            //eine Einzelzuordnung durchzuführen, da dies die Leistung von AutoMapper verringert.
            CreateMap<Kunde, KundeDüo>().
                ForMember(dest=>dest.VorName,sorce=>sorce.MapFrom(kunde=>kunde.Name));

            
        }
    }
}
