using System;
using SFML.Graphics;
using SFML.System;

namespace GLib2D.Graphics.Shapes
{
    public interface IRectShape
    {
        RectangleShape RectShape { get; set; }
        Vector2f Size { get; set; }
    }
}
