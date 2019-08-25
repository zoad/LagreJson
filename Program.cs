﻿using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LargeJson
{
    class Program
    {

        static void Main(string[] args)
        {
            //from AdventureWorks sql to JSON
              ReadJsonFileAsync(@"targetMails1000.min.json").GetAwaiter().GetResult();
        }

        static async Task ReadJsonFileAsync(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                return;
            }

            JsonSerializer serializer = new JsonSerializer();
            TargetMail p;

            using (Stream s = File.Open(filePath, FileMode.Open))
            using (StreamReader sr = new StreamReader(s))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                while (await reader.ReadAsync())
                {
                    try
                    {
                        if (reader.TokenType == JsonToken.StartObject)
                        {
                            // read the json from a stream
                            // json size doesn't matter because only a small piece is read at a time from the HTTP request

                            p = serializer.Deserialize<TargetMail>(reader);
                            Console.WriteLine(p);

                            //or
                            //Console.WriteLine(serializer.Deserialize<TargetMail>(reader));
                        }
                    }
                    catch (System.Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}