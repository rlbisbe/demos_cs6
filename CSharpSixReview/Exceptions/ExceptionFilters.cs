using System.Web;

namespace CSharpSixReview.Exceptions
{
    class ExceptionFilters
    {
        private void WillThrowException()
        {
            throw new HttpException(412, "Precondition failed");
        }

        public void WillCatchException5()
        {
            try
            {
                WillThrowException();
            }
            catch (HttpException ex)
            {
                if (ex.ErrorCode == 412)
                {
                    System.Console.WriteLine("Deal with Precondition failed");
                }
            }
        }

        public void WillCatchException6()
        {
            try
            {
                WillThrowException();
            }
            catch (HttpException ex) if (ex.ErrorCode == 412)
            {
                System.Console.WriteLine("Deal with Precondition failed");
            }
        }
    }
}
