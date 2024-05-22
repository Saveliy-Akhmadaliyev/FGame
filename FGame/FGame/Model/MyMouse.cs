using FGame.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FGame
{
    internal static class MyMouse
    {
        public static MouseState LastMouseState { get; set; }
        public static MouseState CurrentMouseState { get; set; }
        public static Vector2 Position { get; set; }

        public static void GetMyMousePosition()
        {
            CurrentMouseState = Mouse.GetState();

            if (CurrentMouseState.X != LastMouseState.X ||
                CurrentMouseState.Y != LastMouseState.Y)
                Position = new Vector2(CurrentMouseState.X, CurrentMouseState.Y);
            LastMouseState = CurrentMouseState;
        }

        public static bool IsPressed => CurrentMouseState.LeftButton == ButtonState.Pressed;

        public static bool WasInsideMode(Button button) =>
            Position.X < button.MainConer.X + button.XSize &&
            Position.X > button.MainConer.X &&
            Position.Y < button.MainConer.Y + button.YSize &&
            Position.Y > button.MainConer.Y;
    }
}
