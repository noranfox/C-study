﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/06/02
 * 이름 : 정현기
 * 내용 : 자료형(Data Type) 실급하기 교재 p.83
 * 
 * 자료형 (data type)
 *  - 변수에 저장되는 데이터의 종류와 크기를 자료형으로 선언
 *  - 자료형은 크게 기본형과 참조형으로 나뉨
 *  
 */

namespace Ch02
{
    internal class _2_DataType
    {
        static void Main2(string[] args)
        {
            //정수형
            sbyte num1 = 127; //1byte표현 즉 8bit= 이진수7개+맨앞 부호
            byte num2 = 255; //1byte 표현 즉 8bit = 이진수 8개 sbyte와 다르게 맨앞부호없이 이진수로 8개
            short num3 = 32767; //2byte 표현 즉 16bit 맨앞부호
            int num4 = 2147483647; //4byte 표현 맨앞부호
            long num5 = 2147483648L; //8byte 표현, 맨앞부호 마지막 L을 접미사로 써줘야한다

            Console.WriteLine("num1 : {0}", num1);
            Console.WriteLine("num2 : {0}", num2);
            Console.WriteLine("num3 : {0}", num3);
            Console.WriteLine("num4 : {0}", num4);
            Console.WriteLine("num5 : {0}", num5 + "\n");

            //실수형
            float var1 = 1.123456789f;
            double var2 = 1.12345678901234567890;

            Console.WriteLine("var1 : " +var1);
            Console.WriteLine("var2 : " + var2 + "\n");

            //논리형

            bool b1 = true;
            bool b2 = false;

            Console.WriteLine("b1 : "+b1);
            Console.WriteLine("b2 : "+b2 + "\n");

            //문자형

            char c1 = 'A';
            char c2 = '가';

            Console.WriteLine("c1 : "+c1);
            Console.WriteLine("c2 : "+c2 + "\n");

            //문자열
            string str1 = "A";
            string str2 = "가";
            string str3 = "Apple";
            string str4 = "안녕하세요";
            string str5 = "10";

            Console.WriteLine("str1 : "+str1);
            Console.WriteLine("str2 : "+str2);
            Console.WriteLine("str3 : "+str3);
            Console.WriteLine("str4 : "+str4);
            Console.WriteLine("str5 : "+str5 + "\n");

            //object형 데이터종류에 상관없이 여러종류의 타입을 한번에 취급할수 있다
            object obj1 = 11;
            object obj2 = 3.141592;
            object obj3 = true;
            object obj4 = 'A';
            object obj5 = "Apple";

            Console.WriteLine("obj1 : "+obj1);
            Console.WriteLine("obj2 : "+obj2);
            Console.WriteLine("obj3 : "+obj3);
            Console.WriteLine("obj4 : "+obj4);
            Console.WriteLine("obj5 : "+obj5+"\n");


            //var형 컴파일러가 기존데이터를 참조해서 입력된변수의 유형을 추정해서 선언해준다
            var v1 = 11;
            var v2 = 3.141592;
            var v3 = true;
            var v4 = 'A';
            var v5 = "Apple";

            Console.WriteLine("v1 : "+v1);
            Console.WriteLine("v2 : "+v2);
            Console.WriteLine("v3 : "+v3);
            Console.WriteLine("v4 : "+v4);
            Console.WriteLine("v5 : "+v5+"\n");

        }
    }
}
