public class Mentor{

    private string Head;
    private string Name;
    private string SurName;
    private int Age;
    private string Position;
    private string Allergy;
    private string Belief;
    private Boolean Car;
    private Boolean Admin;
    
    public Mentor(string Head, string Name, string SurName, string Position, int Age, string Allergy, string Belief, Boolean Car, Boolean Admin){
        this.Head = Head;
        this.Name = Name;
        this.SurName = SurName;
        this.Age = Age;
        this.Position = Position;
        this.Allergy = Allergy;
        this.Belief = Belief;
        this.Car = Car;
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
    
    public int GetAge(){
        return this.Age;
    }

    public string GetPosition(){
        return this.Position;
    }

    public string GetAllergy(){
        return this.Allergy;
    }

    public string GetBelief(){
        return this.Belief;
    }

    public Boolean GetCar(){
        return this.Car;
    }

    public Boolean GetAdmin(){
        return this.Admin;
    }

    
}

public class MAdminStatus{
    private string Mail;
    private string Password;

    public MAdminStatus(string Mail, string Password){
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

public class Car{
    private string CarAddress;

    public Car(string CarAddress){
        this.CarAddress = CarAddress;
    }

    public string GetCarAddress(){
        return this.CarAddress;
    }
}