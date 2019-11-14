import java.util.Scanner;

/**
 * sum
 */
public class sum {

    public static void main(String[] args) {
        //Scanner
        Scanner myObj= new Scanner(System.in);
        
        System.out.println("Inserisci il primo numero: ");
        int a=myObj.nextInt();

        System.out.println("Inserisci il secondo numero:");
        int b=myObj.nextInt();
        
        myObj.close();

        int c=a+b;
        System.out.println("La loro somma e': " + c);
    }
}