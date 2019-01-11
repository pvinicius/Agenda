namespace Agenda.Models {
    public class User : Base {
        public int Id { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
    }
}