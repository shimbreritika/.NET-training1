using _28JUL.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//singletion = single instance is created and shared for entire application lifetime
//tranient = new instance created every time service is requested
//addscoped = one instance is created per http request
builder.Services.AddScoped<IProductService , ProductService>();  //add method for services

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
