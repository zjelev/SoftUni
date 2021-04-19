using System;

namespace BorderControl
{
    public class Rebel : Identity, IBirthable
    {
        public string Name { get; private set; }

        public string Birthdate { get; private set; }
    }
}
