using webApiDemo;

public class Startup
{
  public Startup(IConfiguration configuration)
  {
    Configuration = configuration;
  }

  public IConfiguration Configuration { get; }

  public void ConfigureServices(IServiceCollection services)
  {
    services.Configure<ChuckNorrisApiOptions>(Configuration.GetSection("ChuckNorrisApi"));

    services.AddHttpClient<ChuckNorrisService>();

    services.AddCors(options =>
    {
      options.AddPolicy("AllowAll",
        builder =>
        {
          builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
    });
    
    services.AddControllers();

    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
  }

  public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
  {
    if (env.IsDevelopment())
    {
      app.UseDeveloperExceptionPage();
      app.UseSwagger();
      app.UseSwaggerUI();
    }

    app.UseRouting();

    app.UseCors("AllowAll");

    app.UseHttpsRedirection();
    app.UseAuthorization();

    app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
  }
}