import java.util.Random;

/**
 * ArrayFuncions
 */
public class ArrayFunctions {
    public static int[] arrayIntRandom(int dimArray, int valoreMax){
        int [] res= new int [dimArray];
        Random rd = new Random();
        for(int i=0; i< res.length;i++){
            res[i]=rd.nextInt(valoreMax);
        }
        return res;
    }

    
    public static int[] reverse(int[] a){
        int [] res = new int [a.length];
        int k=0;
        for (int i=(a.length-1);i>=0;i--){
            res[k]=a[i];
            k++;
        }
        return res;
    }

    public static int[] maxPosizioni(int[] a, int[] b){
        int [] res;
        if(a.length>=b.length)
            res = new int[a.length];
        else
            res = new int[b.length];
        for (int i=0; i< res.length; i++ ){
            if(a[i]>=b[i])
                res[i]=a[i];
            else
                res[i]=b[i];
        }
        return res;
    }

    public static String toString(int[] a, String separatore){
        String res="[";

        for(int i=0; i<a.length;i++){
            if(i!=(a.length-1))
                res+=Integer.toString(a[i]) + separatore;
            else
                res+=Integer.toString(a[i]);
        }
        res+="]";
        return res;
    }
    
}