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
using FinalWeather.ViewModel;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FinalWeather
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel MainPageViewModel = new MainPageViewModel();
        public MainPage()
        {
            InitializeComponent();
            DataContext = MainPageViewModel;
        }
        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            Loaded -= OnLoaded;
            RefreshContainer.RefreshRequested += RefreshContainer_RefreshRequested;
            RefreshContainer.Visualizer.RefreshStateChanged += Visualizer_RefreshStateChanged;

            // Add some initial content to the list.
            await MainPageViewModel.Refresh();
        }

        private async void RefreshContainer_RefreshRequested(RefreshContainer sender, RefreshRequestedEventArgs args)
        {
            // Respond to a request by performing a refresh and using the deferral object.
            using (var RefreshCompletionDeferral = args.GetDeferral())
            {
                // Do some async operation to refresh the content

                await MainPageViewModel.Refresh();

                // The 'using' statement ensures the deferral is marked as complete.
                // Otherwise, you'd call
                // RefreshCompletionDeferral.Complete();
                // RefreshCompletionDeferral.Dispose();
            }
        }
        
        private void Visualizer_RefreshStateChanged(RefreshVisualizer sender, RefreshStateChangedEventArgs args)
        {
            // Respond to visualizer state changes.
            // Disable the refresh button if the visualizer is refreshing.
            if (args.NewState == RefreshVisualizerState.Refreshing)
            {
                RefreshButton.IsEnabled = false;
            }
            else
            {
                RefreshButton.IsEnabled = true;
            }
        }

        private void RefreshButtonClick(object sender, RoutedEventArgs e)
        {
            RefreshContainer.RequestRefresh();
        }
    }
}
