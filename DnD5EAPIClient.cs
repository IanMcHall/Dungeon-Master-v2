using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster
{
    public class DnD5eAPIClient
    {
        public interface IDnD5eAPI
        {
            // The [Get] attribute marks this method as a GET request
            // The "users" is a relative path the a base URL, which we'll provide later
            // "{userId}" is a placeholder in the URL: the value from the "userId" method parameter is used
            [Get("classes")]
            Task<DnDResult<DnD5EClass>> GetClassesAsync();

            [Get("alignments")]
            Task<DnDResult<DnD5EAlignments>> GetAlignmentsAsync();

            [Get("races")]
            Task<DnDResult<DnD5ERaces>> GetRacesAsync();
           

        }

        public static IDnD5eAPI Client()=> RestClient.For<IDnD5eAPI>("https://www.dnd5eapi.co/api");
        

    }
}
