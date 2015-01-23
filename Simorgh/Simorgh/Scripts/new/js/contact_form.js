$(document).on('submit','form#frmContact',function(e){
e.preventDefault()
var name = $("#contact_first_name").val();
var phone = $("#contact_phone").val();
var email = $("#contact_email").val();
var subject = $("#contact_subject").val();
var message = $("#contact_comments").val();
// Checking for blank fields.
if (name == '' || email == '') {
alert("Please Fill Required Fields");
} else {
$('#loadingmessage').css('display','block'); 	
// Returns successful data submission message when the entered information is stored in database.
$.post("contact_form.php", {
name1: name,
email1: email,
phone1: phone,
message1: message,
subject1: subject
}, function(data) {
if (data) {
$('#loadingmessage').css('display','none'); 
$('.alert-success').css('display','block'); 
}
});
}
});