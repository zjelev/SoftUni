using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace StreamsFilesDirs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Path.DirectorySeparatorChar);
            //var path = Path.Combine("data", "input.txt");
            //var dest = Path.Combine("data", "output.txt");
            
            //1
            /*
            using (FileStream file = new FileStream(path, FileMode.Open))
            {
                using (TextReader text = new StreamReader(file))
                {
                    using (FileStream destFile = new FileStream(dest, FileMode.Create))
                    {
                        using (TextWriter writer = new StreamWriter(destFile))
                        {
                            Console.WriteLine(file.CanRead);
                            string line = string.Empty;
                            int lineNumber = 0;
                            while ((line = text.ReadLine()) != null)
                            {
                                if (lineNumber % 2 == 1)
                                {
                                    writer.WriteLine(line);
                                }
                                
                                lineNumber++;
                            }
                        }
                    }
                }
            }
            */
            //2
            /*
            var lines = File.ReadAllLines(path);
            int counter = 1;

            var output = new string[lines.Length];
            foreach (var line in lines)
            {
                output[counter - 1] = $"{counter}. {line}";
                counter++;
            }
            File.WriteAllLines(dest, output);
            */

            //3 Directories
            /*
            var files = Directory.GetFiles("f:\\Movies");
            double size = 0;

            foreach (var file in files)
            {
                var info = new FileInfo(file);
                size += info.Length;
            }

            Console.WriteLine($"Directory size is {size / 1024 / 1024} MB");
            */

            /*
            string input = "text.txt";
            string output = "output.txt";

            using StreamReader streamReader = new StreamReader(input); //ne se nalaga da zatwarqme resursite
            //{
                using StreamWriter streamWriter = new StreamWriter(output);
                //{
                    string line;
                    int counter = 0;

                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (counter++ % 2 == 0)
                        {
                            string[] lineArr = line
                            .Split(new string[] {" "}, 
                            StringSplitOptions.RemoveEmptyEntries);

                            string result = string.Join(" ", lineArr.Reverse())
                            .Replace('-', '@')
                            .Replace(',', '@')
                            .Replace('.', '@')
                            .Replace('!', '@')
                            .Replace('?', '@');

                            streamWriter.WriteLine(result);
                        }
                    }
                //}*
            //}
            */
            //2-Exercise
            /*
            string[] lines = File.ReadAllLines("text.txt");
            int counter = 1;
            List<string> resLines = new List<string>();

            foreach (var line in lines)
            {
            int lettersCount = 0;
            int punctuationCount = 0;
                foreach (var c in line)
                {
                    if (char.IsPunctuation(c))
                    {
                        punctuationCount++;
                    }
                    else if (char.IsLetter(c))
                    {
                        lettersCount++;
                    }
                }
                resLines.Add(($"Line {counter}: {line} ({lettersCount})({punctuationCount})"));
            }

            File.WriteAllLines("output2.txt", resLines);
            */

            //4
            /*
            string[] words = File.ReadAllLines("words.txt");
            string[] lines = File.ReadAllLines("text.txt");

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                wordsCount.Add(word.ToLower(), 0);
            }

            foreach (var line in lines)
            {
                string[] textLine = line
                .ToLower()
                .Split(new char[] {' ', '-', '.', ',', '!', '?', '\''});

                foreach (var word in textLine)
                {
                    if (wordsCount.ContainsKey(word))
                    {
                        wordsCount[word]++;
                    }
                }
            }

            wordsCount.OrderByDescending(x => x.Value)
            .ToDictionary(x => x.Key, y => y.Value);

            StringBuilder sb = new StringBuilder();

            foreach ((string word, int count) in wordsCount)
            {
                sb.AppendLine($"{word} - {count}");
            }

            File.WriteAllText("actualResults.txt", sb.ToString());
            */

            //4
            /*
            using FileStream readFS = new FileStream("copyMe.png", FileMode.Open);
            using FileStream writeFS = new FileStream("sofUniLogo.png", FileMode.Create);
            byte[] buffer = new byte[4096]; 
            
            while (readFS.CanRead )
            {
                int counter = readFS.Read(buffer, 0, buffer.Length);

                if (counter == 0)
                {
                    break;
                }
                writeFS.Write(buffer);
            }
            */
            
            //5
            /*
            string searchExtension = ".";
            string path = "./";

            Dictionary<string, Dictionary<string, double>> fileExtensions = new Dictionary<string, Dictionary<string, double>>(); 
            string[] filenames = Directory.GetFiles(path, $"*{searchExtension}*");

            foreach (var filePath in filenames)
            {
                FileInfo fileInfo = new FileInfo(filePath);
                string extension = fileInfo.Extension;
                string fileName = fileInfo.Name;
                double lenght = fileInfo.Length / 1024.0;

                if (!fileExtensions.ContainsKey(extension))
                {
                    fileExtensions.Add(extension, new Dictionary<string, double>());
                }

                fileExtensions[extension].Add(fileName, lenght);
            }

            StringBuilder sb = new StringBuilder();

            foreach ((string extension, Dictionary<string, double> filesData) in fileExtensions.OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key))
            {
                sb.AppendLine(extension);

                foreach ((string fileName, double fileLenght) in filesData.OrderBy(x => x.Value))
                {
                    sb.AppendLine($"--{fileName} - {fileLenght:f3}kB");
                }
            }

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string resultPath = Path.Combine(desktopPath, "report.txt");
            File.WriteAllText(resultPath, sb.ToString());
            */

            //6
            string file = "copyMe.png";
            //ZipFile.CreateFromDirectory("./", "../myZip.zip");
            using ZipArchive zipArchive = ZipFile.Open("../myZip.zip", ZipArchiveMode.Create);
            zipArchive.CreateEntryFromFile(file, file);
            ZipFile.ExtractToDirectory(file, "unzipped");
        }
    } 
}