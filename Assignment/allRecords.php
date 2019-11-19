<?php include 'Connection.php';
?>
<html>
<head>
<title>All Saved Records</title>
<link rel="stylesheet" type="text/css" href="CSS/style.css">
<body>
<header>
<table class ="tab">
<tr class="tab">
	<th class="tab">Seller Name</th> 
	<th class="tab">Address</th> 
	<th class="tab">City</th> 
	<th class="tab">Contact Number</th> 
	<th class="tab">Email</th> 
	<th class="tab">Vehical Make</th> 
	<th class="tab">Vehical Model</th> 	
	<th class="tab">Vehical Year</th>
	<th class="tab">URL</th>
</tr>
<?php
$squery = "SELECT * from assignment ORDER BY ID DESC;";
$dataFromTable = $connection->query($squery);
while ($show = $dataFromTable->fetch_assoc())
{
echo '<tr class="tab">
	<td class="tab">'. $show["Name"].'</td>
	<td class="tab">'. $show["Address"].'</td>
	<td class="tab">'. $show["City"].'</td>
 	<td class="tab">'. $show["Mobile_Number"].'</td>
 	<td class="tab">'. $show["Email"].'</td>
 	<td class="tab">'. $show["Vehical_Make"].'</td>
 	<td class="tab">'. $show["Vehical_Model"].'</td>
 	<td class="tab">'. $show["Vehical_Year"].'</td>';
	echo '<td class="tab"><a href="'. $show["URL"].'" style="color: white">'. $show["URL"]."</a></td>
</tr>";
}

echo "";
echo "</table>";
?>
</table>
<br>
<a href="Home.html" class="btn">Home</a>
</header>
</body>
</head>
</html>