using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Opgave1;

namespace Opgave4.managers
{
    public interface IManageFootballPlayers
    {
        IEnumerable<FootballPlayer> Get();

        FootballPlayer Get(int id);

        bool Create(FootballPlayer footballPlayer);

        bool Update(int id, FootballPlayer footballPlayer);

        FootballPlayer Delete(int id);

    }
}
