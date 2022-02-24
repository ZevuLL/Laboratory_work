using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    struct owner
    {
       public string fio;
       public string number;
       public string mark;
       public string serial;
       public string registration;
        public owner(string fio_,string number_, string mark_, string serial_, string registration_)
        {
            fio = fio_;
            number = number_;
            mark = mark_;
            serial = serial_;
            registration = registration_;
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
