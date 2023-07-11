
using CarWebAPI.Data;
using CarWebAPI.Data.Repositores.BaseRepsitory;
using CarWebAPI.Data.Repositores.CarRepository;
using CarWebAPI.Data.Repositores.Parameter;
using CarWebAPI.Data.Repositores.Parameter.BrandRepository;
using CarWebAPI.Data.Repositores.Parameter.FeaureRepository;
using CarWebAPI.Modules;
using CarWebAPI.Services.BaseService;
using CarWebAPI.Services.CarService;
using CarWebAPI.Services.Parameter;
using CarWebAPI.Services.Parameter.BodyTypeService;
using CarWebAPI.Services.Parameter.BrandService;
using CarWebAPI.Services.Parameter.FeatureService;
using CarWebAPI.Services.Parameter.FuelTypeService;
using CarWebAPI.Services.Parameter.ModelService;
using CarWebAPI.Services.Parameter.TransmissionService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<DataContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("CarWebAPI")));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IBaseService<,>), typeof(BaseService<,>));

builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<lBrandRepository, BrandRepository>();
builder.Services.AddScoped<IBrandService, BrandService>();

builder.Services.AddScoped<lModelRepository, ModelRepository>();
builder.Services.AddScoped<IModelService, ModelService>();

builder.Services.AddScoped<IFeatureRepository, FeatureRepository>();
builder.Services.AddScoped<IFeatureService, FeatureService>();

builder.Services.AddScoped<ITransmissionRepository, TransmissionRepository>();
builder.Services.AddScoped<ITransmissionService, TransmissionService>();

builder.Services.AddScoped<lFuelTypeRepository, FuelTypeRepository>();
builder.Services.AddScoped<IFuelTypeService, FuelTypeService>();

builder.Services.AddScoped<IFeatureRepository, FeatureRepository>();
builder.Services.AddScoped<IFeatureService, FeatureService>();
builder.Services.AddScoped<IFeatureService, FeatureService>();

builder.Services.AddScoped<IImageRepositroy, ImageRepository>();
builder.Services.AddScoped<IImageService, ImageService>();

builder.Services.AddScoped<IFeatureRepository, FeatureRepository>();
builder.Services.AddScoped<IFeatureService, FeatureService>();

builder.Services.AddScoped<IBodyTypeRepository, BodyTypeRepository>();
builder.Services.AddScoped<IBodyTypeService, BodyTypeService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSwagger();
app.UseSwaggerUI();
app.UseDefaultFiles();

app.UseStaticFiles();

app.UseRouting();
app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
