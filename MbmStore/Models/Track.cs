﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Track
    {
        public int TrackId { get; internal set; }
        public string Title { get; set; }
        public string Composer { get; set; }
        public TimeSpan Length { get; set; }
        public int ProductId { get; set; }
        public virtual MusicCd MusicCd { get; set; }

        public Track()
        {

        }

        public Track(string title, string composer, TimeSpan length)
        {
            Title = title;
            Composer = composer;
            Length = length;
        }

    }
}
