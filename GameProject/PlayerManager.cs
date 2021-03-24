using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager : IPlayerService
    {
        public IUserCheck _userCheck;

        public PlayerManager()
        {
        }

        public PlayerManager(IUserCheck userCheck)
        {
            _userCheck = userCheck;
        }

        public void delete(Player player)
        {
            Console.WriteLine("Deleted");
        }

        public void SignUp(Player player)
        {
            Console.WriteLine("Signing up successful");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Updated");
        }
    }
}
