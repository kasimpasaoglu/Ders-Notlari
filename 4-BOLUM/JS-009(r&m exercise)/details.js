var queryString = window.location.search; // sayfanin lokasyon bilgisini aldik, yani diger sayfada hazirladigimiz querystring burda
var urlParams = new URLSearchParams(queryString); // bu query string icindeki parametreleri ayikladik
var selectedId = urlParams.get('id'); // id isimli parametreyi yakala

// asagida sayfa(DOM) icindeki elementleri yakaladik
var image = document.querySelector('#image');
var titleInfo = document.querySelector('#title');
var nameInfo = document.querySelector('#name');
var speciesInfo = document.querySelector('#species');
var typeInfo = document.querySelector('#type');
var statusInfo = document.querySelector('#status');
var genderInfo = document.querySelector('#gender');
var originInfo = document.querySelector('#origin');
var locationInfo = document.querySelector('#location');


// fetch yapacagimiz url'yi olustururken diger sayfadan gelen az once yukarda yakaladigimiz id parametresini url'ye ekledik
var urlDefault = 'https://rickandmortyapi.com/api/character/' + selectedId
// bu url yi kullanarak fetch yapiyoruz
fetch(urlDefault)
    .then(response => response.json())
    .then(data => {

        // gelen sonuclari sayfa icinde istedigimiz yerlere yarlestirme islemi

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