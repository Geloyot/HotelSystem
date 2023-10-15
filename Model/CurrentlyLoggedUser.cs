using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Appdata;

namespace HotelReservationSystem
{
    public sealed class CurrentlyLoggedUser
    {
        // NO THREAD SAFETY SINGLETON
        //private static CurrentlyLoggedUser CurrentUserAccount = null;

        //private CurrentlyLoggedUser() { }

        //public static CurrentlyLoggedUser GetInstance() 
        //{
        //    if (CurrentUserAccount == null) CurrentUserAccount = new CurrentlyLoggedUser();
        //    return CurrentUserAccount;
        //}

        // NO LOCK NO LAZY SINGLETON DESIGN

        private static readonly CurrentlyLoggedUser _instance = new CurrentlyLoggedUser();
        public UserAccount CurrentUserAccount;

        private CurrentlyLoggedUser() { }

        public static CurrentlyLoggedUser GetInstance()
        {
            return _instance;
        }
    }
}
