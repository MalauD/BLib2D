using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;

namespace GLib2D.Graphics
{
    public abstract class GameObject : ITransformable, IDrawable
    {
        public Vector2f Position { get ; set ; }
        public Vector2f Rotation { get ; set ; }
        public Vector2f Scale { get ; set ; }

        public Drawable ObjectDraw { get ; set ; }

        public abstract void Start();
        public abstract void Update();
    }
}
