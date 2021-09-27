using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Opgave1;

namespace Opgave4.managers
{
    public class ManageFootballPlayer:IManageFootballPlayers
    {
        private static List<FootballPlayer> _data = new List<FootballPlayer>()
        {
            new FootballPlayer(1, "Cristiano Ronaldo", 1000, 7),
            new FootballPlayer(1, "Messi", 1000, 10),
        };


        public IEnumerable<FootballPlayer> Get()
        {
            return new List<FootballPlayer>(_data);
        }

        public FootballPlayer Get(int id)
        {
            return _data.Find(p => p.Id == id);

        }

        public bool Create(FootballPlayer footballPlayer)
        {
            _data.Add(footballPlayer);
            return true;
        }

        public bool Update(int id, FootballPlayer value)
        {
            FootballPlayer footballPlayer = Get(id);
            if (footballPlayer != null)
            {

                {
                    footballPlayer.Id = value.Id;
                    footballPlayer.Name = value.Name;
                    footballPlayer.Price = value.Price;
                    footballPlayer.ShirtNumber = value.ShirtNumber;

                    return true;
                }

            }
                return false;
            
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer f = Get(id);
            _data.Remove(f);
            return f;
        }
    }
}
