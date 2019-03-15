using SFML.Graphics;
using SFML.System;

namespace Chess.Graphics
{
    interface IGlibView
    {
        bool IsVisible { get; set; }
        string WindowName { get; set; }
        Color ClearColor { get; set; }


        Vector2i WindowSize { get; set; }

    }
}
