namespace Portfolio
{
    public class ProjectImages
    {
        public ProjectImages(int imageId, string source, string imageDescription)
        {
            ImageId = imageId;
            Source = source;
            ImageDescription = imageDescription;
        }
        public int ImageId { get; set; }
        public string Source { get; set; }
        public string ImageDescription { get; set; }
    }
}
