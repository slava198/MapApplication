using GMap.NET;
using System;

namespace MapApplication.Entities
{
    public class Departmen
    {
        public int id { get; set; }
        public string bankName { get; set; }
        public string address { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }


        public override string ToString()
        {
            return String.Format($"{bankName}[{id}]"); 
        }


        public PointLatLng GetPosition()
        {
            return new PointLatLng(latitude, longitude);
        }

    }
}
