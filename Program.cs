//Using Abstract Classes.
//You can force a class to override a method by declaring the base class’s method as abstract.
//Whenever a method is declared as abstract, the class must also be declared as abstract.
using System;

namespace InheritAbstract
{
	//Because the Person class now has an abstract method, the class itself must be declared as abstract.
	//An abstract class cannot be used to create an object.
	abstract class Person
	{
		protected string firstName;
		protected string LastName;
		
		public Person()
		{
		}
		
		public Person(string fn, string ln)
		{
			firstName = fn;
			LastName = ln;
		}
		
		// Below this displayFullName method is declared as abstract. 
		// This indicates that the method will be implemented in a derived class. Therefore, there is no body for the method.
		
		public abstract void displayFullName();
	}
		
	class Employee : Person
	{
		public ushort hireYear;
			
		public Employee() : base()
		{
		}
			
		public Employee(string fn, string ln, ushort hy) : base(fn, ln)
		{
			hireYear = hy;
		}
			
		public override void displayFullName()
		{
			Console.WriteLine("Employee: {0} {1}", firstName, LastName); 
		}
	}
		
	//New class derived from Person class.
	class Contractor : Person
	{
		public string company;
			
		public Contractor() : base()
		{
		}
			
		public Contractor(string fn, string ln, string c) : base(fn, ln)
		{
			company = c;
		}
			
		public override void displayFullName()
		{
			Console.WriteLine("Contractor: {0} {1}", firstName, LastName);
		}	
	}
		
	class NameApp
	{
		public static void Main()
		{
			//An abstract class cannot be used to create an object.
			Person me = new Employee("Michael", "Lawrence", 2016);
			Person worker = new Contractor("Mike", "Lawrence", "SkyNet"); 
				
			//Mike.displayFullName();
			me.displayFullName();
			worker.displayFullName();
			
			Console.ReadKey(true);
		}
	}
}
//The complier ensures that your base class abstract methods are overridden correctly.