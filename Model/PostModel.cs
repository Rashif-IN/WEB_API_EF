using System;
namespace WEBAPIEF.Model
{
    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string tags { get; set; }
        public bool status { get; set; }
        public DateTime create_time { get; set; }
        public DateTime updated_time { get; set; }

    }
}
