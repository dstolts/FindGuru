using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit; //"Package Requirement Octokit [Install-Package Octokit] Added package 'Octokit.0.26.0' to 'packages.config' Successfully installed 'Octokit 0.26.0'"

namespace FindGuru
{
    class Program
    {
        
        static void Main(string[] args)
        {
            String SearchTerm;
            Console.Clear();
            DateTime dat = DateTime.Now;
            Console.WriteLine("\nToday is {0:d} at {0:T}.", dat);
            Console.Write("\nEneter Search Term and press ENTER to continue... ");
            SearchTerm = Console.ReadLine();
            Console.WriteLine(SearchTerm);
            //var client = new Octokit.GitHubClient(new ProductHeaderValue("GuruFind"));
            //      var user = await github.User.Get("half-ogre");
            //      Console.WriteLine(user.Followers + " folks love the half ogre!");


            Console.Write("\nPress ENTER to continue... ");
            Console.ReadLine();

        }
    }
}
