﻿using System;
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
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ContactsDataBinding
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //private List<Contact> Contacts;
        private ObservableCollection<Contact> Contacts;
        private List<Icon> Icons;
        public MainPage()
        {
            this.InitializeComponent();

            Icons = new List<Icon>();
            //Add images [icons] to list
            Icons.Add(new Icon { IconPath = "Assets/female-01.png" });
            Icons.Add(new Icon { IconPath = "Assets/female-02.png" });
            Icons.Add(new Icon { IconPath = "Assets/female-03.png" });
            Icons.Add(new Icon { IconPath = "Assets/male-01.png" });
            Icons.Add(new Icon { IconPath = "Assets/male-02.png" });
            Icons.Add(new Icon { IconPath = "Assets/male-03.png" });

            Contacts = new ObservableCollection<Contact>();
        }

        private void AddContactButton_Click(object sender, RoutedEventArgs e)
        {
            //DUH!!!
            var avatarPath = ((Icon)AvatarComboBox.SelectedValue).IconPath;
            Contacts.Add(new Contact { FirstName = FirstNameTextBox.Text, 
                LastName = String.Format($"{LastNameTextBox.Text}, "), 
                AvatarPath = avatarPath });

            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            AvatarComboBox.SelectedItem = null;
        }
    }
}
