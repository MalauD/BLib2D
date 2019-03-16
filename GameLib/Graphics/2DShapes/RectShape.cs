using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;

namespace GLib2D.Graphics.Shapes
{
    public class RectangleShape2D : Shape2D, IRectShape
    {
        public RectangleShape RectShape { get; set; }
        public override Shape GShape { get => RectShape; protected set => throw new NotImplementedException(); }

        public Vector2f Size { get => RectShape.Size; set => RectShape.Size = value; }
        public new Vector2f Position { get => RectShape.Origin; set => RectShape.Origin = value; }

        public RectangleShape2D(Vector2f origin,Vector2f size)
        {
            RectShape = new RectangleShape(size);
            Position = origin;
        }
    }
}
