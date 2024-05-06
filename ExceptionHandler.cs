using System;

namespace CSharpConcepts
{
    public class ExceptionHandler
    {
        /*while writing exceptions, more specific exceptions should be
         *caught first
         *supertype  for eg. ArgumentException cannot come after
         *Exception supertype and will throw error because previous catch
         *clause already catches all exceptions of this type or
         *of a super type
        */
        public static void HandleExceptions(Action codeToExcecute)
        {
            try
            {
                codeToExcecute.Invoke();
            }
            catch (IndexOutOfRangeException ex)
            {
                HandleIndexOutOfRangeException(ex);
            }
            catch (ArgumentException ex)
            {
                HandleArgumentException(ex);
            }
            catch (Exception ex)
            {
                HandleGeneralException(ex);
            }
            
            //may or may not have finally
            //but try must have either catch or finally
            //also finally should not have return statement 
            //else it will throw compile time error
            //finally is especially for cleanup purpose
        }

        private static void HandleIndexOutOfRangeException(IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Index out of range error: {ex.Message}");
            Console.WriteLine($"Helplink: {ex.HelpLink}");
            Console.WriteLine($"Source: {ex.Source}");
            Console.WriteLine($"Target Site: {ex.TargetSite}");
            Console.WriteLine($"Stack trace: {ex.StackTrace}");
            Console.WriteLine($"Inner exception: {ex.InnerException}");
        }

        private static void HandleArgumentException(ArgumentException ex)
        {
            Console.WriteLine($"Argument exception error: {ex.Message}");
        }

        private static void HandleGeneralException(Exception ex)
        {
            Console.WriteLine($"An error occured: {ex.Message}");
        }

        //public void TryCatchButWithUnreachableCode()
        //{
        //    try
        //    {
        //        throw new SystemException();
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    catch(ArgumentException e)
        //    {

        //    }
        //}
    }
}
