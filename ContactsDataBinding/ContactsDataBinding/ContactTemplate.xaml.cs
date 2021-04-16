using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ContactsDataBinding.Models;


// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ContactsDataBinding
{
    public sealed partial class ContactTemplate : UserControl
    {
        //Following code should be used if you do not use ContactsDataBindings.Models
        //public Models.Contact Contact { get { return this.DataContext as Models.Contact; } }
        public Contact Contact { get { return this.DataContext as Contact; } }

        public ContactTemplate()
        {
            this.InitializeComponent();

            this.DataContextChanged += (s, e) => this.Bindings.Update();
        }
    }
}
