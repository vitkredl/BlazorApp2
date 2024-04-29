using BlazorApp2.ForObjects;
using System.Drawing;

namespace BlazorApp2.Objects
{
    public class Ctverec:GeometricObject
    {
        public Ctverec(Enums enums, Color colorObject, int xPosition, int yPosition, int stranaA) : base(enums, colorObject, xPosition, yPosition)
        {
            StranaA = stranaA;
        }

        public int StranaA {  get; set; }
    }
}
