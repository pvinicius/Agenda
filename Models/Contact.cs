namespace Agenda.Models {
    public class Contact : Base {
        public int Id { get; private set; }
        public User User { get; private set; }
    }
}