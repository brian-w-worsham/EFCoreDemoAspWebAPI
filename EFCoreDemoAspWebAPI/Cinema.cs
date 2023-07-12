using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace EFCoreDemoAspWebAPI
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Precision(precision: 9, scale: 3)]
        public decimal Price { get; set; }

        public Point Localtion {  get; set; }
    }
}
