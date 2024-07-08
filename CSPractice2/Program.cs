﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice2
{
    internal class Program
    {
        class Parent
        {
            public int variable = 273;
            public virtual void Method()
            {
                Console.WriteLine("부모메서드");
            }
        }
        class Child : Parent
        {
            public new string variable = "하이딩";// 하이딩을 하려면 new 키워드를 사용해주어야 한다. 
            public new void Method()
            {
                Console.WriteLine("자식메서드");
            }
        }

        class Child2 : Parent
        {
            public override void Method()
            {

            }
        }

        public static int number = 10;
        static void Main(string[] args)
        {
            // #6 23-7. 섀도잉
            int number = 20;
            Console.WriteLine(number);

            // #6 23-7. 하이딩
            Child child = new Child();
            Console.WriteLine(child.variable); // 출력: 하이딩
            child.Method();// 출력: 자식 메서드
            Console.WriteLine(((Parent)child).variable); // 출력: 273
            ((Parent)child).Method();// 출력: 부모 메서드
            Parent p = child;
            Console.WriteLine(p.variable); // 출력: 273
            p.Method(); // 출력: 부모 메서드
            ((Child)p).Method(); // 출력: 자식 메서드

            // #6 23-8. 오버라이딩
            Child2 child2 = new Child2();
            // 오버라이딩하면 어떻게 해도 자식의 것만 출력된다. 덮어씌워졌기 때문이다.
            child2.Method();// 출력: 자식 메서드
            ((Parent)child2).Method();// 출력: 자식 메서드
            Parent p2 = child2;
            p2.Method(); // 출력: 자식 메서드
            ((Child)p2).Method(); // 출력: 자식 메서드
        }
    }
}
