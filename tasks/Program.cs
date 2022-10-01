
Console.WriteLine(@"Какую задачу изволите запустить?
 Введите:
  1 - для задачи 34;
  2 - для задачи 36;
  3 - для задачи 38;
  4 - для задачи с *;
  5 - для задачи с ** ");
  int answer = Convert.ToInt32(Console.ReadLine());

  switch(answer){
    case 1: task34();
            break;
    case 2: task36();
            break;
    case 3: task38();
            break;
    case 4: starTask();
            break;
    case 5: doubleStarTask();
            break;
    default: Console.WriteLine("Вы ввели что-то не то!");
            break;                  
  } 


void task34(){
    // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    // Напишите программу, которая покажет количество чётных чисел в массиве.
    int[] array = MyLibrary.FillIntArray(100,1000);
    int amountEvenNumbers = getAmountEvenNumber(array);
    Console.WriteLine("Количество четных элементов в массиве [" + String.Join(",", array) + $"] равно {amountEvenNumbers}");

    int getAmountEvenNumber(int[] arr){
        int counter = 0;
        for(int i = 0; i < arr.Length; i++){
            if (arr[i] % 2 == 0){
                counter++;
            }
        }
        return counter;
    }
}

void task36(){
    //Задача 36: Задайте одномерный массив, заполненный случайными числами.
    //Найдите сумму элементов, стоящих на нечётных позициях.
    int[] array = MyLibrary.FillIntArray(1, 100);
    Console.WriteLine("Сумма элементов, стоящих на нечетных позициях в массиве [" + String.Join(",", array) +
     $"] равна {getSum(array)}");

    int getSum(int[] arr){
        int sum = 0;
        for (int i = 1; i < arr.Length; i+=2){
            sum += arr[i];
        }
        return sum;
    }
}

void task38(){
    //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    double[] array = MyLibrary.FillDoubleArray(1, 100);//числа в массиве округлены до двух знаков после запятой для наглядного вывода
    Console.WriteLine("Разница между максимальным и  минимальным элементами массива [" + String.Join("  ", array) +
    $"] равна {Math.Round(array.Max() - array.Min(), 2)}");
}

void starTask(){
    //Задайте одномерный массив, заполненный случайными числами. Из входного массива 
    //сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. 
    //Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат 
    //сравнения средних арифметических.
    int[] array = MyLibrary.FillIntArray(1, 10);
    int[] evenArray = new int[array.Length];
    int[] oddArray = new int[array.Length];
    int evenCounter = 0;
    int oddCounter = 0;

    for(int i = 0; i<array.Length; i++){
        if (array[i] % 2 == 0){
            evenArray[evenCounter] = array[i];
            evenCounter++;
        }
        else {
            oddArray[oddCounter] = array[i];
            oddCounter++;
        } 
    }
    
    Array.Resize(ref evenArray, evenCounter);
    Array.Resize(ref oddArray, oddCounter);
    Console.WriteLine("четные элементы [" + String.Join(",", evenArray) + "], нечетные элементы [" + String.Join(",", oddArray) + "]");

    double evenAverage = Math.Round(evenArray.Average(), 2);
    double oddAverage = Math.Round(oddArray.Average(), 2);

    if (evenAverage > oddAverage){
        Console.WriteLine("[" + String.Join(",", array)+$"] -> средн. арифм. значений элементов массива с чётными числами ({evenAverage}) > средн. арифм. значений элементов с нечётными числами ({oddAverage})");
    }
    else if (evenAverage < oddAverage){
        Console.WriteLine("[" + String.Join(",", array)+$"] -> средн. арифм. массива значений элементов с нечётными числами ({evenAverage}) > средн. арифм. значений элементов с чётными числами ({oddAverage})");
    }
    else Console.WriteLine("[" + String.Join(",", array)+ $"] -> средн. арифм. значений элементов массива с нечётными числами ({evenAverage}) = средн. арифм. значений элементов с чётными числами ({oddAverage})");
}

void doubleStarTask(){
    //Задайте одномерный массив из N элементов, заполненный случайными числами. 
    //Необходимо определить, в какой последовательности заданы элементы массива: по возрастанию, по убыванию, хаотично, или все элементы одинаковы.
    int[] array = MyLibrary.FillIntArray(1, 10);

    if(checkEquality(array)){
        Console.WriteLine("[" + String.Join(",", array) + "] -> равны");
    }
    else if(checkReducing(array)){
        Console.WriteLine("[" + String.Join(",", array) + "] -> по убыванию");
    }
    else if (checkIncreasing(array)){
        Console.WriteLine("[" + String.Join(",", array) + "] -> по возрастанию");
    }
    else Console.WriteLine("[" + String.Join(",", array) + "] -> хаотично");

    bool checkIncreasing(int[] arr){
        if (checkEquality(arr)) return false;
        for(int i = 1; i < arr.Length; i++){
            if(arr[i - 1] > arr[i]) return false; 
        }
        return true;
    }

    bool checkReducing(int[] arr){
        if (checkEquality(arr)) return false;
        for(int i = 1; i < arr.Length; i++){
            if(arr[i - 1] < arr[i]) return false; 
        }
        return true;
    }

    bool checkEquality(int[] arr){
        for(int i = 1; i < arr.Length; i++){
            if(arr[i - 1] != arr[i]) return false; 
        }
        return true;
    }
}

