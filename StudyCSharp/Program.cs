using System;

namespace StudyCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Content problem = new Problem(1);
            ContentService service = new ContentService();
            service.Publish(problem);  
        }
    }
}
