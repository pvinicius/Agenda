using System;
using System.Collections.Generic;

namespace Agenda.Models {
    public class Base {
        public string Name { get; private set; }
        public string Adress { get; private set; }
        public string Email { get; private set; }
        public List<Phone> Phone { get; private set; }
        public Photo Photo { get; private set; }
        public DateTime DateOfBirth { get; private set; }
    }
}