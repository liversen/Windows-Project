﻿using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System;

namespace OptiLight.ViewModel
{
    public class RoundLampViewModel : LampViewModel
    {
        public RoundLampViewModel(Model.Lamp lamp) : base(lamp){ }
    }
}
