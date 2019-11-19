<?php include 'Connection.php';
$sellerName = $_REQUEST['sellerName'];
$address = $_REQUEST['address'];
$city = $_REQUEST['city'];
$mobileNumber = $_REQUEST['mobileNumber'];
$emailAddress = $_REQUEST['emailAddress'];
$vehicalMake = $_REQUEST['vehicalMake'];
$vehicalMake = preg_replace('/\s+/', '-', $vehicalMake);
$vehicalModel = $_REQUEST['vehicalModel'];
$vehicalModel = preg_replace('/\s+/', '-', $vehicalModel);
$vehicalYear = $_REQUEST['vehicalYear'];
$URL = "https://jdpower.com/Cars/$vehicalYear/$vehicalMake/$vehicalModel";

$squery= "INSERT INTO `assignment`(`Name`, `Address`, `City`, `Mobile_Number`, `Email`, `Vehical_Make`, `Vehical_Model`, `Vehical_Year`, `URL`) VALUES ('$sellerName','$address','$city','$mobileNumber','$emailAddress','$vehicalMake','$vehicalModel','$vehicalYear','$URL')";

$connection->query($squery);
?>

<html>
<script src ="validationOfEmail.js"></script>
<head>
<link rel="stylesheet" type="text/css" href="CSS/style.css">
</head>
<body>
<header>
<table  class="tab">
<tr class="tab">
	<th class="tab">Seller's Name</th>
	<th class="tab">Address</th>
	<th class="tab">City</th>
	<th class="tab">Contact</th>
	<th class="tab">Email</th>
	<th class="tab">Vehical's Make</th>
	<th class="tab">Vehical's Model</th>
	<th class="tab">Vehical's Year</th>
	<th class="tab">URL</th>
</tr>
<tr class="tab">
	<td class="tab"><?php echo $sellerName; ?></td>
	<td class="tab"><?php echo $address; ?></td>
	<td class="tab"><?php echo $city; ?></td>
	<td class="tab"><?php echo $mobileNumber; ?></td>
	<td class="tab"><?php echo $emailAddress; ?></td>
	<td class="tab"><?php echo $vehicalMake; ?></td>
	<td class="tab"><?php echo $vehicalModel; ?></td>
	<td class="tab"><?php echo $vehicalYear; ?></td>
	<td class="tab"><a id="url" href="<?php echo $URL; ?>"><?php echo $URL; ?></a></td>
</tr>
</table>
<br>
<a href="Home.html" class="btn">Home</a>
<header>
</body>
</html>