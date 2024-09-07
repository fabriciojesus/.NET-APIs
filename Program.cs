var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/user",() => new { Name = "Jett", Age = 35 });
app.MapGet("/Addheader", (HttpResponse response) => response.Headers.Add("Teste", "Jett Player"));

app.MapGet("/Addreturn", (HttpResponse response) => {
    response.Headers.Add("teste", "Reyna");
    return new { Name = "Reyna", Age = 927 };
});

app.MapPost("/saveProduct", (Product product) => {
    return product.Code + " - " + product.Name;
});

// Endpoint PUT para alterar a idade do usuário
app.MapPut("/updateUserAge", (int newAge) => {
    // Lógica simples para modificar a idade
    var user = new { Name = "Jett", Age = newAge };
    return user;
});

app.Run();

public class Product
{
    public string Code { get; set; }
    public string Name { get; set; }
}
