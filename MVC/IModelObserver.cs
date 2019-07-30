using System;
using System.Collections.Generic;
using System.Text;

namespace MVC
{
    // tje omterface wjocj the form/view must implement so that, the event will be
    // fired when a value is changed in the model
    public interface IModelObserver
    {
        void valueIncremented(IModel model, ModelEventArgs e);
    }
}
