using System;
using System.Collections.Generic;
using System.Text;
using Xbehave;
using Xunit;

namespace PFML.UnitTest.TestScripts.Core.Headers.AgencyLogic
{
    public class Search
    {
        public int Add(int x, int y) => x + y;
    }

    public class SampleTestWithXBehave
    {
        [Scenario]
        [Example(1, 2, 3)]
        [Example(2, 3, 6)]
        public void Addition(int x, int y, int expectedAnswer, Search calculator, int answer)
        {
            $"Given the number {x}"
                .x(() => { });

            $"And the number {y}"
                .x(() => { });

            "And a calculator"
                .x(() => calculator = new Search());

            "When I add the numbers together"
                .x(() => answer = calculator.Add(x, y));

            $"Then the answer is {answer}"
                .x(() => Assert.Equal(expectedAnswer, answer));
        }
    }
}
