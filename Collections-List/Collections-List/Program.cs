using Collections_List.Controllers;
using System.Collections;


//Non Generic olanlar

//ArrayList arrayList = new();

//arrayList.Add(5);
//arrayList.Add("salam");

//foreach (var item in arrayList)
//{
//    Console.WriteLine(item);
//}

//Hashtable hashtable = new Hashtable();

//hashtable.Add(1, "Samir");
//hashtable.Add(2, "Fidan");
//hashtable.Add(3, "Kubra");

//foreach (DictionaryEntry item in hashtable)
//{
//    Console.WriteLine(item.Value);
//}



//SortedList sortedList = new SortedList();

//sortedList.Add(5, "Salam5");
//sortedList.Add(3, "Salam3");
//sortedList.Add(1, "Salam1");

//foreach (DictionaryEntry item in sortedList)
//{
//    Console.WriteLine(item.Value);
//}


//SortedList sortedList = new SortedList();

//sortedList.Add("Az", "Salam5");
//sortedList.Add("Ca", "Salam3");
//sortedList.Add("Ba", "Salam1");

//foreach (DictionaryEntry item in sortedList)
//{
//    Console.WriteLine(item.Value);
//}



// Generic olanlar





//SortedList<int,string> genericSortList = new SortedList<int,string>();

//genericSortList.Add(2, "sd");
//genericSortList.Add(1, "saasa");

//foreach (KeyValuePair<int,string> item in genericSortList)
//{
//    Console.WriteLine(item.Value);
//}


//Dictionary<int, int> dicionary = new Dictionary<int, int>();

//dicionary.Add(1, 2);
//dicionary.Add(2, 5);

//foreach (KeyValuePair<int,int> item in dicionary)
//{
//    Console.WriteLine(item.Value);
//}



//Dictionary<string, string> dicionary = new Dictionary<string, string>();

//dicionary.Add("Admin", "Cahangir");
//dicionary.Add("Superadmin", "Sheref");
//dicionary.Add("Member", "Pervin");

// Rolu admin olanin adin goster

//foreach (KeyValuePair<string, string> item in dicionary)
//{
//	if (item.Key=="Admin")
//	{
//        Console.WriteLine(item.Value);
//    }
//}



//Stack<int> stack = new Stack<int>();

//stack.Push(1);
//stack.Push(10);
//stack.Push(4);

//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}



//Queue<int> queue = new Queue<int>();


//queue.Enqueue(1);
//queue.Enqueue(10);
//queue.Enqueue(4);


//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}



List<int> nums = new List<int>();

nums.Add(1);
nums.Add(2);
nums.Add(3);
nums.Add(6);
nums.Add(8);
//Console.WriteLine(nums[0]);
//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}

//int[] arr = { 1, 2, 3 };
//var data = arr.ToList();


//var result = nums.ToArray();
//Console.WriteLine(result);


//List<int> nums2 = new List<int>();

//nums2.Add(1);
//nums2.Add(2);
//nums2.Add(3);
//nums2.Add(88);


//nums.AddRange(nums2);

//foreach (var item in nums )
//{
//    Console.WriteLine(item);
//}


//Console.WriteLine(nums.Count);

//for (int i = 0; i < nums.Count; i++)
//{
//    Console.WriteLine(nums[i]);
//}



//nums.Remove(6);


//var result = nums.FirstOrDefault(m => m > 5);
//Console.WriteLine(result);


//var result = nums.FindAll(m => m > 5);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}



//var result = nums.Exists(x=> x == 1);

//Console.WriteLine();


//var result = nums.Find(m=> m.Equals(1));
//Console.WriteLine(result);


//var result = nums.Where(x => x > 20 || x < 30).FirstOrDefault();

//Console.WriteLine(result);



//var result = nums.Any(m => m == 5);

//Console.WriteLine(result);



// Employee-nin 1000-500 arasinda olanlari ekranda gosterin


//EmployeeController controller= new EmployeeController();
////controller.GetAll();
//controller.FilterByPrice();










































