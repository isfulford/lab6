namespace lab6
{
    public class Author
    {
        private string name;
        private char gender;
        private string email;

        public Author(string tempName, char tempGender, string tempEmail){
           this.name = tempName;
           this.gender = tempGender;
           this.email = tempEmail;
        }
        public string GetName(){
            return name;
        }
        private void SetName(string tempName){
            this.name = tempName;
        }
        public void SetGender(char tempGender){
            this.gender = tempGender;
        }
        public string GetEmail(){
            return email;
        }
        private void SetEmail(string tempEmail){
            this.email = tempEmail;
        }
        public override string ToString(){
            return "name = " + name + ", email = " + email + ", gender = " + gender;
        }


    }
}