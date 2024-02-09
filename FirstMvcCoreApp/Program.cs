using FirstMvcCoreApp.Custom;
using FirstMvcCoreApp.IRepository;
using FirstMvcCoreApp.Models;
using FirstMvcCoreApp.Reposiotry;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<CustomMiddleWare>();//register
builder.Services.AddScoped<IStudentReposiotryModel, StudentReposiotryModel>();//register

builder.Services.AddScoped<IScopedServices, ImplentService>();//register
builder.Services.AddTransient<ITransientServices, ImplentService>();//register
builder.Services.AddSingleton<ISingletonServices, ImplentService>();//register

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}


//app.MapGet("/m1", HandleMapOne);
app.Map("/m2", appMap => {
    appMap.Run(async context =>
    {
        await context.Response.WriteAsync("Hello from 2nd app.Map()");
    });
});

//app.UseMiddleware<CustomMiddleWare>();//usemiddleware methd to call ur custom middleware
//app.Use(async (context, next) =>
//{

//    await context.Response.WriteAsync("hello Program Request 1\n");
//      next();
//    await context.Response.WriteAsync("hello Program Response 1\n");


//});


//app.Use(async (context, next) =>
//{

//    await context.Response.WriteAsync("hello Program Request 2\n");
//      next();
//    await context.Response.WriteAsync("hello Program Response 2\n");


//});

//app.Run(async (context) => {

//    await context.Response.WriteAsync("Run Method is called\n");

//});

//app.Use(async (context, next) =>
//{

//    await context.Response.WriteAsync("hello Program Request 3");
//    next();
//    await context.Response.WriteAsync("hello Program Response 3");


//});


app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

// static void HandleMapOne(IApplicationBuilder app)
//{
//    app.Run(async context =>
//    {
//        await context.Response.WriteAsync("Hello from 1st app.Map()");
//    });
//}
