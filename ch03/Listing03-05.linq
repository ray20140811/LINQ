<Query Kind="Program" />

void Main()
{
	string[] animals = new string[] { "Koala", "Kangaroo", "Spider", "Wombat", "Snake", "Emu", "Shark", "String-Ray", "Jellyfish" };
	
	var q1 = animals.Where(
		a => a.StartsWith("S")  && a.Length > 5);
	
	q1.Dump();
	
	var q2 = from a in animals
			where IsAnimalDeadly(a)
			select a;
	
	foreach(string s in q2){
		Console.WriteLine("A {0} can be deadly.", s);
	}
}

bool IsAnimalDeadly(string s)
{
	string[] deadly = new string[] { "Spider", "Snake", "Shark", "String-Ray", "Jellyfish" };
	return deadly.Contains(s);
}


