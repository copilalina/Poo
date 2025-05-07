List<Student> student = new List<Student>();
Student s1 = new Student("Copil", "Alina", 010, 3);
Student s2 = new Student("Ciuculescu", "Denisa", 111, 3);
Disciplina d1 = new Disciplina("Mate", 123);
Disciplina d2 = new Disciplina("Romana", 235);
s1.AddMaterii(d1);
s2.AddMaterii(d2);
s1.PrintMaterii();
s2.PrintMaterii();