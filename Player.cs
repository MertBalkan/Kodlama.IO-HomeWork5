using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.ioOdev5.Concretes
{
    class Player 
    {
        private string _name;
        private string _surname;
        private string _playerId;
        private int _age;


        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string PlayerId { get => _playerId; set => _playerId = value; }
        public int Age { get => _age; set => _age = value; }

        public Player(string name, string surname, string playerId, int age)
        {
            Name = name;
            Surname = surname;
            PlayerId = playerId;
            Age = age;
        }
    }
}
