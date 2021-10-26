namespace Stealer
{
public class Hacker
    {
        public string username = "securityGod82";
        private string password = "mySuperSecretPassw0rd";

        public Hacker(string name, string passwd)
        {
            this.username = name;
            this.Password = passwd;
        }

        public Hacker(string name, string passwd, int id)
        {
            this.username = name;
            this.Password = passwd;
            this.Id = id;
        }


        public string Password
        {
            get => this.password;
            set => this.password = value;
        }

        private int Id { get; set; }

        public double BankAccountBalance { get; private set; }

        public void DownloadAllBankAccountsInTheWorld()
        {
            System.Console.WriteLine("No money here");
        }
    }
}
