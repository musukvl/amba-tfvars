using System.Text.RegularExpressions;

namespace Amba.TfVarsTests;

public abstract class TestUtils
{
    public static void CompareLines(string expected, string actual)
    {
        var eolRegex = new Regex("\r\n|\r|\n", RegexOptions.Compiled);
        var expectedLines = eolRegex.Split(expected);
        var actualLines = eolRegex.Split(actual);
        for (var i = 0; i < expectedLines.Length; i++)
        {
            Assert.Equal(expectedLines[i].Trim(), actualLines[i].Trim());
        }
    }
}