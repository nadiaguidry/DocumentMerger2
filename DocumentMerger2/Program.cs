using System;
using System.IO;

namespace DocumentMerger
{
    class Merger
    {
        static void Main(string[] args)

        {

            if (args.Length < 3)
            {
            Console.WriteLine("DocumentMerger2 <input_file_1> <input_file_2> ... <input_file_n> <output_file>")
            Console.WriteLine("Supply a list of text files to merge followed by the name of the resulting merged text file as command line arguments.")
            }

            var doLoop = true;

            Console.WriteLine("Document Merger\n");

            string file;
            Console.Write("Please enter the name of the text file you'd like to merge: ");
            file = Console.ReadLine();
            Console.WriteLine("You entered '{0}'", file);


            while (doLoop)

            {
                if (File.Exists(file))
                {
                    Console.WriteLine("{0} is verified in the directory", file);
                    doLoop = false;
                }

                else
                {
                    Console.WriteLine("Error. The text file is not verified in the directory.");
                    Console.Write("Please enter the name of the text file: ");
                    file = Console.ReadLine();
                    Console.WriteLine("You entered '{0}'", file);
                }


                doLoop = !File.Exists(file);
            }

            string document;
            Console.Write("Please enter the name of the second text file you'd like to merge: ");
            document = Console.ReadLine();
            Console.WriteLine("You entered '{0}'", document);

            while (doLoop)

            {
                if (File.Exists(document))
                {
                    Console.WriteLine("{0} is verified in the directory", document);
                    doLoop = false;
                }

                else
                {
                    Console.WriteLine("Error. The document is not verified in the directory.");
                    Console.Write("Please enter the name of the second document: ");
                    file = Console.ReadLine();
                    Console.WriteLine("You entered '{0}'", document);
                }


                doLoop = !File.Exists(document);
            }

            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(file + ".txt");
                streamWriter.WriteLine(file);
                streamWriter.Close();
                Console.WriteLine("{0} was successfully saved. The document contains {1} characters. ", file, file.Length);
                Console.WriteLine("{0} and {1} are placeholders for the filename of the document and the number of characters it contains.", file, file.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            try
            {
                streamWriter = new StreamWriter(document + ".txt");
                streamWriter.WriteLine(document);
                streamWriter.Close();
                Console.WriteLine("{0} was successfully saved. The document contains {1} characters. ", document, document.Length);
                Console.WriteLine("{0} and {1} are placeholders for the filename of the document and the number of characters it contains.", document, document.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            string merge;
            Console.Write("Would you like to merge two more files?: y/n ");
            merge = Console.ReadLine();
            Console.WriteLine("You entered '{0}'", merge);



            try
            {

            }

            catch
            {

            }

            finally
            {
                if (file != null || document != null)
                {
                    if (streamWriter != null)
                    {
                        streamWriter.Close();
                    }

                }

            }

        }
    }
}

