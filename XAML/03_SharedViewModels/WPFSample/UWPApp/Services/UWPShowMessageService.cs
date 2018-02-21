﻿using DISampleViewModels.Services;
using System;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace UWPApp.Services
{
    public class UWPShowMessageService : IShowMessageService
    {
        public async Task ShowMessageAsync(string message) => await new MessageDialog(message).ShowAsync();
    }
}
