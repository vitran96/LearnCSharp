using System;
using System.Collections.Generic;
using System.Text;

namespace MVC
{
    class IncModel : IModel
    {
        public event ModelHandler<IncModel> changed;
        int value;
        // implement imodel, set value = 0
        public IncModel()
        {
            this.value = 0;
        }
        // attach the function which is implementing the IModelObserver so that it can be
        // notified when a value is changed
        public void attach(IModelObserver imo)
        {
            this.changed += new ModelHandler<IncModel>(imo.valueIncremented);
        }
        // change the value and fire the event with the new value inside modelevent args
        // this will invoke the function valueincremented in the model and will be displayed
        // in the texbtbox and the view change event fires in the controller
        public void increment()
        {
            value++;
            changed.Invoke(this, new ModelEventArgs(value));
        }
        // set value function to set the value in case if the user directly changes the value in the textbox
        // and the view change event fires in the controller
        public void setvalue(int v)
        {
            this.value = v;
        }
    }
}
