using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class Repository
    {
        // Initialise a new list for guest responses
        private static List<GuestResponse> responses = new List<GuestResponse>();
        
        public static IEnumerable<GuestResponse> Responses => responses;

        //Method for adding a response to the GuestResponse list
        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}
