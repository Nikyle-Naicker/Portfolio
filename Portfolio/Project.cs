namespace Portfolio
{
    public class Project
    {
        public Project(string title, string description, string note, string github, string liveLink)
        {
            Title = title;
            Description = description;
            Note = note;
            Github = github;
            Live_Link = liveLink;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string Github { get; set; }
        public string Live_Link { get; set; }

      
    }
}
