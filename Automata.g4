grammar Automata;

// Syntax Rules

specification: 'automata' IDENTIFIER states;

states: state | state states;

state: 'state' NUMBER actions;

actions		: 
			| action actions
			;

action		: goto
			;

goto		: LETTER 'Goto' NUMBER
			;


// Lexer Rule

fragment DIGIT: [0-9];

LETTER: [a-zA-Z];

NUMBER: DIGIT+;

IDENTIFIER: LETTER (LETTER | DIGIT)*;

WHITESPACES: [ \t\r\n]+ -> skip;

