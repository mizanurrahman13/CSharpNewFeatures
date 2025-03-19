using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;

namespace CSharp09;

/// <summary>
/// 1. Records

//A record in C# is a special type whose primary role is storing data.

//Its 2 main characteristics are:

//1. Value equality - this means that two records are equal if the types match and all property values match.
//2. Immutability - this prevents you from changing any property value after it's instantiated.

//Therefore, records are a good option when creating Data Transfer Objects (DTOs) in your app.
/// </summary>
/// <param name="Id"></param>
/// <param name="Name"></param>
/// <param name="Description"></param>
/// <param name="DefaultCapacity"></param>

public record ClassResponse(long Id, string Name, string Description, int DefaultCapacity);

public record CreateClassRequest(string Name, string Description, int DefaultCapacity);

public record UpdateClassRequest(string Name, string Description, int DefaultCapacity);
