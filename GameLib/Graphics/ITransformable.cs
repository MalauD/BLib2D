using SFML.System;

namespace GLib2D.Graphics
{
    public interface ITransformable
    {
        Vector2f Position { get; set; }
        Vector2f Scale { get; set; }
        float Rotation { get; set; }
    }
}
