﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 :2022/06/21
 * 이름 :정현기
 * 내용 : Linq실습하기 p525
 * 
 * Linq
 *  - Linq(Language Intergrated Query)는 컬렉션 형태의 데이터를 가공처리 하기 위한 c#질의언어
 *  - Linq를 사용해서 DB와 함께 데이터를 쉽게 관리
 *
 */

namespace Ch09
{
    class Member
    {
        private string uid;
        private string name;
        private int age;

        public Member(string uid, string name, int age)
        {
            this.uid = uid;
            this.name = name;
            this.age = age;
        }

        public string Uid { get => uid; set => uid = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        internal class _3_Linq
        {
            static void Main1(string[] args)
            {
                //컬렉션 생성
                List<int> result1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                //짝수 데이터 추출
                List<int> result2 = new List<int>();
                //방법1 for문 이용
                foreach (int n in result1)
                {
                    if (n % 2 == 0)
                    {
                        result2.Add(n);
                    }
                }
                Console.WriteLine(String.Join(",", result2));
                //방법2 람다식 이용
                result1.ForEach((n) =>
                {
                    if (n % 2 == 0)
                    {
                        result2.Add(n);
                    }
                });
                Console.WriteLine("result2 : " + String.Join(",", result2));

                //방법3 .Linq이용
                var result3 = from n in result1 where n % 2 == 0 select n;
                Console.WriteLine("result3 : " + String.Join(",", result3));

                //dataset에서 데이터 5 이상 큰 순서대로 출력
                var result4 = from n in result1 where n >= 5 orderby n descending select n;
                Console.WriteLine("result4 : " + String.Join(",", result4));

                //객체 리스트 Linq 이용
                List<Member> members = new List<Member>();
                members.Add(new Member("a101", "김유신", 25));
                members.Add(new Member("a102", "김춘추", 23));
                members.Add(new Member("a103", "장보고", 35));
                members.Add(new Member("a104", "강감찬", 45));
                members.Add(new Member("a105", "이순신", 55));

                //30세 이상
                var result5 = from Member in members 
                              where Member.Age >= 30 
                              orderby Member.Name ascending
                              select Member;

                foreach (Member m in result5)
                {
                    Console.WriteLine("{0}, {1}, {2}", m.Uid, m.Name, m.Age);
                }

            }
        }
    }
}
