using System;

public class Sesi2 
{

    public static void nomor1()
    {
        int i,j,k,l,n;
        Console.Write("Enter the Range=");
        n = int.Parse(Console.ReadLine());    

        for(i=0;i<=n;i++){
            
            // print spasi
            for(j=0; j<n-i; j++){
                Console.Write(" ");
            }
            
            // print angka sampek i
            for(k=1; k<=i; k++){
                int temp = k+64;
                Console.Write((char)temp);
            }

            // print dibalik
            for(l=i-1; l>=1; l--){
                int temp = l+64;
                Console.Write((char)temp);
            }
            
            Console.WriteLine();
        }
        Console.WriteLine();

    }

    public static void nomor2()
    {
        int i,j,k,l,n;
        Console.Write("Enter the Range=");
        n = int.Parse(Console.ReadLine());    

        for(i=0;i<=n;i++){
            
            // print spasi
            for(j=0; j<n-i; j++){
                Console.Write(" ");
            }
            
            // print angka sampek i
            for(k=1; k<=i; k++){
                Console.Write(k);
            }

            // print dibalik sampek 1
            for(l=i-1; l>=1; l--){
                Console.Write(l);
            }
            
            Console.WriteLine();
        }
        Console.WriteLine();

    }

    public static void nomor3(){
        Console.Write("Enter any Number: ");
        int n = int.Parse(Console.ReadLine());
        int total = 1;
        for(int i=1;i<=n;i++){
            total *= i;
        }
        Console.WriteLine($"Factorial of {n} is : {total}");
    }

    public static void nomor4(){
        Console.Write("Enter a number: ");
        string n = Console.ReadLine();

        Console.Write("Reversed Number: ");
        for (int i=n.Length-1; i>=0; i--){
            Console.Write(n[i]);
        }
        Console.WriteLine();
    }

    public static void nomor5(){
        Console.Write("Enter a number: ");
        string n = Console.ReadLine();
        
        for (int i=0; i<n.Length; i++){
            if(n[i] == '0'){
                Console.Write("zero");
            }
            else if(n[i] == '1'){
                Console.Write("one");
            }
            else if(n[i] == '2'){
                Console.Write("two");
            }
            else if(n[i] == '3'){
                Console.Write("three");
            }
            else if(n[i] == '4'){
                Console.Write("four");
            }
            else if(n[i] == '5'){
                Console.Write("five");
            }
            else if(n[i] == '6'){
                Console.Write("six");
            }
            else if(n[i] == '7'){
                Console.Write("seven");
            }
            else if(n[i] == '8'){
                Console.Write("eight");
            }
            else if(n[i] == '9'){
                Console.Write("nine");
            }

            Console.Write(" ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        int menu;
        Console.Clear();
        do
        {
            Console.WriteLine("Welcome To Assignment 1");
            Console.WriteLine("Nama: Michael Christiawan");
            Console.WriteLine("No Peserta: 013");
            Console.WriteLine("Alamat: Jl. Barito No 62, Semarang");
            Console.WriteLine("1. Question Number 1");
            Console.WriteLine("2. Question Number 2");
            Console.WriteLine("3. Question Number 3");
            Console.WriteLine("4. Question Number 4");
            Console.WriteLine("5. Question Number 5");
            Console.WriteLine("6. Exit");
            Console.Write("Choice : ");
            menu = int.Parse(Console.ReadLine());
            if(menu == 1){
                nomor1();
            }
            else if(menu == 2){
                nomor2();
            }
            else if(menu == 3){
                nomor3();
            }
            else if(menu == 4){
                nomor4();
            }
            else if(menu == 5){
                nomor5();
            }
            else if(menu == 6){
                Console.WriteLine("Thank You");
            }
            else{
                Console.WriteLine("Unknown Menu");
            }
            Console.Write("Press Any Key To Continue...");
            Console.ReadLine();
            Console.Clear();

        } while (menu != 6);
    }
}