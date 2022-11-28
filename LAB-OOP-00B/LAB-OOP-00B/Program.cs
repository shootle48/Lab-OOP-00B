using Lab_OOP_00A;

Student student1 = new Student();
student1.name = "Boatty";
student1.weight = 60.8f;

Student student2 = new Student();
student2.name = "Gussie";
student2.weight = 58.2f;

Student student3 = new Student();
student3.name = "Biggy";
student3.weight = 65.4f;

Student student4 = new Student();
student4.name = "Mixxie";
student4.weight = 70.2f;

Student student5 = new Student();
student5.name = "Nettie";
student5.weight = 67.8f;

float avgweight = (student1.weight + student5.weight + student3.weight + student4.weight + student5.weight) / 5;
Console.WriteLine("ค่าเฉลี่ยน้ำหนักของนักศึกษาทั้งหมด ==> "+" "+ avgweight);
Console.WriteLine("ชื่อและน้ำหนักของคนที่มีน้ำหนักมากที่สุด ==> " + " " + student4.name + " " + student4.weight);
Console.WriteLine("ชื่อและน้ำหนักของคนที่มีน้ำหนักน้อยทีสุด ==> " + " " + student2.name + " " + student2.weight);
Console.WriteLine("ชื่อ&รหัส ของผู้พัฒนาโปรแกรม ==> " + " " + "เทพฤทธิ์ อินทรประพันธ์ \n 653450091-4");
