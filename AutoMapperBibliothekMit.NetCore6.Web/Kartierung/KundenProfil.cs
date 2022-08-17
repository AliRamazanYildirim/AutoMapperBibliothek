using AutoMapper;
using AutoMapperBibliothekMit.NetCore6.Web.Düoe;
using AutoMapperBibliothekMit.NetCore6.Web.Models;

namespace AutoMapperBibliothekMit.NetCore6.Web.Kartierung
{
    public class KundenProfil : Profile
    {
        public KundenProfil()
        {
            CreateMap<Kunde, KundeDüo>().IncludeMembers(kunde=>kunde.KreditKarte);
            //Anstatt wie unten geschrieben zu schreiben, können wir auf diese Weise schreiben.
            //CreateMap<KundeDüo, Kunde>();

            //Wie werden zwei Objekte mit unterschiedlichen Eigenschaftsnamen zugeordnet?

            //Wie unten geschrieben können wir  definieren.Aber es wird nicht empfohlen,
            //eine Einzelzuordnung durchzuführen, da dies die Leistung von AutoMapper verringert.

            //CreateMap<Kunde, KundeDüo>().
            //ForMember(ziel => ziel.VorName, quelle => quelle.MapFrom(kunde => kunde.Name)).
            //ForMember(ziel => ziel.KreditKarteNummer, quelle => quelle.MapFrom(kunde => kunde.KreditKarte.Nummer)).
            //ForMember(ziel => ziel.KreditKarteGültigesDatum, quelle => quelle.MapFrom(kunde => kunde.KreditKarte.GültigesDatum));

            //Wenn wir diese Methodu ausblenden,dann erhalten wir VollständigerName leer(null).
            //ForMember(ziel=>ziel.VollständigerName,quelle=>quelle.MapFrom(kunde=>kunde.GeheZumVollständigerName()));

            CreateMap<KreditKarte, KundeDüo>();
        }
    }
}
