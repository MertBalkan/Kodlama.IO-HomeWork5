using Kodlama.ioOdev5.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.ioOdev5.Concretes
{
    class Program
    {
        static void Main(string[] args)
        {
            //BU PROGRAM MERT BALKAN TARAFINDAN KODLAMA.IO'NUN 5.ÖDEVİNDEKİ BAZI BİLGİLER DEĞİŞTİRİLEREK YAZILMIŞTIR...
            //2 ÇEŞİT DATABASE YARATILARAK BU DATABASELERE BİLGİLER GÖTÜRÜLÜP ÇEKİLME İŞLEMİ YAPILMAKTADIR...
            //KODLARA BAKAN KİŞİLER KODLARI İSTEDİĞİ KADAR İNCELEYİP DEĞİŞTİREBİLİR...
            //İYİ ÇALIŞMALAR...
            List<Player> playerList = new List<Player>();

            Player[] players = new Player[3];
            IPlayerService playerService = new PlayerManager(playerList);
            IDataBase dataBase = new SteamDatabase(playerService);


            players[0] = new Player("mert", "balkan", "12", 18);
            players[1] = new Player("ali", "balkan", "13", 55);
            players[2] = new Player("osman", "balkan", "14", 28);

            for (int i = 0; i < players.Length; i++)
            {
                playerList.Add(players[i]);
            }

            dataBase.RegisterPlayerInfosToDataBase(playerService);
            Console.WriteLine("----------------------------------------------");
            dataBase.UpdatePlayerInfosFromDataBase(playerService);
            Console.WriteLine("----------------------------------------------");
            dataBase.DeletePlayerInfosFromDataBase(playerService);
            Console.WriteLine("**********************************************");

            playerList.Remove(players[0]); // MERT BALKANI LİSTEDEN ÇIKARIYORUM. YANİ DATABASEDEN ÇIKARIYORUM.

            dataBase.RegisterPlayerInfosToDataBase(playerService);
            Console.WriteLine("----------------------------------------------");
            dataBase.UpdatePlayerInfosFromDataBase(playerService);
            Console.WriteLine("----------------------------------------------");
            dataBase.DeletePlayerInfosFromDataBase(playerService);
        }
    }
}
