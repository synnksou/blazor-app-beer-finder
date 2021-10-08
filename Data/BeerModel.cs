using System;

namespace testblazor
{
    class Beer
    {
        public string Name { get; set; }
        public string Tagline { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public float Abv { get; set; }
        public string Url { get; set; }
        public Beer(string name, string tagline, string type, string description, DateTime date, float abv, string url)
        {
            this.Name = name;
            this.Tagline = tagline;
            this.Type = type;
            this.Description = description;
            this.Date = date;
            this.Abv = abv;
            this.Url = url;

        }

    }

}
