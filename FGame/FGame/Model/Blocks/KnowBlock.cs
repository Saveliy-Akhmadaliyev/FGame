using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FGame.Model.Blocks
{
    public class KnowBlock : IBlock
    {
        public Block Block { get; set; }
        public int HP { get; set; }
        public Texture2D Texture { get; set; }

        public KnowBlock(int hp, Texture2D texture)
        {
            HP = hp;
            Block = Block.Know;
            Texture = texture;
        }

        public KnowBlock(Texture2D texture) : this(0, texture) { }
    }
}
