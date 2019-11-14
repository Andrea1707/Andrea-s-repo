<?php
require 'header.php';
 ?>

 <main>
   <div class="">
     <section>
       <h1 class="register">Signup form:</h1>
       <?php
       if (isset($_GET['error'])) {
         if ($_GET['error']=='emptyfields') {
           echo '<p class="error">Fill in all fields!</p>';
         }
         elseif ($_GET['error']=='invalidmailuid') {
           echo '<p class="error">Invalid username and e-mail!</p>';
         }
         elseif ($_GET['error']=='invaliduid') {
           echo '<p class="error">Invalid username!</p>';
         }
         elseif ($_GET['error']=='invalidmail') {
           echo '<p class="error">Invalid e-mail!</p>';
         }
         elseif ($_GET['error']=='passwordcheck') {
           echo '<p class="error">Your passwords do not march!</p>';
         }elseif ($_GET['error']=='usertaken') {
           echo '<p class="error">Username is already token!</p>';
         }elseif ($_GET['signup'] == 'success' ) {
           echo '<p class="true">Signup successful!</p>';
       }
       }
       ?>
      <form class="register" action="includes/signup.inc.php" method="post">
         <input type="text" name="uid" placeholder="Username">
         <input type="text" name="mail" placeholder="E-mail">
         <input type="text" name="fiv" placeholder="Card number">
         <input type="password" name="pwd" placeholder="Password">
         <input type="password" name="pwd-repeat" placeholder="Repeat password">
         <button type="submit" name="signup-submit">Signup</button>
       </form>
    </section>
   </div>
 </main>

 <?php
 require 'footer.php';
 ?>
