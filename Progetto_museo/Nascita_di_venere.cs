﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_museo
{
	public class Nascita_di_venere
	{
		public string Nome { get; set; }
		public DateTime data_di_pubblicazione { get; set; }
		public string Autore { get; set; }
		public string Posizione { get; set; }


		public override string ToString()
		{
			return $"{Nome} {data_di_pubblicazione} {Autore} {Posizione}";
		}
	}

	
}
