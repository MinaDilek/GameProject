using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IPlayerService
    {
        void SignUp(Player player);
        void Update(Player player);
        void delete(Player player);

    }
}
