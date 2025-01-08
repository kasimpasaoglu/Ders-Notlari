// Factory Metod DP,
// Bir interface tanimla, bu interfaceten kalitilan alt siniflar hangisinin calisacagina karar versin
// Nesne olusturma isini bir "Factory" sinifina birakir. Facory sinifi hangi siniftan nesne uretilecegine karar verir.
// Product : ortak bir arayuz
// ConcreteProduct: uretilen nesnelerin(altsiniflarin) tanimlari
// Creator : Factory metodu tanimlayan sinif
// ConcrateCreator : FactoryMetodu uygulayan sinif

SandwichStore veggieStore = new VeggieStore();
Console.WriteLine("Veggie Sandwich : " + veggieStore.OrderSandwich());


SandwichStore turkishStore = new TurkishStore();
Console.WriteLine("Turkish Sandwich : " + turkishStore.OrderSandwich());
