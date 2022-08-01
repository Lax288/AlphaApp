using System;

namespace AlphaApp
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Random random = new Random();
            
           // var accountBalance = random.Next(100, 301);

            //int discount1 = 10;
           /// int discount2 = 20;
            
            //
          //  if(noOfDaysRemaining <= 10)
            //{
               //Console.WriteLine($"Your subscription will soon expire");
            //}   

            //if(noOfDaysRemaining <=5 )
            //{
            //   Console.WriteLine($"Your subscription will expire in {noOfDaysRemaining} days. \nRenew now and get {discount1}% discount." );
            //}
           
            //if(noOfDaysRemaining <= 2)
           // {
              //  Console.WriteLine($"Your subscription will expire in {noOfDaysRemaining} days. \nRenew now and get {discount2}% discount.");
           // }
           // if(noOfDaysRemaining >= 1)
          //////  {
           //     Console.WriteLine($"Your subscription will end in a day.")
           // }
           //Console.WriteLine($"Initial Account balance is: {accountBalance}\n");



           //var minimumBalance = 100;


           //while (accountBalance > minimumBalance)
           //{
              // var amount = random.Next(10, 50);
              // Console.WriteLine($"Amount to withdraw is: {amount}");
               //accountBalance -= amount;
               //Console.WriteLine($"New account balance is: {accountBalance}");
               //Console.WriteLine();


          // }
         
             //For WHILE LOOP to create A multiplication Table
         // int i = 1;
         // Console.Write("Enter the number the multiplication table: ");
         // int n = int.Parse(Console.ReadLine());
        //  do
        //  {
        //     Console.WriteLine($"{n} * {i} = {n*i}");
        //     ++i;
         // }  while (i <= 12);
         
         

        //string name = "Adelanwa";
         //int number = 564345;
         //var num = number.ToString();
         
         //foreach(char character in num)
        // {
        //    Console.WriteLine(character);
         //}
         // To diclear a odd num
         
         //long number = 08036448774;
        // string num = number.ToString();
        // foreach (char odd in num)
         
        // if (odd%2!=0)
        //  {
        //     Console.WriteLine(odd);
        //  }
            
        //    long number = 08036448774;
          //  string num = number.ToString();
            //foreach (char even in num)

           // if (even%2==0)
            //{
              // Console.WriteLine(even);
           // }
         
            //      .......Arrry  ......Example 1
         //int[] numbers = new int[10];
         //numbers[5] = 8;
         //foreach(int number in numbers)
         //{
         //   Console.WriteLine(number);
         //}
        //......... //   Example 2  \\..........\\
      
        // int[] numbers = {1,2,3,4,5,6,7,8,9,10};
      
         //numbers[5] = 8;
         
         //for(int i = 0; i < numbers.Length; i++)
        // {
           // Console.WriteLine(numbers[i]);
         //}


        // var numbers = new int[10];
      
        // numbers[i] = i+1;
         
        // for(int i = 0; i < numbers.Length; i++)
       //  {
         //   numbers[i] = i+1;
        //    Console.WriteLine(numbers[i]);
        // }

           /* int[] array = { 1, 2, 3, 4, 5 };
            int length = array.Length;
            int[] reversed = new int[length];

            for (int i = 0; i < length; i++)
            {
               reversed[length - i - 1] = array[i];
            }
            for (int i = 0; i < length; i++)
            {
               Console.Write(reversed[i] + " ");
            }*/
          //    No 1
           /* string[] Month = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
             int length = Month.Length;
             Console.WriteLine(length);

               // No2
               for (int i = 0; i < Month.Length; i++)
               {
                  Console.WriteLine("Rank[{0}] = {1}", i, Month[i]);
               }
               ///NO 3
               for(int i = Month.Length - 1 ;i >= 0; i--)
               {
                  Console.WriteLine(Month[i]);
               }
               
                       // No Array.Sort(month, (a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,) => String.Compare(a.month, b.month, c.month, d.month, e.month, f.month, g.month, h.month, i.month, j.month, k.month, l.month, m.month, n.month, o.month, p.month, q.month, r.month, s.month, t.month, u.month, v.month, w.month, x.month,  y.month, z.month));
               Array.Sort<Month>(Month);
               for(int i = 0; i < Month.Length; i++)
               {
                  Console.WriteLine(Month[i]);
               }*/    
                    // No 1
                  
               int count = 0;
    
               Console.Write("Enter first num: ");
               int m = Int32.Parse(Console.ReadLine());
               Console.Write("Enter second num: ");
               int n = Int32.Parse(Console.ReadLine());
    
               for (int i = m; i <= n; i++)
               {
                    if (i % 5 == 0) count++;
               }
    
               Console.WriteLine("{0} numbers found.", count);

               //  No 2

               
               int number1 = 0;
               int number2 = 1;
               int sum = 1;
               int counter = 0;
    
               Console.WriteLine(number1);
    
               while(counter < 100)
               {
                    sum = number1 + number2;
                    number1 = number2;
                    number2 = sum;
                    Console.WriteLine(number2);
                    counter++;

               }

                                       //  No 3
               
               
               
               Console.Write("Enter first number: ");
               int v = Int32.Parse(Console.ReadLine());
               Console.Write("Enter second number: ");
               int w = Int32.Parse(Console.ReadLine());
               Console.Write("Enter third number: ");
               int x = Int32.Parse(Console.ReadLine());
               Console.Write("Enter fourth number: ");
               int y = Int32.Parse(Console.ReadLine());
               Console.Write("Enter fifth number: ");
               int z = Int32.Parse(Console.ReadLine());
    
               if (v < w) v = w;
               if (v < x) v = x;
               if (v < y) v = y;
               if (v < z) v = z;
                Console.WriteLine("{0} is the biggest number.", v);
                    // No 4

               Console.Write("Input A (not 0): ");
               sbyte a = Convert.ToSByte(Console.ReadLine());
               Console.Write("Input B: ");
               sbyte b = Convert.ToSByte(Console.ReadLine());
               Console.Write("Input C: ");
               sbyte c = Convert.ToSByte(Console.ReadLine());

               sbyte d = (sbyte)(b * b - 4 * a * c);
               if (d < 0)
                 Console.WriteLine("\nD={0}\nThere are no real roots.", d);
               else if (d == 0)
               {
                  sbyte x1 = (sbyte)(-b / 2 * a);
                  Console.WriteLine("\nX={0}", x1);
               }
               else
               {
                  sbyte x1 = (sbyte)((-b + Math.Sqrt(d)) / (2 * a));
                  sbyte x2 = (sbyte)((-b - Math.Sqrt(d)) / (2 * a));
                  Console.WriteLine("\nX1={0}\nX2={1}", x1, x2);
               }
               Console.ReadLine();
            
               
         
               
               
               
                            // No 5
                           
              byte points;
             Console.Write("Enter points between 1 and 9: ");
             points = Convert.ToByte(Console.ReadLine());
             if (points >= 1 && points <= 3)
                Console.WriteLine("Points multiplied by 10: {0}", points * 10);
             else if (points >= 4 && points <= 6)
                Console.WriteLine("Points multiplied by 100: {0}", points * 100);
             else if (points >= 7 && points <= 9)
                Console.WriteLine("Points multiplied by 1000: {0}", points * 1000);
             else
                Console.WriteLine("Wrong Input!");
             Console.ReadLine();
                // NO 6

               
             Console.Write("Enter N: ");
             int length = Int32.Parse(Console.ReadLine());

             for (int i = 1; i < length; i++)
             {
                 if (i % (3 * 7) != 0) Console.WriteLine(i);
             }

                      // No 7

             

             for (int i = 0; i < 4; i++)
            {
                if(i != 0) Console.WriteLine();

                for (int j = 0; j < 13; j++)
                {
                    switch (i)
                    {
                        case 0: Console.Write("Hearts "); break;
                        case 1: Console.Write("Diamonds "); break;
                        case 2: Console.Write("Spades "); break;
                        case 3: Console.Write("Clubs "); break;
                    }
                    switch(j)
                    {
                        case 0: Console.WriteLine("2"); break;
                        case 1: Console.WriteLine("3"); break;
                        case 2: Console.WriteLine("4"); break;
                        case 3: Console.WriteLine("5"); break;
                        case 4: Console.WriteLine("6"); break;
                        case 5: Console.WriteLine("7"); break;
                        case 6: Console.WriteLine("8"); break;
                        case 7: Console.WriteLine("9"); break;
                        case 8: Console.WriteLine("10"); break;
                        case 9: Console.WriteLine("J"); break;
                        case 10: Console.WriteLine("Q"); break;
                        case 11: Console.WriteLine("K"); break;
                        case 12: Console.WriteLine("A"); break;
                    }
                }
            }
            Console.ReadLine();
            //      No 10
            
            

            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);
            }
                               // 12
               

             int Count = 1, tempCount = 1, number = 0;

			    Console.Write ("Enter array length: ");
			    int Length = Int32.Parse (Console.ReadLine ());
			    int[] Array = new int[length];

             for (int i = 0; i < Array.Length; i++) 
			   {
				    Console.Write ("Enter {0} element: ", i);
				    Array [i] = Int32.Parse (Console.ReadLine ());
			   }

			   for (int i = 0; i < Array.Length - 1; i++) 
			   {
                  if (arr[i] == Array[i + 1]) tempCount++;
                  else tempCount = 1;

				  if (tempCount > Count) 
				{
					Count = tempCount;
					number = Array [i];
				}
			   }

			     for (int i = 0; i < Count; i++) Console.Write ("{0}, ", number);
		  Console.WriteLine(".......Question 1.........");
          ushort number1 = 52130;
          sbyte number2 = -115;
          uint number3 = 4825932;
          byte number4 = 97;
          short number5 = -10000;
          short number6 = 20000;
          byte number7 = 224;
          uint number8 = 970700000;
          sbyte number9 = 112;
          sbyte number10 = -44;
          int number11 = -1000000;
          ushort number12 = 1992;
          long number13 = 123456789123456789; 
          
            Console.WriteLine(".......Question 2.........");
          double number1 = 34.567839023;
          float number2 = 12.345f;
          double number3 = 8923.1234857;
          decimal number4 = 3456.091124875956542151256683467m;                 
           
            Console.WriteLine(".......Question 3.........");  
            decimal number1 = 5.25745243896m;
            decimal number2 = 9.8544531763m;
            number1 += number2;
            Console.WriteLine(number1.ToString("#.######"));
            Console.WriteLine(".......Question 4.........");
            int number = 0x100;
            Console.WriteLine(".......Question 5.........");
            int number = 0x100;
            Console.WriteLine(".......Question 6.........");
            bool isMale = true;
            Console.WriteLine(".......Question 7.........");
             string stg1 = "Hello";
              string stg2 = "World";
              object obj = stg1 + " " + stg2;

                          Console.WriteLine(".......Question 8.........");
            string str1 = "Hello";
            string str2 = "World";
            object obj = str1 + " " + str2;
            string str3 = obj.ToString();  
                                      Console.WriteLine(".......Question 9.........");
            string str1 = "The \"use\" of quotations causes difficulties.";        
            string str2 = "The " + "\u0022" + "use" + "\u0022" + " of quotations causes difficulties";                          
                                                  Console.WriteLine(".......Question 10.........");
            Console.WriteLine("       0  0          0  0");
            Console.WriteLine("     0     0      0       0");
            Console.WriteLine("    0        0   0        0 ");
            Console.WriteLine("   0           0            0");
            Console.WriteLine("   0                       0");
            Console.WriteLine("   0                       0");
            Console.WriteLine("    0                     0");
            Console.WriteLine("     0                   0");
            Console.WriteLine("      0                 0");
            Console.WriteLine("       0               0");
            Console.WriteLine("        0             0");
            Console.WriteLine("         0          0");
            Console.WriteLine("           0       0");
            Console.WriteLine("               0 0 ");
            
            Console.WriteLine(".......Question 11.........");
             Console.WriteLine("     @");
              Console.WriteLine("   @ @");
              Console.WriteLine("  @   @");
              Console.WriteLine(" @     @");
              Console.WriteLine("@@@@@@@@");                                                  Console.WriteLine(".......Question 10.........");
              Console.WriteLine(".......Question 12.........");
                string firstName;
                string lastName;
                byte age;
                char gender;
                int id;  
                    Console.WriteLine(".......Question 13.........");
               int a = 2;
                int b = 3;
                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine("a:{0} b:{1}", a, b); 

               Console.WriteLine(".......Chapter 3.........");
                  Console.WriteLine(".......Question 1.........");
              int number = 53;
              bool even = number % 2 == 0 ? true : false;
              Console.WriteLine("{0} is even? {1}", number, even); 
                  Console.WriteLine(".......Question 2.........");

              int number = 36;
              bool divisible = number % 35 == 0 ? true : false;
              Console.WriteLine("{0} is divisible by both 5 and 7? {1}", number, even);
                                Console.WriteLine(".......Question 3.........");

               int number = 45764;
                bool isSeven = (number / 100) % 10 == 7 ? true : false;
                Console.WriteLine("Third digit of {0} is 7", number, even);
		   Console.WriteLine("Chapter 3");

            /*1. Write an expression that checks whether an integer is odd or even.
            2. Write a Boolean expression that checks whether a given integer is 
            divisible by both 5 and 7, without a remainder.
            3. Write an expression that looks for a given integer if its third digit (right 
            to left) is 7.
            4. Write an expression that checks whether the third bit in a given integer 
            is 1 or 0.
            5. Write an expression that calculates the area of a trapezoid by given 
            sides a, b and height h.
            6. Write a program that prints on the console the perimeter and the area 
            of a rectangle by given side and height entered by the user.
            7. The gravitational field of the Moon is approximately 17% of that on the 
            Earth. Write a program that calculates the weight of a man on the 
            moon by a given weight on the Earth.
            8. Write an expression that checks for a given point {x, y} if it is within 
            the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of 
            the circle and 5 is the radius.
            9. Write an expression that checks for given point {x, y} if it is within the 
            circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. 
            Clarification: for the rectangle the lower left and the upper right corners 
            are given.
            10. Write a program that takes as input a four-digit number in format abcd
            (e.g. 2011) and performs the following actions:
            - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
            - Prints on the console the number in reversed order: dcba (in our 
            example 1102).
            - Puts the last digit in the first position: dabc (in our example 1201).
            - Exchanges the second and the third digits: acbd (in our example 
            2101).
            
            11. We are given a number n and a position p. Write a sequence of 
            operations that prints the value of the bit on the position p in the 
            number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, 
            p=6 -> 0.
            12. Write a Boolean expression that checks if the bit on position p in the 
            integer v has the value 1. Example v=5, p=1 -> false.
            13. We are given the number n, the value v (v = 0 or 1) and the position p. 
            write a sequence of operations that changes the value of n, so the bit on 
            the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. 
            Another example: n=35, p=2, v=1 -> n=39.
            14. Write a program that checks if a given number n (1 < n < 100) is a 
            prime number (i.e. it is divisible without remainder only to itself and 1).
            15. * Write a program that exchanges the values of the bits on positions 
            3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32-bit unsigned 
            integer.
            16. * Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, 
            q+1, …, q+k-1} of a given 32-bit unsigned integer.*/


          Console.WriteLine("--------Question1-------");
          Console.WriteLine("Enter number to display if it is odd or even:");
          int number = int.Parse(Console.ReadLine());
          Console.Clear();
          Console.WriteLine($"{number} is odd: {number % 2 != 0}");
          Console.WriteLine($"{number} is even: {number % 2 == 0}");
          Console.WriteLine();

          Console.WriteLine("--------Question2-------");
          Console.WriteLine("Enter number :");
          int num1 = int.Parse(Console.ReadLine());
          Console.Clear();
          bool isdivisible = (num1 % 5*7 == 0) ? true : false;
          Console.WriteLine($"{num1} is divisible by 5 and 7 : {isdivisible}");
          Console.WriteLine();

          Console.WriteLine("--------Question3-------");
          
          int[] isSeven = new int[]{1,3,8,5,4};

          if(isSeven[2] == 7)
          {
            Console.WriteLine("The third digit is seven");
          }
          else
          {
            
            Console.WriteLine("The third digit is not seven");
          }
          Console.WriteLine();

          
          Console.WriteLine("--------Question4-------");

          int n = 451;
          Console.WriteLine($"The third bit of {n} is 1? {((n >> 3) & 1) == 1}");
          
          Console.WriteLine("--------Question5-------");
         Console.WriteLine("Enter a:");
         double a = double.Parse(Console.ReadLine());
         Console.Clear();
         Console.WriteLine("Enter b:");
         double b = double.Parse(Console.ReadLine());
         Console.Clear();
         Console.WriteLine("Enter h:");
         double h = double.Parse(Console.ReadLine());
         Console.Clear();
         double S =((a + b) * (h / 2));
         Console.WriteLine($"The area of the trapezoid a={a} and b={b} and h={h} is:{S}cm^2.");
         Console.WriteLine();

         Console.WriteLine("--------Question6-------");
         Console.WriteLine("Enter length:");
         int c = int.Parse(Console.ReadLine());
         Console.Clear();
         Console.WriteLine("Enter width:");
         int d = int.Parse(Console.ReadLine());
         Console.Clear();
         int A = c * d;
         int P = (c + d) * 2;
         Console.WriteLine($"The perimeter and area of the rectangle lenght={c} and width={d} is: {P}m and {A}m^2 respectively.");
         Console.WriteLine();

         
         Console.WriteLine("--------Question7-------");
         Console.WriteLine("Enter the weight of man on earth:");
         double weightOfManOnEarth = double.Parse(Console.ReadLine());
         Console.Clear();
         double percentGiven = 17d / 100;
         Console.WriteLine($"The weight of the man on the moon is: {weightOfManOnEarth * percentGiven}kg");
         Console.WriteLine();

         Console.WriteLine("--------Question8-------");
         Console.WriteLine("Enter x:");
         int x = int.Parse(Console.ReadLine());
         Console.Clear();
         Console.WriteLine("Enter y:");
         int y = int.Parse(Console.ReadLine());
         Console.Clear();
         bool isInside = (x * x) + (y * y) <= 25 ? true : false;
         Console.WriteLine($"The point ({x},{y}) is inside K((0, 0), R=5):{isInside}");
         Console.WriteLine();

         Console.WriteLine("--------Question9-------");
         Console.WriteLine("Enter x1:");
         int x1 = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter y1:");
         int y1 = int.Parse(Console.ReadLine());
         bool isInsideTheCircle = (x1 * x1) + (y1 * y1) <= 25;
         bool outOfRectangle = (x1 < -1 && x1 > 5) && (y1 < 1 && y1 > 5);
         bool isInsideAndOutOfRectangle = isInsideTheCircle && outOfRectangle ? true : false;
         if(isInsideAndOutOfRectangle)
         Console.WriteLine($"The point ({x},{y}) is inside the cirle and out of the rectangle:{isInsideAndOutOfRectangle}");
         
         Console.WriteLine("--------Question10-------");
         Console.WriteLine("Enter four digits number :");
         string num = Console.ReadLine();
         Console.Clear();
         int first = int.Parse(num[0].ToString());
         int second = int.Parse(num[1].ToString());
         int third = int.Parse(num[2].ToString());
         int fourth = int.Parse(num[3].ToString());
         Console.WriteLine($"Calculates the sum of the four digits:{first + second + third + fourth}");
         Console.WriteLine($"Prints on the console the number in reversed order :{fourth}{third}{second}{first}");
         Console.WriteLine($"Puts the last digit in the first position :{fourth}{first}{second}{third}");
         Console.WriteLine($"Exchanges the second and third digits :{first}{third}{second}{fourth}");
         Console.WriteLine();

         Console.WriteLine("--------Question11-------");
         int k = 351, p = 6, i = 1, m = i << p;
         Console.WriteLine((k & m) != 0 ? "Third bit is 1" : "Third bit is 0");
         Console.WriteLine();

         Console.WriteLine("--------Question12-------");
         int v = 85;
         int position = 2;
         int mask = 1 << position;
         bool isOne = (v & mask) != 0 ? true : false;
         Console.WriteLine($"The bit at position {position} of number {v} is 1? {isOne} ");
         Console.WriteLine();

         Console.WriteLine("--------Question13-------");
         int g = 350;
         int h = 0;
         int i = 3;
         g = (h == 0) ? g = g & (~(1 << i)): g = g | (1 << i);
         Console.WriteLine();

         Console.WriteLine("--------Question14-------");
         int counter = 0;
         Console.WriteLine("Enter a number:");
         int numberInput = int.Parse(Console.ReadLine());

         for(int i = 1; i <= numberInput; i++)
         {
          if( numberInput % i == 0)
          {
            counter++;
          }

         }
         if( counter == 2)
         {
          Console.WriteLine($"{numberInput} is a prime Number");
         }
         else
         {
           Console.WriteLine($"{numberInput} is not a prime Number");
         }
                
                                    
                           
            
            
              // chapter 4
          Console.WriteLine(".......Question 1.........");
          Console.Write("Enter First number: ");
          int e = Int32.Parse(Console.ReadLine());
          Console.Write("Enter Second number: ");
          int f = Int32.Parse(Console.ReadLine());
          Console.Write("Enter Third Number: ");
          int g = Int32.Parse(Console.ReadLine());
          Console.WriteLine("Sum is {0}", e + f + g);

          /*Console.WriteLine("........Question 2.....");
          Console.Write("Enter radius:");
          int d = Int32.Parse(Console.ReadLine());
          Console.WriteLine("P is {0} and S is {1}", 2 * Math.PI * d); */
          /*Console.WriteLine("......Question 4......");
          int hexaDecimal = 3015;
          Console.WriteLine("10*{0,-0;*}", hexaDecimal);
          double fractionNumber = -1.856;
          Console.WriteLine("{0,-10;f2}", fractionNumber);*/
           /* Console.WriteLine("...........Question 4.......");
         
          int hexNum = 2022;
          Console.WriteLine("|0x{0,-8:X}|", hexNum);
          double fracNum = -1.856;
          Console.WriteLine("|{0,-10:f2}|", fracNum);
          Console.WriteLine("........Question 5.....");
          int counter = 0;
          Console.Write("Enter First number: ");
          int k = Int32.Parse(Console.ReadLine());
          Console.Write("Enter second number: ");
          int l = Int32.Parse(Console.ReadLine());
          
          for (int i = k; i <= l; i++)
          {
            if (i % k == 0) counter++;
          } 
          
          Console.WriteLine("{0} number seen.", counter);
          Console.WriteLine("......Question 6......");

          Console.Write("Enter first number: ");
          int m = Int32.Parse(Console.ReadLine());
          Console.Write("Enter Second number: ");
          int n = Int32.Parse(Console.ReadLine());

          Console.WriteLine("{0} > {1}", Math.Max(m, n), Math.Min(m, n) );

          Console.WriteLine("...........Question 9.......");*/
          /*int sum = 0;
          Console.WriteLine("Enter numbers count: "); 
          int length = Int32.Parse(Console.ReadLine());
          for (int i = 0; i < length; i++)
          {
            Console.Write("Enter {0} number ", 1+1);
            sum + Int32.Parse(Console.ReadLine());
          } 
          Console.WriteLine("sum of all numbers {0}.", sum);*/
          /*Console.Write("Enter Number count: ");
          int number = int.Parse(Console.ReadLine());
          int num = 1;
          int sum = 1;
          Console.Write("The sum 1");
          while (num < number)
          {
            num++;
            sum += num;
            Console.Write(" + " + num);
          }
          Console.WriteLine(" = " + sum);
        
            Console.WriteLine("...........Question 10.......");

         
         
          int range = 0;
          Console.Write("Enter number: ");
          int length = Int32.Parse(Console.ReadLine());
          for (int i = 1; i <= length; i++)
          {
            Console.WriteLine(i);
          }
            int number1 = 0;
            int number2 = 1;
            int sums = 1;
            int count = 0;
    
            Console.WriteLine(number1);
    
            while(count < 100)
            {
                sums = number1 + number2;
                number1 = number2;
                number2 = sums;
                Console.WriteLine(number2);
                count++;

            }*/
            



          





           
           
           
           
           
           
           
           
           
           
                  // Chapter 5
          /*Write an if-statement that takes two integer variables and exchanges
          their values if the first one is greater than the second one.
          Console.WriteLine("-------Question 1-------");
          int firstNumber = 12;
          int secondNumber = 3;
          if (firstNumber > secondNumber)
          {
            Console.WriteLine("First number is greater than Second Number");
          }
          else
          {
            Console.WriteLine("First Number is not greater than Second Number");
          }
                   /* Write a program that shows the sign (+ or -) of the product of three real 
                        numbers, without calculating it. Use a sequence of if operators.

                    Console.WriteLine("  -------Question 2-------"); */

                     



          


         } 
      

    }
}
