using FGame.Model.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGame.Model.Pages
{
    public class GamePage : IPage
    {
        public Button[] Buttons { get; set; }

        public Page Page { get; set; } 
        public IBlock[] Blocks { get; set; }

        public GamePage(Page page, IBlock[] blocks, params Button[] buttons)
        {
            Page = page;
            Buttons = buttons;
            Blocks = blocks;
        }
    }
}
