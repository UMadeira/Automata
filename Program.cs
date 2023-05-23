using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Automata;

Console.WriteLine( "Automata v1.0");
if ( args.Length == 0 )
{
    Console.WriteLine( "usage: Automata <filename>" );
    return;
}

if ( ! File.Exists( args[0] ) )
{
    Console.WriteLine( $"Error: file {args[0]} does not exists.");
    return;
}

string automata = File.ReadAllText( args[0] );

var stream = CharStreams.fromString( automata );
var lexer  = new AutomataLexer( stream );
var tokens = new CommonTokenStream( lexer );
var parser = new AutomataParser( tokens );
parser.BuildParseTree = true;

var tree = parser.specification();

var visitor = new GraphGenerator();
var graph = visitor.Visit( tree );

var filename = $"{Path.GetFileNameWithoutExtension(args[0])}.viz";
File.WriteAllText( filename, graph );


