var comboPrices={
    option1:799,
    option2:899,
    option3:1199,
    option4:299,
    option5:999,
};

function costCalculation(){

    var name= document.getElementById("name").value;
    var phone= document.getElementById("phoneNumber").value;
    var email= document.getElementById("emailId").value;
    var address= document.getElementById("address").value;

    var pattern=/^[a-zA-Z]+[a-z A-Z]*$/g;
    // if(name.match(pattern) ==null){
        // document.getElementById("show").innerHTML="enter the valid details";  
    // }
    var pattern_phone=/\d{10}/g;
    // if(phone.match(pattern_phone)==null)
    // {
        // document.getElementById("show").innerHTML="enter the valid details";  
   
    // }
    var pattern_email=/[^@]+@[a-zA-Z]+.[a-z]/g;
    if(email.match(pattern_email)!=null){
        document.getElementById("show").innerHTML="";  
    }
    else{
        document.getElementById("show").innerHTML="enter the valid details";  

    }


    

var checkCombo1=document.getElementById("option1").checked;
var checkCombo2=document.getElementById("option2").checked;
var checkCombo3=document.getElementById("option3").checked;
var checkCombo4=document.getElementById("option4").checked;
var checkCombo5=document.getElementById("option5").checked;

var orgprice=0;
var netprice;
if(checkCombo1||checkCombo2||checkCombo3||checkCombo4||checkCombo5)
{
    if(checkCombo1)
    {
        orgprice+=comboPrices.option1;
    }
    if(checkCombo2)
    {
        orgprice+=comboPrices.option2;
    }
    if(checkCombo3)
    {
        orgprice+=comboPrices.option3;
    }
    if(checkCombo4)
    {
        orgprice+=comboPrices.option4;
    }
    if(checkCombo5)
    {
        orgprice+=comboPrices.option5;
    }
    if(orgprice>=2000)
    {
         var discount=(orgprice*20)/100;
         netprice=orgprice-discount;
         document.getElementById("result").innerHTML="Order has been placed successfully. You are requested to pay Rs." +
         Math.round(netprice) +
         " on delivery.";
    }
    else{
        document.getElementById("result").innerHTML="Order has been placed successfully. You are requested to pay Rs." +
         orgprice +
         " on delivery.";
    }
}
else{
    document.getElementById("result").innerHTML="please select the combo offers";
}
}