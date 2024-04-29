using System.Drawing;

namespace BlazorApp2.Objects
{
    public abstract class GeometricObject(ForObjects.Enums enums, Color colorObject, int xPosition, int yPosition)
    {
        public Color ColorObject { get; set; } = colorObject;
        public int XPosition { get; set; } = xPosition;
        public int YPosition { get; set; } = yPosition;
        public ForObjects.Enums Enums { get; set; } = enums;
    }
}
