        using System;
        using YamlDotNet.Serialization;
        using YamlDotNet.Serialization.NamingConventions;
        namespace Yamlparser
        {

        struct Person
        {
            public string name;
            public string age;
            public string height_in_inches;
        };

        class Program
            {
                static void Main(string[] args)
                {
                    var yml = @"
                    name: George Washington
                    age: 89
                    height_in_inches: 5.75
                    ";
                    var deserializer = new DeserializerBuilder()
                        .WithNamingConvention(UnderscoredNamingConvention.Instance)  // see height_in_inches in sample yml 
                        .Build();
                    var p = deserializer.Deserialize<Person>(yml);
                    Console.WriteLine("Hello World!");
                    Console.WriteLine(p.name);
                    System.Environment.SetEnvironmentVariable("name", p.name, EnvironmentVariableTarget.User);
                }
            }
        }
