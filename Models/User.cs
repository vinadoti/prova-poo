namespace UserProva.Models 
{ 
    public class User 
    {
        // Atributos da classe Game
        private Guid userId;   
        private string name;
        private string email;
        private string password;

        // propriedades da classe
        public Guid UserId { 
            get { return userId; } 
            set { userId = value; } 
        }

        public string Name { 
            get { return name; } 
            set { name = value; } 
        }

        public string Email { 
            get { return email; } 
            set { email = value; } 
        }

        public string Password { 
            get { return password; } 
            set { password = value; } 
        }
    }
}