import java.util.*;

/**
 * Rettangolo
 */
public class Rettangolo {
            int base, altezza;

    public void CreaRettangolo(int MaxBase,int MaxAltezza) {
        Random rand = new Random();
        base= rand.nextInt(MaxBase);
        altezza = rand.nextInt(MaxAltezza);
    }
    public void StampaRettangolo(Rettangolo a){
        System.out.print("Rettangolo: ");
        System.out.println("La base e': "+ a.base);
        System.out.println("La altezza e': "+ a.altezza);

    }
    
}