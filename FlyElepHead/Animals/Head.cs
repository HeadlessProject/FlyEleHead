using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyElepHead.Animals
{
    public class Head:Role
    {
        public MainWindow win;
        public Head(MainWindow window):base()
        {
            win = window;
            PictureBox head_box = new()
            {
                Parent = win.scenes["GamePanel"],
                Dock = DockStyle.Fill,
                Image = new Bitmap($"{Environment.CurrentDirectory}\\img\\headsingle.png"),
                Location = new Point(350,250)
            };
        }
    }
}
