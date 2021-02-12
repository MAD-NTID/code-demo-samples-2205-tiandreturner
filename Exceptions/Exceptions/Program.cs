using System;
using System.Net.Http;

namespace Exceptions
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Enter your name: ");

            // string name = Console.ReadLine();

            try
            {

                Console.Write("Enter an IP address: ");

                string ip = Console.ReadLine();
                int numDots = 0;

                foreach(char c in ip)
                {
                    if (c == '.')
                        numDots++;
                }

                if (numDots != 3)
                    throw new IPFormatException();
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine("Invalid Operation Exception caught! " + ioe.Message);

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //    int n1 = 60;
            //    int n2 = int.Parse(Console.ReadLine());
            //    int result = n1 / n2;
            //    //if (String.IsNullOrWhiteSpace(name))
            //    //    throw new Exception("Name was not entered.");
            //    //else
            //    //    Console.WriteLine("Name has been processed.");




        }

        //static async void Connect()
        //{

        //    HttpClient http = new HttpClient();

        //    // Call asynchronous network methods in a try/catch block to handle exceptions.
        //        HttpResponseMessage response = await http.GetAsync("http://gggggggggggggggggggggggg.com/");
        //        response.EnsureSuccessStatusCode();
        //        string responseBody = await response.Content.ReadAsStringAsync();
        //        // Above three lines can be replaced with new helper method below
        //        // string responseBody = await client.GetStringAsync(uri);

        //        Console.WriteLine(responseBody);
            
        //}
    }

    public class IPFormatException : FormatException
    {
        public IPFormatException() { Console.WriteLine("IP Address is not formatted correctly"); }
        public IPFormatException(string message) { Console.WriteLine(message); Console.WriteLine(base.Message); }
    }
}
