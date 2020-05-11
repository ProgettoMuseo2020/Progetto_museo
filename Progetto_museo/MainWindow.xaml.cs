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
using System.Xml.Linq;

namespace Progetto_museo
{
	/// <summary>
	/// Logica di interazione per MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			

		}

		private void Btn_primo_Click(object sender, RoutedEventArgs e)
		{
			Lst_primo.Items.Clear();
			Task.Factory.StartNew(() => CaricaDati());
		}

		private void CaricaDati()
		{
			Nascita_di_venere opera = new Nascita_di_venere();
			string path = @"nascita_di_venere";
			XDocument xmlDoc = XDocument.Load(path);
			XElement xmlmuseo = xmlDoc.Element("museo");
			var xmlopere = xmlmuseo.Elements("opere");
			foreach (var item in xmlopere)
			{
				XElement xmlFirstname = item.Element("nome");
				XElement xmlData = item.Element("data");
				XElement xmlAutore = item.Element("Autore");
				XElement xmlPosizione = item.Element("posizione");
				Nascita_di_venere a = new Nascita_di_venere();
				a.Nome = xmlFirstname.Value;
				a.data_di_pubblicazione = Convert.ToDateTime(xmlData.Value);
				a.Autore = xmlAutore.Value;
				a.Posizione = xmlPosizione.Value;
				opera = a;
				Dispatcher.Invoke(() => Lst_primo.Items.Add(opera));
			}
		}
	}
}
