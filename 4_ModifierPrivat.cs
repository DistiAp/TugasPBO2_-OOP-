﻿using System;
using System.Collections;

namespace ModifierPrivate
{
    class Person
    {
        private string name = "Disti";
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.name);
        }
    }
}