using SFML.Graphics;

namespace GLib2D.Graphics
{
    public interface IDrawable : ITransformable
    {
        Drawable ObjectDraw { get;}
    }
}
