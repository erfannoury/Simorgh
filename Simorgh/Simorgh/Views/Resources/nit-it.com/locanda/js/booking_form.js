$(document).on('submit','form#frmContact',function(e){
e.preventDefault()

var name = $("#contact_first_name").val();
var lname = $("#contact_lastname").val();
var phone = $("#contact_phone").val();
var email = $("#contact_email").val();
var roomtype = $("#room_type").val();
var rooms = $("#rooms").val();
var adults = $("#adults").val();
var children = $("#children").val();
var arrival = $("#checkin").val();
var departure = $("#checkout").val();
var message = $("#booking_comments").val();

$("#returnmessage").empty(); // To empty previous error/success message.
// Checking for blank fields.
if (name == '' || email == '') {
alert("Please Fill Required Fields");
} else {
// Returns successful data submission message when the entered information is stored in database.
$('#loadingmessage').css('display','block'); 
$.post("booking_form.php", {
name1: name,
lname1: lname,
email1: email,
phone1: phone,
roomtype1: roomtype,
rooms1: rooms,
adults1: adults,
children1: children,
arrival1: arrival,
departure1: departure,
message1: message,
}, function(data) {
if (data) {
$('#loadingmessage').css('display','none'); 
$('.alert-success').css('display','block'); 
}
});
}
});