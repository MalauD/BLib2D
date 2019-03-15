using System;
using SFML.System;
using SFML.Graphics;
using SFML.Window;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            GLibInstance app = new GLibInstance();
            app.StartSFMLProgram();
        }
    }
    class GLibInstance
    {
        RenderWindow _window;
    
        public void StartSFMLProgram()
        {
            _window = new RenderWindow(new VideoMode(720, 720), "SFML Chess");
            _window.SetVisible(true);
            _window.Closed += new EventHandler(OnClosed);

            while (_window.IsOpen)
            {
                _window.DispatchEvents();
                
                _window.Clear(Color.Black);

                _window.Display();
            }
        }
        void OnClosed(object sender, EventArgs e)
        {
            _window.Close();
        }
    }
}
