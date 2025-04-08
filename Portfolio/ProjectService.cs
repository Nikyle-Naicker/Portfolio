using Portfolio.Components.Pages;

namespace Portfolio
{
    public class ProjectService : IProjectService
    {
        private readonly IList<Project> _projects;
        private readonly IList<ProjectImages> _images;

        public ProjectService() 
        {
            _projects = new List<Project>
            {
                 new Project(
                    "Finshark",
                    "Created with a REACT frontend, .NET backend and an SQL database for data storage" +
                    "A stock app that allows users to register an account, search for, and view various stock options from Nasdaq(provided by FMP)," +
                    " the user can add the stock options to their portfolio and can comment on the selected stock.",
                    "/pictures/finshark/finsharkhome.png",
                    "The server in use is on a free tier of a hosting service, so expect delays when using the app at first",
                    "https://github.com/Nikyle-Naicker/API",
                    "https://delightful-island-0a0d63a1e.4.azurestaticapps.net/",
                    1),
                    
                 new Project(
                     "Dewey",
                     "Created using Windows Presentation Foundation (WPF).The application consists of two games designed for people learning the dewey decimal system. Game 1 allows users to sort callnumbers in ascending order. " +
                     "Game 2 is a match the column game where users match the dewey class number to their correct description. Each game has their own difficulty selector.",
                     "/pictures/dewey/deweygamesort.png",
                     "",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A",
                     2)
            };
            _images = new List<ProjectImages>
            {
                new ProjectImages(
                    1,
                    "/pictures/finshark/finsharkhome.png",
                    "Home Page"),
                new ProjectImages(
                    1,
                    "/pictures/finshark/finsharksearch.png",
                    "Search Page"),
                new ProjectImages(
                    1,
                    "/pictures/finshark/finsharkcompanyprofile.png",
                    "Company Page"),

                new ProjectImages(
                    2,
                    "/pictures/dewey/deweygamesort.png",
                    "Sort the callnumbers game"),
                new ProjectImages(
                    2,
                    "/pictures/dewey/deweygame2.png",
                    "Match the column game"),
                new ProjectImages(
                    2,
                    "/pictures/dewey/deweydifficultyselection.png",
                    "Difficulty Selection")

            };
        }

        public IEnumerable<Project> GetProjects()
        {
            return _projects.ToList();
        }

        public Project GetProjectByTitle(string title)
        {
            return _projects.Where(p => p.Title == title).FirstOrDefault();
        }

        public IEnumerable<ProjectImages> GetImages(int imageId)
        {
            return _images.Where(i => i.ImageId == imageId).ToList();
        }
    }
}
