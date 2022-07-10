﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BookLibraryApi.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("BookLibrary Api Tests")]
    public partial class BookLibraryApiTestsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "BookLibrary.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "BookLibrary Api Tests", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "username",
                        "emailAddress",
                        "password"});
            table1.AddRow(new string[] {
                        "testuser_1",
                        "testuser_1@yahoo.com",
                        "1234241412412"});
#line 4
 testRunner.Given("User is created with the following fields:", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify the POST method on the Books endpoint")]
        [NUnit.Framework.CategoryAttribute("POST")]
        public void VerifyThePOSTMethodOnTheBooksEndpoint()
        {
            string[] tagsOfScenario = new string[] {
                    "POST"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify the POST method on the Books endpoint", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 9
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "emailAddress",
                            "password"});
                table2.AddRow(new string[] {
                            "testuser_1@yahoo.com",
                            "1234241412412"});
#line 10
 testRunner.Given("User is logged in", ((string)(null)), table2, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "FirstName",
                            "LastName",
                            "DateOfBirth"});
                table3.AddRow(new string[] {
                            "Ion",
                            "Creanga",
                            "2022-07-08T11:57:36.907Z"});
#line 13
 testRunner.And("The Author", ((string)(null)), table3, "And ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Publisher",
                            "ReleaseDate"});
                table4.AddRow(new string[] {
                            "Capra cu Trei Iezi",
                            "Humanitas",
                            "1850"});
#line 16
 testRunner.When("I post a book", ((string)(null)), table4, "When ");
#line hidden
#line 19
 testRunner.Then("Verify The book is saved and status code received is 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify Posting a book without a title")]
        [NUnit.Framework.CategoryAttribute("POST")]
        public void VerifyPostingABookWithoutATitle()
        {
            string[] tagsOfScenario = new string[] {
                    "POST"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify Posting a book without a title", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 22
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "emailAddress",
                            "password"});
                table5.AddRow(new string[] {
                            "testuser_1@yahoo.com",
                            "1234241412412"});
#line 23
 testRunner.Given("User is logged in", ((string)(null)), table5, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "FirstName",
                            "LastName",
                            "DateOfBirth"});
                table6.AddRow(new string[] {
                            "Ion",
                            "Creanga",
                            "2022-07-08T11:57:36.907Z"});
#line 26
 testRunner.And("The Author", ((string)(null)), table6, "And ");
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Publisher",
                            "ReleaseDate"});
                table7.AddRow(new string[] {
                            "",
                            "Humanitas",
                            "1850"});
#line 29
 testRunner.When("I post a book", ((string)(null)), table7, "When ");
#line hidden
#line 32
 testRunner.Then("Verify The book is not and status code received is 400", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify Posting a book without an author")]
        [NUnit.Framework.CategoryAttribute("POST")]
        public void VerifyPostingABookWithoutAnAuthor()
        {
            string[] tagsOfScenario = new string[] {
                    "POST"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify Posting a book without an author", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 35
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "emailAddress",
                            "password"});
                table8.AddRow(new string[] {
                            "testuser_1@yahoo.com",
                            "1234241412412"});
#line 36
 testRunner.Given("User is logged in", ((string)(null)), table8, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Publisher",
                            "ReleaseDate"});
                table9.AddRow(new string[] {
                            "Capra cu Trei Iezi",
                            "Humanitas",
                            "1850"});
#line 39
 testRunner.When("I post a book without author", ((string)(null)), table9, "When ");
#line hidden
#line 42
 testRunner.Then("Verify The book is not saved and status code received is 500", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify a posted book can be retrieved successfully")]
        [NUnit.Framework.CategoryAttribute("GET")]
        public void VerifyAPostedBookCanBeRetrievedSuccessfully()
        {
            string[] tagsOfScenario = new string[] {
                    "GET"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify a posted book can be retrieved successfully", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 45
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "emailAddress",
                            "password"});
                table10.AddRow(new string[] {
                            "testuser_1@yahoo.com",
                            "1234241412412"});
#line 46
 testRunner.Given("User is logged in", ((string)(null)), table10, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "FirstName",
                            "LastName",
                            "DateOfBirth"});
                table11.AddRow(new string[] {
                            "Ion",
                            "Creanga",
                            "2022-07-08T11:57:36.907Z"});
#line 49
 testRunner.And("The Author", ((string)(null)), table11, "And ");
#line hidden
                TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Publisher",
                            "ReleaseDate"});
                table12.AddRow(new string[] {
                            "Capra cu Trei Iezi",
                            "Humanitas",
                            "1850"});
#line 52
 testRunner.When("I post a book", ((string)(null)), table12, "When ");
#line hidden
#line 55
 testRunner.Then("Verify The book is saved and status code received is 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 56
 testRunner.And("The book can be retrieved successfully by First Name: Ion and Last Name: Creanga", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.And("Verify book data is returned correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify a posted book can be retrieved successfully by id")]
        [NUnit.Framework.CategoryAttribute("GETbyId")]
        public void VerifyAPostedBookCanBeRetrievedSuccessfullyById()
        {
            string[] tagsOfScenario = new string[] {
                    "GETbyId"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify a posted book can be retrieved successfully by id", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 60
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                            "emailAddress",
                            "password"});
                table13.AddRow(new string[] {
                            "testuser_1@yahoo.com",
                            "1234241412412"});
#line 61
 testRunner.Given("User is logged in", ((string)(null)), table13, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                            "FirstName",
                            "LastName",
                            "DateOfBirth"});
                table14.AddRow(new string[] {
                            "Ion",
                            "Creanga",
                            "2022-07-08T11:57:36.907Z"});
#line 64
 testRunner.And("The Author", ((string)(null)), table14, "And ");
#line hidden
                TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Publisher",
                            "ReleaseDate"});
                table15.AddRow(new string[] {
                            "Capra cu Trei Iezi",
                            "Humanitas",
                            "1850"});
#line 67
 testRunner.When("I post a book", ((string)(null)), table15, "When ");
#line hidden
#line 70
 testRunner.Then("Verify The book is saved and status code received is 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.And("Save the Book Id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And("The book can be retrieved successfully by bookId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.And("Verify book data is returned correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify that posted book cannot be retrieved by first name only")]
        [NUnit.Framework.CategoryAttribute("GET")]
        public void VerifyThatPostedBookCannotBeRetrievedByFirstNameOnly()
        {
            string[] tagsOfScenario = new string[] {
                    "GET"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that posted book cannot be retrieved by first name only", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 76
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                            "emailAddress",
                            "password"});
                table16.AddRow(new string[] {
                            "testuser_1@yahoo.com",
                            "1234241412412"});
#line 77
 testRunner.Given("User is logged in", ((string)(null)), table16, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                            "FirstName",
                            "LastName",
                            "DateOfBirth"});
                table17.AddRow(new string[] {
                            "Ion",
                            "Creanga",
                            "2022-07-08T11:57:36.907Z"});
#line 80
 testRunner.And("The Author", ((string)(null)), table17, "And ");
#line hidden
                TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Publisher",
                            "ReleaseDate"});
                table18.AddRow(new string[] {
                            "Capra cu Trei Iezi",
                            "Humanitas",
                            "1850"});
#line 83
 testRunner.When("I post a book", ((string)(null)), table18, "When ");
#line hidden
#line 86
 testRunner.Then("Verify The book is saved and status code received is 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 87
 testRunner.And("The book can be retrieved successfully by firstname: Ion", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.And("Verify book data is not returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify you can successfully delete a posted book")]
        [NUnit.Framework.CategoryAttribute("DELETE")]
        public void VerifyYouCanSuccessfullyDeleteAPostedBook()
        {
            string[] tagsOfScenario = new string[] {
                    "DELETE"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify you can successfully delete a posted book", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 91
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                            "emailAddress",
                            "password"});
                table19.AddRow(new string[] {
                            "testuser_1@yahoo.com",
                            "1234241412412"});
#line 92
 testRunner.Given("User is logged in", ((string)(null)), table19, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                            "FirstName",
                            "LastName",
                            "DateOfBirth"});
                table20.AddRow(new string[] {
                            "Ion",
                            "Creanga",
                            "2022-07-08T11:57:36.907Z"});
#line 95
 testRunner.And("The Author", ((string)(null)), table20, "And ");
#line hidden
                TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Publisher",
                            "ReleaseDate"});
                table21.AddRow(new string[] {
                            "Capra cu Trei Iezi",
                            "Humanitas",
                            "1850"});
#line 98
 testRunner.When("I post a book", ((string)(null)), table21, "When ");
#line hidden
#line 101
 testRunner.Then("Verify The book is saved and status code received is 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 102
 testRunner.And("Save the Book Id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 103
 testRunner.When("I delete the book by the book id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 104
 testRunner.Then("Verify the book was deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify you cannot delete a book that doesn\'t exist")]
        [NUnit.Framework.CategoryAttribute("DELETE")]
        public void VerifyYouCannotDeleteABookThatDoesntExist()
        {
            string[] tagsOfScenario = new string[] {
                    "DELETE"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify you cannot delete a book that doesn\'t exist", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 106
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                            "emailAddress",
                            "password"});
                table22.AddRow(new string[] {
                            "testuser_1@yahoo.com",
                            "1234241412412"});
#line 107
 testRunner.Given("User is logged in", ((string)(null)), table22, "Given ");
#line hidden
#line 110
 testRunner.When("I delete the book by the book id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 111
 testRunner.Then("Verify the book was not deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify you can update a posted book")]
        [NUnit.Framework.CategoryAttribute("PUT")]
        public void VerifyYouCanUpdateAPostedBook()
        {
            string[] tagsOfScenario = new string[] {
                    "PUT"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify you can update a posted book", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 114
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                            "emailAddress",
                            "password"});
                table23.AddRow(new string[] {
                            "testuser_1@yahoo.com",
                            "1234241412412"});
#line 115
 testRunner.Given("User is logged in", ((string)(null)), table23, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                            "FirstName",
                            "LastName",
                            "DateOfBirth"});
                table24.AddRow(new string[] {
                            "Ion",
                            "Creanga",
                            "2022-07-08T11:57:36.907Z"});
#line 118
 testRunner.And("The Author", ((string)(null)), table24, "And ");
#line hidden
                TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Publisher",
                            "ReleaseDate"});
                table25.AddRow(new string[] {
                            "Capra cu Trei Iezi",
                            "Humanitas",
                            "1850"});
#line 121
 testRunner.When("I post a book", ((string)(null)), table25, "When ");
#line hidden
#line 124
 testRunner.Then("Verify The book is saved and status code received is 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 125
 testRunner.And("Save the Book Id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Publisher",
                            "ReleaseDate"});
                table26.AddRow(new string[] {
                            "UpdatedTitle",
                            "Updated Publisher",
                            "1850"});
#line 126
 testRunner.When("I update a book", ((string)(null)), table26, "When ");
#line hidden
#line 129
 testRunner.Then("I verify the book is updated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify that you cannot update a non existing book")]
        [NUnit.Framework.CategoryAttribute("PUT")]
        public void VerifyThatYouCannotUpdateANonExistingBook()
        {
            string[] tagsOfScenario = new string[] {
                    "PUT"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that you cannot update a non existing book", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 132
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                            "emailAddress",
                            "password"});
                table27.AddRow(new string[] {
                            "testuser_1@yahoo.com",
                            "1234241412412"});
#line 133
 testRunner.Given("User is logged in", ((string)(null)), table27, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                            "FirstName",
                            "LastName",
                            "DateOfBirth"});
                table28.AddRow(new string[] {
                            "Ion",
                            "Creanga",
                            "2022-07-08T11:57:36.907Z"});
#line 136
 testRunner.And("The Author", ((string)(null)), table28, "And ");
#line hidden
                TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Publisher",
                            "ReleaseDate"});
                table29.AddRow(new string[] {
                            "Capra cu Trei Iezi",
                            "Humanitas",
                            "1850"});
#line 139
 testRunner.When("I post a book", ((string)(null)), table29, "When ");
#line hidden
#line 142
 testRunner.Then("Verify The book is saved and status code received is 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 143
 testRunner.And("Save the Book Id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Publisher",
                            "ReleaseDate"});
                table30.AddRow(new string[] {
                            "UpdatedTitle",
                            "Updated Publisher",
                            "1850"});
#line 144
 testRunner.When("I update a book without authToken", ((string)(null)), table30, "When ");
#line hidden
#line 147
 testRunner.Then("Verify the book is not updated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
