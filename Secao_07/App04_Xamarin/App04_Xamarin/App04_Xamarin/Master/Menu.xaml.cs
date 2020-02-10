﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App04_Xamarin.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void GoPaginaPerfil1(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Pages.Perfil1());
        }

        private void GoPaginaXamarin(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Pages.Xamarin());
        }
    }
}