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
using System.Threading.Tasks;
using Windows.Storage.Pickers;
using Windows.Storage;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_File_Folder_Pickers
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

        private async void FilePickerButton_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            openPicker.FileTypeFilter.Add(".txt");
            //Await command will prevent main thread from hanging(waiting)
            StorageFile file = await openPicker.PickSingleFileAsync();
            //However, the following code will not execute until line 40 is complete
            if(file != null)
            {
                FileTextBlock.Text = "Selected File: " + file.Path;
                ReadDataFromTxtFile(file);
            }
            else
            {
                FileTextBlock.Text = "No file selected. Try again.";
            }
        }

        private async void ReadDataFromTxtFile(StorageFile storageFile)
        {
            var text = await FileIO.ReadTextAsync(storageFile);
            OutputTextBlock.Text += text;
            //var text = await FileIO.ReadLinesAsync(storageFile);

            //foreach (string line in text)
            //{
            //    OutputTextBlock.Text += line.ToString();
            //}
        }
    }
}
