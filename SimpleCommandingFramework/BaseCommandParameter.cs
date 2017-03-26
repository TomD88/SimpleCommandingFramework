using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCommandingFramework
{
    public abstract class BaseCommandParameter:ICommandParameter
    {
        protected Dictionary<string, Object> _parameterDictionary = new Dictionary<string, object>();

    }
}
