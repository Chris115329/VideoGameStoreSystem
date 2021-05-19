using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameStore.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Genre { get; set; }

        public Game() {

}

    }
}
