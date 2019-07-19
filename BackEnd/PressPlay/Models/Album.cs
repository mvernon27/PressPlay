﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressPlay.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumTitle { get; set; }
        public string ImageUrl { get; set; }
        public string RecordLabel { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual int ArtistId { get; set; }
        public virtual List<Song> Song { get; set; }

        public Album()
        {

        }

    }
}
