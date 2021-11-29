using Shapes.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    public abstract class Shape
    {
        protected DrawApi drawAPI;

        protected Shape(DrawApi drawAPI)
        {
            this.drawAPI = drawAPI;
        }
        public void Draw()
        {
            drawAPI.DrawShape();
        }
    }
}
