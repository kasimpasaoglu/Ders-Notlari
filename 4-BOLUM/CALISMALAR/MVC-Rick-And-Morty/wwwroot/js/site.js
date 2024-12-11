
// next ve prev buttonlar icin fonksioyn

$(document).on("click", "#nextButton, #prevButton", function () {
    const link = $(this).data("url"); // buttonun data-url attributundan linki al
    if (!link) return; // url yoksa bi islem yapma

    $.ajax({ // ajax metodu ??  ile bir istek yap
        url: '/Home/Index', // controllerdaki index actionuna yonlendir
        method: 'GET', // get istegi
        data: { url: link }, // linki parametre olarak gönder
        success: function (data) { // basarili olursa asagidaki bu fonksiyonu calistir
            // data: controllerdan gelen tum html sayfasidir, 
            // content id li alani bulup, o kismi guncellemek istiyoruz,
            const newContent = $(data); // gelen tum html icerigini bir nesneye degiskene

            const updatedHtml = newContent.find('#content').html(); // gelen icerigin sadece #content alanini yakala

            $('#content').html(updatedHtml); // mevcut sayfadaki content alaninin icerigini degistir.

        },
        error: function () {
            alert("Error fetching data");
        }
    });
});