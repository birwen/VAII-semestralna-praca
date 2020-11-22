using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VAII_semestralna_praca.Models
{
    public class Author
    {
		public int ID { get; set; }
		public string Name { get; set; }
		public DateTime Birth { get; set; }
		public DateTime Death { get; set; }

		public ICollection<Poem> Poem { get; set; }
	}
}
