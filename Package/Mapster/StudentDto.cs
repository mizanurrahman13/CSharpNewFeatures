namespace Mapster;

public class StudentDto
{
    public int StudentId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email {  get; set; } = string.Empty;
}

public class StudentEntity
{
    public int StudentId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}

public class Solution
{
    //public class StudentEntity MapStudentDtotoEntity(StudentDto studentDto)
    //{
    //    var entity = studentDto.Adapt<StudentEntity>();
    //}
}


