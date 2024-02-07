var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



/*
 
The second view should be a simple calculator that allows the user to figure out how much you would charge for your services to help tutor them about your hobby.  
The view should use a JavaScript file using jQuery to complete the calculation.    
    • A box for the user to enter the number of hours they need from you 
    • Validation to make sure they actually entered a positive number 
    • An non-editable box that shows how much you charge per hour 
    • A button that allows the user to calculate the total 
    • An output box that shows the total 
    • Navigation back to the home page  
*/