using Dapper;
using Microsoft.Data.SqlClient;
using flashcards.Models;

namespace flashcards.Repositories
{
    public class UserRepository
    {
        private readonly string connectionString = "Server=localhost,1433;Database=Flashcards;User Id=sa;Password=S3cureP@ssw0rd2024#;TrustServerCertificate=true";

        public void InsertFlashcardsDataForTests(List<Flashcards> flashcardsList)
        {
            var sql = "INSERT INTO Flashcards (Front, Back, StackId) VALUES (@Front, @Back, @StackId)";

            using (var connection = new SqlConnection(connectionString))
            {
                foreach (var flashcard in flashcardsList)
                {
                    connection.Execute(sql, new { flashcard.Front, flashcard.Back, flashcard.StackId });
                }
            }
        }

        public void InsertFlashcardsData(string stackName, string front, string back)
        {
            int stackId;
            var stackIdSql = "SELECT Id FROM Stacks WHERE LanguageName = @StackName";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                stackId = connection.ExecuteScalar<int>(stackIdSql, new { StackName = stackName });
            }

            var sql = "INSERT INTO Flashcards (Front, Back, StackId) VALUES (@Front, @Back, @StackId)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(sql, new { Front = front, Back = back, StackId = stackId });
            }
        }

        public void InsertStackData(string stack)
        {
            var sql = "INSERT INTO Stacks (LanguageName) VALUES (@Stack)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(sql, new { Stack = stack });
            }
        }

        public void DeleteStackData(string stack)
        {
            var sql = "DELETE FROM Stacks WHERE LanguageName = @Stack";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(sql, new { Stack = stack });
            }
        }

        public void ViewStacksData()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var sql = "SELECT * FROM Stacks";
                var stacks = connection.Query<Stacks>(sql);

                Console.WriteLine("Id\tName");
                foreach (var stack in stacks)
                {
                    Console.WriteLine($"{stack.Id}\t{stack.LanguageName}");
                }
            }
        }

    }
}