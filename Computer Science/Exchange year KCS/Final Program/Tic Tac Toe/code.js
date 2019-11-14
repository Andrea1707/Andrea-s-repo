var p1Name;
var p2Name;
var res1;
var res2;
var p1Score = 0;
var p2Score = 0;
var turn = 0;
var color=rgb(255,241,208);   
var color2=rgb(6,174,213);
var result = false;
var account=false;
function sleep(milliseconds) {
  var start = new Date().getTime();
  for (var i = 0; i < 1e7; i++) {
    if ((new Date().getTime() - start) > milliseconds){
      break;
    }
  }
}
onEvent("logout","click",function(){
  account=false
  p1Name=null;
  setProperty("play_local","hidden",false);
  setScreen("Instructions");
  setText("label4","Hi, login for save your score.");
  setText("play","Login!");
});
onEvent("score_button","click",function(){
  setScreen("score_screen");
});
onEvent("back_button2","click",function(){
  setScreen("Instructions");
});
onEvent("back_button","click",function(){
  setScreen("Instructions");
});
onEvent("change","click",function(){
  var OldPassword=getText("OldPassword");
  var NewPassword=getText("NewPassword");
  if(OldPassword.length==0||NewPassword.length==0){
    setText("label_response1","Please fill Old & New Password!");
  } else {
    readRecords("Users",{username:p1Name,password:OldPassword},function(password){
      console.log(password);
      if(password.length>0){
        
        setText("label_response1","Password changed!");
        setText("NewPassword","");
        setText("OldPassword","");
      }else{
        setText("NewPassword","");
        setText("OldPassword","");
        setText("label_response1","Wrong Password!");
      }
    });
  }
});
onEvent("option","click",function(){
  if(account==true){
    setScreen("Options");
  }else{
    setScreen("login");
  }
});
onEvent("play","click",function(){
  if(account==false){
  setScreen("login");
  }else{
  do{
  p2Name=prompt("Second player name:");
  }while(p2Name == null || p2Name == "" );
  setScreen("MainGame");
  res1 = p1Name.substring(0, 3);
  res2 = p2Name.substring(0, 3);
  setText("p1Score",res1);
  setText("p2Score",res2);
  setScreen("MainGame");
  }
});
onEvent("signup","click",function(){
  var username1=getText("username");
  var password1=getText("password");
  if(username1.length==0||password1.length==0){
  setText("label_response","Please fill username & Password!");
  } else {
    readRecords("Users",{username:username1},function(records){
     if(records.length>0){
       console.log(records)
       setText("label_response","Username already exist!");
       setText("password","");
     }else{
     createRecord("Users",{username:username1,password:password1,win:0,loss:0},function(){
       setText("label_response","User created!");
       setText("username","");
       setText("password","");
       setText("label_response","");
     });
      }
    });
  }
});
onEvent("login_button","click",function(){
  var username1=getText("username");
  var password1=getText("password");
  if(username1.length==0||password1.length==0){
  setText("label_response","Please fill username & Password!");
  } else { readRecords("Users",{username:username1,password:password1},function(user){
    if(user.length>0){
       setText("label_response","Login succesfull! Wait 3 seconds.");
       account=true;
       sleep(3000);
       setProperty("play_local","hidden",true);
       setScreen("Instructions");
       p1Name=username1;
       setText("label4","Welcome back "+p1Name);
       setText("username","");
       setText("password","");
       setText("label_response","");
       setText("play","Play!");
    }else{
       setText("label_response","Login failed!");
    }
  });
  }
});
onEvent("play_local", "click", function(){
  do{
  p1Name=prompt("First player name:");
  }while(p1Name == null || p1Name == "" );
  do{
  p2Name=prompt("Second player name:");
  }while(p2Name == null || p2Name == "" );
  setScreen("MainGame");
  res1 = p1Name.substring(0, 3);
  res2 = p2Name.substring(0, 3);
  setText("p1Score",res1);
  setText("p2Score",res2);
});
resetBoard();
function resetScore(){
  p1Score = 0;
  p2Score = 0;
  setText("score1",p1Score);      //reset score//
  setText("score2",p2Score);
  setText("roundWinner", "");
  result = false;
}
function resetBoard(){
  setText("b1","");
  setText("b2","");
  setText("b3","");
  setText("b4","");
  setText("b5","");
  setText("b6","");
  setText("b7","");
  setText("b8","");
  setText("b9","");
  setProperty("b1", "background-color", color2);      // reset noard//
  setProperty("b2", "background-color", color2);
  setProperty("b3", "background-color", color2);
  setProperty("b4", "background-color", color2);
  setProperty("b5", "background-color", color2);
  setProperty("b6", "background-color", color2);
  setProperty("b7", "background-color", color2);
  setProperty("b8", "background-color", color2);
  setProperty("b9", "background-color", color2);
  turn = 0;
  setText("roundWinner", "");
  result = false;
}
function isPlayed(text){
  if(text==""){
    console.log("not played");
    return true;
  }
  else{
    console.log("played");
    return false;
  }
}
function threeInARow(){
  if(getText("b1")==getText("b2")&&getText("b2")==getText("b3")&&getText("b1")!==""){
    result = true;
  }
  else if(getText("b4")==getText("b5")&&getText("b5")==getText("b6")&&getText("b4")!==""){
    result = true;
  }
  else if(getText("b7")==getText("b8")&&getText("b8")==getText("b9")&&getText("b7")!==""){
    result = true;
  }
  else if(getText("b1")==getText("b4")&&getText("b4")==getText("b7")&&getText("b1")!==""){
    result = true;
  }
  else if(getText("b2")==getText("b5")&&getText("b5")==getText("b8")&&getText("b2")!==""){
    result = true;
  }
  else if(getText("b3")==getText("b6")&&getText("b6")==getText("b9")&&getText("b3")!==""){
    result = true;
  }
  else if(getText("b1")==getText("b5")&&getText("b5")==getText("b9")&&getText("b1")!==""){
    result = true;
  }
  else if(getText("b3")==getText("b5")&&getText("b5")==getText("b7")&&getText("b3")!==""){
    result = true;
  }
  return result;
}
function game(){
  if(threeInARow()){
    console.log("win");
    if(turn%2==1){
      p1Score++;
      setText("score1",p1Score);
      setText("roundWinner", "Winner is: ",p1Name);
      sleep(500);
      setText("roundWinner",p1Name);
      sleep(3000);
      resetBoard();
    }
    else{
      p2Score++;
      setText("score2",p2Score);
      setText("roundWinner", "Winner is: ");
      sleep(500);
      setText("roundWinner",p2Name);
      sleep(3000);
      resetBoard();
    }
  }
  else if(turn==9){
    console.log("tie");
    setText("roundWinner", "Tie wait 2 sec");
    sleep(2000);
    resetBoard();
  }
  win();
}
onEvent("b1", "click", function(event) {
  if(result==false){
    setProperty("b1", "background-color", color);
    if(isPlayed(getText("b1"))&&!threeInARow()){
      if(turn%2==1){
        setText("b1","X");
        turn++;
      }else{
        setText("b1","O");
        turn++;
      }
      game();
    }
  }
  console.log("b1 clicked!");
});
onEvent("b2", "click", function(event) {
  if(result==false){
    setProperty("b2", "background-color", color);
    if(isPlayed(getText("b2"))&&!threeInARow()){
      if(turn%2==1){
        setText("b2","X");
        turn++;
     }else{
        setText("b2","O");
        turn++;
      }
      game();
    }
  }
  console.log("b2 clicked!");
});
onEvent("b3", "click", function(event) {
  if(result==false){
    setProperty("b3", "background-color", color);
    if(isPlayed(getText("b3"))&&!threeInARow()){
     if(turn%2==1){
        setText("b3","X");
        turn++;
      }else{
        setText("b3","O");
        turn++;
      }
    game();
    }
  }
  console.log("b3 clicked!");
});
onEvent("b4", "click", function(event) {
  if(result==false){
    setProperty("b4", "background-color", color);
    if(isPlayed(getText("b4"))&&!threeInARow()){
      if(turn%2==1){
        setText("b4","X");
        turn++;
      }else{
        setText("b4","O");
        turn++;
      }
      game();
    }
  }
  console.log("b4 clicked!");
});
onEvent("b5", "click", function(event) {
   if(result==false){
    setProperty("b5", "background-color", color);
    if(isPlayed(getText("b5"))&&!threeInARow()){
      if(turn%2==1){
        setText("b5","X");
        turn++;
      }else{
        setText("b5","O");
        turn++;
      }
      game();
    }
  }
  console.log("b5 clicked!");
});
onEvent("b6", "click", function(event) {
   if(result==false){
    setProperty("b6", "background-color", color);
    if(isPlayed(getText("b6"))&&!threeInARow()){
      if(turn%2==1){
        setText("b6","X");
        turn++;
      }else{
        setText("b6","O");
        turn++;
      }
      game();
    }
  }
  console.log("b5 clicked!");
});
onEvent("b7", "click", function(event) {
  if(result==false){
    setProperty("b7", "background-color", color);
    if(isPlayed(getText("b7"))&&!threeInARow()){
      if(turn%2==1){
        setText("b7","X");
        turn++;
      }else{
        setText("b7","O");
        turn++;
      }
      game();
    }
  }
  console.log("b7 clicked!");
});
onEvent("b8", "click", function(event) {
  if(result==false){
    setProperty("b8", "background-color", color);
    if(isPlayed(getText("b8"))&&!threeInARow()){
      if(turn%2==1){
        setText("b8","X");
        turn++;
      }else{
        setText("b8","O");
        turn++;
      }
      game();
    }
  }
  console.log("b8 clicked!");
});
onEvent("b9", "click", function(event) {
  if(result==false){
    setProperty("b9", "background-color", color);
    if(isPlayed(getText("b9"))&&!threeInARow()){
      if(turn%2==1){
        setText("b9","X");
        turn++;
      }else{
        setText("b9","O");
        turn++;
      }
      game();
    }
  }
  console.log("b9 clicked!");
});
function win(){
if(p1Score == 3){
  setScreen("Winner");
  setText("winnerLabel", p1Name);
  resetBoard();
  if(account==true){

  }
  resetScore();
  sleep(4000);
  setScreen("Instructions");
}
else if(p2Score == 3){
  setScreen("Winner");
  setText("winnerLabel", p2Name);
  resetBoard();
  resetScore();
  sleep(4000);
  setScreen("Instructions");
}
  }
onEvent("replay", "click", function(){
  setScreen("MainGame");
}); 