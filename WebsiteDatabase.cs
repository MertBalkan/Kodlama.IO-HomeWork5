﻿using Kodlama.ioOdev5.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.ioOdev5.Concretes
{
    class WebsiteDatabase : IDataBase
    {
        private IPlayerService _player;

        public WebsiteDatabase(IPlayerService player)
        {
            _player = player;
        }
        public void RegisterPlayerInfosToDataBase(IPlayerService player)
        {
            _player.Register();
        }

        public void DeletePlayerInfosFromDataBase(IPlayerService player)
        {
            _player.Delete();
        }

        public void UpdatePlayerInfosFromDataBase(IPlayerService player)
        {
            _player.Update();
        }
    }
}
