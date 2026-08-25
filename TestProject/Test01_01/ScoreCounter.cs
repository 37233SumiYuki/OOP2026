namespace Test01_01
{
    public class ScoreCounter
    {
        private IEnumerable<Student> _score;

        public ScoreCounter(string filePath)
        {
            _score = ReadScore(filePath);
        }

        private static IEnumerable<Student> ReadScore(string filePath)
        {
            var list = new List<Student>();
            var lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                var items = line.Split(',');

                var student = new Student
                {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };

                list.Add(student);
            }

            return list;
        }

        public IDictionary<string, int> GetPerSubjectScore()
        {
            var dict = new Dictionary<string, int>();

            foreach (var s in _score)
            {
                if (dict.ContainsKey(s.Subject))
                    dict[s.Subject] += s.Score;
                else
                    dict[s.Subject] = s.Score;
            }

            return dict;
        }
    }
}
