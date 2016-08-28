using System.Device.Location;

namespace HelloWorld
{
    public interface IAddress
    {
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string City { get; set; }
        string State { get; set;  }
        string Province { get; set; }
        string PostalCode { get; set; }
        GeoCoordinate geoCode { get; set; }

    }
}