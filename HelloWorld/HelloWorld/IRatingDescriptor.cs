using System;

namespace HelloWorld
{
    public interface IRatingDescriptor
    {
        DateTimeOffset ShipDate { get; set; }
        IAddress ShipperAddress { get; set; }
        String ServiceDescription { get; set; }

    }
}