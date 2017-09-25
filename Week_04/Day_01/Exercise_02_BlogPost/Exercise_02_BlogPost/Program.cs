using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02_BlogPost
{
    
    class Program
    {
        static void Main(string[] args)
        {
            BlogIt blog1 = new BlogIt("John Doe", "Lorensum", "Lorem ipsum dolor sit amet.", "2000.05.04.");
            BlogIt blog2 = new BlogIt("Tim Urban", "Wait but why", "A popular long-form, stick-figure-illustrated blog about almost everything.", "2010.10.10.");
            BlogIt blog3 = new BlogIt("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump", "A popular long-form, stick-figure-illustrated blog about almost everything.Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.", "2017.03.28.");
            Console.ReadLine();
        }
    }
}
