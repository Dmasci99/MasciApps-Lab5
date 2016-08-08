using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasciApps_Lab5.Models
{
    public class Song
    {
        public virtual int SongId { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Duration { get; set; }
    }
}