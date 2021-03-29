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

namespace MADContentDialog
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

        private async void ShowContentDialogButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog contentDialog = new ContentDialog()
            {
                Content = "What is this content?",
                CornerRadius = new CornerRadius(15),
                CloseButtonText = "Close",
                PrimaryButtonText = "Save",
                SecondaryButtonText = "Forget it",

            };

            ContentDialogResult result = await contentDialog.ShowAsync();

            if(result == ContentDialogResult.Primary)
            {
                SaveToFile();
            }
            if(result == ContentDialogResult.Secondary)
            {
                ResultTextBlock.Text = "You are not sure";
            }
        }

        private void SaveToFile()
        {
            using (StreamWriter sw = new StreamWriter("file.txt"))
            {
                sw.Write("This is a file created by my program");
            };
        }
    }
}
