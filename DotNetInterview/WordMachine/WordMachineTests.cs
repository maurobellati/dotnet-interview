namespace DotNetInterview.WordMachine;

using Xunit;

public class WordMachineTests
{
    [Fact]
    public void Ok()
    {
        var input = "13 DUP 4 POP 5 DUP + DUP + -";
        // invoke 
        var expected = 7;

        // assert
    }

    // Error 1:
    // "5 6 + -"


    // Error 2:
    // "3 DUP 5 - -"
}