
using System.Collections.Immutable;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
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
            #region Restriction Operators><
            //1
            //var res = ProductsList.Where(x => x.UnitsInStock == 0);
            //Print(res);

            //2
            //var res = ProductsList.Where(x => x.UnitsInStock >= 0&&x.UnitPrice>3);
            //Print(res); 
            #endregion


            #region Element Operators
            //3
            //var res = ProductsList.Where(x => x.UnitsInStock == 0).FirstOrDefault();
            //Console.WriteLine(res);

            //4
            //var res = ProductsList.FirstOrDefault(x => x.UnitPrice > 1000);
            //Console.WriteLine(res); 
            #endregion

            #region Aggregate Operators
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

            //9
            //var res = ProductsList.GroupBy(x => x.Category).Select(x => new
            //{
            //    Category=x.Key,
            //    Count=x.Count()
            //});
            //Print(res);

            //10
            //var res = from o in ProductsList
            //          group o by o.Category
            //        into g
            //          select new
            //          {
            //              Category=g.Key,
            //              MinPrice = g.Min(x => x.UnitPrice)
            //          };
            //Print(res);

            //11
            //var res = from p in ProductsList
            //          group p by p.Category into g
            //          let mn = g.Min(x => x.UnitPrice)
            //          from prod in g
            //          where prod.UnitPrice == mn
            //          select prod;
            //        Print(res);

            //12 
            //var res = from o in ProductsList
            //          group o by o.Category
            //        into g
            //          select new
            //          {
            //              Category = g.Key,
            //              Average = g.Average(x => x.UnitPrice)
            //          };
            //Print(res);
            #endregion

            #region Ordering Operators
            //13
            //var res = ProductsList.OrderBy(x => x.ProductName);
            //Print(res);

            //14
            //var res = ProductsList.OrderByDescending(x => x.UnitsInStock);
            //Print(res);

            //15
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var res = Arr.OrderBy(x => x.Length).ThenBy(x => x);
            //Print(res);

            //16
            //var res = ProductsList.OrderBy(x => x.Category).ThenByDescending(x => x.UnitPrice);
            //Print(res); 

            //17
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var res = Arr.OrderBy(x => x.Length).ThenByDescending(x => x);
            //Print(res);         

            //18
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var res = Arr.Select((x,i)=>new { x,i }).Where(x => x.x[1]=='i').Select(x=>x.i).Reverse();
            //Print(res); 
            #endregion

            #region Transformation Operators
            //19
            //var res = ProductsList.Select(x => x.ProductName);
            //Print(res); 

            //20
            //string[] words = { "aPPLE", "BLUeBeRrY", "cHeRry" };
            //var res = words.Select(x => new
            //{
            //    upper=x.ToUpper(),
            //    lower=x.ToLower(),
            //});
            //Print(res); 

            //21
            //int[] numA = [0, 2, 4, 5, 6, 8, 9];
            //int[] numb = [1,2,5,7,8];

            //var res = from o in numA
            //          from x in numb
            //          where o < x
            //          select new
            //          {
            //              result = $"{o} is less than {x}"
            //          };
            //Print (res);

            //22
            //var res=from o in CustomersList
            //        from x in o.Orders
            //        where x.Total<500
            //        select x;   
            //Print(res); 
            #endregion

            #region  Set Operators
            //23
            //var res=ProductsList.Select(x => x.ProductName).Distinct();
            //Print(res);


            //24
            //var seq = ProductsList.Select(x => x.ProductName[0]);
            //var seq2 = CustomersList.Select(x => x.CustomerName[0]);
            //var res=seq.Union(seq2);    
            //Print(res);         

            //25
            //var seq = ProductsList.Select(x => x.ProductName[0]);
            //var seq2 = CustomersList.Select(x => x.CustomerName[0]);
            //var res = seq.Intersect(seq2);
            //Print(res);

            //26
            //var seq = ProductsList.Select(x => x.ProductName[0]);
            //var seq2 = CustomersList.Select(x => x.CustomerName[0]);
            //var res = seq.Except(seq2);
            //Print(res); 
            #endregion

            #region Partitioning Operators
            //27
            //var res=CustomersList.Where(x => x.Region=="WA").SelectMany(x=>x.Orders).Take(3);
            //Print(res);

            //28
            //var res = CustomersList.Where(x => x.Region == "WA").SelectMany(x => x.Orders).Skip(2);
            //Print(res);


            //29
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers.TakeWhile((x, i) => x > i);
            //Print(res);

            //30
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res=numbers.SkipWhile(x => x%3!= 0);
            //Print(res); 
            #endregion

            #region Quantifiers
            //31
            //string[] dictionary = File.ReadAllLines("dictionary_english.txt");
            //var res = dictionary.Any(x => x.Contains("ei"));
            //Console.WriteLine(res);

            //32
            //var res = from x in ProductsList                    
            //          group x by x.Category
            //          into g
            //          where g.Any(x=>x.UnitsInStock==0)
            //           select new
            //          {
            //              Category = g.Key,
            //              Products = g
            //          };
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.Category);
            //    Print(item.Products);
            //}

            //33
            //var res = from x in ProductsList
            //          group x by x.Category
            //          into g
            //          where g.All(x => x.UnitsInStock > 0)
            //          select new
            //          {
            //              Category = g.Key,
            //              Products = g
            //          };
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.Category);
            //    Print(item.Products);
            //} 
            #endregion


            #region Grouping Operators
            //34
            //string[] dictionary = File.ReadAllLines("dictionary_english.txt");
            //var res = from o in dictionary
            //          group o by o[0];
            //foreach (var item in res) {
            //    Console.WriteLine(item.Key);
            //    Print(item);
            //} 
            #endregion
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

            #region casting operator
            //casting operator [immediate execution]
            //List<Product> l = ProductsList.Where(p => p.UnitsInStock == 0).ToList();
            //Print<Product>(l);
            //Console.WriteLine(l.Count);

            //Product[]l = ProductsList.Where(p => p.UnitsInStock == 0).ToArray();
            // Print<Product>(l);
            // Console.WriteLine(l.Length);

            //Dictionary<long,Product >l= ProductsList.Where(p => p.UnitsInStock == 0).
            //    ToDictionary(p => p.ProductID);
            //Print(l);

            //Dictionary<long,string> l = ProductsList.Where(p => p.UnitsInStock == 0).
            //    ToDictionary(p => p.ProductID,p=>p.ProductName);
            //Print(l);

            //Dictionary<string, Product> l = ProductsList.Where(p => p.UnitsInStock == 0).
            //    ToDictionary(p => p.ProductName, EqualityComparer<string>.Create((x, y) => x.ToLower().Equals(y.ToLower()),
            //   (ob) => ob.ToLower().GetHashCode()));
            //Print(l); 
            #endregion

            #region generation operation
            //generation operation
            //dont work in existing collection [create a sequence]

            //var res = Enumerable.Range(0, 100);
            //Print<int>(res);

            //var res = Enumerable.Range(0, 100).Select(i=>new Product { ProductID=i,Category="meat"});
            //Print(res);

            //var res = Enumerable.Repeat("mariem", 100);
            //Print(res);

            //var res=Enumerable.Empty<int>().ToList();
            //Console.WriteLine(res.Count);

            #endregion

            #region quntifiers op
            //quntifiers op
            // any check if exist one element in seq
            //var res = ProductsList.Any();
            //Console.WriteLine(res);

            //var res = ProductsList.Any(p=>p.UnitsInStock>1);
            //Console.WriteLine(res);

            //all check all element match the condition
            //var res = ProductsList.All(p => p.UnitsInStock > 0);
            //Console.WriteLine(res);

            //contains check if the item in the seq

            //sequence equal must same oerder 
            #endregion

            #region Zip
            // List<string> l = ["one", "two", "three", "four"];
            // int[] arr = { 1, 2, 3, 4,5 };
            //// var res=l.Zip(arr); //take min length 
            // //Print(res);

            // char[] arr2 = { 'o', 't', 't', 'f' };
            // var res = l.Zip(l, arr2);
            // Print(res);  
            #endregion
            #region grouping

            //grouping

            //var res = from o in ProductsList
            //          group o by o.Category;
            //foreach (var item in res)//outer loop iterate over category
            //{
            //    Console.WriteLine(item.Key);
            //    Print(item);
            //}

            //var res = from x in ProductsList
            //          where x.UnitsInStock > 0
            //          group x by x.Category
            //          into ProGroup//start new query
            //          where ProGroup.Count() > 10
            //          select new
            //          {
            //              category = ProGroup.Key,
            //              count = ProGroup.Count(),
            //          };
            //Print(res);

            //var res = ProductsList.GroupBy(x => x.Category, p => p.ProductName);

            //foreach (var item in res)//outer loop iterate over category
            //{
            //    Console.WriteLine(item.Key+":\n");
            //    Print(item);
            //}

            //var res = ProductsList.GroupBy(x => x.Category, (key, p) => new { key, Count = p.Count() });

            //Print(res);

            //Chunk
            //divide array in same size bucket 
            #endregion

            #region partitioning operators
            //partitioning operators

            //var res = ProductsList.Take(3);
            //Print(res); 

            //var res = ProductsList.Where(x=>x.UnitsInStock==0).Take(3);
            //Print(res);

            //var res = ProductsList.TakeLast(3);
            //Print(res);

            // var res=ProductsList.Take(new Range(1, 10));   
            //Print(res);

            //var res = ProductsList.Skip(12);
            //Print(res);

            //pagination
            //int pageSize = 10; int pageinx = 4;
            //var res=ProductsList.Skip(pageSize*(pageinx-1)).Take(pageSize);
            //Print(res);

            //var res=ProductsList.TakeWhile(x => x.UnitsInStock>0);
            //Print(res);

            //var res = ProductsList.SkipWhile(x => x.UnitsInStock > 0);
            //Print(res); 
            #endregion


            #region let into
            //let into

            //aeiouAEIOU    
            //string[] n = ["mahmoud", "ali", "shawky", "mariem"];
            //var res = from o in n
            //          select Regex.Replace(o, "[aeiouAEIOU]", string.Empty)
            //          into nonvowel
            //          where nonvowel.Length>3
            //          select nonvowel;              
            //Print(res);

            //string[] n = ["mahmoud", "ali", "shawky", "mariem"];
            //var res = from o in n
            //          let nonvowel=  Regex.Replace(o, "[aeiouAEIOU]", string.Empty)              
            //          where nonvowel.Length > 3
            //          select nonvowel;
            //Print(res);

            //new in .net 9
            //count by 
            #endregion

            #endregion


        }
    }
}
