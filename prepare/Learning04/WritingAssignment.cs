public class WritingAssignment : Assignment
{
    private string _title;
    
    //Notice that the WritingAssignment constructorhas 3 parametersand then
    //it passes 2 of them directly to the base constructor which is assignment class constructor

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        //here we set any variable specific to the WritingAssignment class
        _title = title;
    }

    public string GetWritingInformation()
    {
        //Notice that we are calling the gettervhere because_studentName is private in the base class
        string studentName = GetStudentName();
        
        return $"{_title} by {studentName}";
    }
}