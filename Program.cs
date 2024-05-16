using Amor.Entities;
namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();
            
                
            Console.Write("Enter file full path:");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string [] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        LogRecord record = new LogRecord(name, instant);
                        set.Add(new LogRecord(name, instant));
                        Console.WriteLine(record);
                    }

                    Console.WriteLine($"Total users: {set.Count}");
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine(e);
                
            }
        }
    }
}

