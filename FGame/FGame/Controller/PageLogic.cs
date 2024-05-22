using FGame.Model.Pages;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGame.Controller
{
    public class PageLogic
    {
        public static IPage ChoosePage(IPage myPage, IPage[] pages)
        {
            var resultPage = Page.None;
            foreach (var button in myPage.Buttons)
                if (button.IsButtonClick()) 
                    resultPage = button.NextPage;

            if (resultPage == Page.None) 
                return myPage;
            else 
                return pages[(int)resultPage - 1];
        }
    }
}
