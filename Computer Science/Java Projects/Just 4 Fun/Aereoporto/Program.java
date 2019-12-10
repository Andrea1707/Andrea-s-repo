/**
 * Program
 */
public class Program {

    public static void main(String[] args) {
        Aereo aereo1 = new Aereo( " Sto cazzo", "pene", 69) ;
        Volo [] a = new Volo [2] ;
        a[0]=new Volo(956 ,aereo1, 20 , 23 , " 9 dicembre 2019" ) ;
        a [1] = new Volo ( 988, aereo1, 10 , 12, " 28 gennaio 2020" );
        
        for ( int i= 0 ; i<a.length ; i++){
            a[i].scrivoInfo();
        }
        
    }
}