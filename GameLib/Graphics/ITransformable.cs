using SFML.System;

namespace GLib2D.Graphics
{
    interface ITransformable
    {
        Vector2f Position { get; set; }
        Vector2f Rotation { get; set; }
        Vector2f Scale { get; set; }
    }
}
