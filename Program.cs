using System;

namespace project {


    class Program {
        
        static void Main(){
            // int number;
            // number = -10;
            // Console.WriteLine(number);
            // number = 10 + 15;
            // Console.WriteLine(number);
            // int plusNumber = number +100;
            // Console.WriteLine(plusNumber);

            // float myNum = 2.4f;
            // double yourNum = 3.55d;
            // float theirNum = 56.8f;
            // Console.WriteLine(yourNum + theirNum);
            // Console.WriteLine(yourNum);

            // byte num1 = 9, num2 = 10;
            // int usersNum = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Num1: " + num1);
            // Console.WriteLine("Num2: " + num2);
            // int total = num1 + num2 + usersNum;
            // Console.WriteLine("Num2 + Num 1 + UsersNum = " + total);



            // Console.Write("Insert the number: ");
            // // user_input = Convert.ToDouble(Console.ReadLine());

            // float user_input = float.Parse(Console.ReadLine());

            // float result;
            // result = user_input + 10f;
            

            // Console.WriteLine("Variable: " + user_input);
            // Console.WriteLine("Result: " + result);

            // float doubledResult = result *= 2f;
            // Console.WriteLine("Result * 2: " + doubledResult);

            // doubledResult++;
            // Console.WriteLine("Result * 2: " + doubledResult);

            // Console.WriteLine(Math.PI);
            // Console.WriteLine(Math.Ceiling(4.11)); //Округляет до большего в данном случае округляет к 5. 
            // Console.WriteLine(Math.Floor(4.99)); // Округляет к меньшему - 4.
            // Console.WriteLine(Math.Round(4.6)); //округляет к ближайшему значению после точки, в данном случае к 5.
            // Console.WriteLine(Math.Round(4.5)); // 4
            // Console.WriteLine(Math.Min(4, 5)); // 4
            // Console.WriteLine(Math.Max(4, 5)); // 5
            // Console.WriteLine(Math.Pow(4, 5)); // 1024


// Ниже написали программу высчитывающую площадь круга при введенном пользователем радиусе...
            // System.Console.WriteLine("Insert radius of circle: ");
            // double radius = Convert.ToDouble(Console.ReadLine());
            // double area = Math.PI * Math.Pow(radius, 2);
            // System.Console.WriteLine("Площадь круга с радиусовм {0} равна {1}", radius, area);




            // Условные конструкции

            // System.Console.WriteLine("Insert a number: ");
            // double a = Convert.ToDouble(Console.ReadLine());
            // bool isHasCar = true;

            // if(a == 4){
            //     System.Console.WriteLine("You got it right!");
            // }else if(a < 4){
            //     System.Console.WriteLine("Your number is less than the one you guessed one...");
            // }else if(a == 5 && isHasCar){
            //     System.Console.WriteLine("User number 5 has a car...");
            //     // if(isHasCar){
            //     //     System.Console.WriteLine("this car is grey!");
            //     }else if((a > 4 || isHasCar) && a < 2 ){
            //     System.Console.WriteLine("Your number is greater than the one you guessed one...");
            // }else{
            //     Console.WriteLine("Incorrect number!");
            // }


            System.Console.WriteLine("Enter your name: ");
            string role = Console.ReadLine();

             if(role == "Admin"){
                System.Console.WriteLine("Enter user name: ");
                string user_name = Console.ReadLine();
                Console.Write("Enter {0} age: ", user_name);
                short age = Convert.ToInt16(Console.ReadLine());

                if(age <= 0 || age > 99){
                    Console.Write("Enter {0} age: ", user_name);
                    age = Convert.ToInt16(Console.ReadLine());
                }if(age <= 0 || age > 99){
                    Console.Write("Error: ");
                    age = Convert.ToInt16(Console.ReadLine());
                }else
                    System.Console.WriteLine("User's age is " + age);
             }else{
                System.Console.WriteLine("You are not an Admin");
             }
        }
    }
}