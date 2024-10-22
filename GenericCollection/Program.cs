// 1. List

using System.Collections;
using System.Globalization;

List<string> names = new List<string>();
names.Add("Nakib");
names.Add("Rahat");
names.Add("Sayeed");

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

// 2. Dictonary
Dictionary<string, int> empInfo = new Dictionary<string, int>();
empInfo.Add("Nakib Khan", 20476581);
empInfo.Add("Nouman Ali Khan", 203423);

empInfo["Nakib Khan"] = 22;
Console.WriteLine(empInfo["Nakib Khan"]);

// 3. HashSet: you can't insert duplicate
HashSet<string> itemList = new HashSet<string>();
itemList.Add("Darma Rollar");
itemList.Add("Minoxidil");
itemList.Add("Biotin");
itemList.Add("DHT");
itemList.Add("DHT");      //Though it's not showing error , but the hashset it will insert one time

foreach (string item in itemList)
{
    Console.WriteLine(item);
}

// 4. Stack
Stack<string> stack = new Stack<string>();
stack.Push("Fixation");
stack.Push("Checker");
stack.Push("Maker");

for(int i = 0; i < 3; i ++)
{
    Console.WriteLine(stack.Pop());
}

// 5. Queue
Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);

for(int i = 0;i < 3; i ++)
{
    Console.WriteLine(queue.Dequeue());
}

// 6. Sorted list
SortedList<string, int> keyValuePairs = new SortedList<string, int>();
keyValuePairs.Add("Khan", 33);
keyValuePairs.Add("Shaheb", 32);
keyValuePairs.Add("Abir", 87);


foreach(var item in keyValuePairs)
{
    Console.WriteLine($"Key : {item.Key}, Value : {item.Value}");
}

// 7. Link list
LinkedList<string> list = new LinkedList<string>();
list.AddLast("One");
list.AddLast("Two");


// Non generic version: these are object type. so you can put any type date

// 1. ArrayList
ArrayList arrayList = new ArrayList();
arrayList.Add("One");
arrayList.Add(1);
arrayList.Add(2.5);
arrayList.Add(true);

// 2. Stack
Stack stack1 = new Stack();
stack.Push("Nakib Khan");
stack.Pop();

// 3. Queue
Queue queue1 = new Queue(); 
queue1.Enqueue(1);
queue1.Dequeue();

// 4. HashTable : It's almost like dictionary
Hashtable hashtable = new Hashtable();
hashtable.Add("Nakib", 4344);
