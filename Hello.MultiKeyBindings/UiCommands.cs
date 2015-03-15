﻿using System.Windows;
using System.Windows.Input;

namespace Hello.MultiKeyBindings
{
    public static class UiCommands
    {
        public static readonly RoutedCommand TestA = new RoutedCommand("Test A", typeof(UIElement));
        public static readonly RoutedCommand TestB = new RoutedCommand("Test B", typeof(UIElement));
        public static readonly RoutedCommand TestC = new RoutedCommand("Test C", typeof(UIElement));
        public static readonly RoutedCommand TestD = new RoutedCommand("Test D", typeof(UIElement));
    }
}