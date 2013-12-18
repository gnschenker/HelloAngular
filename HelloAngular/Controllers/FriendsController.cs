using HelloAngular.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace HelloAngular.Controllers
{
    public class FriendsController : ApiController
    {
        public IEnumerable<Friend> Get()
        {
            return new [] { 
                new Friend{FirstName = "John", LastName = "Doe"},
                new Friend{FirstName = "Ann", LastName = "Wellington"},
                new Friend{FirstName = "Sabrina", LastName = "Burke"},
            };
        }
    }
}