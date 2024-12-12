using MongoDB.Bson;
using MongoDB.Driver;

public static class MongoDbClient
{
    public static void AddLog(LogModel model)
    {
        var client = new MongoClient("mongodb+srv://kasimpasaoglu:pVbtOCZWaGPn013S@cluster0.n2dxd.mongodb.net/");
        var database = client.GetDatabase("logs");
        var collection = database.GetCollection<BsonDocument>("Cluster0");
        collection.InsertOne(model.ToBsonDocument());
    }
}