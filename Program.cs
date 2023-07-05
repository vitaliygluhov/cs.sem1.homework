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
    //int max_index = 0;
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
        Console.Write("- Задание 6: Программа принимает на вход два числа и определяет какое число больше. \r\n");
        //task 8
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("8 ");
        Console.ResetColor();
        Console.WriteLine("- Задание 8: Программа принимает на вход два числа и определяет какое число больше. \r\n");
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
            int input_num_array[];
            instr = Console.ReadLine();
            bool input_error = false;
            string[] words = instr.Split(" "); // раскладываем строку на слова


            /*
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
            */
            // проверяем содержат ли слова числа
            for(int i = 0; i < words.Length && !input_error; i++)
            {
                //Console.WriteLine(words[i]);
                input_error = !int.TryParse(words[i], out input_num_array[i]);
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
            task4_enabled = false;
        }
        else if (userinput == "r")
        {
            task4_enabled = true;
        }

    }
}



//int.TryParse(str.Substring(str.IndexOf(" ")+1, str.Length-str.IndexOf(" ")), out num2);
//tmp = str.Substring(str.IndexOf(" ")+1, str.Length-str.IndexOf(" ")-1);
//index = num1;
//Console.WriteLine(num1);
//Console.WriteLine(num2);