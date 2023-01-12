


using System;
using System.Collections.Generic;

public static class PesoLettere
{

    public static int Pesa(string input)
    {
        int x = 0;
        int y = 0;
        int valore = 0;
        while (x < input.Length)
        {
            switch (input[y])
            {
                case 'a':case 'e':case 'i':case 'o':case 'u':case 'l':case 'n':case 'r':case 's':case 't':
                valore = valore + 1;
                break;
                case 'd':case 'g':
                valore = valore + 2;
                break;
                case 'b':case 'c':case 'm':case 'p':
                valore = valore + 3;
                break;
                case 'f':case 'h':case 'v':case 'w':case 'y':
                valore = valore + 4;
                break;
                case 'k':
                valore = valore + 5;
                break;
                case 'j':case 'x':
                valore = valore + 8;
                break;
                case 'q':case 'z':
                valore = valore + 10;
                break;
                
                 case 'A':case 'E':case 'I':case 'O':case 'U':case 'L':case 'N':case 'R':case 'S':case 'T':
                valore = valore + 1;
                break;
                case 'D':case 'G':
                valore = valore + 2;
                break;
                case 'B':case 'C':case 'M':case 'P':
                valore = valore + 3;
                break;
                case 'F':case 'H':case 'V':case 'W':case 'Y':
                valore = valore + 4;
                break;
                case 'K':
                valore = valore + 5;
                break;
                case 'J':case 'X':
                valore = valore + 8;
                break;
                case 'Q':case 'Z':
                valore = valore + 10;
                break;
                default:
                break;
            }
            y = y + 1;
            x = x + 1;
        }
        return valore;
    }
}