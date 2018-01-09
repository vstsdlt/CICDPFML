using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbehave; //Allows use of Xbehave
using PFML.BusinessLogic.Sample.ExampleScreen; //Pulls class of method to be tested

namespace PFML.UnitTest.TestScripts.ExampleScreen.ExampleScreenLogic
{
    class Search
    {
        //Tests positive path of the 'Search' method
        public void Positive(string sourceType, string sourceName, string targetType, string targetName, string accessType)
        {
            //Arrange
            "Given the string sourceType is a"
                .x(() => sourceType = "a");

            "And the string sourceName is b"
                .x(() => sourceName = "b");

            "And the string targetType is c"
                .x(() => targetType = "c");

            "And the string targetName is d"
                .x(() => targetName = "d");

            "And the string accessType is e"
                .x(() => accessType = "e");

            //Act
            "When I search for a List of SecurityPermissionDto"
                .x(() => )

            //Assert

        }
    }
}
