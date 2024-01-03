﻿using AlbertoPlayer.pages;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace AlbertoPlayer
{
    public partial class MainWindow : Window
    {

        private readonly Button playButton = new Button
        {
            // Set the initial image for the playButton
            Content = new Image
            {
                Source = new BitmapImage(new Uri("/assets/PlayButton.png", UriKind.Relative)),
                Width = 50,
                Height = 50
            },

            // Set the button background to transparent
            Background = Brushes.Transparent,

            // Set the button border brush to transparent
            BorderBrush = Brushes.Transparent,

            // Set alignment properties
            HorizontalAlignment = HorizontalAlignment.Left, // Adjust as needed
            VerticalAlignment = VerticalAlignment.Top,

            // Set content alignment properties
            HorizontalContentAlignment = HorizontalAlignment.Center,
            VerticalContentAlignment = VerticalAlignment.Top,
            Margin = new Thickness(515, 15, 0, 0) // Adjust margin as needed
        };


        public MainWindow()
        {
            InitializeComponent();



            // Add a Click event handler for the playButton
            playButton.Click += Play_Click;

            // Add a MouseEnter event handler for hover effect
            playButton.MouseEnter += PlayButton_MouseEnter;

            // Add a MouseLeave event handler for hover effect
            playButton.MouseLeave += PlayButton_MouseLeave;

            // Set up the main grid
            Grid.SetColumn(playButton, 1); // Adjust column index as needed
            Grid.SetRow(playButton, 2);    // Adjust row index as needed
            MainGrid.Children.Add(playButton); // Use playButton instead of Play
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            // Toggle the image and handle the Click event accordingly
            string currentImagePath = ((Image)playButton.Content).Source.ToString();

            if (currentImagePath.Contains("PlayButton.png"))
            {
                // Change to Pause image
                ((Image)playButton.Content).Source = new BitmapImage(new Uri("/assets/pause.png", UriKind.Relative));

                // Set the button background to transparent
                playButton.Background = Brushes.Transparent;
                playButton.BorderBrush = Brushes.Transparent;

                // Add event handler for Pause
                playButton.Click -= Play_Click;
                playButton.Click += Pause_Click;
            }
            else
            {
                // Change to Play image
                ((Image)playButton.Content).Source = new BitmapImage(new Uri("/assets/PlayButton.png", UriKind.Relative));

                // Set the button background to transparent
                playButton.Background = Brushes.Transparent;
                playButton.BorderBrush = Brushes.Transparent;

                // Add event handler for Play
                playButton.Click -= Pause_Click;
                playButton.Click += Play_Click;
            }
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            // Change the image to PlayButton.png after clicking Pause
            ((Image)playButton.Content).Source = new BitmapImage(new Uri("/assets/PlayButton.png", UriKind.Relative));

            // Set the button background to transparent
            playButton.Background = Brushes.Transparent;
            playButton.BorderBrush = Brushes.Transparent;

            // Add event handler for Play
            playButton.Click -= Pause_Click;
            playButton.Click += Play_Click;
        }

        // Obsługa zdarzenia dla przycisku Previous
        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Previous clicked");
            // Tutaj dodaj kod zmieniający obrazek dla przycisku Previous
        }

        // Obsługa zdarzenia dla przycisku Repeat
        private void Repeat_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Repeat clicked");
            // Tutaj dodaj kod zmieniający obrazek dla przycisku Repeat
        }

        // Obsługa zdarzenia dla przycisku Randomize
        private void Randomize_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Randomize clicked");
            // Tutaj dodaj kod zmieniający obrazek dla przycisku Randomize
        }

        // Obsługa zdarzenia dla przycisku Forward
        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Forward clicked");
            // Tutaj dodaj kod zmieniający obrazek dla przycisku Forward
        }

        // Obsługa zdarzenia dla najechania myszą
        private void PlayButton_MouseEnter(object sender, MouseEventArgs e)
        {
            playButton.Background = Brushes.Transparent; // Set the background to transparent
            playButton.BorderBrush = Brushes.Transparent; // Set the border brush to transparent
        }

        // Obsługa zdarzenia dla opuszczenia myszy
        private void PlayButton_MouseLeave(object sender, MouseEventArgs e)
        {
            playButton.Background = Brushes.Transparent;
            playButton.BorderBrush = Brushes.Transparent;
        }

        //zmiana stron
        private void LibraryClick(object sender, RoutedEventArgs e)
        {
            Main.Content = new Library();
        }

        private void PlaylistClick(object sender, RoutedEventArgs e)
        {
            Main.Content = new Playlist();
        }

        private void SettingsClick(object sender, RoutedEventArgs e)
        {
            Main.Content = new Settings();
        }

        private void ShopClick(object sender, RoutedEventArgs e)
        {
            Main.Content = new Shop();
        }

        private void Main_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        //skróty klawiszowe


    }
}
