namespace exercise_streams_file_and_io;

public static class FileHelper
{
    public static bool ExecuteWithHandling(Action action)
    {
        try
        {
            action();
            return true;

        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e);
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return false;
    }

    public static T? ExecuteWithHandling<T>(Func<T> func)
    {
        try
        {
            return func();
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e);
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return default;
    }
}