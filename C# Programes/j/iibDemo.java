class iibDemo
{
    //instence initization block
    {
        System.out.println("IIB block");
    }
    iibDemo()
    {
        System.out.println("constructor called");
    }
    public static void main(String[] args)
    {
        iibDemo A=new iibDemo();
    }
}