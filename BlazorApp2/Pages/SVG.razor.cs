using BlazorApp2.Objects;
using System.Drawing;

namespace BlazorApp2.Pages
{
    public partial class SVG
    {
        public int SvgWIdth { get; set; } = 1600;
        public int SvgHeight { get; set; } = 800;
        private Random random = new();
        public int Min {get; set; } = 20;
        public int Max { get; set; } = 100;
        public int NumberTypeObject => Enum.GetNames(typeof(ForObjects.Enums)).Length;
        public List<GeometricObject> SvgObjectList {  get; set; } = new List<GeometricObject>();
        int stranaA;
        int xPosition;
        int yPosition;
        private void AddObject(Microsoft.AspNetCore.Components.Web.MouseEventArgs e)
        {
            ForObjects.Enums Type;
            Type = (ForObjects.Enums)random.Next(3);
            Color barva = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            GeometricObject newObject = null;
            switch (Type)
            {
                case ForObjects.Enums.ctverec:
                    int stranaA = random.Next(Min, Max);
                    int xPosition = random.Next(SvgWIdth - stranaA);
                    int yPosition = random.Next(SvgHeight - stranaA);
                    newObject = new Ctverec(Type, barva, xPosition, yPosition, stranaA);
                    break;
                case ForObjects.Enums.obdelnik:
                    stranaA = random.Next(Min, Max);
                    var stranaB = random.Next(Min, Max);
                    xPosition = random.Next(SvgWIdth - stranaA);
                    yPosition = random.Next(SvgHeight - stranaA);
                    newObject = new Obdelnik(Type, barva, xPosition, yPosition, stranaA, stranaB);
                    break;
                case ForObjects.Enums.kruh:
                    stranaA = random.Next(Min, Max);
                    xPosition = random.Next(SvgWIdth - stranaA);
                    yPosition = random.Next(SvgHeight - stranaA);
                    newObject = new Kruh(Type, barva, xPosition, yPosition, polomer:stranaA);
                    break;


            }
            if (newObject != null)
            {
                SvgObjectList.Add(newObject);
            }
        }
    }
}
