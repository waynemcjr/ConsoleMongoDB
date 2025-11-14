// See https://aka.ms/new-console-template for more information
using MongoDB.Driver;

var client = new MongoClient("mongodb+srv://waynebarbosa10_db_user:iDD5OiWYs6TL1PKT@interacaomongo.fo1gf88.mongodb.net/");

var database = client.GetDatabase("InterAcaoMongoDb");

var collection = database.GetCollection<User>("Usuarios");

//var Usuario = new User("Wayne", "123@Mudar");

//collection.InsertOne(Usuario);

//var usuarioNovos = new List<User>();

//usuarioNovos.Add(new User("Maria", "123@Mudar"));
//usuarioNovos.Add(new User("Joao", "123@Mudar"));
//usuarioNovos.Add(new User("Guilhermer", "123@Mudar"));

//collection.InsertMany(usuarioNovos);

//var Usuarios = collection.Find(_ => true).ToList();

//foreach (var user in Usuarios)
//{
//    Console.WriteLine(user);
//    Console.WriteLine("-----------------------------------------");
//}

var usuario = collection.Find(x => x.Id == "69172d5b2e50e2c4e7732800").FirstOrDefault();
//var usuario = collection.Find(x => x.Password == "123@Mudar").ToList();


//collection.UpdateOne<User>(x => x.Id == "69172d5b2e50e2c4e7732800", )

Console.WriteLine(usuario);
usuario.Password = "456@Mudar";

collection.ReplaceOne(x => x.Id == usuario.Id, usuario);
Console.WriteLine(usuario);