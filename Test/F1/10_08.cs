﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.F1
{
    class Member
    {
        public string Name { get; set; }
        public string Hp { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name},{Hp},{Age}";
        }
    }
    internal class _10_08
    {
        static void Main(string[] args)
        {
            Member m1 = new Member { Name = "김유신", Hp = "010-1234-1001", Age = 25 }; 
            Member m2 = new Member { Name = "김춘추", Hp = "010-1234-1002", Age = 23 }; 
            Member m3 = new Member { Name = "장보고", Hp = "010-1234-1003", Age = 27 };

            var m4 = new { Name = "강감찬", Hp = "010-1234-1004", Age = 41 };
            var m5 = new { Name = "이순신", Hp = "010-1234-1005", Age = 52 };

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            Console.WriteLine(m5);


        }
    }
}
