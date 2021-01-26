using Kodlama.ioOdev5.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.ioOdev5.Concretes
{
    class PlayerManager : IPlayerService
    {
        private List<Player> _players;

        public PlayerManager(List<Player> player)
        {
            _players = new List<Player>();
            _players = player;
        }
        public void Delete()
        {
            foreach (var player in _players)
            {
                Console.WriteLine(player.Name + " deleted");
            }
        }

        public void Register()
        {
            foreach (var player in _players)
            {
                Console.WriteLine(player.Name + " registered");
            }
        }

        public void Update()
        {
            foreach (var player in _players)
            {
                Console.WriteLine(player.Name + " updated");
            }
        }
    }
}