using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCSharp
{
    class ContentService
    {
        //public ;
        public void Publish(Content content)
        {
            try
            {
                content.Publish();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
