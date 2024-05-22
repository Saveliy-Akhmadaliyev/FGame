using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FGame.Model.Blocks
{
    public class UnKnowBlock : IBlock
    {
        public Block Block { get; set; }
        public int HP { get; set; }
        public Texture2D Texture { get; set; }

        public UnKnowBlock(int hp, Texture2D texture)
        {
            HP = hp;
            Block = Block.Know;
            Texture = texture;
        }

        public UnKnowBlock(Texture2D texture) : this(0, texture) { }
    }
}
