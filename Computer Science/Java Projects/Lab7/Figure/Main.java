import java.util.*; 
public class Main
{
    public static void main(String[] args){

        Scanner scan = new Scanner(System.in);

        Rettangolo a = new Rettangolo();

        System.out.println("Max Base: ");
        int MaxBase=scan.nextInt();
        System.out.println("Max Altezza: ");
        int MaxAltezza= scan.nextInt();

        a.CreaRettangolo(MaxBase, MaxAltezza);
        
        
        scan.close();

        a.StampaRettangolo(a);
    }
}

