using Spectre.Console;
using flashcards.Models;

namespace flashcards.Utils
{
    public class SpectreTable
    {
        public static void StackTable(IEnumerable<Stacks> stackData)
        {
            var table = new Table();

            table.AddColumn("Id");
            table.AddColumn("Name");

            foreach (var stack in stackData)
            {
                table.AddRow(
                    stack.Id.ToString(),
                    stack.LanguageName
                );
            }
            AnsiConsole.Write(table);
        }

        public static void FlashcardsTable()
        {

        }

        public static void FlashcardsFrontTable()
        {

        }

        public static void StudyTable()
        {

        }
    }
}