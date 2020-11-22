using VAII_semestralna_praca.Enums;

namespace VAII_semestralna_praca.Models
{
    public class Poem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public Genres Genre { get; set; }

        public Author Author { get; set; }
    }
}