using Portfolio.Components.Pages;

namespace Portfolio
{
    public class ProjectService : IProjectService
    {
        private readonly IList<Project> _projects;

        public ProjectService() 
        {
            _projects = new List<Project>
            {
                 new Project(
                    "Finshark",
                    "A stock app",
                    "Server startup takes long",
                    "https://github.com/Nikyle-Naicker/API",
                    "https://delightful-island-0a0d63a1e.4.azurestaticapps.net/"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A"),
                 new Project(
                     "Dewey",
                     "Library game",
                     "Third game not implemented yet",
                     "https://github.com/Nikyle-Naicker/Library_Game",
                     "N/A")

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
    }
}
