//void ShowText()
//{
//    Console.WriteLine("Welcome PB101");

//}

//ShowText();

//void Sum()
//{
//    int a = 5;
//    int b = 10;
//    int sum = a + b;
//    Console.WriteLine(sum);
//}

//Sum();

//string SumOfNumbers()
//{
//    int a = 5;
//    int b = 10;
//    int sum = a + b;
//    string res = $"Sum of numbers is - {sum} and";
//    return res;
//}

//var result = SumOfNumbers();

//Console.WriteLine(result);

//void SumOfEvenNumbers()
//{
//    int[] elems = { 1, 2, 3, 4, 56 };

//    int sum = 0;

//    foreach (var item in elems)
//    {
//        if (item % 2 == 0)
//        {
//            sum += item;
//        }
//    }

//    Console.WriteLine(sum);
//}

//SumOfEvenNumbers();


//void Sum()
//{
//    int a = 5;
//    int b = 60;
//    int sum = a + b;
//    Console.WriteLine(sum);
//}

//void ShowText(string text)
//{
//    Console.WriteLine(text);
//}

//bool isMarried = true;

//if (isMarried)
//{
//    string text1 = "salam";
//    ShowText(text1);
//}
//else
//{
//    ShowText("Azerbaycan");
//}


//void Sum(int num1, int num2)
//{
//    int sum=num1+num2;
//    Console.WriteLine(sum);
//}

//Sum(100, 200);

//Sum(3, 10);


//int SumOfEvenNumbers(int[] elems,int number)
//{
//    int sum = 0;

//    foreach (var item in elems)
//    {
//        if (item % 2 == 0)
//        {
//            sum += item;
//        }
//    }

//    int result = sum + number;

//    return result;
//}

//int[] nums = { 1, 2, 3, 4 };

//var result = SumOfEvenNumbers(nums,5);

//Console.WriteLine(result);


//Console.WriteLine("Add your name :");

//string name = Console.ReadLine();

//Console.WriteLine("Add your surname :");

//string surname = Console.ReadLine();

//Console.WriteLine(name + "-" + surname);


//Console.WriteLine("Add first number: ");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Add second number: ");
//int num2 = int.Parse(Console.ReadLine());

//int result = num1 + num2;

//Console.WriteLine(result);

//int[] GetDatas(int num1, int num2, params int[] nums)
//{
//    return nums;
//}

//var result = GetDatas(1, 2, 3, 4, 5, 6);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//int SumOfDatas(int num1, int num2, params int[] nums)
//{
//    int sumNumbers = num1 + num2;

//    int sumOfArrayItems = 0;

//    foreach (var item in nums)
//    {
//        sumOfArrayItems += item;
//    }

//    int result=sumNumbers+sumOfArrayItems;

//    return result;
//}

//var result = SumOfDatas(1, 2, 3, 4, 5, 6);

//    Console.WriteLine(result);


//string GetName(string name = "XXX")
//{
//    return name;
//}

//Name: string name = Console.ReadLine();

//if (name == "")
//{
//    Console.WriteLine(GetName());
//    goto Name;
//}
//else
//{
//    Console.WriteLine(GetName(name));
//}


//string Login(string username, string password)
//{
//    string message;

//    if (username == "Cavid123" && password == "cavid123_")
//    {
//        message = "Login successful";
//    }
//    else
//    {
//        message = "Username or password is wrong";
//    }

//    return message;
//}

//Inputs: Console.WriteLine("Username:");
//string username = Console.ReadLine();

//Console.WriteLine("Password:");
//string password = Console.ReadLine();

//if (!IsValid(username, password))
//{
//    Console.WriteLine("Inputs cannot be empty");
//    goto Inputs;
//}

//string result = Login(username, password);

//Console.WriteLine(result);

//bool IsValid(string username, string password)
//{
//    if (username == "" || password == "")
//    {
//        return false;
//    }
//    return true;
//}