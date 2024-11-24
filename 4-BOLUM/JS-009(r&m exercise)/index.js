var container = document.getElementById('container')
var nextbtn = document.getElementById('next')
var prevbtn = document.getElementById('prev')
var urlDefault = 'https://rickandmortyapi.com/api/character'

verileriGetir(urlDefault);

function verileriGetir(link) {



    container.innerHTML = "";
    fetch(link)
        .then(response => response.json())
        .then(data => {

            nextbtn.setAttribute('url', data.info.next)
            if (data.info.prev == null) {
                prevbtn.setAttribute('url', urlDefault)
            }
            else {
                prevbtn.setAttribute('url', data.info.prev)
            }

            for (let i = 0; i < data.results.length; i++) { // her dongude yeni bir scope acilmasi icin let ile tanimliyoruz. asagidaki degerler her dongude farkli deger almasi gerek
                const resultSet = data.results[i]; // her dongude sabit bir deger almasi lazim, o yuzden const
                const createdImg = document.createElement('img');
                createdImg.src = resultSet.image;

                createdImg.addEventListener('click', function () {
                    window.location.href = "detail.html?id=" + resultSet.id;
                });

                container.appendChild(createdImg);
            }


        });

}
