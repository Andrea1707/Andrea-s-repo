<!DOCTYPE html>
<html></html>
  <head>
    <title>simpleCart</title>
    <link href="//netdna.bootstrapcdn.com/twitter-bootstrap/2.2.0/css/bootstrap-combined.min.css" rel="stylesheet">
    <link rel="stylesheet" href="style.css">
  </head>
  
  <body>
  <div class="container"><div class="row">
  <div class="span6">
  
    
    <ul class="products">
        <?php  
        $my_database_txt = 'Macchine.txt';  
        $array_righi = file($my_database_txt);  
        foreach($array_righi as $key => $macchine){  
            list($tipo, $prezzo,$foto) = explode("|", $macchine);  
            echo '
            <li class="simpleCart_shelfItem product">
              <p class="item_name">'.$tipo.'</p>
              <img src="'.$foto.'"></img>
              <br> <span class="item_price">$'.$prezzo.'</span>
              <a href="javascript:;" class="item_add">Add to Cart</a> <br><br>
              </li>
            ';
        }
            ?>
    </ul>

    <hr>
    
  </div>
  
  
  <div class="span6">
  
  	<div class="product-Info">
      <span class="simpleCart_quantity"></span> items 
      <a href="#myModal" role="button" class="product-view" data-toggle="modal">View</a>
    </div>
       
    <div id="myModal" class="modal hide fade">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
        <h3><span class="simpleCart_quantity"></span> items</h3>
      </div>
      <div class="modal-body">
        <div class="simpleCart_items"></div>
    
        <hr>
        <div class="left"><strong>Items: </strong><span class="simpleCart_quantity"></span></div>
				<div class="right"><strong>Total: </strong><span class="simpleCart_total"></span></div>
      </div>
      <div class="modal-footer">
        <a href="javascript:;" class="simpleCart_empty">Empty</a>
        <a href="javascript:;" class="simpleCart_checkout">Checkout</a>
      </div>
    </div>
    
    

    <div class="product-total">
    
      <p><b>Items:</b> <span class="simpleCart_quantity"></span></p>
      
      
      <p><b>Total:</b> <span class="simpleCart_total"></span></p>
      
      
      <p><b>Tax rate:</b> <span class="simpleCart_taxRate"></span></p>
      
      
      <p><b>Tax:</b> <span class="simpleCart_tax"></span></p>
      
      
      <p><b>Final price:</b> <span class="simpleCart_grandTotal"></span> </p>
      
      
    </div>
  </div>
    
  </div></div>
  

    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script src="//netdna.bootstrapcdn.com/twitter-bootstrap/2.2.0/js/bootstrap.min.js"></script>
    <script src="simplecart.js"></script>
    <script src="script.js"></script>
  </body>

</html>