using System;
using TechJobsOOAutograded;

namespace TechJobsOO
{
    public class Employer
    {
        public int Id { get; }
        private static int nextId = 1; //declares the field nextId. it is STATIC so its changin value is not stored within any Employer object.
        public string Value { get; set; }

        public Employer() // constructor. (accepts no arguments)
        {
            Id = nextId; // assigns the value or nextID to the Id field.
            nextId++; // increments nextId (so every new Employer object will get a different Id number)
        }

        public Employer(string value) : this() // second constructor. initializes Id for the object by calling the first constructor statement with the ": this() " syntax.
        {
            Value = value; // assigns the value field.
        }
        // including " : this()" in any Employer constructor makes initializing Id (lines 14-15) a default behaviour.

        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }

    }
}