﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCommandingFramework
{
    public interface ICommand
    {
        void Execute(ICommandParameter parameter);
    }
}
