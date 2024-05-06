using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MyInfo
    {
        private string name;

        public event EventHandler NameChanged;

        public MyInfo(string initialName)
        {
            name = initialName;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnNameChanged(EventArgs.Empty);
                }
            }
        }

        protected virtual void OnNameChanged(EventArgs e)
        {
            NameChanged?.Invoke(this, e);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyInfo info = new MyInfo("Егор");

            info.NameChanged += Info_NameChanged;

            info.Name = "Новое имя";

            Console.ReadKey();
        }

        static void Info_NameChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Значение поля name изменилось!");
        }
    }
}
