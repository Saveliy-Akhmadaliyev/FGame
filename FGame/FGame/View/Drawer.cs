using FGame.Model.Pages;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;

namespace FGame.View
{
    public static class Drawer
    {
        public static void DrawButton(SpriteBatch spriteBatch, IPage page) 
        {
            if (page.Buttons.Any())
                foreach(var button in page.Buttons)
                    spriteBatch.Draw(button.ButtonTexture, button.MainConer, null, Color.White, 0, Vector2.Zero, 
                        1f, SpriteEffects.None, 1);
        }

        public static void DrawBlock(SpriteBatch spriteBatch, IPage page)
        {
            if (page.Page == Page.Game)
            {
                var gamePage = (GamePage) page;
                for(var i = 0; i < 85; i++)
                {
                    for (var j = 0; j < 48; j++)
                    {
                        spriteBatch.Draw(gamePage.Blocks[0].Texture, new Vector2(16 * i, 16 * j), null, Color.White, 0,
                            Vector2.Zero, 1f, SpriteEffects.None, 0.25f);
                    }
                }
            }
        }
    }
}
