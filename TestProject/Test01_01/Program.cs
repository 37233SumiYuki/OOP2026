namespace Test01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var score = new ScoreCounter("StudentScore.csv");
            var totalBySubject = score.GetPerSubjectScore();
            foreach (var obj in totalBySubject)
            {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }

            //実行結果
            //英語 520
            //数学 550
            //国語 500
        }
    }
}
