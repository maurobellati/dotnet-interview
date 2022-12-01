namespace DotNetInterview.Exercises;

using FluentAssertions;
using Xunit;

public class StudentsGroupBy
{
    public record Student(string Name, int Age);


    [Fact]
    public void SortedAdultNamesGroupedByDecade()
    {
        var students = new List<Student>
        {
            new("A0", 17),
            new("A1", 21),
            new("A2", 18),
            new("B0", 13),
            new("B1", 25),
            new("B2", 29),
            new("B3", 19),
            new("B4", 18),
            new("B3", 18),
        };

        Dictionary<int, List<string>> adultsGroupedByDecadeWithUniqueNamesSorted = null;


        adultsGroupedByDecadeWithUniqueNamesSorted[10].Should().ContainInConsecutiveOrder("A2", "B3", "B4");
    }
}


#region Solution

// students
//     .Where(it => it.Age >= 18)
//     .GroupBy(
//         it => (it.Age / 10) * 10,
//         it => it.Name
//     ).ToDictionary(
//         it => it.Key,
//         it => it.OrderBy(x => x).Distinct().ToList());

#endregion