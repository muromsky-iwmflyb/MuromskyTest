namespace MuromskyInspectorLib
{
    public class FunctionInsp
    {
        private string mainInspector = "Васильев Василий Иванович";
        private string inspectionName = "Автоинспекция г. Чита";
        private List<string> workers = new List<string>
        {
            "Иванов И.И.",
            "Зиронов Т.А.",
            "Миронов А.В.",
            "Васильев В.И."
        };

        public string GetInspector()
        {
            return mainInspector;
        }

        public string GetCarInspection()
        {
            return inspectionName;
        }

        public bool SetInspector(string fullname)
        {
            if (workers.Contains(fullname))
            {
                mainInspector = fullname;
                return true;
            }
            return false;
        }

        public string GenerateNumber(string symbol, int number, string code)
        {
            if (string.IsNullOrEmpty(symbol) || char.IsLower(symbol[0]) || !char.IsLetter(symbol[0]))
            {
                throw new ArgumentException("Символ должен состоять из одной заглавной буквы.");
            }
            return $"{symbol.ToUpper()}{number}_{code}";
        }

        public List<string> GetWorker()
        {
            return new List<string>(workers);
        }

        public void AddWorker(string fullname)
        {
            if (!workers.Contains(fullname))
            {
                workers.Add(fullname);
            }
        }
    }
}
