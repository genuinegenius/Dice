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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Dice
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

        Lib library = new Lib();

        private void New_Click(object sender, RoutedEventArgs e)
        {
            DiceOne.Children.Clear();
            DiceTwo.Children.Clear();
        }

        private void DiceOne_Tapped(object sender, RoutedEventArgs e)
        {
            library.New(ref DiceOne);
        }

        private void DiceTwo_Tapped(object sender, RoutedEventArgs e)
        {
            library.New(ref DiceTwo);
        }

        private void Roll_Click(object sender, RoutedEventArgs e)
        {
            library.New(ref DiceOne);
            library.New(ref DiceTwo);
        }
    }
}
