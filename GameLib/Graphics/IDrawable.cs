using SFML.Graphics;

namespace GLib2D.Graphics
{
    interface IDrawable : ITransformable
    {
        Drawable ObjectDraw { get;}
    }
}
