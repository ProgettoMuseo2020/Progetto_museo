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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Progetto_museo
{
    /// <summary>
    /// Logica di interazione per opzione2.xaml
    /// </summary>
    public partial class opzione2 : Window
    {
        public opzione2()
        {
            InitializeComponent();
			Rbn_duchidiurbino.IsChecked = false;
			Rbn_nascitadivenre.IsChecked = false;
			Rbn_primavera.IsChecked = false;
			
        }

		private void Btn_prova_Click(object sender, RoutedEventArgs e)
		{
			if (Rbn_duchidiurbino.IsChecked == true)
			{
				OPERE opera = new OPERE();
				string path = @"duchi_di_urbino.xml";
				XDocument xmlDoc = XDocument.Load(path);
				XElement xmlmuseo = xmlDoc.Element("museo");
				var xmlopere = xmlmuseo.Elements("opere");
				foreach (var item in xmlopere)
				{
					XElement xmlFirstname = item.Element("nome");
					XElement xmlData = item.Element("data");
					XElement xmlAutore = item.Element("autore");
					XElement xmlPosizione = item.Element("posizione");
					OPERE a = new OPERE();
					a.Nome = xmlFirstname.Value;
					a.data_di_pubblicazione = Convert.ToDateTime(xmlData.Value);
					a.Autore = xmlAutore.Value;
					a.Posizione = xmlPosizione.Value;
					opera = a;
					Dispatcher.Invoke(() => Lst_prova.Items.Add(opera));
				}

			}
			else if (Rbn_primavera.IsChecked == true)
			{
				OPERE opera = new OPERE();
				string path = @"primavera.xml";
				XDocument xmlDoc = XDocument.Load(path);
				XElement xmlmuseo = xmlDoc.Element("museo");
				var xmlopere = xmlmuseo.Elements("opere");
				foreach (var item in xmlopere)
				{
					XElement xmlFirstname = item.Element("nome");
					XElement xmlData = item.Element("data");
					XElement xmlAutore = item.Element("autore");
					XElement xmlPosizione = item.Element("posizione");
					OPERE a = new OPERE();
					a.Nome = xmlFirstname.Value;
					a.data_di_pubblicazione = Convert.ToDateTime(xmlData.Value);
					a.Autore = xmlAutore.Value;
					a.Posizione = xmlPosizione.Value;
					opera = a;
					Dispatcher.Invoke(() => Lst_prova.Items.Add(opera));
				}

			}
			else if (Rbn_nascitadivenre.IsChecked == true)
			{
				OPERE opera = new OPERE();
				string path = @"nascitadivenere.xml";
				XDocument xmlDoc = XDocument.Load(path);
				XElement xmlmuseo = xmlDoc.Element("museo");
				var xmlopere = xmlmuseo.Elements("opere");
				foreach (var item in xmlopere)
				{
					XElement xmlFirstname = item.Element("nome");
					XElement xmlData = item.Element("data");
					XElement xmlAutore = item.Element("autore");
					XElement xmlPosizione = item.Element("posizione");
					OPERE a = new OPERE();
					a.Nome = xmlFirstname.Value;
					a.data_di_pubblicazione = Convert.ToDateTime(xmlData.Value);
					a.Autore = xmlAutore.Value;
					a.Posizione = xmlPosizione.Value;
					opera = a;
					Dispatcher.Invoke(() => Lst_prova.Items.Add(opera));
				}

			}
			else if (Rbn_bustodinerone.IsChecked == true)
			{
				OPERE opera = new OPERE();
				string path = @"busto_di_nerone.xml";
				XDocument xmlDoc = XDocument.Load(path);
				XElement xmlmuseo = xmlDoc.Element("museo");
				var xmlopere = xmlmuseo.Elements("opere");
				foreach (var item in xmlopere)
				{
					XElement xmlFirstname = item.Element("nome");
					XElement xmlData = item.Element("data");
					XElement xmlAutore = item.Element("autore");
					XElement xmlPosizione = item.Element("posizione");
					OPERE a = new OPERE();
					a.Nome = xmlFirstname.Value;
					a.data_di_pubblicazione = Convert.ToDateTime(xmlData.Value);
					a.Autore = xmlAutore.Value;
					a.Posizione = xmlPosizione.Value;
					opera = a;
					Dispatcher.Invoke(() => Lst_prova.Items.Add(opera));
				}
			}
			
		}

		private void Btn_resetta_Click(object sender, RoutedEventArgs e)
		{
			Lst_prova.Items.Clear();
			Rbn_nascitadivenre.IsChecked = false;
			Rbn_primavera.IsChecked = false;
			Rbn_duchidiurbino.IsChecked = false;
			Rbn_bustodinerone.IsChecked = false;
		}

		private void Btn_Sito_Click(object sender, RoutedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://progettomuseo2020.github.io/");
		}
	}
}
