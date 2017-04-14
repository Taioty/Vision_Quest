using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hub
{
    public enum Status { Player, Enemy, Minion };
    public class Entity
    {
        public Status _species;
        public int _health { get; set; }
        public int _damage;
        public int _speed;
        public int _defense;
        public bool _turn = false;
        public bool _went = false;
        public Entity(int rank)
        {
            if(rank == 0)
            {
                _species = Status.Player;
                _health = 100;
                _damage = 10;
                _speed = 10;
                _defense = 10;
            }
            else if(rank == 1)
            {
                _species = Status.Enemy;
                _health = 85;
                _damage = 5;
                _speed = 5;
                _defense = 5;
            }
            else if(rank == 2)
            {
                _species = Status.Minion;
                _health = 50;
                _damage = 2;
                _speed = 1;
                _defense = 1;
            }
            
        }

        //returns damage to be done
        public int UseMoves(Entity i)
        {
            return _damage;
        }
    }
}
