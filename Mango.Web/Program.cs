using Mango.Web;
using Mango.Web.Services;
using Mango.Web.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.IdentityModel.Logging;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient<IProductService, ProductService>();
SD.ProductAPIBase = builder.Configuration["ServiceUrls:ProductApi"];

builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = "Cookies";
    options.DefaultChallengeScheme = "oidc";
})
    .AddCookie("Cookies", c => c.ExpireTimeSpan = TimeSpan.FromMinutes(10))
    .AddOpenIdConnect("oidc", options =>
    {
        options.Authority = builder.Configuration["ServiceUrls:IdentityAPI"];
        options.GetClaimsFromUserInfoEndpoint = true;
        options.ClientId = "mango";
        options.ClientSecret = "secret";
        options.ResponseType = "code";

        options.TokenValidationParameters.NameClaimType = "name";
        options.TokenValidationParameters.RoleClaimType = "role";
        options.Scope.Add("mango");
        options.SaveTokens = true;
    }
    
    );

builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");   
    app.UseHsts();
}
app.UseDeveloperExceptionPage();
IdentityModelEventSource.ShowPII = true;

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
