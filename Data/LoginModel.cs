namespace testblazor{
   public class Login { 
        public string MotDePasse { get; set; }
        public string Email { get; set; }

        public Login(string motDePasse, string email)
        {
            this.Email=email;
            this.MotDePasse=motDePasse;
        }

        
    }
}