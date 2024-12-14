using System.Text.Json;
using System.Text.Json.Serialization;

class Student
{
	[JsonInclude]
	public string name = "";

	[JsonInclude]
	public int age = 0;

	[JsonInclude]
	public List<string> subjects = new List<string>();


	public Student() { }
	public Student( string NAME, int AGE, List<string> SUBJECTS )
	{
		name = NAME;
		age = AGE;
		subjects = SUBJECTS;
	}
}
class pr4
{
	public static void Main()
	{
		string fileName = "students.json";
		List<Student> studentsForJson = new List<Student>();
		studentsForJson.Add( new Student( "Adolf Gaga", 32, new List<string> { "Arts", "Hello world" } ) );
		studentsForJson.Add( new Student( "Adolf Gaga", 32, new List<string> { "Arts", "Hello world" } ) );
		studentsForJson.Add( new Student( "Adolf Gaga", 32, new List<string> { "Arts", "Hello world" } ) );

		string jsonFromStudents = JsonSerializer.Serialize( studentsForJson );

		File.WriteAllText( fileName, jsonFromStudents );


		string jsonFromFile = File.ReadAllText( fileName );

		List<Student> studentsFromJson = JsonSerializer.Deserialize<List<Student>>( jsonFromFile );

		foreach ( Student i in studentsFromJson )
		{
			Console.WriteLine( i.name );
		}
	}
}