using System;
public class Rock_Paper_Sieser {
    public static void Main(String[] args)
    {
        Random com=new Random();

        int res;

        Console.WriteLine();
        Console.WriteLine("-------Rules-------");
        Console.WriteLine("Choose One Number You Want to do");
        Console.WriteLine("0 For ROCK");
        Console.WriteLine("1 For PAPER");
        Console.WriteLine("2 For SCISSOR");
        do{

        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Enter A Number : " );
        int a= Int32.Parse(Console.ReadLine());
        Console.WriteLine("You Choosed : {0} ",a);
        
         if(a==0 || a==1 || a==2){
       
        int b=com.Next(3);
        Console.WriteLine(b);
        Console.WriteLine("Computer Choosed : {0} ",b);
        Console.WriteLine("____________________");
   
    if((a==0 && b==1) || (a==1 && b==2)|| (a==2 && b==0))
    {
       
        Console.WriteLine("Computer Wins..");
        Console.WriteLine();
    }
    else if((a==0 && b==2) || (a==1 && b==0) || (a==2 && b==1))
    {
       
        Console.WriteLine("You Wins..");
        Console.WriteLine();
    }
    else{
        Console.WriteLine("Match Tie..");
        Console.WriteLine();
    }
    
}
else
{
    Console.WriteLine("Enter A Proper Number");
}
    Console.WriteLine("Do you want to play again ");
    Console.WriteLine("press 1 to restart the game");

    res=Int32.Parse(Console.ReadLine());
        }while(res==1);
    }
    
}
