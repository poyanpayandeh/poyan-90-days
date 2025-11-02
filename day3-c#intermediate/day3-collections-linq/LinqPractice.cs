public class LinqPractice {
  public void Run() {
    List<int> nums = new List<int> {1,5,10,3,8,7,20};

    // Filtering
    var evens = nums.Where(n => n % 2 == 0);

    // Sorting
    var sorted = nums.OrderBy(n => n);

    //
    var doubled = nums.Select(n => n * 2);

    // Aggregates
    int sum = nums.Sum();
    int max = nums.Max();
    double avg = nums.Average();

    Console.WriteLine($"Evens: {string.Join(", ", evens)}");
    Console.WriteLine($"Sorted: {string.Join(", ", sorted)}");
    Console.WriteLine($"Doubled: {string.Join(", ", doubled)}");
    Console.WriteLine($"Sum: {sum}, Max: {max}, Avg: {avg}");
  }
}
