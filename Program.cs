using flashcards.Controllers;
using flashcards.Repositories;
using flashcards.Services;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the DatabaseManager class with the connection string
        var databaseManager = new DatabaseManager();

        try
        {
            // Call the CreateTables method to set up the database schema
            databaseManager.CreateTables();
        }
        catch (Exception ex)
        {
            // Basic exception handling to log any errors that occur
            Console.WriteLine($"An error occurred while creating tables: {ex.Message}");
        }

        //insert flashcards data for tests
        // var insertData = new InsertData();
        // insertData.InsertFlashcardsData();

        new GetUserInput().MainMenu();

    }
}
