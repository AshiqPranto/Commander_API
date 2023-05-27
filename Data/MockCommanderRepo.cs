using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            List<Command> commands = new List<Command>
            {
                new Command { HowTo = "boil an egg", Id = 0, Line = "Boil water", Platform = "Kettle and pan" },
                new Command { HowTo = "boil an egg", Id = 1, Line = "Boil water", Platform = "Kettle and pan" },
                new Command { HowTo = "boil an egg", Id = 2, Line = "Boil water", Platform = "Kettle and pan" },
                new Command { HowTo = "boil an egg", Id = 3, Line = "Boil water", Platform = "Kettle and pan" },
                new Command { HowTo = "boil an egg", Id = 4, Line = "Boil water", Platform = "Kettle and pan" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { HowTo = "boil an egg", Id = 0, Line = "Boil water", Platform = "Kettle and pan" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
