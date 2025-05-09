using System;
using System.Linq;
using System.Collections.Generic;
using NDO;

namespace PersistenteKlassen
{
    /// <summary>
    /// Summary for Mitarbeiter
    /// </summary>
    [NDOPersistent]
    public partial class Mitarbeiter
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public Mitarbeiter()
        {
        }
    }
}
