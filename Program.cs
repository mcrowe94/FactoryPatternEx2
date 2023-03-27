// See https://aka.ms/new-console-template for more information

using FactoryPatternEx2;

Console.WriteLine("What database would you like to use? List, SQL, or Mongo?");
var responce = Console.ReadLine();

//IDataAccess da = new ListDataAccess();
//IDataAccess da = new SQLDataAccess();
//IDataAccess da= new MongoDataAccess();
var da = DataAccessFactory.GetDataAccessType(responce);

var products = da.LoadData();//loading all products in List/SQL/Mongo

Console.WriteLine("Here are your products:");

foreach(var item in products)
{
    Console.WriteLine($"Name: {item.Name}");
    Console.WriteLine($"Price: ${item.Price}");
}

da.SaveData();