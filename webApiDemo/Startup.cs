using Microsoft.Extensions.Configuration;
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
      options.AddPolicy("AllowLocalhost",
        builder =>
        {
          builder.WithOrigins("http://localhost:3000")
            .AllowAnyMethod()
            .AllowAnyHeader();
        });

      options.AddPolicy("AllowVercel",
        builder =>
        {
          builder.WithOrigins("https://dav-dan-app-s3u7.vercel.app")
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

    app.UseCors(env.IsDevelopment() ? "AllowLocalhost" : "AllowVercel");
    app.UseRouting();
    app.UseCors("AllowLocalhost");

    app.UseHttpsRedirection();
    app.UseAuthorization();

    app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
  }
}