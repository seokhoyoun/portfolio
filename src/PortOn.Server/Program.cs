using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.SignalR;

namespace PortOn.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.WithOrigins("https://your-wasm-app.com") // TODO:: launchSettings.json에서 가져오도록 수정
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowCredentials(); // SignalR에서 필요
                });
            });

            builder.Services.AddSignalR();

            builder.Services.AddControllers();

            builder.Services.AddHttpClient();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors();
            app.MapControllers();
            //app.MapHub<MyHub>("/hubs/myhub");


            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.Run();
        }
    }
}