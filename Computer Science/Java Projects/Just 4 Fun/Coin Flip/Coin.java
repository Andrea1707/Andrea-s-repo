/**
 * coin
 */

import java.util.Random;
public class Coin {
    public Coin(){

    }
    public boolean flip(){
        Random rd = new Random(); // creating Random object'''
        return rd.nextBoolean();
        
    }

    
    
}