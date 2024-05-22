using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGame.Model.Pages
{
    public interface IPage
    {
        public Button[] Buttons { get; }
        public Page Page { get; }

    }
}
