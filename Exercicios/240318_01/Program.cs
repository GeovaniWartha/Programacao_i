using _240318_01.models;


Customer c1 = new Customer();

c1.CustomerId = 1;
c1.FirstName = "Geovani";
c1.LastName = "Wartha";
c1.BirthDate = new DateTime();
c1.EmailAddress = "Wartha2005@gmail.com";

//Instancia de objeto do tipo address
Address address1 = new Address();
// atribuindo valor aos atributos do objeto address1
address1.AddressId = 1;
address1.Street = "Ernesto Andreani";
address1.District = "Portal das Videiras";
address1.City = "Videira";
address1.Number = 251;
address1.FederalState = "SC";
address1.Country = "Brasil";
address1.ZipCode = "89562-402";
// addressType é do tipo enum - portanto espera receber um valor equivalente a seu tipo
address1.AdressType = AddressType.Commercial;

// guardando 1 endereço à lista de endereços do consumidor
c1.Adresses.Add(address1);

Console.WriteLine("Endereços: ");


foreach(var ad in c1.Adresses)
{
    Console.WriteLine("-----------------");
    Console.WriteLine($"Rua: {ad.Street}");
    Console.WriteLine($"Bairro: {ad.District}");
    Console.WriteLine($"Nro: {ad.Number}");
    Console.WriteLine($"Cidade: {ad.City}");
    Console.WriteLine($"Estado: {ad.FederalState}");
    Console.WriteLine($"Pais: {ad.Country}");
}

//Console.WriteLine( $"Nome: {c1.FirstName} {c1.LastName}");
//Console.WriteLine( $"Email: {c1.EmailAddress}");