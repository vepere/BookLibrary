using BookLibraryApi.Drivers;
using BookLibraryApi.Models;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BookLibraryApi.StepDefinitions
{
    [Binding]
    public class BookLibraryStepDefinitions
    {
        public HttpClientHelper? ClientHelper;
        public ApiResponse? ApiResponse;
        private string BookLibraryBaseUrl;
        private string CreateUserUrl;
        private string LoginUrl;
        private string BooksUrl;
        private string? AuthToken;
        private static IConfiguration _config;
        private AuthorModel _author;
        private int savedBookId;

        [BeforeScenario]
        public void CreateConfig()
        {
            if (_config == null)
            {
                _config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional:false, reloadOnChange: true)
                    .Build();
            }

            BookLibraryBaseUrl = _config.GetSection("BookLibraryBaseUrl").Value;
            CreateUserUrl = _config.GetSection("CreateUserUrl").Value;
            LoginUrl = _config.GetSection("LoginUrl").Value;
            BooksUrl = _config.GetSection("BooksUrl").Value;
            AuthToken = null;
        }

        [Given(@"User is created with the following fields:")]
        public async Task GivenUserIsCreatedWithTheFollowingFields(Table table)
        {
            var credentials = table.CreateInstance<AuthenticationModel>();
            var clientHelper = new HttpClientHelper();
            var payload = JsonConvert.SerializeObject(credentials);

            ApiResponse = await clientHelper.PostApiResponseAsync($"{BookLibraryBaseUrl}{CreateUserUrl}", payload);
        }

        [Given(@"User is logged in")]
        public async Task GivenUserIsLoggedInWithEmailAddressAndPassword(Table table)
        {
            var loginCredentials = table.CreateInstance<LoginCredentialsModel>();
            var clientHelper = new HttpClientHelper();
            var payload = JsonConvert.SerializeObject(loginCredentials);

            ApiResponse = await clientHelper.PostApiResponseAsync($"{BookLibraryBaseUrl}{LoginUrl}", payload);

            var responseData = (JObject)JsonConvert.DeserializeObject(ApiResponse.JsonResponse);
            AuthToken = responseData.SelectToken("token").Value<string>();

            responseData.Should().NotBeNullOrEmpty();

        }

        [Given(@"The Author")]
        public void GivenTheAuthor(Table table)
        {
            _author = table.CreateInstance<AuthorModel>();
        }

        [When(@"I post a book")]
        public async Task WhenIPostABook(Table table)
        {
            var books = table.CreateInstance<BooksModel>();
            books = new BooksModel
            {
                Title = books.Title,
                Author = new AuthorModel
                {
                    FirstName = _author.FirstName,
                    LastName = _author.LastName,
                    DateOfBirth = _author.DateOfBirth
                },
                Publisher = books.Publisher,
                ReleaseDate = books.ReleaseDate

            };

            var clientHelper = new HttpClientHelper();
            var payload = JsonConvert.SerializeObject(books);

            ApiResponse = await clientHelper.PostApiResponseAsync($"{BookLibraryBaseUrl}{BooksUrl}", payload, AuthToken);
        }

        [When(@"I update a book")]
        public async Task WhenIUpdateABook(Table table)
        {
            var updatePayload = table.CreateInstance<BookToUpdateModel>();
            updatePayload = new UpdateBookModel 
            {
                BookToUpdate = new BookToUpdateModel 
                {
                    Id = savedBookId,
                    Title = updatePayload.Title,
                    Publisher = updatePayload.Publisher,
                    ReleaseDate = updatePayload.ReleaseDate
                }
            };

            var clientHelper = new HttpClientHelper();
            var payload = JsonConvert.SerializeObject(updatePayload);

            ApiResponse = await clientHelper.PutApiResponseAsync($"{BookLibraryBaseUrl}{BooksUrl}", payload, AuthToken);
        }

        [When(@"I update a book without authToken")]
        public async Task WhenIUpdateABookWithoutAuthToken(Table table)
        {
            var updatePayload = table.CreateInstance<BookToUpdateModel>();
            updatePayload = new UpdateBookModel
            {
                BookToUpdate = new BookToUpdateModel
                {
                    Id = savedBookId,
                    Title = updatePayload.Title,
                    Publisher = updatePayload.Publisher,
                    ReleaseDate = updatePayload.ReleaseDate
                }
            };

            var clientHelper = new HttpClientHelper();
            var payload = JsonConvert.SerializeObject(updatePayload);

            ApiResponse = await clientHelper.PutApiResponseAsync($"{BookLibraryBaseUrl}{BooksUrl}", payload);
        }

        [When(@"I post a book without author")]
        public async Task WhenIPostABookWithoutAuthor(Table table)
        {
            var books = table.CreateInstance<BooksModel>();
            var clientHelper = new HttpClientHelper();
            var payload = JsonConvert.SerializeObject(books);

            ApiResponse = await clientHelper.PostApiResponseAsync($"{BookLibraryBaseUrl}{BooksUrl}", payload, AuthToken);
        }

        [When(@"I delete the book by the book id")]
        public async Task WhenIDeleteTheBookByTheBookId()
        {
            var clientHelper = new HttpClientHelper();
            var bookId = savedBookId;

            ApiResponse = await clientHelper.DeleteApiReseponseAsync($"{BookLibraryBaseUrl}{BooksUrl}?BookId={bookId}", AuthToken);
        }

        [Then(@"Verify The book is saved and status code received is (.*)")]
        public void ThenVerifyTheBookIsSavedAndStatusCodeReceived(int statusCode)
        {
            var responseData = (JObject)JsonConvert.DeserializeObject(ApiResponse.JsonResponse);

            responseData.Should().NotBeNullOrEmpty();
            ApiResponse.StatusCode.Should().Be(statusCode);
            ApiResponse.StatusMessage.Should().Be("OK");
        }

        [Then(@"Save the Book Id")]
        public void ThenSaveTheBookId()
        {
            var responseData = (JObject)JsonConvert.DeserializeObject(ApiResponse.JsonResponse);
            savedBookId = responseData.SelectToken("bookId").Value<int>();
        }

        [Then(@"Create Random Book Id")]
        public void ThenCreateRandomBookId()
        {
            var responseData = (JObject)JsonConvert.DeserializeObject(ApiResponse.JsonResponse);
            savedBookId = responseData.SelectToken("bookId").Value<int>();
            savedBookId += new Random().Next();
        }

        [Then(@"Verify the book was deleted")]
        public void ThenVerifyTheStatusCodeIs()
        {
            ApiResponse.StatusCode.Should().Be(200); // should be 204
            ApiResponse.JsonResponse.Should().Be("Book deleted successfully");
        }

        [Then(@"Verify the book was not deleted")]
        public void ThenVerifyTheBookWasNotDeleted()
        {
            ApiResponse.StatusCode.Should().Be(200); // should be 204 or 404
            ApiResponse.JsonResponse.Should().Contain("Something went wrong deleting book with id:");
        }


        [Then(@"The book can be retrieved successfully by First Name: (.*) and Last Name: (.*)")]
        public async Task ThenTheBookCanBeRetrivedByNames(string authorFirstName, string authorLastName)
        {
            var clientHelper = new HttpClientHelper();

            ApiResponse = await clientHelper.GetApiResponseAsync($"{BookLibraryBaseUrl}{BooksUrl}?AuthorFirstName={authorFirstName}&AuthorLastName={authorLastName}&PageNumber=16", AuthToken);
        }

        [Then(@"The book can be retrieved successfully by bookId")]
        public async Task ThenTheBookCanBeRetrievedSuccessfullyByBookId()
        {
            var clientHelper = new HttpClientHelper();

            ApiResponse = await clientHelper.GetApiResponseAsync($"{BookLibraryBaseUrl}{BooksUrl}/{savedBookId}", AuthToken);
        }

        [Then(@"The book can be retrieved successfully by firstname: (.*)")]
        public async Task ThenTheBookCanBeRetrievedSuccessfullyByFirstName(string authorFirstName)
        {
            var clientHelper = new HttpClientHelper();

            ApiResponse = await clientHelper.GetApiResponseAsync($"{BookLibraryBaseUrl}{BooksUrl}?AuthorFirstName={authorFirstName}", AuthToken);
        }

        [Then(@"Verify book data is returned correctly")]
        public void ThenVerifyBookDataIsReturnedCorrectly()
        {
            var responseData = (JObject)JsonConvert.DeserializeObject(ApiResponse.JsonResponse);

            responseData.Should().NotBeNullOrEmpty();
            ApiResponse.StatusCode.Should().Be(200);
            ApiResponse.StatusMessage.Should().Be("OK");
            ApiResponse.JsonResponse.Should().Contain($"{savedBookId}");
        }

        [Then(@"Verify book data is not returned")]
        public void ThenVerifyBookDataIsNotReturned()
        {
            ApiResponse.StatusCode.Should().Be(400);
        }

        [Then(@"Verify The book is not saved and status code received is (.*)")]
        public void ThenVerifyTheBookIsNotSavedAndStatusCodeReceived(int statusCode)
        {
            ApiResponse.StatusCode.Should().Be(statusCode);
            ApiResponse.StatusMessage.Should().Be("InternalServerError");
        }

        [Then(@"Verify The book is not and status code received is (.*)")]
        public void ThenVerifyTheBookIsNotAndStatusCodeReceivedIs(int statusCode)
        {
            ApiResponse.StatusCode.Should().Be(statusCode);
            ApiResponse.StatusMessage.Should().Be("BadRequest");
        }

        [Then(@"I verify the book is updated")]
        public void ThenIVerifyTheBookIsUpdated()
        {
            ApiResponse.JsonResponse.Should().Be($"Book with id:{savedBookId} was successfully updated ");
        }

        [Then(@"Verify the book is not updated")]
        public void ThenVerifyTheBookIsNotUpdated()
        {
            ApiResponse.StatusCode.Should().Be(401);
            ApiResponse.StatusMessage.Should().Be("Unauthorized");
        }
    }
}