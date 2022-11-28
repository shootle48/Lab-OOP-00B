using Lab_OOP_00A;

Student student1 = new Student();
student1.name = "Mickey";
student1.weight = 20.8f;

Student student2 = new Student();
student2.name = "Minnie";
student2.weight = 18.2f;

Student student3 = new Student();
student3.name = "Biggie";
student3.weight = 65.4f;

Student student4 = new Student();
student4.name = "Mixie";
student4.weight = 70.2f;

Student student5 = new Student();
student5.name = "Nettie";
student5.weight = 67.8f;

float avgweight = (student1.weight + student5.weight + student3.weight + student4.weight + student5.weight) / 5;
Console.WriteLine(avgweight);