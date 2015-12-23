using System;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace HybridApp.Library
{
    [AllowForWeb]
    public sealed class NavigationHelper
    {
        public IAsyncOperation<string> GetUserPositionAsync()
        {
            return GetUserPosition().AsAsyncOperation();
        }

        internal async Task<string> GetUserPosition()
        {
            Geolocator locator = new Geolocator();
            Geoposition position = await locator.GetGeopositionAsync();
            double latitude = position.Coordinate.Point.Position.Latitude;
            double longitude = position.Coordinate.Point.Position.Longitude;

            return $"Latitude: {latitude}, Longitude: {longitude}";
        }
    }
}
