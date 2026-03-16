using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    public class Student // class'ın erişim beliryecisi (public) diger class lardan görebilmek için.
    {
        //değişkenlerin erişim belirleyicileri private yaptık. Cünkü kontrollü bir şekilde verilerimi görmek istiyorum(Encapsulation)
        private int StudentNo;
        private string StudentName;//(string) demek yani sayısal olmayan metinsel ifadeler için kullanılıyor.
        private string StudentSurname;
        private int MidtermExam1;
        private int MidtermExam2;
        private int FinalExamination;
        private string SchoolName;


        public Student(int _StudentNo,string _StudentName,string _StudentSurname,int _MidtermExam1,int _MidtermEcam2,int _FinalExamination,string _SchoolName)
        {
            //degişkenler private olarak tanımlandı yukarıda. bu sekilde yapıcı metot aracılıgı ile Program cs clasımızda verilerimizi
            //kendimiz girecegiz. ve yapıcı metot aracılıgı ile yukarıda belirtilen değişkenlere bu verileri atayacagız.
            //Bu verileri dışarıdan alacagımız icin üstteki değişkenler ile karısmaması için önlerine alt tire simgesi koydum.
            //dışarıdan alınan parametreler oldugunu belirtmek için.
            //şimdi tanımlanan değişkenleri parametre olarak gelen değişkenlere eşitleyeceğiz.
            StudentNo = _StudentNo;
            StudentName = _StudentName;
            StudentSurname = _StudentSurname;
            MidtermExam1 = _MidtermExam1;
            MidtermExam2 = _MidtermEcam2;
            FinalExamination = _FinalExamination;
            SchoolName = _SchoolName;
        }

        public void ShowStudentİnformation()
        {
            //(Void) geriye bir değer döndürmeyen yani return ifadesini kullanmadıgım metot icin kullanacagım tiptir.
            Console.WriteLine("Student Number :"+ StudentNo);
            Console.WriteLine("Student Name :"+StudentName);
            Console.WriteLine("Student Surname :"+StudentSurname);
            Console.WriteLine("Student Midterm Exam(1) :"+MidtermExam1);
            Console.WriteLine("Student Midterm Exam(2)"+MidtermExam2);
            Console.WriteLine("Student Final Examination :"+FinalExamination);
            Console.WriteLine("Student School Name :"+SchoolName);
        }

        public double StudentGradePointAverage()
        {
            //burada öprencinin not ortalamasını bulacagız.
            //ve (double) yapmamızın nedeni : öğrencinin not ortalaması tam sayı olmayabilir. örnegin 75,2 olabilir.
            //bu nedenle int degil double yaptık.
            double Average = MidtermExam1 * 0.2 + MidtermExam2 * 0.2 + FinalExamination * 0.6;
            return Average;
            //burada öğrencinin vize 1 notunu yüzde 20 si vize 2 nin yüzde 20 si ve final notunun yüzde 60 ını alıp topladık. 
            //ve yine metotta belirttigimiz gibi double olarak bir ortalama(Average) adında değişkene bu işlemin sonucunu atadık.
        }

        public void SchoolGet() //farklı bir secenek olarak öğrenin okul adını getirecek metodu yazıyoruz.
        {
            Console.WriteLine("Student's School Name :"+SchoolName);
        }
    }
}
