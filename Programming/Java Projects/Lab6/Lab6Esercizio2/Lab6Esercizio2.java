/**
 * Lab6Esercizio2
 */
public class Lab6Esercizio2 {

    public static void main(String[] args) {
        int [] a = ArrayFunctions.arrayIntRandom(10, 100);
        int [] b = ArrayFunctions.arrayIntRandom(10, 100);
        System.out.println("A= "+ArrayFunctions.toString(a, ","));
        System.out.println("B= "+ArrayFunctions.toString(b, ","));

        System.out.println("Reverse di A= "+ArrayFunctions.toString(ArrayFunctions.reverse(a), ","));

        System.out.println("MaxPosizioni= " + ArrayFunctions.toString(ArrayFunctions.maxPosizioni(a, b), ","));
    }
}