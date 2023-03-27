class student
{
    int id;
    String name;
    student()
    {
        System.out.println("this is the default constructor");
    }
    student(int i,String n)
    {
        id=i;
        name=n;
    }
}
class overloadcons
{ 
    public static void main(String[] args) 
    {
        student s=new student();
        System.out.println("\n default constructor value");
        System.out.println("\n student id="+s.id+"student name="+s.name);
        System.out.println("\n parameterized constructor value");
        student s1=new student(1,"raj");
        System.out.println("\n student id="+s1.id+"student name="+s1.name);
    }  
}
