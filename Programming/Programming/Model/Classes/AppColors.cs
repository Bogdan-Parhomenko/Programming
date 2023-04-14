using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class AppColors
    {
        public static Color CollisionFalseColor = Color.FromArgb(127, 127, 255, 127);

        public static Color CollisionTrueColor = Color.FromArgb(127, 255, 127, 127);

        public static Color ValidationTrueColor = Color.White;

        public static Color ValidationFalseColor = Color.LightPink;

        public static Color AutumnColor = ColorTranslator.FromHtml("#e29c45");

        public static Color SpringColor = ColorTranslator.FromHtml("#559c45");
    }
}
