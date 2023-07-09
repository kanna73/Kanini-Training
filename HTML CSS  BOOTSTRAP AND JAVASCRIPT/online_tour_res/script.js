var option={
    option1:"opt1",
    option2:"opt2",
    option3:"opt3",
    option4:"opt4",
    option5:"opt5",
 };
function cal(){
     var pattern_name=/^[a-zA-Z]+[a-z A-Z]*$/g;
     var name=document.getElementById("name").value;

     if(name.match(pattern_name)==null || name==" ")
     {
       alert("enter the valid name");
     }
     var pattern_phone=/^[789]{1}[0-9]{9}$/g;
     var phone=document.getElementById("phone").value;

     if(phone.match(pattern_phone)==null || phone==" ")
     {
       alert("enter the valid number");
     }
     var pattern_aadhar=/^[1-9]{12}$/g;
     var aadhar=document.getElementById("aadhar").value;

     if(aadhar.match(pattern_aadhar)==null || aadhar==" ")
     {
       alert("enter the valid  aadhar number");
     }

    var pattern_card=/^[345]{1}[0-9]{15}$/g;
     var card=document.getElementById("card").value;

     if(card.match(pattern_card)==null || card==" ")
     {
       alert("enter the valid  card number");
     }
    var pattern_cvv=/^[\d]{3}$/g;
    var cvv=document.getElementById("cvv").value;

    if(cvv.match(pattern_cvv)==null || cvv==" ")
    {
      alert("enter the valid  cvv number");
    }



    
    var pack_type=document.getElementById("p_type").value;
    var adults=document.getElementById("adult").value;
    var child=document.getElementById("chd").value;
    var date=document.getElementById("indate").value;
    var ch=Number(child);
    var ad=Number(adults);
    var total=ch+ad;
    //  alert("total"+total);
    
    if(pack_type==option.option1)
    {
        //  alert(pack_type);
        var price1=11000;
        var rem1;
        //  alert("before extra"+price1);
        if(total>2)
        {
            var extra1=3000;
            rem1=total-2;
            //  alert("extra person"+rem1);
            price1+=rem1*extra1;
            //  alert("after extra added"+price1);
            document.getElementById("result").innerHTML="Total amount Rs."+price1+ "is paid successfully. Tour booking is confirmed! Tour check-in Date is"+date;
        }
        else
        {
            document.getElementById("result").innerHTML="Total amount Rs."+price1+" is paid successfully. Tour booking is confirmed! Tour check-in Date is"+date;
        }
    }
    if(pack_type==option.option2)
    {
        // alert(pack_type);
        var price2=20000;
        var rem2;
        // alert("before extra"+price2);
        if(total>2)
        {
            var extra2=3000;
            rem2=total-3;
            // alert("extra person"+rem2);
            price2+=rem2*extra2;
            // alert("after extra added"+price2);
            document.getElementById("result").innerHTML="Total amount Rs."+price2+" is paid successfully. Tour booking is confirmed! Tour check-in Date is"+date;

        }
        else
        {
            document.getElementById("result").innerHTML="Total amount Rs."+price2+" is paid successfully. Tour booking is confirmed! Tour check-in Date is"+date;
        }
    
    }
    if(pack_type==option.option3)
    {
        // alert(pack_type);
        var price3=29000;
        var rem3;
        // alert("before extra"+price3);
        if(total>2)
        {
            var extra3=3500;
            rem3=total-3;
            // alert("extra person"+rem3);
            price3+=rem3*extra3;
            // alert("after extra added"+price3);
            document.getElementById("result").innerHTML="Total amount Rs."+price3+" is paid successfully. Tour booking is confirmed! Tour check-in Date is"+date;

        }
        else
        {
            document.getElementById("result").innerHTML="Total amount Rs."+price3+" is paid successfully. Tour booking is confirmed! Tour check-in Date is"+date;
        }
    }
    if(pack_type==option.option4)
    {
        // alert(pack_type);
        var price4=37000;
        var rem4;
        // alert("before extra"+price4);
        if(total>2)
        {
            var extra4=4500;
            rem4=total-4;
            // alert("extra person"+rem4);
            price4+=rem4*extra4;
            // alert("after extra added"+price4);
            document.getElementById("result").innerHTML="Total amount Rs."+price4+" is paid successfully. Tour booking is confirmed! Tour check-in Date is"+date;

        }
        else
        {
            document.getElementById("result").innerHTML="Total amount Rs."+price4+" is paid successfully. Tour booking is confirmed! Tour check-in Date is"+date;
        }
    }
    if(pack_type==option.option5)
    {
        // alert(pack_type);
        var price5=45000;
        var rem5;
        // alert("before extra"+price5);
        if(total>2)
        {
            var extra5=4500;
            rem5=total-4;
            // alert("extra person"+rem5);
            price5+=rem5*extra5;
            // alert("after extra added"+price5);
            document.getElementById("result").innerHTML="Total amount Rs."+price5+" is paid successfully. Tour booking is confirmed! Tour check-in Date is"+date;

        }
        else
        {
            document.getElementById("result").innerHTML="Total amount Rs."+price5+" is paid successfully. Tour booking is confirmed! Tour check-in Date is"+date;
        }
    
    }


}