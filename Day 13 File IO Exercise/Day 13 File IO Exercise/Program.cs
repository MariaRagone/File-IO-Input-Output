
//where file is located
using Day_13_File_IO_Exercise;

string filePath = "../../../Students.txt";

//check to see if the file doesn't exist

if (File.Exists(filePath) == false) //can make this into a method
{
    StreamWriter tempWriter = new StreamWriter(filePath);
    tempWriter.WriteLine("Justin Jones|26|10");
    tempWriter.WriteLine("Ethan Tomas|21|12");
    tempWriter.WriteLine("Maria Ragone|30|11");
    tempWriter.Close();
}


//Read the file and fill the list

StreamReader reader = new StreamReader(filePath);
List<Student> allStudents = new List<Student>();
while (true)
{
    string line = reader.ReadLine();
    if (line == null)
    {
        break;
    }
    else
    {
        //split by: name|age|grade
        string[] parts = line.Split('|');
        //parts[0] = name
        //parts[1} = age
        //parts[2] = grade
        Student s = new Student(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
        allStudents.Add(s);
    }
}
reader.Close();

//display all students, main code

foreach(Student s in allStudents)
{
    Console.WriteLine(String.Format("{0,30}: {1,15}, {2,5}", s.Name, s.Grade, s.Age));
}

//add another student (pretend these are validated)
Console.WriteLine("Enter new student's name");
string name = Console.ReadLine();
Console.WriteLine("Enter age");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Enter grade");
int grade = int.Parse(Console.ReadLine());
Student newStu = new Student(name, age, grade);

allStudents.Add(newStu);


//Update the text file with list updates
StreamWriter writer = new StreamWriter(filePath);//this overwrites
foreach(Student stu in allStudents)
{
    writer.WriteLine($"{stu.Name}|{stu.Age}|{stu.Grade}");
}
writer.Close();