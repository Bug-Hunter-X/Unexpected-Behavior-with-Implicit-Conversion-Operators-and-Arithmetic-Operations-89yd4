public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass obj)
    {
        return obj.MyProperty;
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value);
    }

    public static MyClass operator +(MyClass a, int b)
    {
        return new MyClass(a.MyProperty + b);
    }
    public static MyClass operator +(MyClass a, MyClass b)
    {
        return new MyClass(a.MyProperty + b.MyProperty);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 10; 
        int value1 = obj1;   
        Console.WriteLine(value1); 

        MyClass obj2 = new MyClass(20);
        MyClass value2 = obj2 + 5; // Correct handling of MyClass + int
        Console.WriteLine(value2.MyProperty); // Output: 25
        MyClass obj3 = new MyClass(20);
        MyClass value3 = obj3 + obj2; //Correct handling of MyClass + MyClass
        Console.WriteLine(value3.MyProperty); // Output: 40
    }
}