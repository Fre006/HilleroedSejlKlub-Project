using HilleroedSejlKlub_Project.Models;
using HilleroedSejlKlub_Project.Services;
using Microsoft.Extensions.Logging;

namespace HilleroedSejlKlub_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

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

            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapRazorPages()
               .WithStaticAssets();

            app.Run();


            EventService service = new EventService();

            service.CreateEvent(new Event(1, "Informationsaften", new DateTime(2025, 4, 1)));
            service.CreateEvent(new Event(2, "Arbejdsdag", new DateTime(2025, 5, 1)));

            Member medlem1 = new Member(1, "Frederick ");
            Member medlem2 = new Member(2, "Youssef ");
            Member medlem3 = new Member(3, "Omar ");
            Member medlem4 = new Member(4, "Ahmed ");

            service.RegisterMemberToEvent(1, medlem1);
            service.RegisterMemberToEvent(1, medlem2);
            service.RegisterMemberToEvent(2, medlem3);
            service.RegisterMemberToEvent(2, medlem4);


            List<Event> allEvents = service.GetAllEvents();

            foreach (Event begivenhed in allEvents)
            {
                Console.WriteLine($"Event: {begivenhed.Name}, Dato: {begivenhed.Date.ToShortDateString()}");
                Console.WriteLine("Registered members:");
                foreach (Member member in begivenhed.RegisteredMembers)
                {
                    Console.WriteLine($"* {member.Name}");
                }
                Console.WriteLine();
            }




        }
    }
}
