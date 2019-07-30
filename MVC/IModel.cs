using System;
using System.Collections.Generic;
using System.Text;

namespace MVC
{
    // model interface where we can attach the function to be notified when value
    // is changed. An actual data manipulation function increment which increments the value
    // A setvalue function which sets the value when users changes the textbox
    public interface IModel
    {
        void attach(IModelObserver imo);
        void increment();
        void setvalue(int v);
    }
}
