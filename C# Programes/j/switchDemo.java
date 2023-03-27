class switchDemo
{
    public static void main(String[] args) 
    {        
        int i=2;
        switch(i)
        {
            case 0:
            System.out.println("i am in 0 case");
            break;

            case 1:
            System.out.println("i am in 1 case");
            break;

            case 2:
            System.out.println("i am in 2 case");
            break;

            case 3:
            System.out.println("i am in 3 case");
            break;

            default:
            System.out.println("i am indefault");
            break;
        } 
        System.out.println("i am out of switch");
    }
}