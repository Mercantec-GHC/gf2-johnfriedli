using System;

namespace Opgaver
{
    public class ControlFlow
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(
                @"Velkommen til opgaver omkring Control Flow med if, else if og else, 
            Switch og Ternary operator!"
            );
            If1();
            If2();

            Switch1();
            Ternary1();

            MiniProjektQuiz();
            MiniProjektKarakterFeedback();
        }

        public static void If1()
        {
            Console.WriteLine(
                "Lav et program som tjekker om en given værdi er højere eller lavere end 18"
            );
            // Lav opgaven herunder!
            int number = int.Parse(Console.ReadLine());
            if (number > 18)
            Console.WriteLine("Tallet er større end 18");
            else 
            Console.WriteLine("Tallet er mindre end 18");
        }

        public static void If2()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
             
            int number = int.Parse(Console.ReadLine()); 
            if (number % 2 == 0)
                Console.WriteLine("number is even");
            else 
                Console.WriteLine("number is uneven");
            
                
                
        }

        public static void Switch1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            int number = int.Parse(Console.ReadLine());
            switch (number % 2)
            {
            

            case 0:
            Console.WriteLine("number is even");
            break;

            case 1:
            Console.WriteLine("number is uneven");
            break;
        }
    }

        public static void Ternary1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 2 == 0 ? "number is even" : "number is uneven");
        }

        public static void MiniProjektQuiz()
        {
            Console.WriteLine("\nMini-projekt: Simpelt quiz-spil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, der stiller brugeren tre spørgsmål (du vælger selv spørgsmål og svar)."
            );
            Console.WriteLine("Brugeren skal indtaste sit svar til hvert spørgsmål.");
            Console.WriteLine(
                "Programmet skal tjekke, om svaret er rigtigt eller forkert, og til sidst udskrive, hvor mange rigtige brugeren fik."
            ); 
            Console.WriteLine(
                "Tip: Brug variabler til at gemme point og svar, og if/else til at tjekke svarene."
            );
            // Lav opgaven herunder!
            int score = 0; 
            Console.WriteLine("What color is the sky?");
            if(Console.ReadLine()?.ToLower() == "blue")
            score++;
            Console.WriteLine("What color is the ocean?");
            if(Console.ReadLine()?.ToLower() == "blue")
                score++; 
            Console.WriteLine("How old are you?");
            if(Console.ReadLine() == "40")
                score++;
             Console.WriteLine($"You got {score} out of 3.");
        }

        public static void MiniProjektKarakterFeedback()
        {
            Console.WriteLine("\nMini-projekt: Karakter-feedback (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster en karakter (fx 12, 10, 7, 4, 02, 00 eller -3)."
            ); 
            Console.WriteLine(
                @"Programmet skal give en passende feedback baseret på karakteren, 
            fx 'Super flot!', 'Godt klaret', 'Du kan gøre det bedre' osv."
            );
            Console.WriteLine("Brug if/else eller switch til at vælge feedbacken.");

            Console.WriteLine(
                @"Ekstra opgave: Lav så man indtaster flere karaktere 
            for en bruger og man regner gennemsnittet ud."
            );
            // Lav opgaven herunder!
            
            Console.WriteLine("Type your grade (0-12");
            int grade = int.Parse(Console.ReadLine());

            if (grade < -3) (grade > 12);
            Console.WriteLine("Invalid grade");
            
            if (grade == 12)
            Console.WriteLine("Excellent");

            if (grade == 10)
                Console.WriteLine("Very good");
           
            if (grade == 7)
                Console.WriteLine("Good");
            
            if (grade == 4)
                Console.WriteLine("Okay");

            if (grade == 2)
                Console.WriteLine("Good");
            
            if (grade == 00)
                Console.WriteLine("try harder");

                if (grade == -3)
                    Console.WriteLine("Damn");
        }
    }
}
