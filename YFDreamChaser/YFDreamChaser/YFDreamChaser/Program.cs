using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YFDreamChaser
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator(100);
        }

        static void Calculator(int num)
        {
            Random r = new Random();
            for (int i = 0; i < num; i++)
            {
                int result = 0;
                double result2 = 0.0;   //用于判断计算结果是否为整数
                int f = r.Next(1, 17);
                int num1 = r.Next(0, 101);
                int num2 = r.Next(0, 101);
                int num3 = r.Next(0, 101);
                switch (f)
                {
                    case 1:
                        result = num1 + num2 + num3;
                        Console.WriteLine(num1 + " + " + num2 + " + " + num3 + " = " + result);
                        break;
                    case 2:
                        result = num1 + num2 - num3;
                        Console.WriteLine(num1 + " + " + num2 + " - " + num3 + " = " + result);
                        break;
                    case 3:
                        result = num1 + num2 * num3;
                        Console.WriteLine(num1 + " + " + num2 + " * " + num3 + " = " + result);
                        break;
                    case 4:
                        if(num3 != 0)
                        {
                            result = num2 / num3;
                            result2 = num2 * 1.0 / num3;
                            if ((double)result == result2 && num3 != 0)
                            {
                                result += num1;
                                Console.WriteLine(num1 + " + " + num2 + " / " + num3 + " = " + result);
                            }
                            else
                            {
                                i--;
                            }
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 5:
                        result = num1 - num2 + num3;
                        Console.WriteLine(num1 + " - " + num2 + " + " + num3 + " = " + result);
                        break;
                    case 6:
                        result = num1 - num2 - num3;
                        Console.WriteLine(num1 + " - " + num2 + " - " + num3 + " = " + result);
                        break;
                    case 7:
                        result = num1 - num2 * num3;
                        Console.WriteLine(num1 + " - " + num2 + " * " + num3 + " = " + result);
                        break;
                    case 8:
                        if(num3 != 0)
                        {
                            result = num2 / num3;
                            result2 = num2 * 1.0 / num3;
                            if ((double)result == result2)
                            {
                                result = num1 - result;
                                Console.WriteLine(num1 + " - " + num2 + " / " + num3 + " = " + result);
                            }
                            else
                            {
                                i--;
                            }
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 9:
                        result = num1 * num2 + num3;
                        Console.WriteLine(num1 + " * " + num2 + " + " + num3 + " = " + result);
                        break;
                    case 10:
                        result = num1 * num2 - num3;
                        Console.WriteLine(num1 + " * " + num2 + " - " + num3 + " = " + result);
                        break;
                    case 11:
                        if(num3 != 0)
                        {
                            result = num1 * num2 / num3;
                            result2 = num1 * num2 * 1.0 / num3;
                            if ((double)result == result2 )
                            {
                                Console.WriteLine(num1 + " * " + num2 + " / " + num3 + " = " + result);
                            }
                            else
                            {
                                i--;
                            }
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 12:
                        if(num2 != 0)
                        {
                            result = num1 / num2;
                            result2 = num1 * 1.0 / num2;
                            if ((double)result == result2)
                            {
                                result = result + num3;
                                Console.WriteLine(num1 + " / " + num2 + " + " + num3 + " = " + result);
                            }
                            else
                            {
                                i--;
                            }
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 13:
                        if(num2 != 0)
                        {
                            result = num1 / num2;
                            result2 = num1 * 1.0 / num2;
                            if ((double)result == result2)
                            {
                                result = result - num3;
                                Console.WriteLine(num1 + " / " + num2 + " - " + num3 + " = " + result);
                            }
                            else
                            {
                                i--;
                            }
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 14:
                        if(num2 != 0)
                        {
                            result = num1 / num2;
                            result2 = num1 * 1.0 / num2;
                            if ((double)result == result2)
                            {
                                result = result * num3;
                                Console.WriteLine(num1 + " / " + num2 + " * " + num3 + " = " + result);
                            }
                            else if ((double)result != result2)
                            {
                                result = (int)(result2 * num3);
                                result2 = result2 * num3;
                                if ((double)result == result2)
                                {
                                    Console.WriteLine(num1 + " / " + num2 + " * " + num3 + " = " + result);
                                }
                                else
                                {
                                    i--;
                                }
                            }
                            else
                            {
                                i--;
                            }
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 15:
                        if(num2 != 0 && num3 != 0)
                        {
                            result = num1 / num2;
                            result2 = num1 * 1.0 / num2;
                            if ((double)result == result2)
                            {
                                result = result / num3;
                                result2 = result2 * 1.0 / num3;
                                if ((double)result == result2)
                                    Console.WriteLine(num1 + " / " + num2 + " / " + num3 + " = " + result);
                                else
                                {
                                    i--;
                                }
                            }
                            else
                            {
                                i--;
                            }
                           
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    default:
                        result = num1 * num2 * num3;
                        Console.WriteLine(num1 + " * " + num2 + " * " + num3 + " = " + result);
                        break;
                }


            }

        }

    }
}

