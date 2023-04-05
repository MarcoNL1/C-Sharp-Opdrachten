public class Person{

    public readonly string Name;
    protected int Age;

    public Person(string name, int age){

        Name = name;
        Age = age;
    }

    public void GrowOlder(){

        Age += 1;
    }

    public override string ToString(){

        return base.ToString();
    }
}