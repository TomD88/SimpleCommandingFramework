using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCommandingFramework
{
    public abstract class BaseCommand:ICommand
    {

        public virtual void Execute(ICommandParameter parameter)
        {
            if (DoPreExecution(parameter)) 
            {
                DoExecute(parameter);
                DoPostExecution(parameter);
            }
            
        }

        protected virtual bool DoPreExecution(ICommandParameter parameter) 
        {
            return true;
        }

        protected virtual void DoPostExecution(ICommandParameter parameter) { }

        protected abstract void DoExecute(ICommandParameter parameter);

    }
}
