using System;
using System.Collections.Generic;
using System.Text;

namespace MVC
{
    public class IncController : IController
    {
        IView view;
        IModel model;
        // The controller which implements the Icontroller interface ties the view and model
        // together and attaches the view viea the Imodelinterface and addes the event
        // handler to the view_changed function. The view ties the controller to itself
        public IncController(IView view, IModel model)
        {
            this.view = view;
            this.model = model;
            view.setController(this);
            model.attach((IModelObserver)this.view);
            view.changed += new ViewHandler<IView>(this.view_changed);
        }
        // event which get fired from the view when the users changes the value
        public void view_changed(IView view, ViewEventArgs e)
        {
            model.setvalue(e.value);
        }
        public void incvalue()
        {
            model.increment();
        }
    }
}
