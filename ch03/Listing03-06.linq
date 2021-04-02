<Query Kind="Program" />

void Main()
{
	string[] animals = new string[] { "Koala", "Kangaroo", "Spider", "Wombat", "Snake", "Emu", "Shark", "String-Ray", "Jellyfish" };
	
	var q = animals.Where((a, index) => index % 2 == 0);
	
	foreach(string s in q){
		Console.WriteLine(s);
	}
}