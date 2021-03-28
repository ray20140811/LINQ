<Query Kind="Program" />

void Main()
{
	var query1 = from c in Person.SampleData() 
					where c.State == "WA" 
					select new 
					{ 
						Name = c.FirstName + " " + c.LastName, State = c.State
					};
	
	foreach(var item in query1) 
	{
		Console.WriteLine("{0}, {1}", item.Name, item.State);
	}
	
	var query2 = Person.SampleData()
					.Where(c => c.State == "WA")
					.Select(c => new 
					{ 
						Name = c.FirstName + " " + c.LastName, 
						State = c.State 
					});
					
	foreach(var item in query2) 
	{
		Console.WriteLine("{0}, {1}", item.Name, item.State);
	}
}

public class Person 
{
	public string FirstName;
	public string LastName;
	public DateTime Dob;
	public string Phone;
	public string State;
	
	public static List<Person> SampleData()
	{
		return new List<Person> 
			{ 
				new Person { FirstName = "Barney", LastName = "Gottshall", Dob = new DateTime(1945, 10, 19), Phone = "885 983 8858", State = "CA" },
				new Person { FirstName = "Armando", LastName = "Valdes", Dob = new DateTime(1973, 12, 9), Phone = "848 553 8487", State = "WA" },
				new Person { FirstName = "Adam", LastName = "Gauwain", Dob = new DateTime(1959, 10, 3), Phone = "115 999 1154", State = "AK" },
				new Person { FirstName = "Jeffery", LastName = "Deane", Dob = new DateTime(1950, 12, 16), Phone = "677 602 6774", State = "CA" },
				new Person { FirstName = "Collin", LastName = "Zeeman", Dob = new DateTime(1935, 2, 10), Phone = "603 303 6030", State = "FL" },
				new Person { FirstName = "Stewart", LastName = "Kagel", Dob = new DateTime(1950, 2, 20), Phone = "546 607 5462", State = "WA" },
				new Person { FirstName = "Chance", LastName = "Lard", Dob = new DateTime(1951, 10, 21), Phone = "278 918 2789", State = "WA" },
				new Person { FirstName = "Blaine", LastName = "Reifsteck", Dob = new DateTime(1946, 5, 18), Phone = "715 920 7157", State = "TX" },
				new Person { FirstName = "Mack", LastName = "Kamph", Dob = new DateTime(1977, 9, 17), Phone = "364 202 3644", State = "TX" },
				new Person { FirstName = "Ariel", LastName = "Hazelgrove", Dob = new DateTime(1922, 5, 23), Phone = "165 737 1656", State = "OR" }
			};
	}
}
