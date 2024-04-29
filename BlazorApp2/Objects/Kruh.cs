using BlazorApp2.ForObjects;
using System.Drawing;

namespace BlazorApp2.Objects
{
    public class Kruh : GeometricObject
    {
        public Kruh(Enums enums, Color colorObject, int xPosition, int yPosition, int polomer) : base(enums, colorObject, xPosition, yPosition)
        {
            Polomer = polomer;
        }
        public int Polomer { get; set; }
    }
}
