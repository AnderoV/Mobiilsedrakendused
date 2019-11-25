using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsApp.Core.Models
{
    public partial class Starships
    {
        public long Count { get; set; }
        public Uri Next { get; set; }
        public object Previous { get; set; }
        public List<ResultStarships> Results { get; set; }
    }

    public partial class ResultStarships
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string CostInCredits { get; set; }
        public string Length { get; set; }
        public string MaxAtmospheringSpeed { get; set; }
        public long Crew { get; set; }
        public long Passengers { get; set; }
        public string CargoCapacity { get; set; }
        public string Consumables { get; set; }
        public string HyperdriveRating { get; set; }
        public long Mglt { get; set; }
        public string StarshipClass { get; set; }
        public List<Uri> Pilots { get; set; }
        public List<Uri> Films { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Edited { get; set; }
        public Uri Url { get; set; }
    }

}
