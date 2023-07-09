

function fun1()
  {
    var fname=document.getElementById("name").value;
    var email=document.getElementById("email").value;
    var phone=document.getElementById("phone").value;
    var username=document.getElementById("username").value;
    var pass=document.getElementById("pass").value;
    var name_pattern=/^[A-Za-z]+[ A-Za-z]*$/;
    var email_pattern=/[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$/;
    var phonepattern=/[\d]{10}/g;
    var username_pattern=/^[A-Za-z][A-Za-z0-9_]{8,15}$/g;
    var password_pattern=/(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}/g;
    var count=0;
    var uname={};
    if(fname.match(name_pattern)!=null)
    {
        document.getElementById("name").style.borderColor="white";
        count++;
    }
    else{
        document.getElementById("name").style.borderColor="red";

    }
    if(email.match(email_pattern)!=null)
    {

        document.getElementById("email").style.borderColor="white";
        count++;


    }
    else{
        document.getElementById("email").style.borderColor="red";

    }
    if(phone.match(phonepattern)!=null)
    {
        document.getElementById("phone").style.borderColor="white";
        count++;


    }
    else{
        document.getElementById("phone").style.borderColor="red";

    }
    if(username.match(username_pattern)!=null)
        {
            document.getElementById("username").style.borderColor="white";
            count++;


        }
        else{
            document.getElementById("username").style.borderColor="red";

        }
    if(pass.match(password_pattern)!=null)
     {
        document.getElementById("pass").style.borderColor="white";
        count++;


     }
     else{
        document.getElementById("pass").style.borderColor="red";

     }
     if(count==5)
     {
        alert("Registration successful");
        var n= Object.keys(uname).length;
        alert(n);

        document.getElementById("link").href="login.html"; 

        // document.getElementById("pass").style.borderColor="red";

     }
     else{
        alert("Enter valid credentials");
     }
  }
