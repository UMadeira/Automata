
using System.Text;
using Antlr4.Runtime.Misc;

namespace Automata
{
    public class GraphGenerator : AutomataBaseVisitor<string>
    {
        public override string VisitSpecification([NotNull] AutomataParser.SpecificationContext context)
        {
            base.VisitSpecification(context);

            var builder = new StringBuilder();
            builder.AppendLine( "digraph automata {");
            builder.AppendLine( "rankdir=LR;");
            builder.AppendLine( "margin=1;");
            builder.AppendLine("}");
            
            return builder.ToString();
        }
    }
}