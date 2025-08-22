
using System.Collections.Immutable;
using System.Security.Cryptography;
using static Linq.ListGenrator;
namespace Linq
{
    internal class Program
    {
        static void Print<T>(IEnumerable<T> collection)
        {
            Console.WriteLine();
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }
        static void Main()
        {
            #region Assignment
            //1
            //var res = ProductsList.Where(x => x.UnitsInStock == 0);
            //Print(res);

            //2
            //var res = ProductsList.Where(x => x.UnitsInStock >= 0&&x.UnitPrice>3);
            //Print(res);


            //3
            //var res = ProductsList.Where(x => x.UnitsInStock == 0).FirstOrDefault();
            //Console.WriteLine(res);

            //4
            //var res = ProductsList.FirstOrDefault(x => x.UnitPrice > 1000);
            //Console.WriteLine(res);

            //5
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Where(x => (x & 1) == 1);
            //Print(res);
            //6
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Console.WriteLine(Arr.Count());
            //7
            //string[] dictionary = File.ReadAllLines("dictionary_english.txt");
            //Console.WriteLine(dictionary.Length);

            //8
            //string[] dictionary = File.ReadAllLines("dictionary_english.txt");
            //var res = dictionary.OrderBy(x => x.Length).First().Length;
            //Console.WriteLine(res); 
            #endregion

            #region Demo
            #region var-dynamic
            //var s = "mohamed";//can detect data type on initiale value[compile time]
            //                  //var v;//invalid
            //                  //  s = 1;//cant change data type;
            //Console.WriteLine(s.GetType());//string
            //// cant be return variable or attribute for class or parameter 

            //dynamic x = 10;
            //dynamic y;//valid
            //x = 'a';//detect dt based on laset asign value[run time]
            //Console.WriteLine(x.GetType());//char  
            #endregion
            #region extention method
            //int x = 12345;
            //int ans=IntExtention.ReverseNum(x);
            //Console.WriteLine(ans);
            //ans =x.ReverseNum();
            //Console.WriteLine(ans);
            //Console.WriteLine(x.ToString()); 
            #endregion
            #region anonymous type
            ////object emp = new { name = "mohamed", id = 10, salary = 100 };
            //////Console.WriteLine(emp.id);//invalid


            ////anonymous type 
            ////class: object ==>override tostring
            //var emp = new { name = "mohamed", id = 10, salary = 100 };
            //Console.WriteLine(emp.id);
            //Console.WriteLine(emp);
            //Console.WriteLine(emp.GetType().Name);//<>f__AnonymousType0`3
            //var emp2 = new { name = "marioma", id = 11, salary = 2000 };
            //Console.WriteLine(emp2.GetType().Name);//<>f__AnonymousType0`3 same index

            //var emp3 = new { Name = "mohamed", id = 10, salary = 100 };
            //Console.WriteLine(emp3.GetType().Name);//<>f__AnonymousType1`3 same index change Name

            //string Country = "Egypt", street = "MArg";
            //var v = new
            //{
            //    Country,
            //    street
            //};
            //Console.WriteLine(v);
            ////  { Country = Egypt, street = MArg }
            //var employee = new
            //{
            //    name = "mohamed",
            //    id = 10,
            //    Department = new { id = 1, name = "Cs" }
            //};
            //Console.WriteLine(employee);
            //Console.WriteLine(employee.Department.name);
            ////employee.id = 1;//invalid read only
            //var employee2 = employee with { id = 2 };
            //Console.WriteLine(employee2);
            #endregion
            #region linq syntax
            //syntax 1
            //List<int> list = [1, 2, 3, 4, 5, 6, 7, 8];
            //var l=list.Where(x=> x % 2 == 0);
            //foreach (var item in l)
            //{
            //    Console.WriteLine(item);
            //}
            //var l2=Enumerable.Where(list, x => x % 2 == 0);
            //foreach (var item in l2)
            //{
            //    Console.WriteLine(item);
            //}

            //query syntax for complex query
            // must execution order and start from
            //List<int> list = [1, 2, 3, 4, 5, 6, 7, 8];
            //var f = from x in list
            //        where x % 2 == 0
            //        select x;
            //foreach (var item in f)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region linq execution ways
            //List<int> list = [1, 2, 3, 4, 5, 6, 7, 8];
            //var odd = list.Where(x => x % 2 == 1);//will execute when use it
            //list.AddRange([11, 12, 13, 14]); //deffered 
            //foreach (var item in odd)
            //{
            //    Console.Write(item+" ");//1 3 5 7 11 13
            //}

            //aggregate op,elemnent op ,castiong op 
            //make query immediate
            //List<int> list = [1, 2, 3, 4, 5, 6, 7, 8];
            //var odd2=list.Where(x => x %2 == 1).ToList();//will make it 
            //list.AddRange([11, 12, 13, 14]);                                           //immediate
            //foreach (var item in odd2)
            //{
            //    Console.Write(item + " ");//1 3 5 7 11 13
            //} 
            #endregion
            #region Task
            ////Console.WriteLine(ListGenrator.ProductsList[0]);
            ////Console.WriteLine();
            ////Console.WriteLine(ListGenrator.CustomersList[0]);

            ////1
            //int[] arr = [3, 4, 2, 0, 1, 5, 6];
            //var res = arr.Where((x, i) => x == i);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------------------------");
            ////2
            //var res2 = ListGenrator.ProductsList.Select(x => new
            //{
            //    x.ProductName,
            //    Price=x.UnitPrice,

            //});
            //foreach (var item in res2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------------------------");
            ////3
            //var res3 = from o1 in ListGenrator.CustomersList
            //           from o2 in o1.Orders
            //           where o2.OrderDate >= new DateTime(1998, 1, 1)
            //           select o2;
            //foreach (var item in res3)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------------------------");
            ////4

            //var mx=ListGenrator.ProductsList.Max(x=> x.UnitPrice);
            //Console.WriteLine(mx);


            //var ans = from o in ListGenrator.ProductsList
            //          where o.UnitPrice==mx
            //          select o;
            ////Console.WriteLine(ans);
            //foreach (var item in ans)
            //{
            //    Console.WriteLine(item);
            //}

            //var ans2 = ListGenrator.ProductsList.OrderByDescending(x => x.UnitPrice).First();
            //Console.WriteLine(ans2); 
            #endregion
            #region filteration operation
            //filteration operation [deffered execution]
            //var res = ProductsList.Where(x => x.UnitsInStock == 0);//will execute when use it
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //res=from o in ProductsList
            //    where o.UnitsInStock == 0
            //    select o;
            //Console.WriteLine();
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //indexed where [only with fluent syntax]
            //var res = ProductsList.Where((x, i) => x.UnitsInStock != 0 && i < 10);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //} 

            #endregion
            #region Select
            //var res = ProductsList.Select(x => x.ProductName);
            //Print(res);

            //res = from o in ProductsList
            //      select o.ProductName;
            //Print(res);


            //select many to select nested data
            //var res = CustomersList.SelectMany(x => x.Orders);
            //Print(res);

            // res=from x in CustomersList
            //        from o in x.Orders
            //        select o;
            //Print(res);

            //anonymous type
            //var res = ProductsList.Select(x => new
            //{
            //    x.ProductID,
            //    x.ProductName
            //});
            //Print(res);

            //res = from x in ProductsList
            //      select new
            //      {
            //          x.ProductID,
            //          x.ProductName
            //      };
            //Print(res);
            //var res = from o in ProductsList
            //          select new {
            //              o.ProductID,
            //              o.ProductName,
            //              OldPrice = o.UnitPrice,
            //              newprice=o.UnitPrice-o.UnitPrice*.1m
            //        };
            //Print(res);
            //var res = ProductsList.Where(x => x.UnitsInStock > 0).
            //    Select((x, i) => new
            //    {
            //        x.ProductName,
            //        Id = i
            //    });
            //Print(res); 
            #endregion
            #region Ordering
            //var res = ProductsList.OrderBy(x => x.ProductName);
            //Print(res);
            //var res2 = ProductsList.OrderByDescending(x => x.ProductName);
            //Print(res2);
            //var res=from o in ProductsList
            //        orderby o.ProductName descending
            //        select o;
            //Print(res);

            //var res=ProductsList.OrderBy(x=>x.UnitPrice).ThenBy(x=>x.UnitsInStock);
            //Print(res);
            // res = from o in ProductsList
            //          orderby o.UnitPrice ,o.UnitsInStock                     
            //          select o;
            //Print(res); 
            #endregion
            #region element operators
            //element operators

            //if list is empty get exception
            //var f = ProductsList.First();
            //Console.WriteLine(f);
            //var l = ProductsList.Last();
            //Console.WriteLine(l);

            //var safef=ProductsList.FirstOrDefault();//return [default value]null if emptyy
            //Console.WriteLine(safef);

            //var f = ProductsList.FirstOrDefault(x => x.UnitsInStock == 1000000);
            //var l = ProductsList.LastOrDefault(x => x.UnitsInStock == 12);
            //Console.WriteLine(f?.ProductName??"na");
            //Console.WriteLine(l);

            // //return obj as default
            //Product product = new Product() { ProductID=1,ProductName="default"};
            // var f = ProductsList.FirstOrDefault(x => x.UnitsInStock == 1000000,product);
            // Console.WriteLine(f);

            //var res=ProductsList.ElementAt(0);//throw exception if empty
            //Console.WriteLine(res);
            //res= ProductsList.ElementAtOrDefault(1);
            //Console.WriteLine(res);

            //var res = ProductsList.ElementAt(new Index(10, true));//from end
            //Console.WriteLine(res);
            //var res = ProductsList.Single();//work in list has one element
            //Console.WriteLine(res);
            // var res = ProductsList.SingleOrDefault();
            //Console.WriteLine(res);//execption only solve empty seq
            //List<Product> products = new List<Product>() { };
            // var res = products.SingleOrDefault();
            // Console.WriteLine(res);
            //var res=ProductsList.SingleOrDefault(x=>x.ProductID == 1);
            // Console.WriteLine(res);
            //first==>top1
            //single==>top2 
            #endregion

            #region aggregate operation
            //aggregate operation
            //var res = ProductsList.Count();//o(1)if has prop of count
            //Console.WriteLine(res);

            // res=ProductsList.Count(X=>X.UnitsInStock==0);//O(N)
            //Console.WriteLine(res);
            //var res2 = ProductsList.LongCount();//for big value
            //Console.WriteLine(  res2);

            //var res = ProductsList.TryGetNonEnumeratedCount(out int cnt);
            //Console.WriteLine($"{res}  {cnt}");

            //IEnumerable<int> l = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            //var ll=l.Where(x => x %2== 0);
            //var res = ll.TryGetNonEnumeratedCount(out int cnt);
            //Console.WriteLine($"{res}  {cnt}");//cant get the count

            //var res = ProductsList.Sum(x => x.UnitPrice);//for number only
            //Console.WriteLine(res);
            //res=ProductsList.Average(x => x.UnitPrice);
            //Console.WriteLine(res);

            //var res = ProductsList.MaxBy(x=>x.UnitPrice);//return object with max price
            //Console.WriteLine(res);
            //var res = ProductsList.Max(x => x.UnitPrice);//return  max price
            //Console.WriteLine(res);

            //aggregate
            //List<string> n = ["mariem", "mohamed", "shawky"];
            //var res=n.Aggregate((s1,s2)=>$"{s1} {s2}");
            //Console.WriteLine(res);

            //var res = n.Aggregate("i love", (s1, s2) => $"{s1} {s2}");
            //Console.WriteLine(  res);

            //var res = n.Aggregate("i love", (s1, s2) => $"{s1} {s2}",(r)=>r.ToUpper());
            //Console.WriteLine(  res); 
            #endregion

            #endregion


        }
    }
}
