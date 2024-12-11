



fetch('https://fakestoreapi.com/products')
    .then(res => res.json())
    .then(data => {

        const container = document.querySelector('.container');
        for (let i = 0; i < data.length; i++) {
            const element = data[i];

            //kartin kendisi
            const card = document.createElement('div');
            card.style = "width: 18rem;"
            card.className = 'card';

            //resim
            const image = document.createElement('img');
            image.className = 'card-img-top';


            // baslik ve aciklama kapsayicisi
            const cardBody = document.createElement('div');
            cardBody.className = 'card-body';

            // baslik
            const cardTitle = document.createElement('h5');
            cardTitle.className = 'card-title';

            // aciklama
            const cardText = document.createElement('p');
            cardText.className = 'card-text';


            // liste kismi
            const list = document.createElement('ul');
            list.className = "list-group list-group-flush";

            // fiyat
            const price = document.createElement('li');
            price.className = "list-group-item";

            // puan
            const rating = document.createElement('li');
            rating.className = 'list-group-item';

            // stok sayisi
            const count = document.createElement('li');
            count.className = 'list-group-item';


            cardBody.appendChild(cardTitle);
            cardBody.appendChild(cardText);


            list.appendChild(price);
            list.appendChild(rating);
            list.appendChild(count);

            card.appendChild(image);
            card.appendChild(cardBody);
            card.appendChild(list);



            image.src = element.image;
            image.alt = `Image ${element.id}`;
            cardTitle.innerText = element.title;
            cardText.innerText = element.description;
            price.innerText = `Price: ${element.price}`;
            rating.innerText = `Rate : ${element.rating.rate}`;
            count.innerHTML = `In Stock : ${element.rating.count}`;



            container.appendChild(card);
        }

    })

