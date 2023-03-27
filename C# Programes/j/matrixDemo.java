import java.util.*;
class matrixDemo{
	public static void main(String[] args){
		int[][] val1=new int[2][2];
		int[][] val2=new int[2][2];
		int[][] val3=new int[2][2];
		
		System.out.println("Enter First Matrix :");
		Scanner sc=new Scanner(System.in);
		for(int i=0;i<val1.length;i++){
			for(int j=0;j<val1[i].length;j++){
					val1[i][j]=sc.nextInt();
			}
		}
		
		System.out.println("Enter Second Matrix :");

		for(int i=0;i<val2.length;i++){
			for(int j=0;j<val2[i].length;j++){
					val2[i][j]=sc.nextInt();
			}
		}
		System.out.println("    matrix A :");
		for(int i=0;i<val1.length;i++){
			for(int j=0;j<val1[i].length;j++){
					System.out.print(val1[i][j]+"     ");
			}
			System.out.println();
			System.out.println();
		}
		System.out.println("    matrix B :");
		for(int i=0;i<val2.length;i++){
			for(int j=0;j<val2[i].length;j++){
					System.out.print(val2[i][j]+"     ");
			}
			System.out.println();
			System.out.println();
		}
		
		for(int i=0;i<val1.length;i++){
			for(int j=0;j<val1[i].length;j++){
				val3[i][j]=val1[i][j]+val2[i][j];
			}
		}
		
		System.out.println("    Total A + B :");
		for(int i=0;i<val1.length;i++){
			for(int j=0;j<val1[i].length;j++){
					System.out.print(val3[i][j]+"     ");
			}
			System.out.println();
		}
		
	}
}