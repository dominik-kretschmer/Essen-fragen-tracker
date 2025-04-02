Console.WriteLine("wer hat gerade nach dem essen gefragt");
var name = Console.ReadLine();

string currentTime = DateTime.Now.ToString("h:mm:ss tt");
string path = Path.Combine(Directory.GetCurrentDirectory(), "pastQuestions.csv");
string[] fragenFrager = ["ge", "tobi", "rene", "rolf", "chris"];

using (StreamWriter outputFile = new StreamWriter(path, true))
{
    outputFile.WriteLine(name + ";" + currentTime);
}

Console.WriteLine(name + " asked for food at " + currentTime);
string fileText = File.ReadAllText(path);
string[] words = fileText.Split(';');

for (int i = 0; i < fragenFrager.Length; i++)
{
    Console.WriteLine(fragenFrager[i] + ":" + countNames(fileText, fragenFrager[i]));
}

for (int i = 0; i < words.Length; i++)
{
    Console.WriteLine(words[i]);
}

 static int countNames(string text, string search_str)
 {
    return (text.Length - text.Replace(search_str, "").Length) / search_str.Length;
 }