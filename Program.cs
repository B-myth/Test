class Program{
    static void Main(string[]args){
        ReadMenu();
        MainMenu();
    }

    static void Registration(){
        Console.WriteLine("Welcome to Registration Process.");
        Console.WriteLine("Please enter the information as shown.");
    }

    static void Statistic(){
        Console.WriteLine("Statistic Page");
    }

    static void Login(){
        Console.WriteLine("Login Page");
    }

    static void Clear(){
        Console.Clear();
    }

    static void Error(){
        Console.WriteLine("Error. Please try again.");     
    }

    static void ReadMenu(){
        Console.WriteLine("Welcome to the Program.");
        Console.WriteLine("Please type in the Menu number that you selected.");
        Console.WriteLine("========================================");
        Console.WriteLine(" 1 : Registration");
        Console.WriteLine(" 2 : Attender Statistics");
        Console.WriteLine(" 3 : Login");
        Console.WriteLine("========================================");
    }
    static void MainMenu(){
        int Menu;
        
        Menu = int.Parse(Console.ReadLine());

        switch (Menu){
            
            case 1 : Clear();
            Registration();
                break; 

            case 2 : Clear();
            Statistic();
                break;

            case 3 : Clear();
            Login();          
                break; 

            default : Error();
                      MainMenu(); 
                break;
        }      
    }

// Menu(); not finish

    static void AddUniInfo(){
        Univ[] univs = {new Univ(Heading(),InputName(),InputSurName(),InputID(),InputAge(),InputAllergy(),Religious(),AdminStat())};
    }

    static void AddStuInfo(){
        Student[] students = {new Student(Heading(),InputName(),InputSurName(),InputAge(),Gradeyear(),InputAllergy(),Religious(),School())};
    }

    static void AddTeachInfo(){
        Mentor[] mentors = {new Mentor(Heading(),InputName(),InputSurName(),Position(),InputAge(),InputAllergy() ,Religious(),Carinfo(),AdminStat())};
    }

    static string Heading(){
        Console.WriteLine("Please type in your header");
        Console.Write("Mr. ,Ms. , or Mrs. ");
        return (Console.ReadLine());
    }

    static string Gradeyear(){
        Console.WriteLine("Please type in your Gradeyear");
        Console.Write("Grade 10 , Grade 11 ,or Grade 12 ");
        return (Console.ReadLine());
    }

    static string Position(){
        Console.WriteLine("Please type in your Religious");
        Console.Write("Buddhism ,Christianity , Islam, or other ");
        return (Console.ReadLine());
    }
    static string Religious(){
        Console.WriteLine("Please type in your Religious");
        Console.Write("Buddhism ,Christianity , Islam, or other ");
        return (Console.ReadLine());
    }

    static bool AdminStat(){
        bool A;
        Console.Write("Admin? true or false. :");
        
        A = bool.Parse(Console.ReadLine());
        if (A == true){
           return true; 
        }
        else if  (A == false)
        {
            return false;
        }
        else 
        {
            return false;
        }  
    }

    static bool Carinfo(){
        bool A;
        Console.Write("Have car? true or false. :");
        
        A = bool.Parse(Console.ReadLine());
        if (A == true){
           return true; 
        }
        else if  (A == false)
        {
            return false;
        }
        else 
        {
            return false;
        } 
    }

    static string School(){
        Console.Write("School :");

        return Console.ReadLine();
    }

    static string InputName(){
        Console.Write("Name :");

        return Console.ReadLine();
    }

    static string InputID(){
        Console.Write("ID :");

        return Console.ReadLine();
    }

    static string InputSurName(){
        Console.Write("SurName : ");

        return Console.ReadLine();
    }

    static int InputAge(){
        Console.Write("Age : ");

        return int.Parse(Console.ReadLine());
    }

    static string InputAllergy() {
        Console.Write("Allergy : ");

        return Console.ReadLine();
    }

}


