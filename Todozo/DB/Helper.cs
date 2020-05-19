using System.Configuration;

namespace Todozo
{
    // We use the Helper class to fetch the database everytime we want to manipulate the data inside of it.
    public static class Helper
    {
        public static string ConnectionValue(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
