using System;
namespace oop_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //sınıf nedir  ? neden sınıf yapısı kullanılır?
            // sınıf ile nesne arasındaki ilişki nedir?
            #region    sınıf nasıl ve nerede oluşturulur? 
            // class yaz isim ver
            #region namespace içerisinde 
            #region 
            #endregion namespace dışarısında

            #region 
            #endregion class içerisinde (nested type)

            //bir class tanımlamasında tanımlanan yerde (namespace/dışı, class) aynı isimde birden fazla class tanımlanamaz!!!!!
            #endregion
            #endregion
            #region    sınıf ile nesne modeli tasarlama 

            #endregion
            #region sınıf modelinden referans noktası oluşturma
            // BİR CLASS Y-TANIMLANDIĞINDA O CLASS ADI BİR TÜRDÜR .
            // HALİYLE O TÜRÜ KULLNABİLMEK İÇİN DİREKT OLARAK CLASS ADINI KULLANMAMIZ YETERLİ

            OrnekModel W;   // REFERANS NOKTASI ALMA 
            // EĞER Kİ BİR REFERANS NOKTASINDA BİR NESNE REFERANS EDİLMİYORSA O REFERANS NOKTASI  \ REFERANS NULL DEĞERE SAHİPTİR


            #endregion



        }
    }

    class OrnekModel
    {
        int a;
        int b;      //field 
        // a ve b aynı class altında farklı nesneler bu yüzden aldıkları değerler farklı
        // X =>   a=5 b=10        Y=>    a=20 b=2

        public void X()
        {
            Console.WriteLine(a + " " + b);

        }
        public int Y()
        {
            return a * b;
        }
    }
    class MyClass
    {
        class MyClass3
        {

        }
    }
}