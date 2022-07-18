using System;

namespace AutoMapping.Models
{
    public class SongViewModel
    {
        public string Name { get; set; }

        public string Artists { get; set; }

        public string SourceName { get; set; } //Flatenning

        public DateTime LastModified { get; set; }
    }
}