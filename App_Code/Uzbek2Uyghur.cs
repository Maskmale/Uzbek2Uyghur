using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace net.UyghurDev.Text.Converter
{
    
    public class Uzbek2Uyghur
    {
        Hashtable htLatin = new Hashtable();
        public Uzbek2Uyghur()
        {

            #region intialize

            /*
             * http://en.wikipedia.org/wiki/Uzbek_language
            Latin 	Cyrillic 	IPA
            A a 	А а 	/a, æ/
            B b 	Б б 	/b/
            D d 	Д д 	/d̪/
            E e 	Е е, Э э 	/e/
            F f 	Ф ф 	/ɸ/
            G g 	Г г 	/g/
            H h 	Ҳ ҳ 	/h/
            I i 	И и 	/i, ɨ/
            J j 	Ж ж 	/dʒ/
            K k 	К к 	/k/
            L l 	Л л 	/l/
            M m 	М м 	/m/
            N n 	Н н 	/n/
            O o 	О о 	/ɒ , o/[10]
            P p 	П п 	/p/
            Q q 	Қ қ 	/q/
            R r 	Р р 	/r/
            S s 	С с 	/s/
            T t 	Т т 	/t̪/
            U u 	У у 	/u, y/
            V v 	В в 	/w/
            X x 	Х х 	/χ/
            Y y 	Й й 	/j/
            Z z 	З з 	/z/
            O’ o’ 	Ў ў 	/ɤ̟/
            G’ g’ 	Ғ ғ 	/ʁ/
            Sh sh 	Ш ш 	/ʃ/
            Ch ch 	Ч ч 	/tʃ/
            ' 	ъ 	/ʔ/
             */
            htLatin.Add("A", "ا");
            htLatin.Add("a", "ا");
            htLatin.Add("B", "ب");
            htLatin.Add("b", "ب");
            htLatin.Add("D", "د");
            htLatin.Add("d", "د");
            htLatin.Add("E", "ە");
            htLatin.Add("e", "ە");
            htLatin.Add("F", "ف");
            htLatin.Add("f", "ف");
            htLatin.Add("G", "گ");
            htLatin.Add("g", "گ");
            htLatin.Add("H", "ھ");
            htLatin.Add("h", "ھ");
            htLatin.Add("I", "ى");
            htLatin.Add("i", "ى");
            htLatin.Add("J", "ج");
            htLatin.Add("j", "ج");
            htLatin.Add("K", "ك");
            htLatin.Add("k", "ك");
            htLatin.Add("L", "ل");
            htLatin.Add("l", "ل");
            htLatin.Add("M", "م");
            htLatin.Add("m", "م");
            htLatin.Add("N", "ن");
            htLatin.Add("n", "ن");
            htLatin.Add("O", "و");
            htLatin.Add("o", "و");
            htLatin.Add("P", "پ");
            htLatin.Add("p", "پ");
            htLatin.Add("Q", "ق");
            htLatin.Add("q", "ق");
            htLatin.Add("R", "ر");
            htLatin.Add("r", "ر");
            htLatin.Add("S", "س");
            htLatin.Add("s", "س");
            htLatin.Add("T", "ت");
            htLatin.Add("t", "ت");
            htLatin.Add("U", "ۇ");
            htLatin.Add("u", "ۇ");
            htLatin.Add("V", "ۋ");
            htLatin.Add("v", "ۋ");
            htLatin.Add("X", "خ");
            htLatin.Add("x", "خ");
            htLatin.Add("Y", "ي");
            htLatin.Add("y", "ي");
            htLatin.Add("Z", "ز");
            htLatin.Add("z", "ز");
            htLatin.Add("O'", "ۆ");
            htLatin.Add("o'", "ۆ");
            htLatin.Add("G'", "غ");
            htLatin.Add("g'", "غ");
            htLatin.Add("Sh", "ش");
            htLatin.Add("sh", "ش");
            htLatin.Add("Ch", "چ");
            htLatin.Add("ch", "چ");
            htLatin.Add("'", "'");
            htLatin.Add("ъ", "'");
            htLatin.Add(",", "،");
            htLatin.Add("ng", "ڭ");
            htLatin.Add("?", "؟");

            //http://www.gov.uz/uz/
            htLatin.Add("А", "ا");
            htLatin.Add("а", "ا");
            htLatin.Add("о", "و");
            htLatin.Add("O`", "ۆ");
            htLatin.Add("o`", "ۆ");
            htLatin.Add("G`", "غ");
            htLatin.Add("g`", "غ");
            htLatin.Add("х", "خ");
            htLatin.Add("е", "ې");
            htLatin.Add("О", "و");

            
            #endregion

        }

        /// <summary>
        /// ئۈزبەكچىنى ئۇيغۇرچىغا ئايلاندۇرۇش
        /// </summary>
        /// <param name="strUzLatin">ئۇزبەكچە تېكىست</param>
        /// <returns>ئۇيغۇرچە تېكىست</returns>
        public string uzbekLatin2Uyghur(string strUzLatin)
        {
            StringBuilder sb = new StringBuilder();
            string strCurrent = "";
            for (int nCount = 0; nCount < strUzLatin.Length; nCount++)
            {
                strCurrent = strUzLatin.Substring(nCount, 1);

                //if Qoshma
                if (nCount < strUzLatin.Length - 1)
                {
                    if (strCurrent.ToLower() == "s")    //sh
                    {
                        if (strUzLatin.Substring(nCount + 1, 1).ToLower() == "h")
                        {
                            strCurrent = strUzLatin.Substring(nCount, 2);
                            nCount++;
                        }
                    }

                    if (strCurrent.ToLower() == "c")    //ch
                    {
                        strCurrent = strUzLatin.Substring(nCount, 2);
                        nCount++;
                    }

                    if (strCurrent.ToLower() == "o")    //o'
                    {
                        if (strUzLatin.Substring(nCount + 1, 1).ToLower() == "'")
                        {
                            strCurrent = strUzLatin.Substring(nCount, 2);
                            nCount++;
                        }
                   
                        else if (strUzLatin.Substring(nCount + 1, 1).ToLower() == "`")//o` //gov.uz
                        {
                            strCurrent = strUzLatin.Substring(nCount, 2);
                            nCount++;
                        }
                    }


                    if (strCurrent.ToLower() == "g")    //g'
                    {
                        if (strUzLatin.Substring(nCount + 1, 1).ToLower() == "`")
                        {
                            strCurrent = strUzLatin.Substring(nCount, 2);
                            nCount++;
                        }
                        else if(strUzLatin.Substring(nCount + 1, 1).ToLower() == "`") //gov.uz
                        {
                            strCurrent = strUzLatin.Substring(nCount, 2);
                            nCount++;
                        }
                    }

                    if (strCurrent.ToLower() == "n")    //ng
                    {
                        if (strUzLatin.Substring(nCount + 1, 1).ToLower() == "g")
                        {
                            strCurrent = strUzLatin.Substring(nCount, 2);
                            nCount++;
                        }
                    }
                }
                //end qoshma

                if (htLatin.ContainsKey(strCurrent))
                {
                    sb.Append(htLatin[strCurrent]);
                }
                else
                {
                    sb.Append(strCurrent);
                }
            }
            //sb = sb.Replace(" ا", " ئا");
            //sb = sb.Replace(" ە", " ئە");
            //sb = sb.Replace(" و", " ئو");
            //sb = sb.Replace(" ۇ", " ئۇ");
            //sb = sb.Replace(" ى", " ئى");
            //sb = sb.Replace(" ۆ", " ئۆ");
            return hemze(sb.ToString());
        }


        /// <summary>
        /// ھەمزە قويۇشقا تىگىشلىك جا
        /// </summary>
        /// <param name="strSource">ھەمزىسىز تېكىست</param>
        /// <returns>ھەمزە قوشۇلغان تېكىست</returns>
        private string hemze(string strSource)
        {
            StringBuilder sb = new StringBuilder();
            Boolean blnIsStart = true;
            string strCurrent = "";
            for (int nCount = 0; nCount < strSource.Length; nCount++)
            {
                strCurrent = strSource.Substring(nCount, 1);
                //if (nCount == 0)
                //{
                //    sb.Append(addHemze(strCurrent));
                //}
                if (blnIsStart == true)
                {
                    sb.Append(addHemze(strCurrent));

                }
                else
                {
                    sb.Append(strCurrent);
                }

                blnIsStart = isEndWord(strCurrent);

            }

            return sb.ToString();
        }

        /// <summary>
        /// سۆز ئاخىرلاشتۇرۇش بەلگىسىمۇ؟
        /// </summary>
        /// <param name="strCurrent">بىر ھەرىپ</param>
        /// <returns>شۇنداق بولسا راست قىممەت بولمىسا يالغان قىممەت قايتۇرىدۇ</returns>
        private bool isEndWord(string strCurrent)
        {
            string[] strEndChars = { " ", ".", "،", "؟", "!", "؛", ":", ")", "(", "\n", "\r", "\t" };
            Boolean isEnd = false;
            foreach (string str in strEndChars)
            {
                if (str == strCurrent)
                {
                    isEnd = true;
                    break;
                }
            }
            return isEnd;
        }

        /// <summary>
        /// سۇزۇق تاۋۇشنىڭ بېشىدا ھەمزە قوشىدۇ
        /// </summary>
        /// <param name="strYalghuz">ھەمزە قوشىىلىدىغان ھەرىپ</param>
        /// <returns>ھەمزە قوشۇلغان ھەرىپ</returns>
        private string addHemze(string strYalghuz)
        {
            string strTemp = strYalghuz;
            switch (strYalghuz)
            {
                case "ا":
                    strTemp = "ئا";
                    break;

                case "ە":
                    strTemp = "ئە";
                    break;

                case "و":
                    strTemp = "ئو";
                    break;

                case "ۇ":
                    strTemp = "ئۇ";
                    break;

                case "ۆ":
                    strTemp = "ئۆ";
                    break;

                case "ې":
                    strTemp = "ئې";
                    break;

                case "ى":
                    strTemp = "ئى";
                    break;
                default:
                    strTemp = strYalghuz;
                    break;
            }
            return strTemp;
        }
    }

}
