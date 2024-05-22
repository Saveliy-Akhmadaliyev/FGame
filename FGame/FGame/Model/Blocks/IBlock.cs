using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FGame.Model.Blocks
{
    public interface IBlock
    {
        public Block Block { get; set; }
        public int HP { get; set; }
        public Texture2D Texture { get; set; }
    }
}
