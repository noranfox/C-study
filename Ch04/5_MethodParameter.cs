﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/07
 * 이름 : 정현기
 * 내용 : 메서드 출력전용 매개변수, 오버로드가안됨(ref,out)
 * 반환값 2개인 매개변수를 만드는것이다.
 * 
 * 참조 매개변수 ref
 * - 변수의 reference(주소)값으로 참조값이 가리키는 실제변수에 대입하는 매개변수
 * 
 * 출력 매개변수 out
 * - 별도의 변수선언 없이 바로 메서드 호출시 매서드의 결과를 리턴받는 매개변수
 * - 메서드는 하나의 리턴값을 여러개 리턴 할수 있는 효과를 얻는다 
 */

namespace Ch04
{
    internal class _5_MethodParameter
    {
        static void Main1(string[] args)
        {
            //ref 매개변수
            int num1 = 10;
            int num2 = 3;
            int num3 = 0;
            int num4 = 0;

            Divider1(num1, num2, ref num3, ref num4);

            Console.WriteLine("몫 : {0}, 나머지 : {1}", num3, num4);

            //out 매개변수
            int n1 = 10;
            int n2 = 3;
            int n3 = 0;
            int n4 = 0;
            Divider2(n1,n2,out n3,out n4);
            Console.WriteLine("몫 : {0}, 나머지 : {1}", n3, n4);

        }

        public static void Divider1(int a, int b, ref int quotient, ref int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        public static void Divider2(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;

        }


    }
}
