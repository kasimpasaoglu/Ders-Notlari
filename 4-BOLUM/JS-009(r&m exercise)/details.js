var queryString = window.location.search;
var urlParams = new URLSearchParams(queryString);
var selectedId = urlParams.get('id');

var image = document.querySelector('#image');
var titleInfo = document.querySelector('#title');
var nameInfo = document.querySelector('#name');
var speciesInfo = document.querySelector('#species');
var typeInfo = document.querySelector('#type');
var statusInfo = document.querySelector('#status');
var genderInfo = document.querySelector('#gender');
var originInfo = document.querySelector('#origin');
var locationInfo = document.querySelector('#location');



var urlDefault = 'https://rickandmortyapi.com/api/character/' + selectedId

fetch(urlDefault)
    .then(response => response.json())
    .then(data => {

        image.src = data.image;

        titleInfo.innerHTML = data.name;

        nameInfo.innerHTML = data.name;

        speciesInfo.innerHTML = data.species;

        typeInfo.innerHTML = data.type;

        statusInfo.innerHTML = data.status;

        genderInfo.innerHTML = data.gender;

        originInfo.innerHTML = data.origin.name;

        locationInfo.innerHTML = data.location.name;
    });