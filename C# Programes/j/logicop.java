class logicop
{
    public static void main(String[] args)
    {
        int a=15,b=30,c=15,d=30;
        if(a==c && b==d)
        {
            System.out.println("equle");
        }
        else if(a<b || a<c)
        {
            System.out.println("a is smaller then any other value");
        }
        else if(a!=b)
        {
            System.out.println("the value of a and b are not equale");
        }
    }
}