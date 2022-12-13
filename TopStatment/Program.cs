using System;

Random random = new();
string abj = "abcdefghijklmnopqrstuvwxyz";
Customer cus = new();
cus.Id = (int)random.Next(0, abj.Length - 1);
cus.Name = abj[random.Next(0, abj.Length - 1)].ToString();
cus.Sound("hmmmmmmm. I am jhon doe");

interface ISound<T>
{
    string Sound(T sound);
}

class Person : ISound<string>
{
    public string Name { get; set; }

    public string Sound(string sound)
    {
        return sound;
    }
}
class Customer : Person
{
    public int Id { get; set; }
}
