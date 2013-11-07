using SFML.Graphics;
using SFML.Window;

namespace Lazar_Hockey
{
    public static class Program
    {
        private static readonly Color CornflowerBlue = new Color(100, 149, 237);

        public static void Main(string[] args)
        {
            RenderWindow window = new RenderWindow(new VideoMode(1280, 720), "SFML Window");
            window.Closed += (sender, eventArgs) => window.Close();
            window.KeyPressed += new System.EventHandler<KeyEventArgs>(OnKeyPressed);
            while (window.IsOpen())
            {
                window.DispatchEvents();

                // TODO: Insert Update Code Here
               

                window.Clear(CornflowerBlue);

                // TODO: Insert Draw Code Here

                window.Display();
            }
        }

        static void OnKeyPressed(object sender, KeyEventArgs e)
        {
            Window window = (Window)sender;
                if (e.Code == Keyboard.Key.Escape)
                {
                    window.Close();
                }
        }
    }
}