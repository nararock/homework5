    static public class MyLibrary{
    //заполнение массива
        public static int[] FillIntArray(int minNumber, int maxNumber){
            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++){
                array[i] = new Random().Next(minNumber, maxNumber);
            }
            return array;
        }

        public static double[] FillDoubleArray(double minNumber, double maxNumber){
            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Round(new Random().NextDouble() * (maxNumber - minNumber) + minNumber, 2);
            }
            return array;
        }

        public static int GetAverage(int[] array){
            int avg = 0;
            foreach(int element in array){
                avg += element;
            }
            return avg/array.Length;
        }
    }

