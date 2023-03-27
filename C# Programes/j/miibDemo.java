class miibDemo
{
    //multiple instence initization block
    {
        System.out.println("iib block 1");
    }
    {
        System.out.println("iib block 2");
    }
    miibDemo()
    {
        System.out.println("constructor called");
    }
    {
        System.out.println("iib block 3");
    }
    public static void main(String[] args)
    {
        miibDemo a=new miibDemo();
    }
}