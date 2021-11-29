using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Common;
using Shapes.Implementation;

namespace Shapes.Implementation
{
    public class DrawTriangleApi : DrawApi
    {
        public override void DrawShape()
        {
            Console.WriteLine("Triangle");
        }
    }
}
