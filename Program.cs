using System;

namespace StudentApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool control = true;//while döngüsü true oldugu sürece sonsuz olacaktır. 
            Student student1 = new Student(1663, "Baran", "Karakaya", 75, 50, 60, "Sakarya Üniversitesi");
            //Öğrenci clasımdaki bilgilere ulaşmak için öğrenci clasından bir nesne ürettim.
            //burada öncelikle öğrenci clasındaki parametre olarak belirtilen verilerin değerlerinin atamasını yapacağız.
            //Bunu Student nesnesinin yanındaki parantezin içine yapıyoruz.
            Console.WriteLine("Welcome To Application :) Make a Choice. ");
            //okuma yaptıgı icin önce programa hosgeldiniz diyecek daha sonra da alttaki işlemleri sırasıyla gösterecek.)


            while (control)
            {
                ShowTransactions();//while döngüsünde bu metotdu cagırırsam kullanıcı her secım yaptıktan sonra
                //menü yü tekrar tekrar gösterecektir. while dışında cagırırsam bir defa gösterecektir.
                string vote = Console.ReadLine(); //kullanıcı buradan bir seçim yapacak.
                switch (vote) //örnegin if else kullanmak yerine switch case yaklaşımını kullanıyoruz.
                {
                    case "1":
                        student1.ShowStudentİnformation();//ögrenci bilgileri göstermek icin yazılan metodu cagırmamız yeterli.
                        break; //break = belirtilen secenekten bir digerine gecmek icin kullanılır. yani bir sonraki case "2" : olacak.
                    case "2":
                        double StudentAverage = student1.StudentGradePointAverage();//değişken double oldugu icin bir baska değişkene atadık.
                        Console.WriteLine("Student Average :" + StudentAverage);
                        break;
                    case "3":
                        student1.SchoolGet();
                        break;
                    case "4":
                        control = false;//uygulamadan çıkması için yukarıda true belirttigim controlü burada false yapıyorum.
                        break;

                }
            }
        }
        static void ShowTransactions() //Burada daha estetik görünmesi için seçeneklerin oldugu bir static metot oluşturdum.
        {
            //static olusturma sebebim sadece bu class ta işimi görecek ve bir referans tipi oluşturulmayacak.
            Console.WriteLine("1-Show Student İnformation :");
            Console.WriteLine("2-Show Student Average: ");
            Console.WriteLine("3-Show Student School Name :");
            Console.WriteLine("4-Exit Application ");
        }
    }
}
