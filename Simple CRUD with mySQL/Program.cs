using System;
using System.Collections.Generic;
using DbConnection;

namespace Simple_CRUD_with_mySQL
{
    class Program
    {        
        static void Main(string[] args)
        {
            PrintUsers();

            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            string FavoriteNumber = Console.ReadLine();
            string query = "INSERT INTO users (FirstName,LastName,FavoriteNumber,created_at,updated_at) VALUES ('"+FirstName+"','"+LastName+"','"+FavoriteNumber+"',NOW(),NOW())";
            System.Console.WriteLine(query);
            DbConnector.Query(query);

            PrintUsers();
            


        }

        static void PrintUsers(){
            List<Dictionary<string,object>> users =  DbConnector.Query("SELECT * FROM users");
            for(int i=0;i<users.Count;i++){
                foreach (KeyValuePair<string,object> kvp in users[i]){
                    System.Console.WriteLine("KEY: {0} | VALUE: {1}",kvp.Key,kvp.Value);
                }
            }
        }
    }
}
