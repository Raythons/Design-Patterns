﻿namespace FactoryMethod.Factory
{
    public abstract class Person
    {
        public Person(string name, string idenifier, string password)
        {
            Name = name;
            Idenifier = idenifier;
            Password = password;
        }
        public string Name { get; }
        public string Idenifier { get; }
        public string Password { get; }
    }
}
