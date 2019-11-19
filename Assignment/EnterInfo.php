<!DOCTYPE php>
<html>
	<head>
		<title>
		Enter Information Page
		</title>
		<link rel="stylesheet" type="text/css" href="CSS/style.css">
		<script src='validationOfEmail.js'>
		</script>
	</head>
		<body>
			<header>
				<form class="button" action="submit.php" method="post" onsubmit="return ifFieldsAreValid()">
					<table>  
						<tr>        
            						<td><label for="sellerName" class="lbl">Seller Name</label>
							</td>
            						<td><input id="sellerName" type="text" placeholder="Seller Name" name="sellerName" >
							</td>
        						<tr>		
								<td><br>
								</td>
							</tr>
						</tr>
						<tr>        
            						<td><label for="Address" class="lbl">Address</label>
							</td>
            						<td><input id="address" type="text" placeholder="Address" name="address">
							</td>
        						<tr>
								<td><br>
								</td>
							</tr>
						</tr>
						<tr>        
            						<td><label for="City" class="lbl">City</label>
							</td>
            						<td><input id="city" type="text" placeholder="City" name="city">
							</td>
        						<tr>
								<td><br>
								</td>
							</tr>
						</tr>
						<tr>        
            						<td><label for="MobileNumber" class="lbl">Mobile Number</label>
							</td>
            						<td><input id="mobileNumber" type="text" pattern="^[(]{0,1}[0-9]{3,3}[)/-]{0,1}[0-9]{3,3}[-]{1,1}[0-9]{4,4}$" placeholder="123-123-1234" name="mobileNumber">
							</td>
        						<tr>
								<td><br>
								</td>
							</tr>
						</tr>
						<tr>        
            						<td><label for="emailAddress" class="lbl">Email Address</label>
							</td>
            						<td><input id="emailAddress" type="email" pattern="[a-zA-Z0-9.-_]{1,}@[a-zA-Z.-]{2,}[.]{1}[a-zA-Z]{2,}" placeholder="Email Address" name="emailAddress">
							</td>
        						<tr>
								<td><br>
								</td>
							</tr>
						</tr>
						<tr>       
            						<td><label for="vehicalMake" class="lbl">Vehical Make</label>
							</td>
            						<td><input id="vehicalMake" type="text" placeholder="Vehical Make" name="vehicalMake">
							</td>
        						<tr>
								<td><br>
								</td>
							</tr>
						</tr>
						<tr> 
            						<td><label for="vehicalModel" class="lbl">Vehical Model</label>
							</td>
            						<td><input id="vehicalModel" type="text" placeholder="Vehical Model" name="vehicalModel">
							</td>
        						<tr>
								<td><br>
								</td>
							</tr>
						</tr>
						<tr>       
            						<td><label for="vehicalYear" class="lbl">Vehical Year</label>
							</td>
            						<td><input id="vehicalYear" type="text" placeholder="Vehical Year" name="vehicalYear">
							</td>
        						<tr>
								<td><br>
								</td>
							</tr>
						</tr>
						<tr>     
	    						<td> 
		 					<input type="submit" value="Submit" class="btn" >
							</td>
						</tr>
					</table>
				</form>
			</header>
		</body>

</html>