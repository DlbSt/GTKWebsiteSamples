using FormsGtkToolkit.Controls;
using FormsGtkToolkit.Controls.GTK.Renderers;
using Prism;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace GTKWebsiteSamples.GTK
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init(new List<Assembly>
            {
                typeof(GridSplitter).Assembly,
                typeof(GridSplitterRenderer).Assembly
            });

            var app = new App(new GtkInitializer());
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("GTK# Website Samples");
            window.Show();

            Gtk.Application.Run();
        }

        public class GtkInitializer : IPlatformInitializer
        {
            public void RegisterTypes(IContainerRegistry containerRegistry)
            {
                // Register any platform specific implementations
            }
        }
    }
}
