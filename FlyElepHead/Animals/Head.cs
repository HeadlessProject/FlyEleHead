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

        public PictureBox head_box;
        public Panel box = new();

        public Head(MainWindow window):base()
        {
            win = window;
            head_box = new()
            {
                Parent = box,
                Dock = DockStyle.Fill,
                Image = new Bitmap($"{Environment.CurrentDirectory}\\img\\headsingle.png"),
                Location = new Point(0,0),
                Width = 100,
                Height = 100,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            box.Parent = win.scenes["GamePanel"];
            box.BringToFront();
        }

        public void Move(Point point)
        {
            box.Location = point;
        }
    }
}
