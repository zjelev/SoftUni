using System;

namespace BorderControl
{
    public class Robot : Identity
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model { get; private set; }
    }
}
