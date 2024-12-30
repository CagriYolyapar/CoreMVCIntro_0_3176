WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Since when is ambiguity a good design ?

WebApplication app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles(); //wwwroot'un public olarak kullanılmasına izin verir

app.UseRouting(); //url yapılandırması

app.UseAuthorization(); //Yetkilendirme 

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Contact}/{id?}");

app.Run();
