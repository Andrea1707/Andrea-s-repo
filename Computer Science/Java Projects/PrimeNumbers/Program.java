import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Program
 */
public class Program {

    public static boolean isPrime(int n) { 
        boolean res = true; 
        if (n <= 1) {  
            res = false;  
        }  
        for (int i = 2; i <= Math.sqrt(n); i++) {  
            if (n % i == 0) {  
                res = false;  
            }  
        }  
        return res;  
    }   

    public static void main(String[] args) {
        
        List<Integer> list = new ArrayList<>();
        Scanner scanner = new Scanner(System.in);

        System.out.print("Select the end number: ");
        int index = scanner.nextInt();
        scanner.close();


    for(int i = 0; i<index; i++){
        if (isPrime(i+1))
            list.add(i+1);
    }
    
    System.out.print("Prime numbers: ");
    
    for (Integer integer : list) {
        System.out.print(integer+ " " );
    }

    System.out.println("\nSize of the list: "+list.size());
    
        

    }
}