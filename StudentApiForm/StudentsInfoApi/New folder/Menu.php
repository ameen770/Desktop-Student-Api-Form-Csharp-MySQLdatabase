<?php
if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','resturant');
    $Menu=$_POST['Type'];
    
    $sql="select * from `menu` where `Type` like '$Menu'";
    $query=mysqli_query($con,$sql);
    $xml = new SimpleXMLElement('<Menus/>');

    if (mysqli_num_rows($query)>0)
    {
            while($row = mysqli_fetch_assoc($query)){
            $Men = $xml->addChild('Menu');
        
            foreach ($row as $key => $value) {
            $Men->addChild($key, $value);
            }
        }
        echo $xml->asXML();
    }
    else
    {
        echo "Sorry, No food in this menu";
    }
    
}
else 
{
    echo "No data enterd :(";
}

?>