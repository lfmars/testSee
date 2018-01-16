using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonToList.Models.DTO;
using JsonToList.Models.See;

namespace JsonToList.Utils.imp
{
    class JsonToDatabaseImp : IJsonToDatabase
    {
        private SQLiteConnection sqlite;

        public JsonToDatabaseImp()
        {
            sqlite = new SQLiteConnection(@"Data Source=C:\Users\Marius\source\DbAction\testSee\JsonToList\Sources\slack.db");
        }



        public void docTagsVersions(List<DTOdocTagVersions> docTagsVersions)
        {
            StringToDate sToDate = new StringToDateImp();
            foreach (DTOdocTagVersions version in docTagsVersions)
            {
                try
                {
                    Console.WriteLine("adding " +version.Id);
                    DateTime cd = sToDate.GetDate(version.CreationDate);
                    DateTime led = sToDate.GetDate(version.CreationDate);
                    sqlite.Open();
                    SQLiteCommand cmd = new SQLiteCommand(sqlite);
                    cmd.CommandText = "INSERT INTO docTagsVersions VALUES (@id, @tagId, @titl, @cdate, @ledate)";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@id", version.Id);
                    cmd.Parameters.AddWithValue("@tagId", version.DocTagId);
                    cmd.Parameters.AddWithValue("@titl", version.Name);
                    cmd.Parameters.AddWithValue("@cdate", cd);
                    cmd.Parameters.AddWithValue("@ledate", led);
                    cmd.ExecuteNonQuery();

                }
                catch(SQLiteException ex)
                {
                    Console.WriteLine("kajuk in docTagsVersions: "+ex);
                }
                sqlite.Close();
            }
            
        }

        public void examples(List<DTOexamples> examples)
        {
            StringToDate sToDate = new StringToDateImp();
            foreach (DTOexamples example in examples)
            {
                try
                {
                    Console.WriteLine("adding " + example.Id);
                    DateTime cd = sToDate.GetDate(example.CreationDate);
                    DateTime led = sToDate.GetDate(example.CreationDate);
                    sqlite.Open();
                    SQLiteCommand cmd = new SQLiteCommand(sqlite);
                    cmd.CommandText = "INSERT INTO examples VALUES (@id, @topicId, @titl, @des, @cdate, @ledate)";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@id", example.Id);
                    cmd.Parameters.AddWithValue("@topicId", example.DocTopicId);
                    cmd.Parameters.AddWithValue("@titl", example.Title);
                    cmd.Parameters.AddWithValue("@des", example.BodyMarkdown);
                    cmd.Parameters.AddWithValue("@cdate", cd);
                    cmd.Parameters.AddWithValue("@ledate", led);
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine("kajuk in examples: " + ex);
                }
                sqlite.Close();
            }

        }
    }
}
