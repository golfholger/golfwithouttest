using System;
using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    public class MyStep
    {
        private readonly TrackerDriver _driver;

        public MyStep(TrackerDriver driver)
        {
            _driver = driver;
        }

        [Then(@"do it")]
        public void doTheStep()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
