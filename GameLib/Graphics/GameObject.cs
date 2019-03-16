using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;

namespace GLib2D.Graphics
{
    public abstract class GameObject : DrawableCollection, ITransformable
    {
        public Vector2f Position { get; set; }
        public float Rotation { get; set; }
        public Vector2f Scale { get; set; }
        
        public abstract void Update();
    }
}
