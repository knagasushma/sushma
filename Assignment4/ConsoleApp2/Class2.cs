using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class2
    {

        class MyStack
        {
            private int[] ele;
            private int top;
            private int max;
            public MyStack(int size)
            {
                ele = new int[size];
                top = -1;
                max = size;

            }
            public void Push(int item)
            {
                try
                {
                    ele[++top] = item;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
            public int Pop()
            {
                Console.WriteLine("Poped element is:" + ele[top]);
                return ele[top--];
            }
            public void PrintStack()
            {

                if (top == -1)
                {
                    Console.WriteLine("Stack is Empty");
                    return;


                }
                else
                {
                    for (int i = 0; i <= top; i++)
                    {
                        Console.WriteLine("Item[" + (i + 1) + "]:" + ele[i]);

                    }
                }
            }
            class Program
            {
                static void Main()
                {
                    StackException se = new StackException();
                    se.Method();

                    Console.ReadLine();
                }
                class StackException
                {
                    public void Method()
                    {
                        MyStack s = new MyStack(5);
                        s.Push(10);
                        s.Push(20);
                        s.Push(30);
                        s.Push(40);
                        s.Push(50);
                        Console.WriteLine("Items are : ");
                        s.PrintStack();
                        s.Pop();
                        s.PrintStack();
                        s.Push(50);
                        s.Push(60);

                    }
                }

            }


        }

    }
}


            
        
    


