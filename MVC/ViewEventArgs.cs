using System;
using System.Collections.Generic;
using System.Text;

namespace MVC
{
    // WTF is this shit?
    public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);
    // The event arg class that will be used while firing the events
    // for this program, we have only one value which the user changed.
    public class ViewEventArgs: EventArgs
    {
        public int value;
        public ViewEventArgs(int value)
        {
            this.value = value;
        }
    }
}
