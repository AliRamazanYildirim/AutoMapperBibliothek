using AutoMapper;
using AutoMapperBibliothekMit.NetCore6.Web.Düoe;
using AutoMapperBibliothekMit.NetCore6.Web.Models;

namespace AutoMapperBibliothekMit.NetCore6.Web.Kartierung
{
    public class EreignisDatumProfil:Profile
    {
        public EreignisDatumProfil()
        {
            //Hier haben wir die Datumsinformationen als Tag, Monat, Jahr als Ganzes genommen.
            CreateMap<EreignisDatumDüo, EreignisDatum>().
            ForMember(datum => datum.Datum, ziel => ziel.MapFrom(datum => new DateTime(datum.Jahr, datum.Monat, datum.Tag)));

            //Hier haben wir die Datumsinformationen in Teilen von Tag, Monat, Jahr genommen.
            CreateMap<EreignisDatum, EreignisDatumDüo>().
            ForMember(datum => datum.Jahr, ziel => ziel.MapFrom(datum =>datum.Datum.Year)).
            ForMember(datum => datum.Monat, ziel => ziel.MapFrom(datum => datum.Datum.Month)).
            ForMember(datum => datum.Tag, ziel => ziel.MapFrom(datum => datum.Datum.Day));
        }
    }
}
