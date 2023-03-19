using EmployeeManagementSystem.Repository;
using EmployeeManagementSystem.Repository.InMemory;
using EMSApp.Data;
using EMSApp.Repository;
using EMSApp.Repository.MsSQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<EmployeeDbContext, EmployeeDbContext>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeDbRepository>();
// builder.Services.AddScoped<IEmployeeRepository, EmployeeInMemoryRepository>();
// builder.Services.AddScoped<IDepartmentRepository, DepartmentInMemoryRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employees}/{action=Index}/{id?}");

app.Run();
