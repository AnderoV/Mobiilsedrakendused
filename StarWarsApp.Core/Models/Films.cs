using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsApp.Core.Models
{
    public partial class Films
    {
        public long Count { get; set; }
        public object Next { get; set; }
        public object Previous { get; set; }
        public List<FilmResult> Results { get; set; }
    }

    public partial class FilmResult
    {
        public string Title { get; set; }
        public long EpisodeId { get; set; }
        public string opening_crawl { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public DateTimeOffset release_date { get; set; }
        public List<Uri> Characters { get; set; }
        public List<Uri> Planets { get; set; }
        public List<Uri> Starships { get; set; }
        public List<Uri> Vehicles { get; set; }
        public List<Uri> Species { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Edited { get; set; }
        public Uri Url { get; set; }
    }
}
