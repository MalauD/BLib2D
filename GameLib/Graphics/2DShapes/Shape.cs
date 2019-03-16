using System;
using SFML.Graphics;
using SFML.System;

namespace GLib2D.Graphics.Shapes
{
    public abstract class Shape2D : IShape , IDrawable
    {
        public abstract Shape GShape { get; protected set; }
        public Drawable ObjectDraw { get => GShape;}
        public Vector2f Position { get; set; }
        public float Rotation { get; set; }
        public Vector2f Scale { get; set; }
    }
}
