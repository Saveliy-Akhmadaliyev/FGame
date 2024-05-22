using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGame.Model.Pages
{
    public class MainPage : IPage
    {
        public Button[] Buttons { get; set; }

        public Page Page { get; set; }

        public MainPage(Page page, params Button[] buttons) 
        {
            Page = page;
            Buttons = buttons;
        }
    }
}
