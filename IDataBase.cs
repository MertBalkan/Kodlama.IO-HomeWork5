using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.ioOdev5.Abstracts
{
    interface IDataBase
    {
        void RegisterPlayerInfosToDataBase(IPlayerService player);
        void UpdatePlayerInfosFromDataBase(IPlayerService player);
        void DeletePlayerInfosFromDataBase(IPlayerService player);
    }
}
