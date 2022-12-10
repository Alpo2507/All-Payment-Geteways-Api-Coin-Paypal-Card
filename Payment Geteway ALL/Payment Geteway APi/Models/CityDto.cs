namespace Ocelot.Demo.Api2.Models
{
    public class CityDto
    {
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int NumOfPointsOfInterest {
            get { return PointsOfInterest.Count; }
        }
        public ICollection<PointOfInterestDto> PointsOfInterest { get; set; } = new List<PointOfInterestDto>();
    }
}
