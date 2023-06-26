using MarsQA_1.Helpers;
using TechTalk.SpecFlow;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {

        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();
        }

        [AfterScenario]
        public void TearDown()
        {
            Close();
        }
    }
}
