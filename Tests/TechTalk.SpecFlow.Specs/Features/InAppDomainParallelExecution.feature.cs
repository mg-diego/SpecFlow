﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.7.1.0
//      SpecFlow Generator Version:1.7.0.0
//      Runtime Version:4.0.30319.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace TechTalk.SpecFlow.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.7.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("In-AppDomain Parallel Execution")]
    public partial class In_AppDomainParallelExecutionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "InAppDomainParallelExecution.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "In-AppDomain Parallel Execution", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Precondition: Tests run parallel with NUnit v3")]
        public virtual void PreconditionTestsRunParallelWithNUnitV3()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Precondition: Tests run parallel with NUnit v3", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
 testRunner.Given("there is a SpecFlow project");
#line 5
 testRunner.And("the project is configured to use the NUnit3 provider");
#line hidden
#line 6
 testRunner.Given("there is a feature file in the project as", "Feature: Feature 1\nScenario Outline: Simple Scenario Outline\n     When I do somet" +
                    "hing\n\n    Examples: \n      | Count |\r\n      | 1     |\n      | 2     |\n      | 3 " +
                    "    |\n      | 4     |\n      | 5     |", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 20
 testRunner.Given("there is a feature file in the project as", "Feature: Feature 2\nScenario Outline: Simple Scenario Outline\n     When I do somet" +
                    "hing\n\n    Examples: \n      | Count |\r\n      | 1     |\n      | 2     |\n      | 3 " +
                    "    |\n      | 4     |\n      | 5     |", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 34
 testRunner.And("the following step definition", @"public static int startIndex = 0;

[When(@""I do something"")]
public void WhenIDoSomething()
{
   var currentStartIndex = System.Threading.Interlocked.Increment(ref startIndex);
   Console.WriteLine(""Start index: {0}"", currentStartIndex);
   System.Threading.Thread.Sleep(200);
   var afterStartIndex = startIndex;
   if (afterStartIndex == currentStartIndex)
       Console.WriteLine(""Was not parallel"");
   else
       Console.WriteLine(""Was parallel"");
   NUnit.Framework.Assert.AreEqual(currentStartIndex, afterStartIndex);
}", ((TechTalk.SpecFlow.Table)(null)));
#line 52
    testRunner.When("I execute the tests with NUnit3");
#line 53
    testRunner.Then("the execution log should contain text \'Was parallel\'");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#endregion
