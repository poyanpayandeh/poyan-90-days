


// List<T>
List<int> numbers = new List<int> {1,2,3,4,5};
numbers.Add(6);
Console.WriteLine($"List: {string.Join(", ", numbers)}");

// Dictionary<TKey, TValue>
Dictionary<string, int> ages = new Dictionary<string, int> {
  {"Poyan", 28},
  {"Alice", 23}
};
ages["Bob"] = 31;
Console.WriteLine($"Bob's age: {ages["Bob"]}");

// HashSet<T>
HashSet<string> set = new HashSet<string> {"C#","SQL","C++"};
Console.WriteLine($"HashShet (unique): {string.Join(", ", set)}");

// Queue FIFO
Queue<string> queue = new Queue<string>();
queue.Enqueue("Task A");
queue.Enqueue("Task B");
Console.WriteLine($"Queue peek: {queue.Peek()}");

// Stack<T> LIFO
Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
Console.WriteLine($"Stack pop: {stack.Pop()}");
