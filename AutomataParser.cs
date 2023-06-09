//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\Automata.g4 by ANTLR 4.13.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.CLSCompliant(false)]
public partial class AutomataParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, LETTER=4, NUMBER=5, IDENTIFIER=6, WHITESPACES=7;
	public const int
		RULE_specification = 0, RULE_states = 1, RULE_state = 2, RULE_actions = 3, 
		RULE_action = 4, RULE_goto = 5;
	public static readonly string[] ruleNames = {
		"specification", "states", "state", "actions", "action", "goto"
	};

	private static readonly string[] _LiteralNames = {
		null, "'automata'", "'state'", "'Goto'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, "LETTER", "NUMBER", "IDENTIFIER", "WHITESPACES"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Automata.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static AutomataParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public AutomataParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public AutomataParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class SpecificationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(AutomataParser.IDENTIFIER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatesContext states() {
			return GetRuleContext<StatesContext>(0);
		}
		public SpecificationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_specification; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutomataListener typedListener = listener as IAutomataListener;
			if (typedListener != null) typedListener.EnterSpecification(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutomataListener typedListener = listener as IAutomataListener;
			if (typedListener != null) typedListener.ExitSpecification(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAutomataVisitor<TResult> typedVisitor = visitor as IAutomataVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSpecification(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SpecificationContext specification() {
		SpecificationContext _localctx = new SpecificationContext(Context, State);
		EnterRule(_localctx, 0, RULE_specification);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 12;
			Match(T__0);
			State = 13;
			Match(IDENTIFIER);
			State = 14;
			states();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StateContext state() {
			return GetRuleContext<StateContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatesContext states() {
			return GetRuleContext<StatesContext>(0);
		}
		public StatesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_states; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutomataListener typedListener = listener as IAutomataListener;
			if (typedListener != null) typedListener.EnterStates(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutomataListener typedListener = listener as IAutomataListener;
			if (typedListener != null) typedListener.ExitStates(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAutomataVisitor<TResult> typedVisitor = visitor as IAutomataVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStates(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatesContext states() {
		StatesContext _localctx = new StatesContext(Context, State);
		EnterRule(_localctx, 2, RULE_states);
		try {
			State = 20;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,0,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 16;
				state();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 17;
				state();
				State = 18;
				states();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StateContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUMBER() { return GetToken(AutomataParser.NUMBER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ActionsContext actions() {
			return GetRuleContext<ActionsContext>(0);
		}
		public StateContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_state; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutomataListener typedListener = listener as IAutomataListener;
			if (typedListener != null) typedListener.EnterState(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutomataListener typedListener = listener as IAutomataListener;
			if (typedListener != null) typedListener.ExitState(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAutomataVisitor<TResult> typedVisitor = visitor as IAutomataVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitState(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StateContext state() {
		StateContext _localctx = new StateContext(Context, State);
		EnterRule(_localctx, 4, RULE_state);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 22;
			Match(T__1);
			State = 23;
			Match(NUMBER);
			State = 24;
			actions();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ActionsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ActionContext action() {
			return GetRuleContext<ActionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ActionsContext actions() {
			return GetRuleContext<ActionsContext>(0);
		}
		public ActionsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_actions; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutomataListener typedListener = listener as IAutomataListener;
			if (typedListener != null) typedListener.EnterActions(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutomataListener typedListener = listener as IAutomataListener;
			if (typedListener != null) typedListener.ExitActions(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAutomataVisitor<TResult> typedVisitor = visitor as IAutomataVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitActions(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ActionsContext actions() {
		ActionsContext _localctx = new ActionsContext(Context, State);
		EnterRule(_localctx, 6, RULE_actions);
		try {
			State = 30;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Eof:
			case T__1:
				EnterOuterAlt(_localctx, 1);
				{
				}
				break;
			case LETTER:
				EnterOuterAlt(_localctx, 2);
				{
				State = 27;
				action();
				State = 28;
				actions();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ActionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public GotoContext @goto() {
			return GetRuleContext<GotoContext>(0);
		}
		public ActionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_action; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutomataListener typedListener = listener as IAutomataListener;
			if (typedListener != null) typedListener.EnterAction(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutomataListener typedListener = listener as IAutomataListener;
			if (typedListener != null) typedListener.ExitAction(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAutomataVisitor<TResult> typedVisitor = visitor as IAutomataVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAction(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ActionContext action() {
		ActionContext _localctx = new ActionContext(Context, State);
		EnterRule(_localctx, 8, RULE_action);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 32;
			@goto();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class GotoContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LETTER() { return GetToken(AutomataParser.LETTER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUMBER() { return GetToken(AutomataParser.NUMBER, 0); }
		public GotoContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_goto; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutomataListener typedListener = listener as IAutomataListener;
			if (typedListener != null) typedListener.EnterGoto(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutomataListener typedListener = listener as IAutomataListener;
			if (typedListener != null) typedListener.ExitGoto(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAutomataVisitor<TResult> typedVisitor = visitor as IAutomataVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitGoto(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public GotoContext @goto() {
		GotoContext _localctx = new GotoContext(Context, State);
		EnterRule(_localctx, 10, RULE_goto);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 34;
			Match(LETTER);
			State = 35;
			Match(T__2);
			State = 36;
			Match(NUMBER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static int[] _serializedATN = {
		4,1,7,39,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,1,0,1,0,1,0,1,
		0,1,1,1,1,1,1,1,1,3,1,21,8,1,1,2,1,2,1,2,1,2,1,3,1,3,1,3,1,3,3,3,31,8,
		3,1,4,1,4,1,5,1,5,1,5,1,5,1,5,0,0,6,0,2,4,6,8,10,0,0,34,0,12,1,0,0,0,2,
		20,1,0,0,0,4,22,1,0,0,0,6,30,1,0,0,0,8,32,1,0,0,0,10,34,1,0,0,0,12,13,
		5,1,0,0,13,14,5,6,0,0,14,15,3,2,1,0,15,1,1,0,0,0,16,21,3,4,2,0,17,18,3,
		4,2,0,18,19,3,2,1,0,19,21,1,0,0,0,20,16,1,0,0,0,20,17,1,0,0,0,21,3,1,0,
		0,0,22,23,5,2,0,0,23,24,5,5,0,0,24,25,3,6,3,0,25,5,1,0,0,0,26,31,1,0,0,
		0,27,28,3,8,4,0,28,29,3,6,3,0,29,31,1,0,0,0,30,26,1,0,0,0,30,27,1,0,0,
		0,31,7,1,0,0,0,32,33,3,10,5,0,33,9,1,0,0,0,34,35,5,4,0,0,35,36,5,3,0,0,
		36,37,5,5,0,0,37,11,1,0,0,0,2,20,30
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
