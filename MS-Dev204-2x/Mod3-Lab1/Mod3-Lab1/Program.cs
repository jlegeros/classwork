using System;
using System.Globalization;
using System.IO;

namespace Mod3Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Creates StreamReader object called 'streamReaderObject'
            // Assigns its value to null
            StreamReader streamReaderObject = null;

            try
            {
                // Assigns streamReaderObject to read from a text file named 'file1.txt'
                streamReaderObject = new StreamReader("file1.txt");

                // Reads all characters from the current position to the end pf the stream
                // Stores in String variable 'contents'
                string contents = streamReaderObject.ReadToEnd();

                // Closes the StreadReader
                streamReaderObject.Close();

                // Writes the amount of text elements in the text file to the Console
                Console.WriteLine($"The file has {new StringInfo(contents).LengthInTextElements} text elements.");
            }
            // Code to handle any errors
            catch (FileNotFoundException)
            {
                // Informs user there is no file to read
                Console.WriteLine("The file cannot be found");
            }
            // Invoking the Dispose method in a finally block
            // note that code in finally block will always execute
            finally
            {
                // Checks if object is not null
                if (streamReaderObject != null)
                    streamReaderObject.Dispose();
            }
        }
    }
}
