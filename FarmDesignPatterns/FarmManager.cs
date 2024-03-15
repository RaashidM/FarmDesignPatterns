using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDesignPatterns
{
    public class FarmManager
    {
        private List<IObserver> farmers = new List<IObserver>();
        private readonly List<ICommand> commands = new List<ICommand>();

        public void AddFarmer(IObserver farmer)
        {
            farmers.Add(farmer);
        }

        public void RemoveFarmer(IObserver farmer)
        {
            farmers.Remove(farmer);
        }

        public void NotifyFarmers()
        {
            foreach (var farmer in farmers)
            {
                farmer.Update();
            }
        }

        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }
    }
}
