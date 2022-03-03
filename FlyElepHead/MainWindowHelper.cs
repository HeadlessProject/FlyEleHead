using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace FlyElepHead
{
    public class MainWindowHelper
    {
        private MainWindow win;

        public MainWindowHelper(MainWindow window)
        {
            win = window;
        }

        /// <summary>
        /// 交换界面
        /// </summary>
        /// <param name="src">源界面</param>
        /// <param name="newpanel">目标界面</param>
        public void SwapPanel(string src, string newpanel)
        {
            win.scenes[src].Parent = null;
            win.scenes[newpanel].Parent = win;
        }

        /// <summary>
        /// 淡出
        /// </summary>
        public void FadeOut()
        {
            int i = 1;
            Timer ti = new()
            {
                Interval = 10,
            };
            ti.Tick += (_, _) =>
            {
                win.Opacity -= 0.05;
                i++;
                if(i == 20) ti.Stop();
            };
            ti.Start();
        }

        /// <summary>
        /// 淡入
        /// </summary>
        public void FadeIn()
        {
            int i = 1;
            Timer ti = new()
            {
                Interval = 10,
            };
            ti.Tick += (_, _) =>
            {
                win.Opacity += 0.05;
                i++;
                if (i == 20) ti.Stop();
            };
            ti.Start();
        }

        /// <summary>
        /// 淡入淡出
        /// </summary>
        public void FadeOutIn()
        {
            FadeOut();
            bool used = false;
            Timer ti = new()
            {
                Interval = 200
            };
            ti.Tick += (_, _) =>
            {
                if (used) ti.Stop();
                FadeIn();
                used = true;
            };
            ti.Start();
        }

        /// <summary>
        /// 淡出, 淡入, 并交换界面
        /// </summary>
        /// <param name="src">源界面</param>
        /// <param name="target">目标界面</param>
        public void FadeOutIn(string src, string target)
        {
            FadeOut();
            bool used = false;
            Timer ti = new()
            {
                Interval = 200
            };
            ti.Tick += (_, _) =>
            {
                if (used) ti.Stop();
                SwapPanel(src, target);
                FadeIn();
                used = true;
            };
            ti.Start();
        }
    }
}
