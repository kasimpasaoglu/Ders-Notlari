// Veri tabanına bağlatı : Ado.net(Eski) kullanarak


// sql ile çalışmak için, nugetten bir paket indirmeniz gerekmektedir!!
// paketin adresi : dotnet add package Microsoft.Data.SqlClient --version 6.0.0-preview2.24304.8 
// yukarıdaki vermiş olduğum konutu terminalde çalıştırdığınızda artık sql ile çalışabilir hale geleceksiniz!!

using Microsoft.Data.SqlClient; // nugetten sqlClient paketini indiriyoruz

SqlConnection con = new SqlConnection("Server=db4856.public.databaseasp.net; Database=db4856; User Id=db4856; Password=Ni4!7@wA-E2r; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;"); //Connection Stringi dogru birsekilde alip buraya ekliyoruz.
SqlCommand command = new SqlCommand("select product_name from Product", con); // SQL'e bir komut gondermek icin select komutunu bir degiskene tanimladik. Yukaridaki 'con' degiskenini kullanarak select komutunu gonderecek

con.Open(); // yukarda bilgileri girilen db'ye baglanti atiyoruz.

SqlDataReader reader = command.ExecuteReader(); //bu metod surekli, satir satir veri getirecek. 
while (reader.Read()) // Read() metodu veriyi getirirken, arkada baska veri kaldi mi bilgisini de true ve ya false olarak getirir. Son veri geldiginde false doner. ve dongu biter.
{
    Console.WriteLine("Ad : " + reader["product_name"]); // gelen sonucu ekrana yazdirdik. Select Sorgusunda product_name yazdik o yuzden burda da ayni isim olmak zorunda
}
reader.Close(); // DB'ye sorguyu birak
con.Close();  // baglantiyi kes
