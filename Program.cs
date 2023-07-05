// My Functions
//задание 2
string VGTask2(int number_1, int number_2)
{
    string str_out;
    if (number_1 > number_2)
    {
        str_out = "Число " + number_1 + " больше чем " + number_2;
    }
    else
    {
        str_out = "Число " + number_2 + " больше чем " + number_1;
    }
    return str_out;
}
//задание 4
string VGTask4(int[] numbers)
{
    string str_out;
    int max_value = numbers[0];
    for(int i = 0; i < numbers.Length; i++)
    {
        if( numbers[i] > max_value)
        {
            max_value = numbers[i];
        }

    }
    str_out = $"Максимальное значение: {max_value}";

    return str_out;
}
//задание 6
string VGTask6(int number)
{
    string str_out;
    if(number%2 == 1)
    {
       str_out = $"Число {number} НЕ является четным"; 
    }
    else
    {
        str_out = $"Число {number} является четным";
    }
    
    return str_out;
}



//-----------------------------------------------------------------------------------
string instr;
int num1 = 0, num2 = 0;
string error_mssg = "ОШИБКА! введенные данные не являются числами. Повторите попытку";
bool input_status = false;
//bool task_enabled = true;
//bool sel_task = false; // определяет какое задание было выбрано, было ли оно выбрано
bool task2_enabled = false, task4_enabled = false, task6_enabled = false, task8_enabled = false; // флаги для выбранных заданий

//-----------------------------------------------------------------------------------
while (true)
{
    //MENU
    while (!task2_enabled && !task4_enabled && !task6_enabled && !task8_enabled)
    {
        string input_sel_task; // вводимый выбор
        Console.Clear();
        Console.WriteLine("Вибирите задание:\r\n");
        //task 2
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("2 ");
        Console.ResetColor();
        Console.Write("- Задание 2: Программа принимает на вход два числа и определяет какое число больше. \r\n");
        //task 4
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("4 ");
        Console.ResetColor();
        Console.Write("- Задание 4: Программа принимает на вход три числа и выдает максимальное из них. \r\n");
        //task 6
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("6 ");
        Console.ResetColor();
        Console.Write("- Задание 6: Программа принимает число и проверяет является ли оно четным. \r\n");
        //task 8
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("8 ");
        Console.ResetColor();
        Console.WriteLine("- Задание 8: Программа принимает число и проверяет является ли оно четным. \r\n");
        //quit
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("q ");
        Console.ResetColor();
        Console.WriteLine("- Завершить программу. \r\n");
        //sel task
        Console.Write("Введите значение соответствующее номеру задания: ");
        input_sel_task = Console.ReadLine().ToLower();


        if (input_sel_task == "q")
        {
            Console.Clear();
            System.Environment.Exit(0);
        }
        else if (input_sel_task == "2")
        {
            task2_enabled = true;
        }
        else if (input_sel_task == "4")
        {
            task4_enabled = true;
        }
        else if (input_sel_task == "6")
        {
            task6_enabled = true;
        }
        else if (input_sel_task == "8")
        {
            task8_enabled = true;
        }
    }


    //Задание 2
    while (task2_enabled)
    {
        input_status = false;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Задание 1");
        Console.ResetColor();
        Console.WriteLine("Программа принимает на вход два числа и определяет какое число больше. \r\n");
        Console.WriteLine("Введите два числа разделенные пробелом:");

        while (!input_status)
        {
            instr = Console.ReadLine();
            if (instr.IndexOf(" ") == -1 || !int.TryParse(instr.Substring(0, instr.IndexOf(" ")), out num1) || !int.TryParse(instr.Substring(instr.IndexOf(" ") + 1, instr.Length - instr.IndexOf(" ") - 1), out num2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(error_mssg);
                Console.ResetColor();
            }
            else
            {
                input_status = true;
            }
        }

        Console.WriteLine(VGTask2(num1, num2) + "\r\n");
        Console.WriteLine("Повторить это задание или вернуться в меню?");
        Console.Write("Повторить ( ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("r");
        Console.ResetColor();
        Console.Write(" ), меню  ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("m");
        Console.ResetColor();
        Console.WriteLine(": ");
        string userinput = Console.ReadLine().ToLower();
        if (userinput == "m")
        {
            task2_enabled = false;
        }
        else if (userinput == "r")
        {
            task2_enabled = true;
        }

    }
    //Задание 4
    while (task4_enabled)
    {
        input_status = false;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Задание 1");
        Console.ResetColor();
        Console.WriteLine("Программа принимает на вход три числа и выдает максимальное из них. \r\n");
        Console.WriteLine("Введите несколько чисел разделенные пробелами:");

        
        while (!input_status)
        {
            input_status = false;
            instr = Console.ReadLine();
            int input_error_count = 0;//Счетчик ошибок в вводе
            string[] words = instr.Split(" "); // раскладываем строку на слова
            // проверяем содержат ли слова числа
            int[] input_num_array = new int[words.Length];
            for(int i = 0; i < words.Length; i++)
            {
                //Console.WriteLine(words[i]);
                if(!int.TryParse(words[i], out input_num_array[i]))
                {
                    input_error_count++;
                }
            }
            if(input_error_count == 0)
            {
                input_status=true;
                Console.WriteLine(VGTask4(input_num_array) + "\r\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(error_mssg);
                Console.ResetColor();
            }
        }
        Console.WriteLine("Повторить это задание или вернуться в меню?");

        Console.Write("Повторить ( ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("r");
        Console.ResetColor();
        Console.Write(" ), меню  ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("m");
        Console.ResetColor();
        Console.WriteLine(": ");
        string userinput = Console.ReadLine().ToLower();
        if (userinput == "m")
        {
            task4_enabled = false;
        }
        else if (userinput == "r")
        {
            task4_enabled = true;
        }

    }
    //Задание 6
    while (task6_enabled)
    {
        input_status = false;
        int num = 0;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Задание 1");
        Console.ResetColor();
        Console.WriteLine("Программа принимает на вход два числа и определяет какое число больше. \r\n");
        Console.WriteLine("Введите число:");

        while (!input_status)
        {
            instr = Console.ReadLine();
            if (int.TryParse(instr, out num))
            {
                input_status = true;
            }
            else
            {
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(error_mssg);
                Console.ResetColor();
            }
        }

        Console.WriteLine(VGTask6(num) + "\r\n");
        Console.WriteLine("Повторить это задание или вернуться в меню?");
        Console.Write("Повторить  ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("r");
        Console.ResetColor();
        Console.Write(", меню  ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("m");
        Console.ResetColor();
        Console.WriteLine(": ");
        string userinput = Console.ReadLine().ToLower();
        if (userinput == "m")
        {
            task6_enabled = false;
        }
        else if (userinput == "r")
        {
            task6_enabled = true;
        }

    }
}
