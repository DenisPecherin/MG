using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvaders
{
    public class AlienMasterShip: AlienShip
    {
        public AlienMasterShip(MatrixPosition topLeft, MatrixPosition speed)
            : base(topLeft, speed)
        {
            base.image = new char[,] { { '?' } };
            this.life = 2;
        }
    }
}

<<<<<<< Updated upstream
  // Ахули нам     
=======
       fdsfsdfsdf
       fe":LJergf;LjKOLSE?fj;slaf;lasdejf;'lSDJ;flsj;lfs;l'DFJ/
>>>>>>> Stashed changes
