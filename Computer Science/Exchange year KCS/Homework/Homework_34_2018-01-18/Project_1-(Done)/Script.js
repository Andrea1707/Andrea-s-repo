function Kohdai_function() {
  var r=randomNumber(0, 254),g=randomNumber(0, 254),b=randomNumber(0, 254); //Define 3 variables for R G B color//
  penUp();
  moveForward(100);
  turnLeft(90);
  penDown();
  penColor(rgb(r, g, b));
  penWidth(1);
for (var i = 0; i < 50; i++) {
      moveForward(50);                        //Draw the star structure//
      turnRight(144);
    }
    r=0;
    g=0;                                      //Inizalize variables on 0 for have different colors//
    b=0;
}





function Kahla_Function(n) {
  for (var i = 0; i < n; i++) {               //Give a number 'n' draw different stars//
  Kohdai_function();
  }
}






function Andrea_Function() {
  do{
    var n = prompt("How many stars?\n(Number betwheen 0 and 4)", "");        //ask how many stars you want//
  }
  while(n>4||n<0);
Kahla_Function(n);

}


Andrea_Function();      //Program start//
