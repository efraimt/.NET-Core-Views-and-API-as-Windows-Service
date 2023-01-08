using System.ComponentModel;

WebApplicationOptions webApplicationOptions = new()
{
    ContentRootPath = AppContext.BaseDirectory,
    Args = args,
    ApplicationName = System.Diagnostics.Process.GetCurrentProcess().ProcessName
};
var builder = WebApplication.CreateBuilder(webApplicationOptions); 
builder.Host.UseWindowsService();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.MapControllers();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
