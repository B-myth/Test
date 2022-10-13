public class UniInfo{

    private string Head;
    private string Name;
    private string SurName;
    private string ID;
    private int Age;
    private string Allergy;
    private string Belief;
    private Boolean Admin;
    
    public UniInfo(string Head, string Name, string SurName, string ID, int Age, string Allergy, string Belief, Boolean Admin){
        this.Head = Head;
        this.Name = Name;
        this.SurName = SurName;
        this.ID = ID;
        this.Age = Age;
        this.Allergy = Allergy;
        this.Belief = Belief;
        this.Admin = Admin;
         
    }

    public string GetHead(){
        return this.Head;
    }
        
        public string GetName(){
        return this.Name;
    }

    public string GetSurName(){
        return this.SurName;
    }

    public string GetID(){
        return this.ID;
    }

    public int GetAge(){
        return this.Age;
    }

    public string GetAllergy(){
        return this.Allergy;
    }

    public string GetBelief(){
        return this.Belief;
    }

    public Boolean GetAdmin(){
        return this.Admin;
    }

    
}

public class AdminStatus{
    private string Mail;
    private string Password;

    public AdminStatus(string Mail, string Password){
        this.Mail = Mail;
        this.Password = Password;
    } 
    
    public string GetMail(){
        return this.Mail;
    }

    public string GetPassword(){
        return this.Password;
    }

}