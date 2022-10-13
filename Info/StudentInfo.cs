public class Student{
    
    private string Head;
    private string Name;
    private string SurName;
    private int Age;
    private string Education;
    private string Allergy;
    private string Belief;
    private string School;

    public Student(string Head, string Name, string SurName, int Age, string Education, string Allergy, string Belief, string School){
        this.Head = Head;
        this.Name = Name;
        this.SurName = SurName;
        this.Age = Age;
        this.Education = Education;
        this.Allergy = Allergy;
        this.Belief = Belief;
        this.School = School;
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

    public string GetEducation() {
        return this.Education;
    }

    public string GetAllergy() {
        return this.Allergy;
    }

    public string GetBelief() {
        return this.Belief;
    }

    public string GetSchool() {
        return this.School;
    }
}