using GLib2D.Graphics;
using SFML.Graphics;
using SFML.System;
using System.Collections.Generic;

namespace GLib2D.Graphics
{
    interface IGlibView
    {
        bool IsVisible { get; set; }
        string WindowName { get; set; }
        Color ClearColor { get; set; }

        List<GameObject> GameObjects { get; set; }

        Vector2i WindowSize { get; set; }

    }
}
