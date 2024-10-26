using System.Text;
using Amba.TfVars.Model;
using Antlr4.Runtime;

namespace Amba.TfVars
{
    public static class TfVarsContent
    {
        public static TfVarsRoot? Parse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
            }
            var inputStream = new AntlrInputStream(input);
            var lexer = new TfVarsLexer(inputStream);
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new TfVarsParser(tokenStream);

            var tree = parser.file_();
            var visitor = new ExtendedVisitor(tokenStream);
            var result = visitor.Visit(tree);
            return result as TfVarsRoot;
        }

        public static string Serialize(ITfVarsNode? node, bool ident = true, int identSize = 4)
        {
            if (node == null)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();
            var serializer = new TfVarsSerializer(sb, ident, identSize);

            serializer.Serialize(node, 0);
            return sb.ToString();
        }
    }
}
