using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Timers;
using System.Threading;

namespace _20221104
{
    class Program
    {
        static void Main(string[] args)
        {
            //var settings = MongoClientSettings.FromConnectionString("mongodb+srv://chisato:chi37153163@cluster0.wbwkwqe.mongodb.net/?retryWrites=true&w=majority");　//データベース接続
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://makoto:ae21215926@cluster0.zihxmz9.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var db = client.GetDatabase("sample_airbnb"); //()の中に移動
            var collection = db.GetCollection<BsonDocument>("listingsAndReviews"); //()の中に移動
            //var result = collection.Find("{title:'Peter Pan'}").FirstOrDefault();

            //var document = new BsonDocument
            //{
            //    {"student_id", 10000 },
            //    {
            //        "scores", new BsonArray
            //        {
            //            new BsonDocument{{"type", "exam"}, {"score", 88.1234193287023} },
            //            new BsonDocument{{"type", "quiz"}, {"score", 74.92381029342834} },
            //            new BsonDocument{{"type", "homework"}, {"score", 89.97929384290324} },
            //            new BsonDocument{{"type", "homework"}, {"score", 82.12931030513218} }
            //        }
            //    },
            //    {"class_id", 480}
            //};
            //collection.InsertOne(document);
            //Console.WriteLine(result[""]);
            //var filter = Builders<BsonDocument>.Filter.Eq("student_id", 10000); //検索的な
            //var update = Builders<BsonDocument>.Update.Set("class_id", 0); //変更して的な
            //collection.UpdateOne(filter, update);
            //var result = collection.Find("{student_id:10000}").FirstOrDefault();
            //Console.WriteLine(result["class_id"]);


            //int num = 1;
            //System.Timers.Timer timer = new System.Timers.Timer(2000);

            ////タイマー処理
            //timer.Elapsed += (sender, e) =>
            //{
            //    if (num < 7)
            //    {
            //        var filter1 = Builders<BsonDocument>.Filter.Eq("student_id", 10000);
            //        var update1 = Builders<BsonDocument>.Update.Set("class_id", num);
            //        collection.UpdateOne(filter1, update1);
            //        //Thread.Sleep(1000);
            //        var result1 = collection.Find("{student_id:10000}").FirstOrDefault();
            //        Console.WriteLine(result1["class_id"]);
            //        num++;
            //    }
            //    else
            //    {
            //        timer.Stop();
            //        Console.WriteLine("処理終了");
            //    }
            //};
            //timer.Start();
            //Console.ReadKey();
            
            
        }
    }
}
