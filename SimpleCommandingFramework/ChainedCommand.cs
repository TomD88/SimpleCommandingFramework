using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCommandingFramework
{
    public class ChainedCommand:BaseCommand
    {

        List<ICommand> _commandList = new List<ICommand>();

        protected override void DoExecute(ICommandParameter parameter)
        {
            foreach (ICommand command in _commandList)
            {
                command.Execute(parameter);
            }
        }


        public ChainedCommand Add(ICommand command) 
        {
            _commandList.Add(command);
            return this;
        }


    }
}
