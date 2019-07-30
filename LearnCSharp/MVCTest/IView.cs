using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp.MVCTest
{
    // currently the interface only contains the method to set the controller to which
    // it is tied. The rest of the view related code is implemented in the form
    public interface IView
    {
        event ViewHandler<IView> changed;
        void setController(IController controller);
    }
}
