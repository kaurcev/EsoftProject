using EsoftProject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsoftProject
{
    class UIComp
    {
        public static Color Gray = Color.FromArgb(207, 216, 220);

        public static Color Mini = Color.FromArgb(205, 214, 219);
        public static Color Green = Color.FromArgb(0, 191, 165);
        public static Color Red = Color.FromArgb(255, 23, 68);
        public static bool textcheck(string text)
        {
            string azx = text.Trim();
            if (azx == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void alerts(string msg, alerts.enmType type)
        {
            alerts frm = new alerts();
            frm.showAlert(msg, type);
        }
        public static GraphicsPath RoundedRect(Rectangle baseRect, int radius)
        {
            var diameter = radius * 2;
            var sz = new Size(diameter, diameter);
            var arc = new Rectangle(baseRect.Location, sz);
            var path = new GraphicsPath();

            // Верхний левый угол
            path.AddArc(arc, 180, 90);

            // Верхний правый угол
            arc.X = baseRect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Нижний правый угол
            arc.Y = baseRect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Нижний левый угол
            arc.X = baseRect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}

