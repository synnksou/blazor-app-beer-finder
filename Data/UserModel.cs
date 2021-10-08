namespace testblazor
{
    public class Utilisateur
    {
        public string Name { get; set; }
        public string MotDePasse { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public string Token { get; set; }
        public Utilisateur(string Username, string Email, string Password)
        {
            this.Name = Username;
            this.Email = Email;
            this.MotDePasse = Password;
            this.Token = "";
            this.IsAdmin = false;
        }
    }

}

