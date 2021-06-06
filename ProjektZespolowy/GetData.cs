using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZespolowy
{
    public static class GetData
    {
        public static string Token { get; set; }
    }
    public class Users
    {
        public string getAll { get; set; }
        public string getbyId { get; set; }
        public string getByEmail { get; set; }
        public string getByUsername { get; set; }
        public string AddUser { get; set; }
        public string AddAdminUser { get; set; }
        public string putUser { get; set; }
        public string deleteUser { get; set; }

    }
    public  class authorization
    {
        public  string Register { get; set; }
        public string Login { get; set; }
    }
    public class Food
    {
        public string getSortFields { get; set; }
        public string getFood { get; set; }
        public string postFood { get; set; }
        public string putFood { get; set; }
        public string getAccepted { get; set; }
        public string getFoodId { get; set; }
        public string deleteFoodId { get; set; }
        public string searchFood { get; set; }
    }
}
