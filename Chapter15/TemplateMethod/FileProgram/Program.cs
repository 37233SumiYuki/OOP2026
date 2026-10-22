using TextFileProcessoer;

Console.Write("カウントしたい単語：");
WordCounterProcessor.Word = Console.ReadLine();

string path = @"C:\Users\infosys\source\repos\OOP2026\Chapter15\TemplateMethod\FileProgram\Program.cs";

TextProcessor.Run<WordCounterProcessor>(path);

public class WordCounterProcessor : TextProcessor {

    public static string Word { get; set; } = "";

    private int _count = 0;

    protected override void Initializer(string fname) {
        _count = 0;
    }

    protected override void Execute(string line) {
        int index = 0;

        while ((index = line.IndexOf(Word, index)) != -1) {
            _count++;
            index += Word.Length;
        }
    }

    protected override void Terminate() {
        Console.WriteLine($"「{Word}」は{_count}つ出現します。");
    }
}