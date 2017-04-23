using TechTalk.SpecFlow;


namespace KataSupermarket.Tests
{
    public static class ScenarioContextExtensions
    {
        public static void Update(this ScenarioContext scenarioContext, string key, object value)
        {
            if (scenarioContext.ContainsKey(key))
            {
                scenarioContext.Remove(key);
            }
            scenarioContext.Add(key, value);
        }

        public static T Retrieve<T>(this ScenarioContext scenarioContext) where T : class, new()
        {
            T istance;
            scenarioContext.TryGetValue(out istance);
            return istance ?? new T();
        }

        public static T Retrieve<T>(this ScenarioContext scenarioContext, string key) where T : class, new()
        {
            if (scenarioContext.ContainsKey(key))
            {
                return scenarioContext.Get<T>(key);
            }

            T istance;
            scenarioContext.TryGetValue(out istance);
            return istance ?? new T();
        }

    }
}