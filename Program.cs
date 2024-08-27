using System;

class Program{
    static void Main(String[] args){
        
        int [] Promedio = new int [10];

        for (int i = 0; i < 10; i++){
            Promedio[i] = int.Parse(Console.ReadLine());
        }

        rpromedio(Promedio);
    }

    public static void rpromedio(int [] pro){
        int rpro = 0, profi = 0, con = 0;

        for (int f = 0; f < 10; f++){
            rpro = rpro + pro[f]; 
        }

        profi = rpro / 10;
        Console.WriteLine($"El promedio es: {profi}");

        for (int i = 0; i < 10; i++){
            if(pro[i] > profi){
                Console.WriteLine($"Este numero {pro[i]} con el iterador {i} es mayor al promedio");
                con ++;
            }
        }
     Console.WriteLine($"La cantidad de numeros mayores al promedio son: {con}");
    }

}
