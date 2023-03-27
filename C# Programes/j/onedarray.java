import java.util.*;
class onedarray{
	public static void main(String[] args){
		int array[]=new int[10];
		int sarch=0;
		int result=0;
		
		Scanner sc=new Scanner(System.in);
		System.out.println("Enter 10 value:");
		
		for(int i=0;i<10;i++){
			array[i]=sc.nextInt();
		}
		
		System.out.println("Enter value to search :");
		 sarch=sc.nextInt();
		
		for(int i=0;i<10;i++){
			if(array[i]==sarch){
				result=1;
			}
		}
		
		if(sarch==1){
			System.out.println("Matched");
		}
		else{
			System.out.println("not matched");
		}
		
	}
}