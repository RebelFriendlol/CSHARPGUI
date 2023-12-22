using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace AlbertoPlayer
{
    public partial class MainWindow : Window
    {
        private Button playButton;

        public MainWindow()
        {
            InitializeComponent();

            playButton = new Button
            {
                Content = new Image
                {
                    Source = new BitmapImage(new Uri("PlayButton.png", UriKind.Relative)),
                    Width = 50, // Ustawienie szerokości obrazka (dostosuj do potrzeb)
                    Height = 50 // Ustawienie wysokości obrazka (dostosuj do potrzeb)
                }
            };

            // Dodanie obsługi zdarzenia Click
            playButton.Click += Play_Click;

            // Dodanie przycisku do MainGrid
            Grid.SetColumn(playButton, 1); // Ustawienie kolumny w MainGrid
            Grid.SetRow(playButton, 2);    // Ustawienie wiersza w MainGrid
            MainGrid.Children.Add(playButton);
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            // Zmiana obrazka na Pause po kliknięciu
            playButton.Content = new Image
            {
                Source = new BitmapImage(new Uri("/assets/pause.png",UriKind.Relative)),
                Width = 50, // Ustawienie szerokości obrazka (dostosuj do potrzeb)
                Height = 50 // Ustawienie wysokości obrazka (dostosuj do potrzeb)
            };

            // Dodanie obsługi zdarzenia Click dla Pause (opcjonalne)
            playButton.Click -= Play_Click;
            playButton.Click += Pause_Click;
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            // Zmiana obrazka na Play po kliknięciu
            playButton.Content = new Image
            {
                Source = new BitmapImage(new Uri("/assets/PlayButton.png", UriKind.Relative)),
                Width = 50, // Ustawienie szerokości obrazka (dostosuj do potrzeb)
                Height = 50 // Ustawienie wysokości obrazka (dostosuj do potrzeb)
            };

            // Dodanie obsługi zdarzenia Click dla Play (opcjonalne)
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
    }
}
