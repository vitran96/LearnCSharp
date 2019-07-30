using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    /*
     * form is really the view component which will implement imodelobserver interface
     * so that, it can invoke the valueincremented function which is the implementation
     * form also implements the iview interface to send the view changed event and to
     * set the controller associated with the view
     */
    public partial class Form1 : Form, IModelObserver, IView
    {
        IController controller;
        public event ViewHandler<IView> changed;

        public Form1()
        {
            InitializeComponent();
        }

        /*
         *  view will set the associated controller, this is how view is link to the controller
         */
        public void setController(IController controller)
        {
            this.controller = controller;
        }

        /**
         * this event is implementation from imodelobserver which will be invoke by the
         * model when there is a change in the value with modeleventargs which is derived
         * from the eventargs. the imodel object is the one from which invoke this.
         */
        public void valueIncremented(IModel model, ModelEventArgs e)
        {
            textBox1.Text = "" + e.newval;
        }

        /*
         * when user clicks button just ask the controller to increment the value
         * do not worry about how and where it is done
         */
        private void Button1_Click(object sender, EventArgs e)
        {
            controller.incvalue();
        }

        // when this event is raised can mean the user must have changed the value.
        // invoke the view changed event in the contrller which will call the method
        // in imodel to set the new value, user can enter a new value and the invrementing starts
        // from that value onwards
        private void TextBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                changed.Invoke(this, new ViewEventArgs(int.Parse(textBox1.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number");
            }
        }
    }
}
