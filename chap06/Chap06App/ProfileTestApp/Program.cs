﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.PrintProfile("성명건", "010-6683-7732");

            if ((Program.PrintProfile(null, "010-1111-2222")) == -1)
            {
                Console.WriteLine("프로필 출력시 오류가 발생했습니다.");
            }

            //PrintProfile(phone: "010-9999-9999", name: "홍길동");
            //PrintProfile(name: "홍길순", "010-8888-8888");
            PrintProfile("최백호","010-8878-4917");
        }

        private static int PrintProfile(string name, string phone="010-7979-7979")
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("이름을 정확히 입력하세요.");
                return -1;
            }
            //프로필 출력
            Console.WriteLine($"이름 : {name}, 폰번호 : {phone}");
            return 0;
        }
    }
}
