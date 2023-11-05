using System.ComponentModel.DataAnnotations;

namespace API_TouristBay.Models.Catalogues
{
    public class Airline
    {
        private int _idAirline;
        private string _nameAirline;

        public Airline() { }
        public Airline(int id, string name)
        {
            _idAirline = id;
            _nameAirline = name;
        }

        [Key]
        public int IdAirline { get => _idAirline; set => _idAirline = value; }
        [Required]
        public string NameAirline { get => _nameAirline; set => _nameAirline = value; }
    }
}
