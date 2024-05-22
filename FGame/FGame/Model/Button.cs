using FGame.Model.Pages;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Page = FGame.Model.Pages.Page;

namespace FGame.Model
{
    public class Button
    {
        public Texture2D ButtonTexture { get; set; }
        public Vector2 MainConer { get; set; }
        public float XSize { get; set; }
        public float YSize { get; set; }
        public Page NextPage { get; set; }
         
        public bool IsButtonClick()
        {
            return MyMouse.IsPressed && MyMouse.WasInsideMode(this);
        }

        public Button(Texture2D buttonTexture, Vector2 mainConer, float xSize, float ySize, Page nextPage)
        {
            ButtonTexture = buttonTexture;
            MainConer = mainConer;
            XSize = xSize;
            YSize = ySize; 
            NextPage = nextPage;
        }
    }
}
