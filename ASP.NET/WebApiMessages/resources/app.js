const serviceUrl = 'https://localhost:7225/api/';

let currentUsername = null;

function renderMessages() {

}

function loadMessages() {
    $.get({
        url: serviceUrl + 'messages/All',
        success: function success(data) { //callback
            console.log(data);
        }, 
        error: function error(error) {
            console.log(error);
        }
    });
}

function createMessage() {

}