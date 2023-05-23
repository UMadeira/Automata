
using System.Text;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace Automata
{
    public class GraphGenerator : AutomataBaseVisitor<string>
    {
        private string? StateNumber { get; set; }

        public override string VisitSpecification([NotNull] AutomataParser.SpecificationContext context)
        {
            var states = Visit(context.states());

            var builder = new StringBuilder();
            builder.AppendLine( "digraph automata {");
            builder.AppendLine( "rankdir=LR;");
            builder.AppendLine( "margin=1;");
            builder.AppendLine(states);
            builder.AppendLine( "}" );
            
            return builder.ToString();
        }

        public override string VisitStates([NotNull] AutomataParser.StatesContext context)
        {
            if (context.ChildCount == 1)
            {
                return Visit(context.state());
            }
            else
            {
                var builder = new StringBuilder();
                builder.AppendLine(Visit(context.state() ) );
                builder.AppendLine(Visit(context.states() ) );
                return builder.ToString();
            }
        }

        public override string VisitState([NotNull] AutomataParser.StateContext context)
        {
            StateNumber = context.NUMBER().ToString();

            var builder = new StringBuilder();
            builder.Append($"q{StateNumber}");
            builder.Append("[");
            builder.Append("shape=rectangle,");
            builder.Append( $"label=\"state {StateNumber}\"");
            builder.AppendLine("]");

            var actions = Visit(context.actions());
            builder.AppendLine(actions);

            return builder.ToString();
        }

        public override string VisitActions([NotNull] AutomataParser.ActionsContext context)
        {
            if (context.ChildCount == 0) return string.Empty;

            var builder = new StringBuilder();
            builder.AppendLine(Visit(context.action()));
            builder.AppendLine(Visit(context.actions()));
            return builder.ToString();
        }

        public override string VisitAction([NotNull] AutomataParser.ActionContext context)
        {
            return Visit(context.@goto());
        }

        public override string VisitGoto([NotNull] AutomataParser.GotoContext context)
        {
            var number = context.NUMBER().ToString();
            var symbol = context.LETTER().ToString();

            return $"q{StateNumber} -> q{number} [ label=\"{symbol}\"]";
        }
    }

}