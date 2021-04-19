using System;
using System.Collections ; 

namespace checkOrder
{
    class Program
    {
        static bool checkOrder(string value) {

            Stack mystack = new Stack() ; 
            for (int i= 0 ; i < value.Length ; i++)

            {

                if(mystack.Count == 0)
                {
                    mystack.Push(value[i]) ; 
                }
                else
                {
                    if((char) mystack.Peek() != value[i]) 
                    {
                        mystack.Push(value[i]) ; 
                    } 
                    else
                    {
                         mystack.Pop(); 
                    }  

                }
                       
            }
            return mystack.Count == 0; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine(checkOrder("123478888798894321"));
        }
    }
}

