using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        float result;
        bool flag = true;
        while(flag == true){
            Console.WriteLine("Ingresa la opcion a realizar: \n 1. Sumar \n 2. Restar \n 3. Multiplicar \n 4. Dividir \n 5. Potencia \n 6. Raiz \n 7. Salir \n ");
            string options = Console.ReadLine();
            while (options != "1" && options != "2" && options != "3" && options != "4" && options != "5" && options != "6" && options != "7")
            {
                Console.WriteLine("Ingresa una opcion valida");
                options = Console.ReadLine();
            }
            switch (options)
            {
                case "1":
                    result = Sumar();
                    Console.WriteLine("El resultado de la suma es: " + result);
                    break;
                case "2":
                    result = Restar();
                    Console.WriteLine("El resultado de la resta es: " + result);
                    break;
                case "3":
                    result = Multiplicar();
                    Console.WriteLine("El resultado de la multiplicacion es: " + result);
                    break;
                case "4":
                    result = Dividir();
                    Console.WriteLine("El resultado de la division es: " + result);
                    break;
                case "5":
                    result = Potencia();
                    Console.WriteLine("El resultado de la potencia es: " + result);
                    break;
                case "6":
                    result = Raiz();
                    Console.WriteLine("El resultado de la raiz es: " + result);
                    break;
                case "7":
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Algo fallo, por favor intenta de nuevo");
                    break;
            }
        }
    }
    static float Sumar()
    {
        float num = 0;
        float result = 0;
        bool flag = false;
        Console.WriteLine("Ingresa el primer numero: ");
        num = float.Parse(Console.ReadLine());
        result += num;
        Console.WriteLine("Ingresa el segundo numero: ");
        num = float.Parse(Console.ReadLine());
        result += num;
        Console.WriteLine("Desea sumar mas numeros? \n 1. Si \n 2. No");
        string options = Console.ReadLine();
        if (options == "1")
        {
            flag = true;
        }
        while(flag == true){
            Console.WriteLine("Ingresa el siguiente numero: ");
            num = float.Parse(Console.ReadLine());
            result += num;
            Console.WriteLine("Desea sumar mas numeros? \n 1. Si \n 2. No");
            options = Console.ReadLine();
            if (options == "2")
            {
                flag = false;
            }
        }
        return result;
    }

    static float Restar()
    {
        float num = 0;
        float result = 0;
        bool flag = false;
        Console.WriteLine("Ingresa el primer numero: ");
        num = float.Parse(Console.ReadLine());
        result = num;
        Console.WriteLine("Ingresa el segundo numero: ");
        num = float.Parse(Console.ReadLine());
        result -= num;
        Console.WriteLine("Desea restar mas numeros? \n 1. Si \n 2. No");
        string options = Console.ReadLine();
        if (options == "1")
        {
            flag = true;
        }
        while (flag == true)
        {
            Console.WriteLine("Ingresa el siguiente numero: ");
            num = float.Parse(Console.ReadLine());
            result -= num;
            Console.WriteLine("Desea restar mas numeros? \n 1. Si \n 2. No");
            options = Console.ReadLine();
            if (options == "2")
            {
                flag = false;
            }
        }
        return result;
    }

    static float Multiplicar()
    {
        float num = 0;
        float num2 = 0;
        float result = 0;
        bool flag = false;
        Console.WriteLine("Ingresa el primer numero: ");
        num = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el segundo numero: ");
        num2 = float.Parse(Console.ReadLine());
        result = num * num2;
        Console.WriteLine("Desea multiplicar el resultado por otro numero? \n 1. Si \n 2. No");
        string options = Console.ReadLine();
        if (options == "1")
        {
            flag = true;
        }
        while (flag == true){
            Console.WriteLine("Ingresa el siguiente numero: ");
            num2 = float.Parse(Console.ReadLine());
            result = result * num2;
            Console.WriteLine("Desea multiplicar el resultado por otro numero? \n 1. Si \n 2. No");
            options = Console.ReadLine();
            if (options == "2")
            {
                flag = false;
            }
        }
        return result;
    }

    static float Dividir()
    {
        float num = 0;
        float num2 = 0;
        float result = 0;
        bool flag = false;
        Console.WriteLine("Ingresa el primer numero: ");
        num = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el segundo numero: ");
        num2 = float.Parse(Console.ReadLine());
        result = num / num2;
        Console.WriteLine("Desea dividir el resultado por otro numero? \n 1. Si \n 2. No");
        string options = Console.ReadLine();
        if (options == "1")
        {
            flag = true;
        }
        while (flag == true)
        {
            Console.WriteLine("Ingresa el siguiente numero: ");
            num2 = float.Parse(Console.ReadLine());
            result = result / num2;
            Console.WriteLine("Desea dividir el resultado por otro numero? \n 1. Si \n 2. No");
            options = Console.ReadLine();
            if (options == "2")
            {
                flag = false;
            }
        }
        return result;
    }

    static float Potencia()
    {
        float num = 0;
        int exp = 0;
        float result = 0;
        Console.WriteLine("Ingresa el numero: ");
        num = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el exponente: ");
        exp = int.Parse(Console.ReadLine());
        if(exp < 0){
            result = num;
            for (int i = 1; i < Math.Abs(exp); i++)
            {
                result = result * num;
            }
            result = 1 / result;
        }else{
            if (exp == 0)
        {
            result = 1;
        }else{
            result = num;
            for (int i = 1; i < exp; i++)
            {
                result = result * num;
            }
        }
        }
        return result;
    }

    static float Raiz()
    {
        float num = 0;
        float result = 0;
        Console.WriteLine("Ingresa el numero: ");
        num = float.Parse(Console.ReadLine());
        result = (float)Math.Sqrt(num);
        return result;
    }
}

