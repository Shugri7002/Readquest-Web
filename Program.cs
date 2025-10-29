var builder = WebApplication.CreateBuilder(args);

// Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// ✅ MUST have this to serve /wwwroot/css and /wwwroot/img
app.UseStaticFiles();

app.UseRouting();
app.MapRazorPages();

app.Run();
