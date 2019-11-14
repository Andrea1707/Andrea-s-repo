import java.util.Scanner;

/**
 * coin_flip
 */
public class coin_flip {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        Coin coin = new Coin();
        boolean result[]=new boolean[30];
        int scelta, n_testa = 0, n_croce = 0;

        do{
        System.out.println("Inserisci il numero di volte che vuoi flippare la moneta (MAX 30):");
        scelta=scanner.nextInt();
        
        }while(scelta>=30);
        scanner.close();

        for(int i=0; i<scelta; i++)
        {
            result[i]=coin.flip();
        }

        System.out.println("\n\n\nRisultati:");
        for(int i=0; i<scelta; i++)
        {
            if( result[i] == true ) {
            System.out.println( ( i + 1 ) + ". Testa" );
            n_testa++;
            }
            if( result[i] == false ) {
            System.out.println( ( i + 1 ) + ". Croce" );
            n_croce++;
            }
        }
        
        System.out.println("\n\n\nNumero volte testa: " + n_testa); 
        System.out.println("\n\n\nNumero volte croce croce: " + n_croce);
           
        

       
        
        
    }
}