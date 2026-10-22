namespace TextFileProcessoer;

public abstract class TextProcessor {

    public static void Run<T>(string fileName) where T: TextProcessor, new() {
        var self = new T();
        self.Process(fileName);
    }

    private void Process(string fileName) {
        Initializer(fileName);
        var lines = File.ReadLines(fileName);
        foreach (var line in lines) {
            Execute(line);
        }
        Terminate();
    }
    protected virtual void Initializer(string fname) { }
    protected virtual void Execute(string line) { }
    protected virtual void Terminate() { }
}
