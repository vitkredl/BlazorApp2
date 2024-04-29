using BlazorApp2.ForObjects;
using System.Drawing;

namespace BlazorApp2.Objects
{
    public class Obdelnik : Ctverec
    {
        public Obdelnik(Enums enums, Color colorObject, int xPosition, int yPosition, int stranaA, int stranaB) : base(enums, colorObject, xPosition, yPosition, stranaA)
        {
            StranaB = stranaB;
        }
        public int StranaB { get; set; }
    }
}
