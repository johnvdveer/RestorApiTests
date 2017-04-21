using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestoreApiFunctions;

namespace RestorApiTests
{
    [TestClass]
    public class RestoreAPITests
    {
        [TestMethod]
        public void FlexUpStateTesT()
        {
            var device = new RestoreAPiFunctions();
            var actualData = new RestoreDataObject();
            var settingsReport = new RestoreSettingsReport();

            actualData.TempHigh1 = 8000;
            actualData.TempHigh2 = 8000;
            actualData.State = BoilerState.Unknown;
            settingsReport.Value = 850;
            device.actualData = actualData;
            device.settingsReport = settingsReport;

            Assert.AreEqual(device.GetBoilerState(), BoilerStates.FlexUp);

        }
        [TestMethod]
        public void MustRunStateTesT()
        {
            var device = new RestoreAPiFunctions();
            var actualData = new RestoreDataObject();
            var settingsReport = new RestoreSettingsReport();

            actualData.TempHigh1 = 8000;
            actualData.TempHigh2 = 8000;
            actualData.State = BoilerState.HeatingElement;
            settingsReport.Value = 750;
            device.actualData = actualData;
            device.settingsReport = settingsReport;

            Assert.AreEqual(device.GetBoilerState(), BoilerStates.MustRun);

        }
        [TestMethod]
        public void CannotRunTest()
        {
            var device = new RestoreAPiFunctions();
            var actualData = new RestoreDataObject();
            var settingsReport = new RestoreSettingsReport();

            actualData.TempHigh1 = 8001;
            actualData.TempHigh2 = 8001;
            actualData.State = BoilerState.HeatingElement;
            settingsReport.Value = 700;
            device.actualData = actualData;
            device.settingsReport = settingsReport;

            Assert.AreEqual(device.GetBoilerState(), BoilerStates.CannotRun);

        }
        [TestMethod]
        public void FlexDownTest()
        {
            var device = new RestoreAPiFunctions();
            var actualData = new RestoreDataObject();
            var settingsReport = new RestoreSettingsReport();

            actualData.TempHigh1 = 8000;
            actualData.TempHigh2 = 8000;
            actualData.State = BoilerState.HeatingElement;
            settingsReport.Value = 850;
            device.actualData = actualData;
            device.settingsReport = settingsReport;

            Assert.AreEqual(device.GetBoilerState(), BoilerStates.FlexDown);

        }

        [TestMethod]
        public void _FlexUpStateTesT()
        {
            var device = new RestoreAPiFunctions();
            var actualData = new RestoreDataObject();
            var settingsReport = new RestoreSettingsReport();

            actualData.TempHigh1 = 8000;
            actualData.TempHigh2 = 8000;
            actualData.State = BoilerState.Unknown;
            settingsReport.Value = 850;
            device.actualData = actualData;
            device.settingsReport = settingsReport;

            Assert.AreEqual(device._GetBoilerState(), BoilerStates.FlexUp);

        }
        [TestMethod]
        public void _MustRunStateTesT()
        {
            var device = new RestoreAPiFunctions();
            var actualData = new RestoreDataObject();
            var settingsReport = new RestoreSettingsReport();

            actualData.TempHigh1 = 8000;
            actualData.TempHigh2 = 8000;
            actualData.State = BoilerState.Unknown;
            settingsReport.Value = 750;
            device.actualData = actualData;
            device.settingsReport = settingsReport;

            Assert.AreEqual(device._GetBoilerState(), BoilerStates.MustRun);

        }
        [TestMethod]
        public void _CannotRunTest()
        {
            var device = new RestoreAPiFunctions();
            var actualData = new RestoreDataObject();
            var settingsReport = new RestoreSettingsReport();

            actualData.TempHigh1 = 8001;
            actualData.TempHigh2 = 8001;
            actualData.State = BoilerState.HeatingElement;
            settingsReport.Value = 700;
            device.actualData = actualData;
            device.settingsReport = settingsReport;
            Assert.AreEqual(device._GetBoilerState(), BoilerStates.CannotRun);
        }
        [TestMethod]
        public void _FlexDownTest()
        {
            var device = new RestoreAPiFunctions();
            var actualData = new RestoreDataObject();
            var settingsReport = new RestoreSettingsReport();

            actualData.TempHigh1 = 8001;
            actualData.TempHigh2 = 8000;
            actualData.State = BoilerState.HeatingElement;
            settingsReport.Value = 850;
            device.actualData = actualData;
            device.settingsReport = settingsReport;

            Assert.AreEqual(device._GetBoilerState(), BoilerStates.FlexDown);
        }
    }
}
