// 3 different things required to make a file
//file path

string filePath = "../../../file1.txt"; // the ../ moves back one path

//check to see if the file exists
//can be used for a lit of things
if (File.Exists(filePath) == false)
{
    StreamWriter tempWriter = new StreamWriter(filePath);
    tempWriter.WriteLine("This is temp.");
    tempWriter.Close();
}


//write to a file
StreamWriter writer = new StreamWriter(filePath);
writer.WriteLine("Hello"); //opens a process in the background, stays open
writer.WriteLine("Hola");
writer.WriteLine("Ciao");
writer.WriteLine(Console.ReadLine());
writer.Close(); //until you close it


//read
StreamReader reader = new StreamReader(filePath);
//reads one line at a time, needs to loop until there is an empty line

while (true)
{
    string line = reader.ReadLine();
    if (line == null)
    {
        break;
    }
    else
    {
        Console.WriteLine(line);
    }
}
reader.Close(); //you have to close it 