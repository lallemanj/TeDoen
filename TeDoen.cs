using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeDoen
{
    internal class TeDoen
    {

        public int Id {  get; set; }

        public DateTime? Tijdstip {  get; set; }

        public string Titel {  get; set; }

        public string[] Informatie {  get; set; }


        static public int Volgnummer
        {
            get
            {
                _Volgnummer++;
                return _Volgnummer;
            }
            set { _Volgnummer = value; }
        }
        static private int _Volgnummer = 0;

        public TeDoen(DateTime tijdstip, string titel, string[] informatie)
        {
            _Volgnummer++;
            Id = _Volgnummer;
            if (tijdstip >= DateTime.Now)
            {
                Tijdstip = tijdstip;

            }
            else
            {
                Tijdstip = null;
            }
            Titel = titel;
            Informatie = informatie;
        }

        public TeDoen(string titel, string[] informatie)
        {
            _Volgnummer++;
            Id = _Volgnummer;
            Titel = titel;
            Informatie = informatie;
        }

        public override string ToString()
        {
            string info = "";

            foreach (string s in Informatie)
            {
                info += s.ToString() + "\b";

            }

            if (Tijdstip == null)
            {
                return "Id: " + Id + " , Titel " + Titel + " , informatie" + info;

            }
            else
            {
                return "Id: " + Id + " , DateTime " + Tijdstip + " , titel " + Titel + " , informatie" + info;

            }
        }
    }
}
