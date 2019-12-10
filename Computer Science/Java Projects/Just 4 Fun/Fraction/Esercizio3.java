import java.util.Scanner;


/**
 * Main
 */
public class Esercizio3 {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);                                                           //Inizializzo l'oggetto scanner per gli input

        System.out.println("Inserisci il numeratore: ");                                                    //Prendo in input i valori
		    int a=scanner.nextInt();
	    System.out.println("Inserisci il denominatore: ");
		    int b=scanner.nextInt();
    	System.out.println("Inserisci l'esponente: ");
            int c=scanner.nextInt();
        scanner.close();                                                                                    //Per buona norma si chiude lo scanner dopo che si usa
          
        
        Frazione fraz = new Frazione(a, b);                                                                 // Creo l'oggetto Frazione
        System.out.print("Il valore e': "+ Frazione.StampaFrazione(fraz));                                  //Stampo la frazione senza andare a capo
        fraz.ElevaFrazione(c);                                                                              //Elevo la frazione all'esponente inserito
        System.out.println(" L'esponente e': " + c + " Il risultato e': "+ Frazione.StampaFrazione(fraz));  //Completo la stampa del risultato con esponente e frazione elevata



    }
}


/**
 * Creo la classe Frazione
 */
class Frazione {
    int numeratore ;
    int denominatore ;
    Frazione(int a, int b){                                                                                 //Costruttore dell'oggetto aka "La cosa che crea la frazione"
        numeratore=a;
        denominatore=b;
    }
    public void ElevaFrazione( double esponente){                                                           //Metodo della Frazione che eleva
        denominatore=(int)Math.pow(denominatore, esponente);                                                // Utilizzo Math.pow(double numero, double esponente) metodo che eleva un numero restituisce un numero DOUBLE
        numeratore=(int)Math.pow(numeratore, esponente);                                                    // (int)Math.pow(ect.) si chiama CAST coinsiste nel "Convertire il risultato da double in int"
        
    }
    public static String StampaFrazione(Frazione a){                                                        // Stampa l'oggetto Frazione
        String res= a.numeratore + "/" + a.denominatore;
        return res;
    }
}