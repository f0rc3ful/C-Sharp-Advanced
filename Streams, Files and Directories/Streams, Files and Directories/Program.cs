namespace OddLines 
{ public class OddLines 
    { 
        static void Main() 
        { 
            string inputFilePath = @"..\..\..\Streams, Files and Directories\input.txt"; string outputFilePath = @"..\..\..\Streams, Files and Directories\output.txt"; 
            ExtractOddLines(inputFilePath, outputFilePath); 
        } 
        public static void ExtractOddLines(string inputFilePath, string outputFilePath) 
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int lineNumber = 0;
                    while (!reader.EndOfStream)
                    {
                        lineNumber++;
                        string line = reader.ReadLine();
                        if (lineNumber % 2 == 1)
                        {
                            continue;
                        }
                        writer.WriteLine(line);
                    }
                }
            }

            
        }
    }
}
