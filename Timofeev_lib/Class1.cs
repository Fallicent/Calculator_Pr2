using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timofeev_lib
{
    public class Calc
    {
        public static dynamic Go(string t)
        {
            string text = t;
            text += " ";
            string text2 = text;
            string text3 = "";
            int len = text.Length;
            string a = "";
            string b = "";
            int beg = 0;
            for (int i = 0; i < len; i++)
            {
                
                if (text2[i] != '+' & text2[i] != '-' & text2[i] != '*' & text2[i] != '/' & text2[i] != '(' & text2[i] != ')' & text2[i] != '^')
                {

                    a += text2[i];
                }
                else
                {

                    switch (text2[i])
                    {
                        case '+':
                            for (int j = i+1; j < len; j++)
                            {
                                if (text2[j] != '+' & text2[j] != '-' & text2[j] != '*' & text2[j] != '/' & text2[j] != '(' & text2[j] != ')' & text2[j] != '^' & j != len - 1)
                                {
                                    b += text2[j];
                                }
                                else
                                {
                                    //if (j == len - 1) j -= 1;
                                    float ae = float.Parse(a);
                                    float be = float.Parse(b);
                                    float check = ae + be;
                                    text2 = text2.Remove(beg, j);
                                    text3 = check + text2;
                                    //text2 = check + text2.Remove(beg, j);
                                    //text2 = len.ToString();
                                    //text2 = check.ToString();  
                                    beg = 0;
                                    len -= j;
                                    i = 0;
                                    a = "";
                                    b = "";
                                    j=len;
                                    
                                }
                            }
                        break;

                        case '-':
                            for (int j = i + 1; j < len; j++)
                            {
                                if (text2[j] != '+' & text2[j] != '-' & text2[j] != '*' & text2[j] != '/' & text2[j] != '(' & text2[j] != ')' & text2[j] != '^' & j != len - 1)
                                {
                                    b += text2[j];
                                }
                                else
                                {
                                    //if (j == len - 1) j -= 1;
                                    float be = float.Parse(b);
                                    float ae = float.Parse(a);
                                    float check = ae - be;
                                    text2 = text2.Remove(beg, j);
                                    text3 = check + text2;
                                    //text2 = check + text2.Remove(beg, j);
                                    //text2 = len.ToString();
                                    //text2 = check.ToString();  
                                    beg = 0;
                                    len -= j;
                                    i = 0;
                                    a = "";
                                    b = "";
                                    j = len;

                                }
                            }
                        break;

                        case '*':
                            for (int j = i + 1; j < len; j++)
                            {
                                if (text2[j] != '+' & text2[j] != '-' & text2[j] != '*' & text2[j] != '/' & text2[j] != '(' & text2[j] != ')' & text2[j] != '^' & j != len - 1)
                                {
                                    b += text2[j];
                                }
                                else
                                {
                                    //if (j == len - 1) j -= 1;
                                    float be = float.Parse(b);
                                    float ae = float.Parse(a);
                                    float check = ae * be;
                                    text2 = text2.Remove(beg, j);
                                    text3 = check + text2;
                                    //text2 = check + text2.Remove(beg, j);
                                    //text2 = len.ToString();
                                    //text2 = check.ToString();  
                                    beg = 0;
                                    len -= j;
                                    i = 0;
                                    a = "";
                                    b = "";
                                    j = len;

                                }
                            }
                        break;

                        case '/':
                            for (int j = i + 1; j < len; j++)
                            {
                                if (text2[j] != '+' & text2[j] != '-' & text2[j] != '*' & text2[j] != '/' & text2[j] != '(' & text2[j] != ')' & text2[j] != '^' & j != len - 1)
                                {
                                    b += text2[j];
                                }
                                else
                                {
                                    //if (j == len - 1) j -= 1;
                                    float be = float.Parse(b);
                                    float ae = float.Parse(a);
                                    float check = ae / be;
                                    text2 = text2.Remove(beg, j);
                                    text3 = check + text2;
                                    //text2 = check + text2.Remove(beg, j);
                                    //text2 = len.ToString();
                                    //text2 = check.ToString();  
                                    beg = 0;
                                    len -= j;
                                    i = 0;
                                    a = "";
                                    b = "";
                                    j = len;

                                }
                            }
                        break;

                        case '^':
                            for (int j = i + 1; j < len; j++)
                            {
                                if (text2[j] != '+' & text2[j] != '-' & text2[j] != '*' & text2[j] != '/' & text2[j] != '(' & text2[j] != ')' & text2[j] != '^' & j != len - 1)
                                {
                                    b += text2[j];
                                }
                                else
                                {
                                    //if (j == len - 1) j -= 1;
                                    float be = float.Parse(b);
                                    float ae = float.Parse(a);
                                    float check = (int)Math.Pow(ae, be);
                                    text2 = text2.Remove(beg, j);
                                    text3 = check + text2;
                                    //text2 = check + text2.Remove(beg, j);
                                    //text2 = len.ToString();
                                    //text2 = check.ToString();  
                                    beg = 0;
                                    len -= j;
                                    i = 0;
                                    a = "";
                                    b = "";
                                    j = len;

                                }
                            }
                            break;
                    }
                }

            }
            return text3;
        }
        
    }
}
