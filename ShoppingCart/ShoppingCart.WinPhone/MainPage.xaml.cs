﻿using Microsoft.Phone.Controls;

using Xamarin.Forms;

namespace ShoppingCart.WinPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();
            Content = ShoppingCart.App.FirstPage.ConvertPageToUIElement(this);
        }
    }
}