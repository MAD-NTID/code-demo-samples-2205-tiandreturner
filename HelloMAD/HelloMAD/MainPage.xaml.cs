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

namespace HelloMAD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        TextBlock myTextBlock;
        TextBox myTextBox;
        Button myButton;

        public MainPage()
        {
            this.InitializeComponent();
            StackPanel panel = new StackPanel()
            {
                HorizontalAlignment = HorizontalAlignment.Center,
                Width = 500,
                Height = 500,
                VerticalAlignment = VerticalAlignment.Center,
                Orientation = Orientation.Vertical,
            };
            myTextBox = new TextBox()
            {
                PlaceholderText = "Type something here",
                Width = 500
            };
            myTextBox.TextChanged += MyTextBox_TextChanged;
            myTextBox.TextChanged += MyButton_Click;
            panel.Children.Add(myTextBox);

            myButton = new Button()
            {
                Content = "Click Me!",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Bottom
                
            };
            //myButton.Click += MyButton_Click1;
            myButton.Click += MyButton_Click;
            
            panel.Children.Add(myButton);
            
            myTextBlock = new TextBlock()
            {
                Text = "Hey all, this is fun stuff!!",
                VerticalAlignment = VerticalAlignment.Top,
                HorizontalAlignment = HorizontalAlignment.Right               
            };
            panel.Children.Add(myTextBlock);

            this.Content = panel;
        }

        private void MyTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            myTextBlock.Text = myTextBox.Text;
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender is object b)
            {
                myTextBox.Text = "";
                myTextBox.Focus(FocusState.Keyboard);
            }
        }
    }
}
