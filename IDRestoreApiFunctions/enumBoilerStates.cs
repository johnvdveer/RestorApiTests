using System;
using System.Collections.Generic;
using System.Text;

namespace RestoreApiFunctions
{
    public enum BoilerStates
    {
        CannotRun = 0,
        FlexUp,
        FlexDown,
        MustRun,
        NrOfBoilerStates
    };

    public enum BoilerState
    {
        Unknown,
        HeatingElement,
    };
}
