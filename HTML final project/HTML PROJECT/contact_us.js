function fun4()
{
    var name=document.getElementById("name").value;
    var email=document.getElementById("email").value;
    var message=document.getElementById("message").value;
    var subject=document.getElementById("subject").value;

    var name_pattern=/^[A-Za-z]+[ A-Za-z]*$/;
    var email_pattern=/[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$/;
    var subject_pattern="";
    var message_pattern="";
    if(name.match(name_pattern)!=null && email.match(email_pattern)!=null && message!=message_pattern && subject!="")
    {
        document.getElementById("submit").style.display="none";
        document.getElementById("result").style.display="block";

        document.getElementById("name").style.borderColor="white";
        document.getElementById("email").style.borderColor="white";
        document.getElementById("message").style.borderColor="white";
        document.getElementById("subject").style.borderColor="white";

        
        fun4();

        
    }
    else{
        document.getElementById("name").style.borderColor="red";
        document.getElementById("email").style.borderColor="red";
        document.getElementById("message").style.borderColor="red";
        document.getElementById("subject").style.borderColor="red";
    }



}
    function fun5(){
        var getValue= document.getElementById("name");
        var email=document.getElementById("email");
        var message=document.getElementById("message");
        var subject=document.getElementById("subject");
          if (getValue.value !="") {
              getValue.value = "";
          }
          if (email.value !="") {
            email.value = "";
        }
        if (message.value !="") {
            message.value = "";
        }
        if (subject.value !="") {
            subject.value = "";
        }

        location.reload();

       
   }

