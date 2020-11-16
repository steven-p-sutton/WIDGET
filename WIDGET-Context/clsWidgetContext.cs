using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Conductus.Widget.Exceptions; // Custom exceptions
using Conductus.Widget.Object;

// https://exceptionnotfound.net/ef-core-inmemory-asp-net-core-store-database/
// Install-Package Microsoft.EntityFrameworkCore.SqlServer
//
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/creating-and-throwing-exceptions
// throw new System.ArgumentException("Parameter cannot be null", "original");
// throw new System.InvalidOperationException("Logfile cannot be read-only");
// https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-create-user-defined-exceptions
// https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-create-localized-exception-messages
// https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-explicitly-throw-exceptions
// https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netcore-3.1

namespace Conductus.Widget.Context
{
    public class WidgetContext : DbContext
    {
        public WidgetContext(DbContextOptions<WidgetContext> options)
            : base(options)
        {
        }
        public DbSet<WidgetObject> Widgets { get; set; }

        // Dummy data setup so that InMemory database has 4 initial records in it
        private static readonly string[] Names = new[]
        {
            "Widget01", "Widget02", "Widget03", "Widget04", "Widget05", "Widget06", "Widget07", "Widget08", "Widget09", "Widget10"
        };

        private static Boolean bDataLoaded = false; // enure only loaded on first GET
        public void SetupData()
        {
            if (bDataLoaded)
            {
                return;
            }
            //var rng = new Random();

            for (int i = 1; i < 10; i++)
            {
                var widget = new WidgetObject
                {
                    Date = DateTime.Now.AddDays(i),
                    //TemperatureC = rng.Next(-20, 55),
                    Name = Names[i],
                    Count = i,
                    Secret = "Secret " + i.ToString()
                };

                this.Widgets.Add(widget);
                this.SaveChangesAsync();

                bDataLoaded = true;
            }
        }
        public async Task<IEnumerable<WidgetDTO>> Get()
        {
            return await this.Widgets
                .Select(x => new WidgetDTO(x))
                .ToListAsync();
        }

        public async Task<WidgetDTO> Get(long id)
        {
            var widget = await this.Widgets.FindAsync(id);

            if (widget == null)
            {
                // Custom Exceptions added
                throw new WidgetNotFoundException(
                    String.Format("Widget {0} Not Found", id)
                );
            }
            return new WidgetDTO(widget);
        }
        public async Task<WidgetDTO> Update(WidgetDTO widgetDTO)
        {
            var widget = await this.Widgets.FindAsync(widgetDTO.Id);

            if (widget == null)
            {
                // Custom Exceptions added
                throw new WidgetNotFoundException(
                    String.Format("Widget {0} Not Found", widgetDTO.Id)
                );
            }

            widget.Date = widgetDTO.Date;
            //widget.TemperatureC = widgetDTO.TemperatureC;
            //widget.Summaryx = widgetDTO.Summaryx;

            await this.SaveChangesAsync();

            return new WidgetDTO(widget);
        }
        public async Task<WidgetDTO> Create(WidgetDTO widgetDTO)
        {
            var widget = await this.Widgets.FindAsync(widgetDTO.Id);

            if (widget != null)
            {
                // Custom Exceptions added
                throw new WidgetAlreadyExistsException(
                    String.Format("Widget {0} Already exists", widgetDTO.Id)
                );
            }

            widget = new WidgetObject
            {
                Id = widgetDTO.Id,
                Date = widgetDTO.Date,
                //TemperatureC = widgetDTO.TemperatureC,
                //Summaryx = widgetDTO.Summaryx,
                Secret = string.Empty
            };

            this.Widgets.Add(widget);
            await this.SaveChangesAsync();

            return widgetDTO;
        }
        public async Task<WidgetDTO> Delete(long id)
        {
            var widget = await this.Widgets.FindAsync(id);

            if (widget == null)
            {
                // Custom Exceptions added
                throw new WidgetAlreadyExistsException(
                    String.Format("Widget {0} Not Found", id)
                );
            }

            this.Widgets.Remove(widget);
            await this.SaveChangesAsync();

            return new WidgetDTO(widget);
        }
        public bool WidgetExists(long id)
        {
            return this.Widgets.Any(e => e.Id == id);
            //return this.WidgetItems.AnyAsync(e => e.Id == id);
        }
    }
}
