//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from TfVars.g4 by ANTLR 4.13.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Amba.TfVars {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.CLSCompliant(false)]
public partial class TfVarsLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		LCURL=10, RCURL=11, LPAREN=12, RPAREN=13, EOF_=14, NATURAL_NUMBER=15, 
		DESCRIPTION=16, MULTILINESTRING=17, IDENTIFIER=18, STRING=19, LINECOMMENT=20, 
		BLOCKCOMMENT=21, EOLS=22, WS=23, DOT=24;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"DIGIT", "LCURL", "RCURL", "LPAREN", "RPAREN", "EOF_", "NATURAL_NUMBER", 
		"DESCRIPTION", "MULTILINESTRING", "IDENTIFIER", "STRING", "LINECOMMENT", 
		"BLOCKCOMMENT", "EOLS", "WS", "DOT"
	};


	public TfVarsLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public TfVarsLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'='", "'['", "']'", "','", "'+'", "'-'", "'null'", "'true'", "'false'", 
		"'{'", "'}'", "'('", "')'", null, null, null, null, null, null, null, 
		null, null, null, "'.'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, "LCURL", "RCURL", 
		"LPAREN", "RPAREN", "EOF_", "NATURAL_NUMBER", "DESCRIPTION", "MULTILINESTRING", 
		"IDENTIFIER", "STRING", "LINECOMMENT", "BLOCKCOMMENT", "EOLS", "WS", "DOT"
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

	public override string GrammarFileName { get { return "TfVars.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static TfVarsLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,24,220,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,1,0,1,0,1,1,1,1,1,2,1,2,1,3,1,3,1,4,
		1,4,1,5,1,5,1,6,1,6,1,6,1,6,1,6,1,7,1,7,1,7,1,7,1,7,1,8,1,8,1,8,1,8,1,
		8,1,8,1,9,1,9,1,10,1,10,1,11,1,11,1,12,1,12,1,13,1,13,1,14,1,14,1,14,1,
		14,1,14,1,14,1,14,5,14,97,8,14,10,14,12,14,100,9,14,1,14,1,14,1,14,1,14,
		1,15,4,15,107,8,15,11,15,12,15,108,1,16,1,16,1,16,1,16,1,16,1,16,1,16,
		1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,5,16,126,8,16,10,16,12,16,129,
		9,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,16,1,17,
		1,17,1,17,1,17,1,17,1,17,1,17,1,17,5,17,151,8,17,10,17,12,17,154,9,17,
		1,17,1,17,1,17,1,17,1,18,1,18,5,18,162,8,18,10,18,12,18,165,9,18,1,19,
		1,19,1,19,1,19,5,19,171,8,19,10,19,12,19,174,9,19,1,19,1,19,1,20,1,20,
		1,20,3,20,181,8,20,1,20,5,20,184,8,20,10,20,12,20,187,9,20,1,20,1,20,1,
		21,1,21,1,21,1,21,5,21,195,8,21,10,21,12,21,198,9,21,1,21,1,21,1,21,1,
		21,1,21,1,22,4,22,206,8,22,11,22,12,22,207,1,22,1,22,1,23,4,23,213,8,23,
		11,23,12,23,214,1,23,1,23,1,24,1,24,4,98,127,152,196,0,25,1,1,3,2,5,3,
		7,4,9,5,11,6,13,7,15,8,17,9,19,0,21,10,23,11,25,12,27,13,29,14,31,15,33,
		16,35,17,37,18,39,19,41,20,43,21,45,22,47,23,49,24,1,0,6,1,0,48,57,2,0,
		65,90,97,122,5,0,45,45,48,57,65,90,95,95,97,122,3,0,10,10,13,13,34,34,
		2,0,10,10,13,13,2,0,9,9,32,32,230,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,
		0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,
		0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,
		0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,
		1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,0,1,51,1,0,0,
		0,3,53,1,0,0,0,5,55,1,0,0,0,7,57,1,0,0,0,9,59,1,0,0,0,11,61,1,0,0,0,13,
		63,1,0,0,0,15,68,1,0,0,0,17,73,1,0,0,0,19,79,1,0,0,0,21,81,1,0,0,0,23,
		83,1,0,0,0,25,85,1,0,0,0,27,87,1,0,0,0,29,89,1,0,0,0,31,106,1,0,0,0,33,
		110,1,0,0,0,35,142,1,0,0,0,37,159,1,0,0,0,39,166,1,0,0,0,41,180,1,0,0,
		0,43,190,1,0,0,0,45,205,1,0,0,0,47,212,1,0,0,0,49,218,1,0,0,0,51,52,5,
		61,0,0,52,2,1,0,0,0,53,54,5,91,0,0,54,4,1,0,0,0,55,56,5,93,0,0,56,6,1,
		0,0,0,57,58,5,44,0,0,58,8,1,0,0,0,59,60,5,43,0,0,60,10,1,0,0,0,61,62,5,
		45,0,0,62,12,1,0,0,0,63,64,5,110,0,0,64,65,5,117,0,0,65,66,5,108,0,0,66,
		67,5,108,0,0,67,14,1,0,0,0,68,69,5,116,0,0,69,70,5,114,0,0,70,71,5,117,
		0,0,71,72,5,101,0,0,72,16,1,0,0,0,73,74,5,102,0,0,74,75,5,97,0,0,75,76,
		5,108,0,0,76,77,5,115,0,0,77,78,5,101,0,0,78,18,1,0,0,0,79,80,7,0,0,0,
		80,20,1,0,0,0,81,82,5,123,0,0,82,22,1,0,0,0,83,84,5,125,0,0,84,24,1,0,
		0,0,85,86,5,40,0,0,86,26,1,0,0,0,87,88,5,41,0,0,88,28,1,0,0,0,89,90,5,
		60,0,0,90,91,5,60,0,0,91,92,5,69,0,0,92,93,5,79,0,0,93,94,5,70,0,0,94,
		98,1,0,0,0,95,97,9,0,0,0,96,95,1,0,0,0,97,100,1,0,0,0,98,99,1,0,0,0,98,
		96,1,0,0,0,99,101,1,0,0,0,100,98,1,0,0,0,101,102,5,69,0,0,102,103,5,79,
		0,0,103,104,5,70,0,0,104,30,1,0,0,0,105,107,3,19,9,0,106,105,1,0,0,0,107,
		108,1,0,0,0,108,106,1,0,0,0,108,109,1,0,0,0,109,32,1,0,0,0,110,111,5,60,
		0,0,111,112,5,60,0,0,112,113,5,68,0,0,113,114,5,69,0,0,114,115,5,83,0,
		0,115,116,5,67,0,0,116,117,5,82,0,0,117,118,5,73,0,0,118,119,5,80,0,0,
		119,120,5,84,0,0,120,121,5,73,0,0,121,122,5,79,0,0,122,123,5,78,0,0,123,
		127,1,0,0,0,124,126,9,0,0,0,125,124,1,0,0,0,126,129,1,0,0,0,127,128,1,
		0,0,0,127,125,1,0,0,0,128,130,1,0,0,0,129,127,1,0,0,0,130,131,5,68,0,0,
		131,132,5,69,0,0,132,133,5,83,0,0,133,134,5,67,0,0,134,135,5,82,0,0,135,
		136,5,73,0,0,136,137,5,80,0,0,137,138,5,84,0,0,138,139,5,73,0,0,139,140,
		5,79,0,0,140,141,5,78,0,0,141,34,1,0,0,0,142,143,5,60,0,0,143,144,5,60,
		0,0,144,145,5,45,0,0,145,146,5,69,0,0,146,147,5,79,0,0,147,148,5,70,0,
		0,148,152,1,0,0,0,149,151,9,0,0,0,150,149,1,0,0,0,151,154,1,0,0,0,152,
		153,1,0,0,0,152,150,1,0,0,0,153,155,1,0,0,0,154,152,1,0,0,0,155,156,5,
		69,0,0,156,157,5,79,0,0,157,158,5,70,0,0,158,36,1,0,0,0,159,163,7,1,0,
		0,160,162,7,2,0,0,161,160,1,0,0,0,162,165,1,0,0,0,163,161,1,0,0,0,163,
		164,1,0,0,0,164,38,1,0,0,0,165,163,1,0,0,0,166,172,5,34,0,0,167,168,5,
		92,0,0,168,171,5,34,0,0,169,171,8,3,0,0,170,167,1,0,0,0,170,169,1,0,0,
		0,171,174,1,0,0,0,172,170,1,0,0,0,172,173,1,0,0,0,173,175,1,0,0,0,174,
		172,1,0,0,0,175,176,5,34,0,0,176,40,1,0,0,0,177,181,5,35,0,0,178,179,5,
		47,0,0,179,181,5,47,0,0,180,177,1,0,0,0,180,178,1,0,0,0,181,185,1,0,0,
		0,182,184,8,4,0,0,183,182,1,0,0,0,184,187,1,0,0,0,185,183,1,0,0,0,185,
		186,1,0,0,0,186,188,1,0,0,0,187,185,1,0,0,0,188,189,6,20,0,0,189,42,1,
		0,0,0,190,191,5,47,0,0,191,192,5,42,0,0,192,196,1,0,0,0,193,195,9,0,0,
		0,194,193,1,0,0,0,195,198,1,0,0,0,196,197,1,0,0,0,196,194,1,0,0,0,197,
		199,1,0,0,0,198,196,1,0,0,0,199,200,5,42,0,0,200,201,5,47,0,0,201,202,
		1,0,0,0,202,203,6,21,0,0,203,44,1,0,0,0,204,206,7,4,0,0,205,204,1,0,0,
		0,206,207,1,0,0,0,207,205,1,0,0,0,207,208,1,0,0,0,208,209,1,0,0,0,209,
		210,6,22,0,0,210,46,1,0,0,0,211,213,7,5,0,0,212,211,1,0,0,0,213,214,1,
		0,0,0,214,212,1,0,0,0,214,215,1,0,0,0,215,216,1,0,0,0,216,217,6,23,1,0,
		217,48,1,0,0,0,218,219,5,46,0,0,219,50,1,0,0,0,13,0,98,108,127,152,163,
		170,172,180,185,196,207,214,2,0,1,0,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Amba.TfVars
