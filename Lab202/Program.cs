using System;

namespace Lab202
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* Testing the Course class */
            
			Course cpe200 = new Course ("Object-Oriented Programming", "261300");
			Course isne103 = new Course ("Programming Language for ISNE", "269103", "DOME");
			Course cpe453 = new Course ("DIP", "261105", "Dr. Kenneth Cosh", 60);

			Console.WriteLine ("\n--- Initial Courses state ---");
			Console.WriteLine (cpe200);
			Console.WriteLine (isne103);
			Console.WriteLine (cpe453);

			/* playing with cpe200 object */
			Console.WriteLine ("\n--- playing with cpe200 object ---");
            cpe200.setCourseID("261200");
			Console.WriteLine (cpe200);
			cpe200.setCourseID("261200");
			cpe200.setCourseID("2612002");

			cpe200.setNumStudents(40);
			Console.WriteLine (cpe200);
			cpe200.setMaxStudents(60);
			Console.WriteLine (cpe200);
			cpe200.setNumStudents(40);
			Console.WriteLine (cpe200);
			cpe200.setMaxStudents(35);
			cpe200.setMaxStudents(40);
			Console.WriteLine (cpe200);

			/* playing with cpe453 object */
			Console.WriteLine ("\n--- playing with cpe453 object ---");
			cpe453.setName("Digital Image Processing");
			cpe453.setCourseID("261453");
			cpe453.setLecturer("Sansanee");
			cpe453.setMaxStudents(20);
			Console.WriteLine (cpe453);

		}
	}
}
