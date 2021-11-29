using Shapes.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Implementation
{
    public class DrawArrowApi : DrawApi
    {
        public override void DrawShape()
        {
            Console.WriteLine("--->");
        }
    }
}
