function ValidateEmail(email) 
{
 return /^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email)
}
function ValidateM(mobile) 
{
 return /^\(\d{3}\)\d{3}-\d{4}$|^\d{3}-\d{3}-\d{4}$/.test(mobile) 
}


function ifFieldsAreValid()
{
var sellerName = document.getElementById("sellerName").value;
var address = document.getElementById("address").value;
var city = document.getElementById("city").value;
var mobileNumber = document.getElementById("mobileNumber").value;
var emailAddress = document.getElementById("emailAddress").value;
var vehicalMake = document.getElementById("vehicalMake").value;
var vehicalModel = document.getElementById("vehicalModel").value;
var vehicalYear = document.getElementById("vehicalYear").value;	

var flag;
Boolean(flag);
if (sellerName == "")
{
	document.getElementById('sellerName').style.borderColor = "red";
	flag = false;
}
else if (/^[0-9]+$/.test(sellerName)) 
{
alert("Seller Name Contains Numbers!");
document.getElementById('sellerName').style.borderColor = "red";
flag = false;
}
else if(sellerName.length <=2)
{
alert('Seller Name is To Short! Please try Again');
document.getElementById('sellerName').style.borderColor = "red";
flag = false;
}else{document.getElementById('sellerName').style.borderColor = "black";}

if (address == "")
{
	document.getElementById('address').style.borderColor = "red";
	flag = false;
}else{document.getElementById('address').style.borderColor = "black";}


if (city == "")
{
	document.getElementById('city').style.borderColor = "red";
	flag = false;
}
else if (/^[0-9]+$/.test(city)) 
{
alert("City Name Contains Numbers!");
document.getElementById('city').style.borderColor = "red";
flag = false;
}
else if(city.length <=2)
{
alert('City Name is too short! Please input a valid city name');
document.getElementById('city').style.borderColor = "red";
flag = false;
}else{document.getElementById('city').style.borderColor = "black";}


if (mobileNumber == "")
{
	document.getElementById('mobileNumber').style.borderColor = "red";	
	flag = false;
}

else if(!ValidateM(mobileNumber))
{
	document.getElementById('mobileNumber').style.borderColor = "red";
	flag=false;	
}
else{document.getElementById('mobileNumber').style.borderColor = "black";}








if (emailAddress == "")
{
	document.getElementById('emailAddress').style.borderColor = "red";
	flag = false;
}
else if(ValidateEmail(emailAddress))
{
	document.getElementById('emailAddress').style.borderColor = "black";
	flag=true;
}
else
{
alert('Please Enter valid Email Address');
document.getElementById('emailAddress').style.borderColor = "red";
flag=false;
} 



if (vehicalMake == "")
{
	document.getElementById('vehicalMake').style.borderColor = "red";
	flag = false;
}
if (vehicalModel == "")
{
	document.getElementById('vehicalModel').style.borderColor = "red";
	flag = false;
}else{document.getElementById('vehicalModel').style.borderColor = "black";}

if (vehicalYear == "")
{
	document.getElementById('vehicalYear').style.borderColor = "red";
	flag = false;
}
else if(isNaN(vehicalYear))
{
	document.getElementById('vehicalYear').style.borderColor = "red";	
	flag = false;
}
else if(vehicalYear.length<4)
{
	document.getElementById('vehicalYear').style.borderColor = "red";	
	flag = false;
}
else if(vehicalYear.length>4)
{
	document.getElementById('vehicalYear').style.borderColor = "red";	
	flag = false;
}
else if((vehicalYear!="1990") && (vehicalYear!="1991") && (vehicalYear!="1992") && (vehicalYear!="1993") && (vehicalYear!="1994") && (vehicalYear!="1995") && (vehicalYear!="1996") && (vehicalYear!="1997") && (vehicalYear!="1998") && (vehicalYear!="1999") && (vehicalYear!="2000") && (vehicalYear!="2001") && (vehicalYear!="2002") && (vehicalYear!="2003") && (vehicalYear!="2004") && (vehicalYear!="2005") && (vehicalYear!="2006") && (vehicalYear!="2007") && (vehicalYear!="2008") && (vehicalYear!="2009") && (vehicalYear!="2010") && (vehicalYear!="2011") && (vehicalYear!="2012") && (vehicalYear!="2013") && (vehicalYear!="2014") && (vehicalYear!="2015") && (vehicalYear!="2016") && (vehicalYear!="2017") && (vehicalYear!="2018") && (vehicalYear!="2019"))
{
	document.getElementById('vehicalYear').style.borderColor = "red";	
	flag = false;
}else{document.getElementById('vehicalYear').style.borderColor = "black";}



if (flag == false)
{
	alert('Please Enter valid data');
}
return flag
}