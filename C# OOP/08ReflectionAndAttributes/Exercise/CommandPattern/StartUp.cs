using CommandPattern.Core;
using CommandPattern.Core.Contracts;

namespace CommandPattern
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            // var asd = typeof(string).GetCustomAttributes();
            // var personType = typeof(Person);
            
            // typeof(StartUp).GetMethod("Main").Invoke(null, new object[] { "hi" });
            // FieldInfo[] fInfo = personType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            // PropertyInfo pInfo = personType.GetProperty("Name");

            ICommandInterpreter command = new CommandInterpreter();
            IEngine engine = new Engine(command);
            engine.Run();


        }
    }
}
