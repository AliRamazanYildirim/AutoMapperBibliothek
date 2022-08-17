namespace AutoMapperBibliothekMit.NetCore6.Web.Düoe
{
    public class KundeDüo
    {
        public int Id { get; set; }
        public string VorName { get; set; }
        public string Email { get; set; }
        public int Alter { get; set; }
        public string VollständigerName { get; set; }
        //Nach AutoMapper Namenskonvention schreibt man wie unten geschriben, um nicht komplexe Code zu schreiben
        //Diese Transaktion nent man Flattening(Abflachung)
        //public string KreditKarteNummer { get; set; }
        //public DateTime KreditKarteGültigesDatum { get; set; }

        //Wenn wir Properties von KreditKarte Klasse genau hier so schreiben,
        //müssen wir nicht für  die Konvertierung extra Code schreiben.

        public string Nummer { get; set; }
        public DateTime GültigesDatum { get; set; }

    }
}
