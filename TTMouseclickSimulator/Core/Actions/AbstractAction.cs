﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTMouseclickSimulator.Core.Environment;

namespace TTMouseclickSimulator.Core.Actions
{
    public abstract class AbstractAction : IAction
    {
        public abstract Task RunAsync(IInteractionProvider provider);

        public event Action<string> ActionInformationUpdated;


        protected void OnActionInformationUpdated(string text) =>
            ActionInformationUpdated?.Invoke(text);
    }
}
