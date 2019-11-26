using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCd : Product
    {
        private readonly List<Track> tracks = new List<Track>();

        public List<Track> Tracks {
            get
            {
                return tracks;
            }
        }

        public TimeSpan PlayTime { get; }

        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }

        public MusicCd()
        {

        }
        public MusicCd(int productId, string artist, string title, decimal price, short released) : base (productId, title, price)
        {
            Artist = artist;
            Title = title;
            Price = price;
            Released = released;
        }

        public void AddTrack(Track track)
        {
            Tracks.Add(track);

        }

        public TimeSpan GetPlayTime()
        {
            TimeSpan totalTimeLength = new TimeSpan();
            foreach (Track track in tracks)
            {
                totalTimeLength += track.Length;
            }

            return totalTimeLength.Duration();
        }
    }

    
}
