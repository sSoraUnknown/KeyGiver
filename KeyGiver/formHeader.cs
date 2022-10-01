using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyGiver 
{
    public class WindowEventHandler : Form
    {
        // Эти НИ В КОЕМ СЛУЧАЕ не трогать, они для header'а, а точнее - перемещения программы и её закрытия
        // START

        public WindowEventHandler()
        {

        }
        // Промежуточная переменная
        Point lastPoint;

        // Регистрация начала перемещения программы
        public new void MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        // Перемещение программы
        public new void MouseMove2(ref int x, ref int y, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
            {
                x += e.X - lastPoint.X;
                y += e.Y - lastPoint.Y;
            }
        }

        public new void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        // Кнопка (на самом деле label) закрытия программы
        public void ExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // END
    }
}
