﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App12_NossoChat.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mensagem : ContentPage
    {
        public Mensagem()
        {
            InitializeComponent();

            BindingContext = new ViewModel.MensagemViewModel();
        }
    }
}