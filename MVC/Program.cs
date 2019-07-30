using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            // create view, model, controller obj
            // create a controller obj with the concreate implementation inccontroller
            // and pass the view and model
            // controller will store its associated model and view inside the constructor
            // view which is inside the form will tie the controller automatically
            // run the view obj created by you which is infact the form
            Form1 view = new Form1();
            IModel model = new IncModel();
            IController controller = new IncController(view, model);
            Application.Run(view);
        }
    }
}
