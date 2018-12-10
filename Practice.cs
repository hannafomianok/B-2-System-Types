using System;

namespace ConsoleApp7
{
    public class Practice
    {
        ///<summary>
        /// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
        ///</summary>
        ///я закомментила все, что нельзя явно и неявно преобразовать, чтобы оно отработало
        public static void B2_P1_1_TypeConvert()
        {
            string name = "Olga";
            //char charname1 = name; //implicit
            //char charname2 = (char)name; //explicit
            //char charname3 = Convert.ToChar(name); Не может преобразовать так как длина строки должна составлять один знак.

            string hasPhoto = "True";
            //bool boolhasPhoto1 = hasPhoto; //implicit
            //bool boolhasPhoto2 = (bool)hasPhoto; //explicit
            bool boolhasPhoto3 = Convert.ToBoolean(hasPhoto); //Convert

            Console.WriteLine(boolhasPhoto3);

            string flatNumber = "34";
            //decimal decimalflatNumber1 = flatNumber; //implicit
            //decimal decimalflatNumber2 = (decimal)flatNumber; //explicit
            decimal decimalflatNumber3 = Convert.ToDecimal(flatNumber); //Convert

            Console.WriteLine(decimalflatNumber3);

            //int intflatNumber1 = flatNumber; //implicit
            //int intflatNumber2 = (int)flatNumber; //explicit
            int intflatNumber3 = Convert.ToInt32(flatNumber); //Convert
            int intflatNumber4 = int.Parse(flatNumber); //Parse

            Console.WriteLine(intflatNumber3);
            Console.WriteLine(intflatNumber4);

            char sex = NewMethod();
            //string stringsex1 = sex; //implicit
           //string stringsex2 = (string)sex; //explicit
            string stringsex3 = Convert.ToString(sex); //Convert

            Console.WriteLine(stringsex3);

            char place = '3';
            decimal decimalplace1 = place; //implicit
            decimal decimalplace2 = (Decimal)place; //explicit
            //decimal decimalplace3 = Convert.ToDecimal(place); //Convert

            Console.WriteLine(decimalplace1);
            Console.WriteLine(decimalplace2);


            int intplace1 = place; // implicit
            int intplace2 = (int)place; //explicit
            int intplace3 = Convert.ToInt32(place); //Convert

            Console.WriteLine(intplace1);
            Console.WriteLine(intplace2);
            Console.WriteLine(intplace3);


            char hasFingerPrints = '0';
            //bool boolhasFingerPrints1 = hasFingerPrints; //implicit
            //bool boolhasFingerPrints2 = (bool)hasFingerPrints; //explicit
            //bool boolhasFingerPrints3 = Convert.ToBoolean(hasFingerPrints); //Convert

            bool hasFree2Pages = false;
            //char charhasFree2Pages1 = hasFree2Pages; //implicit
            //char charhasFree2Pages2 = (char)hasFree2Pages; //explicit
            //char charhasFree2Pages3 = Convert.ToChar(hasFree2Pages); //Convert

            float visaPrice = 60;
            //char charvisaPrice1 = visaPrice; //implicit
            char charvisaPrice2 = (char)visaPrice; //explicit
           //char charvisaPrice3 = Convert.ToChar(visaPrice); //Convert

            Console.WriteLine(charvisaPrice2);


            //bool boolvisaPrice1 = visaPrice; //implicit
            //bool boolvisaPrice2 = (bool)visaPrice; //explicit
            bool boolvisaPrice3 = Convert.ToBoolean(visaPrice); //Convert

            Console.WriteLine(boolvisaPrice3);


            float photoPrice = 7.5f;
            //string stringphotoPrice1 = photoPrice; //implicit
            //string stringphotoPrice2 = (string)photoPrice; //explicit
            string stringphotoPrice3 = Convert.ToString(photoPrice); //Convert

            Console.WriteLine(stringphotoPrice3);


            //int intphotoPrice1 = photoPrice; //implicit
            int intphotoPrice2 = (int)photoPrice; //explicit
            int intphotoPrice3 = Convert.ToInt32(photoPrice); //Convert

            Console.WriteLine(intphotoPrice2);
            Console.WriteLine(intphotoPrice3);


            int birthYear = 2000;
            //char intbirthYear1 = birthYear; //implicit
            char intbirthYear2 = (char)birthYear; //explicit
            char intbirthYear3 = Convert.ToChar(birthYear); //Convert

            Console.WriteLine(intbirthYear2);
            Console.WriteLine(intbirthYear3);


            //bool boolbirthYear1 = birthYear; //implicit
            //bool boolbirthYear2 = (bool)birthYear; //explicit
            bool boolbirthYear3 = Convert.ToBoolean(birthYear); //Convert

            Console.WriteLine(boolbirthYear3);


            decimal decimalbrthYear1 = birthYear; //implicit
            decimal decimalbrthYear2 = (decimal)birthYear; //explicit
            decimal decimalbrthYear3 = Convert.ToDecimal(birthYear); //Convert

            Console.WriteLine(decimalbrthYear1);
            Console.WriteLine(decimalbrthYear2);
            Console.WriteLine(decimalbrthYear3);


            //string stringbirthYear1 = birthYear; //implicit
            //string stringbirthYear2 = (string)birthYear; //explicit
            string stringbirthYear3 = Convert.ToString(birthYear); //Convert

            Console.WriteLine(stringbirthYear3);




            //1. CHAR CONVERSION 
            //1.1 CHAR to STRING

            //string charToStringImplicit = sex;                        //IMPLICIT: NOT COMPILING
            //string chartToStringExplicit = (string)sex;               //EXPLICIT: NOT COMPILING
            string charToStringUsingConverter = Convert.ToString(sex);  //CONVERT: "M"

            //1.2 CHAR to BOOL

            //1.3 CHAR to DECIMAL

            //1.4 CHAR to INT

            //2. STRING CONVERSION

            //2.1 STRING to CHAR

            //2.2 STRING to BOOL

            //2.3 STRING to DECIMAL

            //2.4 STRING to INT

            //3. BOOL CONVERSION

            //3.1 BOOL to CHAR

            //3.2 BOOL to STRING

            //3.3 BOOL to DECIMAL

            //3.4 BOOL to INT

            //4. DECIMAL CONVERSION

            //4.1 DECIMAL to CHAR

            //4.2 DECIMAL to BOOL

            //4.3 DECIMAL to STRING

            //4.4 DECIMAL to INT

            //5. INT CONVERSION         

            //5.1 INT to CHAR

            //5.2 INT to BOOL

            //5.3 INT to DECIMAL

            //5.4 INT to STRING
        }

        private static char NewMethod()
        {
            return 'М';
        }
    }
}