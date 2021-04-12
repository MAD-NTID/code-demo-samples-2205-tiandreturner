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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace VisualStateManagerBlendApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ClickThisButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageTextBlock.Visibility == Visibility.Collapsed)
                MessageTextBlock.Visibility = Visibility.Visible;
            else
                MessageTextBlock.Visibility = Visibility.Collapsed;
        }

        private void TypeInTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TypeInTextBox.Text.Length > 0)
                if(TypeInTextBox.Text == "Please")
                    ClickThisButton.IsEnabled = true;
            else
                ClickThisButton.IsEnabled = false;
        }
    }
}
