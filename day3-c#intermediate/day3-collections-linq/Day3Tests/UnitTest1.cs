namespace Day3Tests;

public class UnitTest1
{
    [Fact]
    public void WhereFiltersCorrectly()
    {
      var nums = new List<int> {1,2,3,4,5};
      var result = nums.Where(n => n % 2 == 0);
      Assert.Equal(new List<int> {2,4}, result);
    }
}
