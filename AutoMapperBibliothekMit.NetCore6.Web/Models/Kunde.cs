namespace AutoMapperBibliothekMit.NetCore6.Web.Models
{
    public class Kunde
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Alter { get; set; }
        public DateTime? GeburtsDatum { get; set; }
        public IList<Adresse>Adressen { get; set; }
        public Geschlecht Geschlecht { get; set; }

        //Um die folgende Methode auszuführen, müssen wir eine Get-Aktionsmethode schreiben.
        //Andernfalls funktioniert unsere Methode nicht und wird leer.
        //Wenn wir eine benutzerdefinierte Methode schreiben möchten, können wir unsere benutzerdefinierte Methode
        //in KundenProfil erstellen und die entsprechende Anfrage stellen.
        public string GetVollständigerName()
        {
            return $"{Name}-{Email}-{Alter}";
        }

        //Wenn wir eine benutzerdefinierte Methode schreiben möchten, können wir unsere benutzerdefinierte Methode
        //in KundenApiController erstellen und die entsprechende Anfrage stellen.
        //Aber es wird nicht empfohlen, weil ApiController Route deaktiviert wird.
    }
}
