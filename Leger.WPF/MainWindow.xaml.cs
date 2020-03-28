using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Leger.LIB.Entities;

namespace Leger.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Generaal generaal = new Generaal();
            lstGeneraal.Items.Add(generaal);
            generaal = new Generaal();
            lstGeneraal.Items.Add(generaal);


            lblSoortOndergeschikten.Content = "";
            int totaalAantalMilitairen = 0;
            foreach (KeyValuePair<string, int> item in Militair.aantalPersoort)
            {
                lblSoortOndergeschikten.Content += $"{item.Key} : \t{item.Value}\n";
                totaalAantalMilitairen += item.Value;
            }
            lblSoortOndergeschikten.Content += $"Totaal : \t{totaalAantalMilitairen}\n";

        }

        private void ToonDetails(Militair militair)
        {
            lblNaam.Content = militair.Naam;
            lblGraad.Content = militair.GetType().Name;
            string sterren = "";
            for (int r = 1; r <= militair.Sterren; r++)
                sterren += "Þ";
            lblSterren.Content = sterren;
            if (militair.Kleur == "Goud")
                lblSterren.Foreground = Brushes.Gold;
            else if (militair.Kleur == "Zilver")
                lblSterren.Foreground = Brushes.Silver;
            else
                lblSterren.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#CD7F32"));
            lblTotaalOndergeschikten.Content = militair.TotaalAantalOndergeschikten();


        }

        private void lstGeneraal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstMajoors.ItemsSource = null;
            lstLuitenanten.ItemsSource = null;
            lstAdjudanten.ItemsSource = null;
            lstSergeanten.ItemsSource = null;
            lstKorporaals.ItemsSource = null;
            lstSoldaten.ItemsSource = null;
            if (lstGeneraal.SelectedItem == null) return;
            Generaal generaal = (Generaal)lstGeneraal.SelectedItem;
            ToonDetails(generaal);
            lstMajoors.ItemsSource = generaal.RechtstreeksOndergeschikte;

        }

        private void lstMajoors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstLuitenanten.ItemsSource = null;
            lstAdjudanten.ItemsSource = null;
            lstSergeanten.ItemsSource = null;
            lstKorporaals.ItemsSource = null;
            lstSoldaten.ItemsSource = null;
            if (lstMajoors.SelectedItem == null) return;
            Majoor majoor = (Majoor)lstMajoors.SelectedItem;
            ToonDetails(majoor);
            lstLuitenanten.ItemsSource = majoor.RechtstreeksOndergeschikte;
        }

        private void lstLuitenanten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstAdjudanten.ItemsSource = null;
            lstSergeanten.ItemsSource = null;
            lstKorporaals.ItemsSource = null;
            lstSoldaten.ItemsSource = null;
            if (lstLuitenanten.SelectedItem == null) return;
            Luitenant luitenant = (Luitenant)lstLuitenanten.SelectedItem;
            ToonDetails(luitenant);
            lstAdjudanten.ItemsSource = luitenant.RechtstreeksOndergeschikte;

        }

        private void lstAdjudanten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstSergeanten.ItemsSource = null;
            lstKorporaals.ItemsSource = null;
            lstSoldaten.ItemsSource = null;
            if (lstAdjudanten.SelectedItem == null) return;
            Adjudant adjudant = (Adjudant)lstAdjudanten.SelectedItem;
            ToonDetails(adjudant);
            lstSergeanten.ItemsSource = adjudant.RechtstreeksOndergeschikte;

        }

        private void lstSergeanten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstKorporaals.ItemsSource = null;
            lstSoldaten.ItemsSource = null;
            if (lstSergeanten.SelectedItem == null) return;
            Sergeant sergeant = (Sergeant)lstSergeanten.SelectedItem;
            ToonDetails(sergeant);
            lstKorporaals.ItemsSource = sergeant.RechtstreeksOndergeschikte;

        }

        private void lstKorporaals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstSoldaten.ItemsSource = null;
            if (lstKorporaals.SelectedItem == null) return;
            Korporaal korporaal = (Korporaal)lstKorporaals.SelectedItem;
            ToonDetails(korporaal);
            lstSoldaten.ItemsSource = korporaal.RechtstreeksOndergeschikte;

        }

        private void lstSoldaten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstSoldaten.SelectedItem == null) return;
            Soldaat soldaat = (Soldaat)lstSoldaten.SelectedItem;

            ToonDetails(soldaat);

        }


    }
}
