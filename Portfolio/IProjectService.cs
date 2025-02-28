using Portfolio.Components.Pages;
namespace Portfolio
    
{
    public interface IProjectService
    {
        public IEnumerable<Project> GetProjects();
        public Project GetProjectByTitle(string title);
        public IEnumerable<ProjectImages> GetImages(int imageId);
    }
}
