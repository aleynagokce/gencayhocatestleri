using System;
namespace oop_class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region    Class Members

            #region Property
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.Yasi);
            myClass.Yasi = 65;
            #endregion
            #endregion



        }
    }


    class MyClass
    {
        
        int yasi;
        string b;

       


        #region Full Property
        //property hangi türden bir field temsil ediyorsa o türden olmalıo
        //propert ler temsil ettikleri field ların isimlerinin başharfi büyük olacak şekilde isimlendirilir
        public int Yasi
        {
            get
            {
                // property üzerinden değer talep edildiğinde bu blok tetiklenir
                // yani değer buradan gönderilir
                return yasi;
            }
            set 
            { 
                yasi = value;
            }
        }
        #endregion
    }
}
