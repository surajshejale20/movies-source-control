using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Movies.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Movies.Repository
{
    public class MovieRepository : IMovieRepository
    {
        public IList<Movie> GetAll()
        {
            var pizzaList = new List<Movie>();
            try
            {
                var json = Configs.ReadFileData(Configs.MoviesData);
                if (!string.IsNullOrEmpty(json))
                {
                    var jObject = JObject.Parse(json);
                    pizzaList = JsonConvert.DeserializeObject<List<Movie>>(jObject["movies"].ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return pizzaList;
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsExists(int id)
        {
            throw new NotImplementedException();
        }

        public bool Create(Movie entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Movie entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Movie entity)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }

    public class Configs
    {
        public const string MoviesData = "~\\..\\..\\Data\\movies.json";

        public static string ReadFileData(string fileName)
        {
            if (File.Exists(fileName))
            {
                var result = File.ReadAllText(fileName);
                return result;
            }

            return null;
        }

        public static bool WriteDataToFile(string fileName, string content)
        {
            if (File.Exists(fileName))
            {
                File.WriteAllText(fileName, content);
                return true;
            }

            return false;
        }
    }
}
