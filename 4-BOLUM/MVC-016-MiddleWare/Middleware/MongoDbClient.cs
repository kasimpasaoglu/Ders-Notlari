using MongoDB.Bson;
using MongoDB.Driver;

public class MongoDbClient
{
    public void AddLog(LogModel model)
    {
        var client = new MongoClient("mongodb+srv://emrahelis:40GV5bQbIKnqCNYz@cluster0.3p4ow.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
        var database = client.GetDatabase("foo");
        var collection = database.GetCollection<BsonDocument>("cluster0");
        collection.InsertOne(model.ToBsonDocument());

    }
}