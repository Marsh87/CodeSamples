using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCDesignPattern
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*https://www.c-sharpcorner.com/article/introduction-to-model-view-control-mvc-pattern-using-C-Sharp/

            The Model View Controller (MVC) design pattern specifies that an application consist of a data model, presentation information, and control information. 
            The pattern requires that each of these be separated into different objects.MVC is more of an architectural pattern, but not for complete application. 
            MVC mostly relates to the UI / interaction layer of an application. You’re still going to need business logic layer, maybe some service layer and data access layer.
            The Model contains only the pure application data, it contains no logic describing how to present the data to a user.
            The View presents the model’s data to the user. The view knows how to access the model’s data, but it does not know what this data means or what the user can do to manipulate it.
            The Controller exists between the view and the model. It listens to events triggered by the view (or another external source) and executes the appropriate reaction to these events.
            In most cases, the reaction is to call a method on the model. Since the view and the model are connected through a notification mechanism, the result of this action is then automatically reflected in the view.

            The benefits of using the Model-View-Control (MVC) pattern in our development projects is that we can completely decouple our business and presentation application layers. 
            Furthermore, we will have a completely independent object to control the presentation layer. 
            The independence between the objects/layers in our project that the MVC provides will make maintenance somewhat easier and code reuse very easy (as you'll see below).
            As a general practice we know we want to keep the object dependencies in our projects to a minimum so changes are easy and we can reuse the code we've worked so hard on. 
            To accomplish this we will follow a general principle of "programming to the interface, not the class" using the MVC pattern.
            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AutoView());
        }
    }
}
