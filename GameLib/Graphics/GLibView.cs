using System;
using System.Collections.Generic;
using GLib2D.Graphics;
using GLib2D.Graphics.Shapes;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace GLib2D.Graphics
{
    public class GLibView : IGlibView
    {
        public bool IsVisible { get ; set ; }
        public string WindowName { get ; set ; }
        public Vector2i WindowSize { get ; set ; }
        public Color ClearColor { get; set; }

        private RenderWindow RenderWindow { get; set; }
        public List<GameObject> GameObjects { get; set; }

        #region Constructors

        public GLibView(Vector2i windowSize)
        {
            WindowSize = windowSize;
            WindowName = "GLibView";
            IsVisible = true;
            GameObjects = new List<GameObject>();
        }

        public GLibView(string windowName, Vector2i windowSize)
        {
            WindowName = windowName;
            WindowSize = windowSize;
            IsVisible = true;
            GameObjects = new List<GameObject>();
        }

        public GLibView(bool isVisible, string windowName, Vector2i windowSize)
        {
            IsVisible = isVisible;
            WindowName = windowName;
            WindowSize = windowSize;
            GameObjects = new List<GameObject>();
        }

        #endregion
        

        public void Start(Color clearColor)
        {
            RenderWindow = new RenderWindow(new VideoMode((uint)WindowSize.X,(uint)WindowSize.X),WindowName);
            ClearColor = clearColor;

            RenderWindow.SetVisible(IsVisible);

            while (RenderWindow.IsOpen)
            {
                RenderWindow.DispatchEvents();
                

                RenderWindow.Clear(ClearColor);

                DrawGameObjects();
                RenderWindow.Display();
            }
        }

        private void DrawGameObjects()
        {
            for (int i = 0; i < GameObjects.Count; i++)
            {
                GameObjects[i].Update();
                foreach (var Go in GameObjects[i])
                {
                    var g = Go;
                    g.base.Position =   GameObjects[i].Position;
                    RenderWindow.Draw(g.ObjectDraw);
                    Console.WriteLine(g.Position.X);
                }
                   
            }
        }

        public void AddGameObject(GameObject go) => GameObjects.Add(go);
    }
}
