public class Program{
    
     static int InputPeople(){
        Console.Write("Input People: ");
        return Console.ReadLine();
    }
    static string InputNumber() {
        Console.Write("Input Number: ");
        return Console.ReadLine(); 
    }

    static string InputScore(){
        Console.Write("Input Score: ");
        return Console.ReadLine();
    }

    static void PrintInputInformation( int People, string Number, string Score) {
        Console.WriteLine();
        Console.WriteLine("*******************************");
        Console.WriteLine("People is {0}", People);
        Console.WriteLine("Number is {0}", Number);
        Console.WriteLine("Score is {0}", Score);
        Console.WriteLine("*******************************");         
        }
        public static string ConvertNumberToGrade(int score){
            if ( 1 < InputNumber <= 10000) { throw new Exception("Please input Score 0 - 10"); } 

            if (InputPeople (Number) ){
                return "K1";
            } else if (InputPeople (Number)){
                return "K2";
            } else if (K1 == 10 (Number)){
                return "Full";
            } else if (K2 == 10 (Number)){
                return "Full";
    }
}
public static bool Pass (int score) {
    return (score <= 10 && score >= 8) ;
}
public static bool Not Pass (int score) {
    return score == 0 && score >= 5; 
}

static void Main(string [] args){
    int People = InputPeople();
    string NumberText = InputNumber();
    int scoreDecimal = int.Parse(scoreText);

    PrintInputInformation(People, NumberText, score);
}
}