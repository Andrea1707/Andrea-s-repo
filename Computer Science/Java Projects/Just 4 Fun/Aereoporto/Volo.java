public class Volo {
    int numeroVolo ;
    Aereo aereo ;
    int orarioPartenza ;
    int orarioArrivo ;
    String giornoPartenza;

    Volo(){

    }
    Volo ( int a , Aereo b ,int c , int d , String e ){
        numeroVolo = a;
        aereo = b ;
        orarioPartenza = c ;
        orarioArrivo = d ;
        giornoPartenza = e ;

    } 
    public void scrivoInfo () {
         System.out.println ( " Numero Volo " +numeroVolo);
         System.out.println ( " Tipo di areo" +aereo.modello);
         System.out.println (" Orario partenza " +orarioPartenza);
        System.out.println ( " Orario arriivo " +orarioArrivo);
        System.out.println ( "Giorno partenza " +giornoPartenza + "\n\n\n\n");

        }

    }
