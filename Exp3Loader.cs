using System.Text.Json;

namespace Revolt2D.Exp.Json
{
    public class Exp3Loader
    {
        private Exp3 _exp;

        public Exp3Loader(string filePath)
        {
            _exp = LoadFromFile(filePath);
        }

        public Exp3 GetExp()
        {
            return _exp;
        }

        public Exp3? LoadFromFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                throw new Exception($"Invalid path! {filePath}");

            string? jsonData = File.ReadAllText(filePath);
            return LoadJson(jsonData);
        }

        public Exp3? LoadJson(string jsonData)
        {
            try
            {
                if (string.IsNullOrEmpty(jsonData))
                    throw new Exception("JSON data empty!");

                JsonSerializerOptions options = new JsonSerializerOptions { IncludeFields = true };
                return JsonSerializer.Deserialize<Exp3>(jsonData, options);
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
    }
}
