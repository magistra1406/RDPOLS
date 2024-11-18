using System.Collections.Generic;

namespace TesBlazor1.Models.Entities
{
    public class UserAccount
    {
        public string Username { get; set; }
        public string Password { get; set; } 
        public string Name { get; set; }
        public string Nopek { get; set; }
        public string Role { get; set; }
        public string? PRL { get; set; }
        public string Section { get; set; }
        public string Position { get; set; }
        public int? Points { get; set; }

        public static List<UserAccount> GetDummyUsers()
        {
            return new List<UserAccount>
            {
                new UserAccount { Username = "dika", Password = "password1", Name = "Ramadhan Surya", Nopek = "2070", Role = "SuperAdmin", PRL = "18", Section = "HC", Position = "Manager Area HC", Points = 790},
                new UserAccount { Username = "dinda", Password = "password2", Name = "Dinda Rachma", Nopek = "2056", Role = "Pegawai", PRL = "22", Section = "SSC-ICT", Position = "Manager Area SSC-ICT", Points = 1324},
                new UserAccount { Username = "kerin", Password = "password3", Name = "Cecillia Kerin", Nopek = "2028", Role = "AM", PRL = "19", Section = "Asset Management", Position = "Manager Area Asset Management", Points = 800},
                new UserAccount { Username = "dayinta", Password = "password4", Name = "Dayinta Palupi", Nopek = "2080", Role = "TKJP", PRL = "20", Section = "Maintenance", Position = "Manager Maintenance Planning & Support", Points = 810},
                new UserAccount { Username = "magis", Password = "123", Name = "Magis", Nopek = "2048", Role = "Pegawai", PRL = "12", Section = "EngDev", Position = "Project Engineer", Points = 500},
                new UserAccount { Username = "admin", Password = "admin123", Name = "Super Admin KPI RU IV", Nopek = "", Role = "SuperAdmin", PRL = "", Section = "", Position = "", Points = 0},
            };
        }
    }
}
