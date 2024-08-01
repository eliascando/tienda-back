using tienda.Config; 

var builder = WebApplication.CreateBuilder(args); 

builder.Services.InjectDependencies(builder.Configuration); 

var app = builder.Build(); 

if (app.Environment.IsDevelopment()) 
{ 
    app.UseSwagger(); 
    app.UseSwaggerUI(); 
}


app.UseCors("AllowAll");

app.UseHttpsRedirection(); 

app.UseAuthorization(); 

app.MapControllers(); 

app.Run(); 
