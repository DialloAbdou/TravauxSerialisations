namespace ModelsSerialisation
{
    public class Video
    {
        public string Titre { get; set; } = string.Empty;
        public int Duree { get; set; }
        public Youtubeur Youtubeur { get; set; } = default;
        public List<string> Tags { get; set; }
    }
}