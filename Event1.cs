using System;
using System.Windows.Forms;

namespace DelegatesAndEvents
{
    class Event1
    {
        static void Main(string[] args)
        {
            Form f = new Form();
            Button bt = new Button();
            bt.Text="Click Me";
            bt.Click += MethodButton;
            f.Controls.Add(bt);
            f.Show();
            Application.Run(f);
        }
       public static void MethodButton(object sender,EventArgs args)
        {
            Console.WriteLine("The button was Clicked");
        }
    }
}
