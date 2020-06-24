<!-- The core Firebase JS SDK is always required and must be listed first -->
<script src="https://www.gstatic.com/firebasejs/7.15.1/firebase-app.js"></script>
<script src="https://www.gstatic.com/firebasejs/7.15.1/firebase-database.js"></script>

<!-- TODO: Add SDKs for Firebase products that you want to use
     https://firebase.google.com/docs/web/setup#available-libraries -->

<script>
  // Your web app's Firebase configuration
  var firebaseConfig = {
    apiKey: "AIzaSyCEN_DXWvdAKTYQ-BiMwzVCxRkGOVFRDb4",
    authDomain: "eracost-36a0d.firebaseapp.com",
    databaseURL: "https://eracost-36a0d.firebaseio.com",
    projectId: "eracost-36a0d",
    storageBucket: "eracost-36a0d.appspot.com",
    messagingSenderId: "77389038855",
    appId: "1:77389038855:web:f42b258b877b15071471a2"
  };
  // Initialize Firebase
  firebase.initializeApp(firebaseConfig);
  var myName = prompt("enter your name");

  function sendMessage(){
  	var message = document.getElementById("message").value;
  	firebase.database().ref("messages").push().set({
  		"sender": myName,
  		"message": message
  	});
  	return false;
  }
  firebase.database().ref("messages").on("child_added", function(snapshop){
      var html= "";
      html += "<li id='message-" + snapshop.key + "'>";
      if(snapshop.val().sender == myName){
        html += "<button data-id='" +  snapshop.key + "' onclick='deleteMessage(this);'>";
          html += "Delete";
        html += "</button>";
      }
        html += snapshop.val().sender + ":" + snapshop.val().message;
      html += "</li>";

      document.getElementById("messages").innerHTML += html;
  });

  function deleteMessage(self){
    var messageId = self.getAttribute("data-id");
    firebase.database().ref("messages").child(messageId).remove();
  }
  firebase.database().ref("messages").on("child_removed", function (snapshop){
    document.getElementById("message-" + snapshop.key).innerHTML = "this message has been deleted";
  });

</script>
<body>
<!--create a form to send message-->
<h3 style="margin-left: 1400px; margin-top: 40px;"><a href="index.html" style="color: #fff;"><u>Logout</u></h3></a>
<div id="formStyle">
<form onsubmit="return sendMessage();">

	<input id="message" placeholder="enter message" autocomplete="off" id="writemessage">
	<input type="submit" style="background: blue;">
</form>

<ul id="messages"></ul>
</div>
<style>
  body {
  background-image: url('blur1.jpg');
  background-repeat: no-repeat;
  background-attachment: fixed; 
  background-size: 100% 100%;
}
  #formStyle{
    background-color: lightblue;
    border-style: solid;
    margin-top: 200px;
    margin-left: 400px;
    margin-right: 400px;
  }
  #formStyle input{
    display: block;
    border: 1px solid #ccc;
    border-radius: 5px;
    background: #fff;
    padding: 15px;
    outline: none;
    width: 100%;

  }

</style>
</body>
