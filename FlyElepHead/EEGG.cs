using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyElepHead
{
    public class EEGG
    {
        Form target;

        public EEGG(Form target)
        {
            this.target = target;
        }

        Queue<int> keys = new();

        public void EEGGRegister(string book, Action action)
        {
            target.KeyDown += (_, e) =>
            {
                if (keys.Count >= book.Length)
                {
                    keys.Dequeue();
                    keys.Enqueue(e.KeyValue);
                }
                else keys.Enqueue(e.KeyValue);
                if (keys.Count == book.Length)
                {
                    bool pass = true;
                    int index = 0;
                    foreach (int key in keys)
                    {
                        if (key != book[index])
                        {
                            pass = false;
                            break;
                        }
                        ++index;
                    }
                    if (pass) action.Invoke();
                }
            };
        }
    }
}
