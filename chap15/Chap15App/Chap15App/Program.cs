using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15App
{
    class Program
    {
        class Profile
        {
            public string Name { get; set; }
            public short Height { get; set; } 
        }

        class Product
        {
            public string Title { get; set; }
            public string Star { get; set; }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 }; //10개 배열
            // LINQ 안 쓰는 방식
            /*List<int> result = new List<int>();

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    result.Add(item);
                }
            }*/

            // LINQ 쓰는 방식
            var result = from item in numbers
                         where item % 2 == 0
                         orderby item
                         select item;

            foreach (var item in result)
            {
                Console.WriteLine($"짝수 : {item}");
            }

            List<Profile> profiles = new List<Profile>();
            profiles.Add(new Profile() { Name = "정우성", Height = 186 });
            profiles.Add(new Profile() { Name = "김태희", Height = 158 });
            profiles.Add(new Profile() { Name = "고현정", Height = 172 });
            profiles.Add(new Profile() { Name = "이문세", Height = 178 });
            profiles.Add(new Profile() { Name = "하하", Height = 171 });

            List<Product> products = new List<Product>
            {
                new Product() { Title = "비트", Star = "정우성" },
                new Product() { Title = "아이리스", Star = "김태희" },
                new Product() { Title = "선덕여왕", Star = "고현정" },
                new Product() { Title = "옛사랑", Star = "이문세" },
                new Product() { Title = "천국의계단", Star = "김태희" }
            };

            var resProfiles = from item in profiles
                              where item.Height < 175
                              orderby item.Height descending // ascending
                              select new
                              {
                                  Name = item.Name,
                                  Height = item.Height,
                                  InchHeight = item.Height * 0.393
                              };

            foreach (var item in resProfiles)
            {
                Console.WriteLine($"{item.Name}, {item.Height}cm, {item.InchHeight}inch");
            }

            var resProfiles2 = from item in profiles
                               where item.Height < 175
                               orderby item.Height descending
                               select item.Height;

            foreach (var item in resProfiles2)
            {
                Console.WriteLine($"{item}");
            }

            //group by
            var resProfiles3 = from item in profiles
                               orderby item.Height ascending
                               group item by item.Height < 175 into g
                               select new
                               {
                                   GroupKey = g.Key,
                                   Items = g
                               };

            foreach (var group in resProfiles3)
            {
                Console.WriteLine($"175cm 미만 그룹 : {group.GroupKey}");

                foreach (var item in group.Items)
                {
                    Console.WriteLine($"        {item.Name}, {item.Height}cm");
                }
            }

            // inner join
            var joinProfiles = from profile in profiles
                               join product in products
                               on profile.Name equals product.Star
                               select new
                               {
                                   Name = profile.Name,
                                   Work = product.Title,
                                   Height = profile.Height
                               };
            Console.WriteLine("내부 조인 결과");
            foreach (var item in joinProfiles)
            {
                Console.WriteLine($"이름 : {item.Name}, 작품 : {item.Work}, 키 : {item.Height}cm");
            }

            // outer join
            var joinProfiles2 = from profile in profiles
                               join product in products
                               on profile.Name equals product.Star into ps
                               from product2 in ps.DefaultIfEmpty(new Product() { Title = "작품없음" })
                               select new
                               {
                                   Name = profile.Name,
                                   Work = product2.Title,
                                   Height = profile.Height
                               };
            Console.WriteLine("외부 조인 결과");
            foreach (var item in joinProfiles2)
            {
                Console.WriteLine($"이름 : {item.Name}, 작품 : {item.Work}, 키 : {item.Height}cm");
            }
        }
    }
}