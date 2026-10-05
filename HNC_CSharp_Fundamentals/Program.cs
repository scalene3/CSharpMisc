

string? studentName;
string? courseName;
int age = 0;
bool? isFullTime = null ;

do {
    Console.WriteLine("What is your name: ");
    studentName = Console.ReadLine();
    if (studentName is null || studentName.IsWhiteSpace())
    {
        studentName = null;
        continue;
    }
    studentName = studentName.Trim();

} while (studentName is null) ;

bool parseSuccess = false;
do
{
    Console.WriteLine("What is your age: ");
    string? line = Console.ReadLine();
    if (line is null)
        continue;

    parseSuccess = int.TryParse(line, out age );
} while (!parseSuccess);

do
{
    Console.WriteLine("What is your course name: ");
    courseName = Console.ReadLine();
    if (courseName is null || courseName.IsWhiteSpace())
    {
        studentName = null;
        continue;
    }
    courseName = courseName.Trim();
} while (courseName is null);

do
{
    Console.WriteLine("Are you full time (Y/N): ");
    string? line = Console.ReadLine();
    if (line is null || line.IsWhiteSpace())
    {
        continue;
    }
    if (line[0] == 'Y')
    {
        isFullTime = true;
    }
    else if (line[0] == 'N')
    {
        isFullTime = false;
    }
        
} while (isFullTime is null);

Console.WriteLine(studentName + age + courseName + isFullTime);