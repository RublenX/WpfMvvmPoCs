﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using WpfMvvmNet6.Services;

namespace WpfMvvmNet6.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        #region Propiedades Observables
        [ObservableProperty]
        private string textoPrueba = "Esto es un texto de prueba";
        #endregion

        #region Ciclo de vida
        private IWindowService _windowService;

        public MainViewModel()
        {
            _windowService = new WindowService();
        }

        public MainViewModel(IWindowService windowService)
        {
            _windowService = windowService;
        }
        #endregion

        #region Comandos
        [RelayCommand]
        private void CambiarTexto()
        {
            TextoPrueba = $"Modificado a las {DateTime.Now.ToLongTimeString()}";
        }

        [RelayCommand]
        private void OpenWindow()
        {
            _windowService.Show();
        }
        #endregion
    }
}
