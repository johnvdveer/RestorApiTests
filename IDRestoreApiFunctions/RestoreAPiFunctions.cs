using System;

namespace RestoreApiFunctions
{


    public class RestoreAPiFunctions
    {
        public RestoreDataObject actualData { get;  set; }
        public RestoreSettingsReport settingsReport { get; set; }

        public BoilerStates? GetBoilerState()
        {
            var state = BoilerStates.NrOfBoilerStates;

            if ((actualData.TempHigh1 > 8000 || actualData.TempHigh2 > 8000 ||
                          actualData.State.HasFlag(BoilerState.HeatingElement)) && settingsReport.Value == 850)
            {
                state = BoilerStates.FlexDown;
            }
            else if ((actualData.TempHigh1 > 8000 || actualData.TempHigh2 > 8000) == false &&
                     actualData.State.HasFlag(BoilerState.HeatingElement) == false)
            {
                state = BoilerStates.FlexUp;
            }
            else if (actualData.TempHigh1 > 8000 || actualData.TempHigh2 > 8000)
            {
                state = BoilerStates.CannotRun;
            }
            else
            {
                state = BoilerStates.MustRun;
            }
            return state;
        }

        public BoilerStates? _GetBoilerState()
        {
            var state = BoilerStates.NrOfBoilerStates;

            if ((actualData.TempHigh1 > 8000 || actualData.TempHigh2 > 8000 ||
                actualData.State.HasFlag(BoilerState.HeatingElement)) && settingsReport.Value == 850)
            {
                state = BoilerStates.FlexDown;
            }
            else if (actualData.TempHigh1 > 8000 || actualData.TempHigh2 > 8000)
            {
                state = BoilerStates.CannotRun;
            }
            else if ((actualData.TempHigh1 > 8000 || actualData.TempHigh2 > 8000) == false &&
                     ( actualData.State.HasFlag(BoilerState.HeatingElement) == false) && (settingsReport.Value == 850))
            {
                state = BoilerStates.FlexUp;
            }
            else
            {
                state = BoilerStates.MustRun;
            }
            return state;
        }
    }
}
