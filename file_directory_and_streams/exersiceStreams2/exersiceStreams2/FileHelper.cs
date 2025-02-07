namespace exersiceStreams2;

public static class FileHelper
{
    public static bool ExecuteWithHandling(Action action)
    {
        try
        {
            action();
            return true;

        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return false;
    }

    public static T? ExecuteWithHandling<T>(Func<T> func)
    {
        try
        {
            return func();
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return default;
    }
}