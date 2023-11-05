using System.ComponentModel.DataAnnotations;

namespace API_TouristBay.Models.Passengers
{
    public class PassengerType
    {
        private int _idPassangerType;
        private string _namePassengerType;
        private bool _viewPassengerType;

        public PassengerType() { }

        public PassengerType(int id, string name, bool view )
        {
            _idPassangerType = id;
            _namePassengerType = name;
            _viewPassengerType = view;
        }

        [Key]
        public int IdPassangerType { get => _idPassangerType; set => _idPassangerType = value; }
        [Required]
        public string NamePassengerType { get => _namePassengerType; set => _namePassengerType = value; }
        [Required]
        public bool ViewPassengerType { get => _viewPassengerType; set => _viewPassengerType = value; }
    }
}
