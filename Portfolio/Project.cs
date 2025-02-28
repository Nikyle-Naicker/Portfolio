namespace Portfolio
{
    public class Project
    {
        public Project(string title, string description, string projectThumbnail ,string note, string github, string liveLink, int projectImageId)
        {
            Title = title;
            Description = description;
            ProjectThumbnail = projectThumbnail;
            Note = note;
            Github = github;
            Live_Link = liveLink;
            ProjectImageId = projectImageId;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProjectThumbnail { get; set; }
        public string Note { get; set; }
        public string Github { get; set; }
        public string Live_Link { get; set; }
        public int ProjectImageId { get; set; }
      
    }
}
