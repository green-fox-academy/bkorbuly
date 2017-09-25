using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02_BlogPost
{
    public class BlogIt
        {
            string AuthorName;
            string Title;
            string Text;
            string PublicationDate;

            public BlogIt(string Authorname, string Title, string Text, string PublicationDate)
            {
                this.AuthorName = Authorname;
                this.Title = Title;
                this.Text = Text;
                this.PublicationDate = PublicationDate;

            Console.WriteLine("{1}\n{0}\n{2}\n{3}\n\n", Authorname, Title, Text, PublicationDate);
            }
        }
}
