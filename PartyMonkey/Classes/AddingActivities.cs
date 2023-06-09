using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyMonkey.Classes
{
    internal class AddingActivities
    {
        private string _title;
        private TimeSpan _time;
        private string _jury;

        public AddingActivities(string Title, TimeSpan Time, string Jury) 
        { 
            this._title = Title;
            this._time = Time;
            this._jury = Jury;
        }
    }
}
