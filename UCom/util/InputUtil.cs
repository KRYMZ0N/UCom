using System;

namespace util {

    public class InputUtil {

        public string[] parseStringCom(string s) { // Parsing through a string using a space as the delimeter. then adding to array
            string[] newS =  s.Split(' ');


            return newS;
        }
    }
}