using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp.MVCTest
{
    public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);
    // the model event args class which is derived from the event args class to
    // be passed on to the controller when the value is changed
    public class ModelEventArgs : EventArgs
    {
        public int newval;
        public ModelEventArgs(int v)
        {
            newval = v;
        }
    }
}
