// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;
using System.Security.Claims;

Console.WriteLine("Hello, World!");

ClassRoom classRoom = new ClassRoom();
classRoom.ClassName = "3Q";
classRoom.SemesterStart = new DateTime(2019,8,11);
classRoom.StudentList.Add(new Student("Mathias",8,11));
classRoom.StudentList.Add(new Student("Sebastian", 4, 5));

Console.WriteLine(classRoom);