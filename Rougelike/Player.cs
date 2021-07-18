using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelike
{
    class Player
    {
        private string name;
        private string profession;

        public Player(string name, string profession)
        {
            this.name = name;
            this.profession = profession;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        public void setProfession(String profession)
        {
            this.profession = profession;
        }

        public String getProfession()
        {
            return profession;
        }

       

    }
}
