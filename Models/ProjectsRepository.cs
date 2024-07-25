namespace AboutMarcinP.Models
{
    public static class ProjectsRepository
    {
        public static List<Project> projects = new()
        {
            new Project { Title = "My Tools Warehouse App [backend]", 
                Description = "Application created using Asp.Net technology and based on the CQRS pattern. " +
                "It is a backend service that issues endpionts to the user interface. " +
                "This service is also the access layer to the MsSql database.", 
                Link = "https://github.com/AboutMarcinPierchala/MyToolsMagBackend" },
            new Project { Title = "My Tools Warehouse User Interface App", 
                Description = "Front-end application created using Blazor technology. " +
                "It has authentication functions, an overview of tools and assigning them to a person and place. " +
                "The application communicates with the backend layer through REST queries and commands.",
                Link = "https://github.com/AboutMarcinPierchala/MyToolsWarehouseBlazorUI" },
            new Project { Title = "E-commerce web application used for selling photos",
                Description = "Web application created using ASP.Net MVC technology. " +
                "The main functions are managing photos for sale, customer service and payments. " +
                "When implemented into production, the entire database is automatically initialized and a default Administrator profile is created.",
                Link = "https://github.com/AboutMarcinPierchala/PhotosForSale_E_Commerce" },
            new Project { Title = "A web application used to remind me about important dates",
                Description = "This is a website where the user enters important events or tasks and determines their expiration date" +
                "Then, before this important date, the user receives e-mail notifications with a description" +
                "This application uses a simple Sqlite database supported by Entity Framework Core.",
                Link = "https://github.com/AboutMarcinPierchala/ImportantTasksAutoEmailer" },
            new Project { Title = "An external console application used to review expiring deadlines in the application above",
                Description = "The action trigger is set in Windows Task Scheduler, " +
                "Then the database is queried about overdue cases and those whose expiration date is approaching. " +
                "A summary email is automatically sent to the user.",
                Link = "https://github.com/AboutMarcinPierchala/ImportantTasksAutoEmailerOutServiceJob" }
        };

        public static List<Project> GetAllProjects() => projects;
    }
}
