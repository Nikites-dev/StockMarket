using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Driver;
using StockMarket.Models;
using StockMarket.Pages;

namespace StockMarket.MongoDB
{
    public class MongoDBAction
    {
        public static void AddToDatabase(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StockMarket");

            var collection = database.GetCollection<User>("UserCollection");
            collection.InsertOne(user);
        }
        
        public static void AddItemToDB(Item item)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StockMarket");

            var collection = database.GetCollection<Item>("ItemCollection");
            collection.InsertOne(item);
        }
        
        public static Item FindItemByName(String itemName)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StockMarket");
            var collection = database.GetCollection<Item>("ItemCollection");
            Item item = collection.Find(x => x.Name == itemName).FirstOrDefault();

            if (item == null)
            {
                return null;
            }
            return item;
        }

        public static User FindByLogin(String login)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StockMarket");
            var collection = database.GetCollection<User>("UserCollection");
            User user = collection.Find(x => x.Login == login).FirstOrDefault();

            if (user == null)
            {
                return null;
            }
            return user;
        }


        public static void UpdateByLogin(String login, User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StockMarket");
            var collection = database.GetCollection<User>("UserCollection");
            var b = collection.ReplaceOne(x => x.Login == login, user).ModifiedCount > 0;
        }


        public static String DeleteByName(String login)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StockMarket");
            var collection = database.GetCollection<User>("UserCollection");
            var user = collection.DeleteOne(x => x.Login == login);
            return $"User {user.GetType().Name} is remove!";
        }

        public static void ClearDB()
        {
            var client = new MongoClient("mongodb://localhost");
            client.GetDatabase("Warcraft").DropCollectionAsync("UserCollection");
        }

        public static List<String> GetListItemNames()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StockMarket");
            var collection = database.GetCollection<Item>("ItemCollection");
            var strNames = collection.Find<Item>(x => x.Name != null && x.Name != "").ToEnumerable<Item>();
            return strNames.Select(x => x.Name).ToList<String>();
        }

        public static List<Item> GetListItem(List<String> listNames)
        {
            List<Item> listItem = new List<Item>();
            foreach(var item in listNames)
            {
                listItem.Add(FindItemByName(item));
            }

            return listItem;
        }


        //public static List<String> GetListMatchInfo()
        //{
        //    var client = new MongoClient("mongodb://localhost");
        //    var database = client.GetDatabase("Warcraft");
        //    var collection = database.GetCollection<MatchDb>("MatchCollection");
        //    var strNames = collection.Find<MatchDb>(x => x.Date != null && x.Date != "")
        //        .ToEnumerable<MatchDb>();
        //    return strNames.Select(x => x.Date).ToList<String>();
        //}

        //public static MatchDb FindByDateMatch(String name)
        //{
        //    var client = new MongoClient("mongodb://localhost");
        //    var database = client.GetDatabase("Warcraft");
        //    var collection = database.GetCollection<MatchDb>("MatchCollection");
        //    MatchDb match = collection.Find(x => x.Date == name).FirstOrDefault();

        //    //MatchInfo matchInfo = new MatchInfo(match.Date, CharacterToUnitList(match.ListHeroes), CharacterToUnitList(match.TeamUnit1), CharacterToUnitList(match.TeamUnit2)); 

        //    return match;
        //}


    }
}
