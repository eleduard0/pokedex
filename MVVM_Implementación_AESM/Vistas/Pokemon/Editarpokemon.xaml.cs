﻿using MVVM_Implementación_AESM.VistaModelo.VMpokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_Implementación_AESM.Vistas.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Editarpokemon : ContentPage
    {
        public Editarpokemon()
        {
            InitializeComponent();
            BindingContext = new VMeditarpokemon(Navigation);
        }
    }
}