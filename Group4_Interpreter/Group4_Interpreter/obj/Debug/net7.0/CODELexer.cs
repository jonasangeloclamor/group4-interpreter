//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Group4_Interpreter\Group4_Interpreter\Code.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Group4_Interpreter {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class CodeLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, BEGIN_CODE=24, 
		END_CODE=25, BEGIN_IF=26, END_IF=27, WHILE=28, BEGIN_WHILE=29, END_WHILE=30, 
		INT=31, FLOAT=32, CHAR=33, BOOL=34, INTEGER_VALUES=35, FLOAT_VALUES=36, 
		CHARACTER_VALUES=37, BOOLEAN_VALUES=38, STRING_VALUES=39, LOGICAL_OPERATORS=40, 
		SCAN=41, IDENTIFIERS=42, COMMENTS=43, BLANK_LINES=44, WHITESPACES=45;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "BEGIN_CODE", "END_CODE", 
		"BEGIN_IF", "END_IF", "WHILE", "BEGIN_WHILE", "END_WHILE", "INT", "FLOAT", 
		"CHAR", "BOOL", "INTEGER_VALUES", "FLOAT_VALUES", "CHARACTER_VALUES", 
		"BOOLEAN_VALUES", "STRING_VALUES", "LOGICAL_OPERATORS", "SCAN", "IDENTIFIERS", 
		"COMMENTS", "BLANK_LINES", "WHITESPACES"
	};


	public CodeLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "','", "'='", "'IF'", "'('", "')'", "'ELSE'", "'NOT'", "'*'", 
		"'/'", "'%'", "'+'", "'-'", "'&'", "'=='", "'<>'", "'>'", "'<'", "'>='", 
		"'<='", "'['", "']'", "':'", null, null, null, null, "'WHILE'", null, 
		null, "'INT'", "'FLOAT'", "'CHAR'", "'BOOL'", null, null, null, null, 
		null, null, "'SCAN:'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		"BEGIN_CODE", "END_CODE", "BEGIN_IF", "END_IF", "WHILE", "BEGIN_WHILE", 
		"END_WHILE", "INT", "FLOAT", "CHAR", "BOOL", "INTEGER_VALUES", "FLOAT_VALUES", 
		"CHARACTER_VALUES", "BOOLEAN_VALUES", "STRING_VALUES", "LOGICAL_OPERATORS", 
		"SCAN", "IDENTIFIERS", "COMMENTS", "BLANK_LINES", "WHITESPACES"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Code.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2/\x150\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x4*\t"+
		"*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5"+
		"\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t"+
		"\x3\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3"+
		"\xF\x3\x10\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x13\x3"+
		"\x13\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3"+
		"\x17\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3"+
		"\x19\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3"+
		"\x1A\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3"+
		"\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1D\x3"+
		"\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3"+
		"\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3\x1F\x3"+
		"\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3 \x3 \x3!\x3"+
		"!\x3!\x3!\x3!\x3!\x3\"\x3\"\x3\"\x3\"\x3\"\x3#\x3#\x3#\x3#\x3#\x3$\x6"+
		"$\xEB\n$\r$\xE$\xEC\x3%\x6%\xF0\n%\r%\xE%\xF1\x3%\x3%\x6%\xF6\n%\r%\xE"+
		"%\xF7\x3&\x3&\x3&\x3&\x3&\x3&\x3&\x3&\x3&\x3&\x3&\x3&\x3&\x5&\x107\n&"+
		"\x3\'\x3\'\x3\'\x3\'\x3(\x3(\a(\x10F\n(\f(\xE(\x112\v(\x3(\x3(\x3(\a("+
		"\x117\n(\f(\xE(\x11A\v(\x3(\x5(\x11D\n(\x3)\x3)\x3)\x3)\x3)\x3)\x3)\x3"+
		")\x5)\x127\n)\x3*\x3*\x3*\x3*\x3*\x3*\x3+\x3+\a+\x131\n+\f+\xE+\x134\v"+
		"+\x3,\x3,\a,\x138\n,\f,\xE,\x13B\v,\x3,\x3,\x3-\a-\x140\n-\f-\xE-\x143"+
		"\v-\x3-\x5-\x146\n-\x3-\x3-\x3.\x6.\x14B\n.\r.\xE.\x14C\x3.\x3.\x2\x2"+
		"\x2/\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n"+
		"\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11"+
		"!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31"+
		"\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?\x2!"+
		"\x41\x2\"\x43\x2#\x45\x2$G\x2%I\x2&K\x2\'M\x2(O\x2)Q\x2*S\x2+U\x2,W\x2"+
		"-Y\x2.[\x2/\x3\x2\r\x3\x2\x32;\x5\x2\f\f\xF\xF))\x3\x2$$\x3\x2))\x5\x2"+
		"\x43\\\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\x4\x2\f\f\xF\xF\x4\x2"+
		"\v\v\"\"\x3\x2\xF\xF\x3\x2\f\f\x5\x2\v\v\xF\xF\"\"\x15D\x2\x3\x3\x2\x2"+
		"\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2"+
		"\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2"+
		"\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B"+
		"\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2"+
		"#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3"+
		"\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3"+
		"\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2"+
		";\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2\x43"+
		"\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2K\x3"+
		"\x2\x2\x2\x2M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2Q\x3\x2\x2\x2\x2S\x3\x2\x2"+
		"\x2\x2U\x3\x2\x2\x2\x2W\x3\x2\x2\x2\x2Y\x3\x2\x2\x2\x2[\x3\x2\x2\x2\x3"+
		"]\x3\x2\x2\x2\x5_\x3\x2\x2\x2\a\x61\x3\x2\x2\x2\t\x63\x3\x2\x2\x2\v\x66"+
		"\x3\x2\x2\x2\rh\x3\x2\x2\x2\xFj\x3\x2\x2\x2\x11o\x3\x2\x2\x2\x13s\x3\x2"+
		"\x2\x2\x15u\x3\x2\x2\x2\x17w\x3\x2\x2\x2\x19y\x3\x2\x2\x2\x1B{\x3\x2\x2"+
		"\x2\x1D}\x3\x2\x2\x2\x1F\x7F\x3\x2\x2\x2!\x82\x3\x2\x2\x2#\x85\x3\x2\x2"+
		"\x2%\x87\x3\x2\x2\x2\'\x89\x3\x2\x2\x2)\x8C\x3\x2\x2\x2+\x8F\x3\x2\x2"+
		"\x2-\x91\x3\x2\x2\x2/\x93\x3\x2\x2\x2\x31\x95\x3\x2\x2\x2\x33\xA0\x3\x2"+
		"\x2\x2\x35\xA9\x3\x2\x2\x2\x37\xB2\x3\x2\x2\x2\x39\xB9\x3\x2\x2\x2;\xBF"+
		"\x3\x2\x2\x2=\xCB\x3\x2\x2\x2?\xD5\x3\x2\x2\x2\x41\xD9\x3\x2\x2\x2\x43"+
		"\xDF\x3\x2\x2\x2\x45\xE4\x3\x2\x2\x2G\xEA\x3\x2\x2\x2I\xEF\x3\x2\x2\x2"+
		"K\x106\x3\x2\x2\x2M\x108\x3\x2\x2\x2O\x11C\x3\x2\x2\x2Q\x126\x3\x2\x2"+
		"\x2S\x128\x3\x2\x2\x2U\x12E\x3\x2\x2\x2W\x135\x3\x2\x2\x2Y\x141\x3\x2"+
		"\x2\x2[\x14A\x3\x2\x2\x2]^\a=\x2\x2^\x4\x3\x2\x2\x2_`\a.\x2\x2`\x6\x3"+
		"\x2\x2\x2\x61\x62\a?\x2\x2\x62\b\x3\x2\x2\x2\x63\x64\aK\x2\x2\x64\x65"+
		"\aH\x2\x2\x65\n\x3\x2\x2\x2\x66g\a*\x2\x2g\f\x3\x2\x2\x2hi\a+\x2\x2i\xE"+
		"\x3\x2\x2\x2jk\aG\x2\x2kl\aN\x2\x2lm\aU\x2\x2mn\aG\x2\x2n\x10\x3\x2\x2"+
		"\x2op\aP\x2\x2pq\aQ\x2\x2qr\aV\x2\x2r\x12\x3\x2\x2\x2st\a,\x2\x2t\x14"+
		"\x3\x2\x2\x2uv\a\x31\x2\x2v\x16\x3\x2\x2\x2wx\a\'\x2\x2x\x18\x3\x2\x2"+
		"\x2yz\a-\x2\x2z\x1A\x3\x2\x2\x2{|\a/\x2\x2|\x1C\x3\x2\x2\x2}~\a(\x2\x2"+
		"~\x1E\x3\x2\x2\x2\x7F\x80\a?\x2\x2\x80\x81\a?\x2\x2\x81 \x3\x2\x2\x2\x82"+
		"\x83\a>\x2\x2\x83\x84\a@\x2\x2\x84\"\x3\x2\x2\x2\x85\x86\a@\x2\x2\x86"+
		"$\x3\x2\x2\x2\x87\x88\a>\x2\x2\x88&\x3\x2\x2\x2\x89\x8A\a@\x2\x2\x8A\x8B"+
		"\a?\x2\x2\x8B(\x3\x2\x2\x2\x8C\x8D\a>\x2\x2\x8D\x8E\a?\x2\x2\x8E*\x3\x2"+
		"\x2\x2\x8F\x90\a]\x2\x2\x90,\x3\x2\x2\x2\x91\x92\a_\x2\x2\x92.\x3\x2\x2"+
		"\x2\x93\x94\a<\x2\x2\x94\x30\x3\x2\x2\x2\x95\x96\a\x44\x2\x2\x96\x97\a"+
		"G\x2\x2\x97\x98\aI\x2\x2\x98\x99\aK\x2\x2\x99\x9A\aP\x2\x2\x9A\x9B\x3"+
		"\x2\x2\x2\x9B\x9C\a\x45\x2\x2\x9C\x9D\aQ\x2\x2\x9D\x9E\a\x46\x2\x2\x9E"+
		"\x9F\aG\x2\x2\x9F\x32\x3\x2\x2\x2\xA0\xA1\aG\x2\x2\xA1\xA2\aP\x2\x2\xA2"+
		"\xA3\a\x46\x2\x2\xA3\xA4\x3\x2\x2\x2\xA4\xA5\a\x45\x2\x2\xA5\xA6\aQ\x2"+
		"\x2\xA6\xA7\a\x46\x2\x2\xA7\xA8\aG\x2\x2\xA8\x34\x3\x2\x2\x2\xA9\xAA\a"+
		"\x44\x2\x2\xAA\xAB\aG\x2\x2\xAB\xAC\aI\x2\x2\xAC\xAD\aK\x2\x2\xAD\xAE"+
		"\aP\x2\x2\xAE\xAF\x3\x2\x2\x2\xAF\xB0\aK\x2\x2\xB0\xB1\aH\x2\x2\xB1\x36"+
		"\x3\x2\x2\x2\xB2\xB3\aG\x2\x2\xB3\xB4\aP\x2\x2\xB4\xB5\a\x46\x2\x2\xB5"+
		"\xB6\x3\x2\x2\x2\xB6\xB7\aK\x2\x2\xB7\xB8\aH\x2\x2\xB8\x38\x3\x2\x2\x2"+
		"\xB9\xBA\aY\x2\x2\xBA\xBB\aJ\x2\x2\xBB\xBC\aK\x2\x2\xBC\xBD\aN\x2\x2\xBD"+
		"\xBE\aG\x2\x2\xBE:\x3\x2\x2\x2\xBF\xC0\a\x44\x2\x2\xC0\xC1\aG\x2\x2\xC1"+
		"\xC2\aI\x2\x2\xC2\xC3\aK\x2\x2\xC3\xC4\aP\x2\x2\xC4\xC5\x3\x2\x2\x2\xC5"+
		"\xC6\aY\x2\x2\xC6\xC7\aJ\x2\x2\xC7\xC8\aK\x2\x2\xC8\xC9\aN\x2\x2\xC9\xCA"+
		"\aG\x2\x2\xCA<\x3\x2\x2\x2\xCB\xCC\aG\x2\x2\xCC\xCD\aP\x2\x2\xCD\xCE\a"+
		"\x46\x2\x2\xCE\xCF\x3\x2\x2\x2\xCF\xD0\aY\x2\x2\xD0\xD1\aJ\x2\x2\xD1\xD2"+
		"\aK\x2\x2\xD2\xD3\aN\x2\x2\xD3\xD4\aG\x2\x2\xD4>\x3\x2\x2\x2\xD5\xD6\a"+
		"K\x2\x2\xD6\xD7\aP\x2\x2\xD7\xD8\aV\x2\x2\xD8@\x3\x2\x2\x2\xD9\xDA\aH"+
		"\x2\x2\xDA\xDB\aN\x2\x2\xDB\xDC\aQ\x2\x2\xDC\xDD\a\x43\x2\x2\xDD\xDE\a"+
		"V\x2\x2\xDE\x42\x3\x2\x2\x2\xDF\xE0\a\x45\x2\x2\xE0\xE1\aJ\x2\x2\xE1\xE2"+
		"\a\x43\x2\x2\xE2\xE3\aT\x2\x2\xE3\x44\x3\x2\x2\x2\xE4\xE5\a\x44\x2\x2"+
		"\xE5\xE6\aQ\x2\x2\xE6\xE7\aQ\x2\x2\xE7\xE8\aN\x2\x2\xE8\x46\x3\x2\x2\x2"+
		"\xE9\xEB\t\x2\x2\x2\xEA\xE9\x3\x2\x2\x2\xEB\xEC\x3\x2\x2\x2\xEC\xEA\x3"+
		"\x2\x2\x2\xEC\xED\x3\x2\x2\x2\xEDH\x3\x2\x2\x2\xEE\xF0\t\x2\x2\x2\xEF"+
		"\xEE\x3\x2\x2\x2\xF0\xF1\x3\x2\x2\x2\xF1\xEF\x3\x2\x2\x2\xF1\xF2\x3\x2"+
		"\x2\x2\xF2\xF3\x3\x2\x2\x2\xF3\xF5\a\x30\x2\x2\xF4\xF6\t\x2\x2\x2\xF5"+
		"\xF4\x3\x2\x2\x2\xF6\xF7\x3\x2\x2\x2\xF7\xF5\x3\x2\x2\x2\xF7\xF8\x3\x2"+
		"\x2\x2\xF8J\x3\x2\x2\x2\xF9\xFA\a$\x2\x2\xFA\xFB\aV\x2\x2\xFB\xFC\aT\x2"+
		"\x2\xFC\xFD\aW\x2\x2\xFD\xFE\aG\x2\x2\xFE\x107\a$\x2\x2\xFF\x100\a$\x2"+
		"\x2\x100\x101\aH\x2\x2\x101\x102\a\x43\x2\x2\x102\x103\aN\x2\x2\x103\x104"+
		"\aU\x2\x2\x104\x105\aG\x2\x2\x105\x107\a$\x2\x2\x106\xF9\x3\x2\x2\x2\x106"+
		"\xFF\x3\x2\x2\x2\x107L\x3\x2\x2\x2\x108\x109\a)\x2\x2\x109\x10A\n\x3\x2"+
		"\x2\x10A\x10B\a)\x2\x2\x10BN\x3\x2\x2\x2\x10C\x110\a$\x2\x2\x10D\x10F"+
		"\n\x4\x2\x2\x10E\x10D\x3\x2\x2\x2\x10F\x112\x3\x2\x2\x2\x110\x10E\x3\x2"+
		"\x2\x2\x110\x111\x3\x2\x2\x2\x111\x113\x3\x2\x2\x2\x112\x110\x3\x2\x2"+
		"\x2\x113\x11D\a$\x2\x2\x114\x118\a)\x2\x2\x115\x117\n\x5\x2\x2\x116\x115"+
		"\x3\x2\x2\x2\x117\x11A\x3\x2\x2\x2\x118\x116\x3\x2\x2\x2\x118\x119\x3"+
		"\x2\x2\x2\x119\x11B\x3\x2\x2\x2\x11A\x118\x3\x2\x2\x2\x11B\x11D\a)\x2"+
		"\x2\x11C\x10C\x3\x2\x2\x2\x11C\x114\x3\x2\x2\x2\x11DP\x3\x2\x2\x2\x11E"+
		"\x11F\a\x43\x2\x2\x11F\x120\aP\x2\x2\x120\x127\a\x46\x2\x2\x121\x122\a"+
		"Q\x2\x2\x122\x127\aT\x2\x2\x123\x124\aP\x2\x2\x124\x125\aQ\x2\x2\x125"+
		"\x127\aV\x2\x2\x126\x11E\x3\x2\x2\x2\x126\x121\x3\x2\x2\x2\x126\x123\x3"+
		"\x2\x2\x2\x127R\x3\x2\x2\x2\x128\x129\aU\x2\x2\x129\x12A\a\x45\x2\x2\x12A"+
		"\x12B\a\x43\x2\x2\x12B\x12C\aP\x2\x2\x12C\x12D\a<\x2\x2\x12DT\x3\x2\x2"+
		"\x2\x12E\x132\t\x6\x2\x2\x12F\x131\t\a\x2\x2\x130\x12F\x3\x2\x2\x2\x131"+
		"\x134\x3\x2\x2\x2\x132\x130\x3\x2\x2\x2\x132\x133\x3\x2\x2\x2\x133V\x3"+
		"\x2\x2\x2\x134\x132\x3\x2\x2\x2\x135\x139\a%\x2\x2\x136\x138\n\b\x2\x2"+
		"\x137\x136\x3\x2\x2\x2\x138\x13B\x3\x2\x2\x2\x139\x137\x3\x2\x2\x2\x139"+
		"\x13A\x3\x2\x2\x2\x13A\x13C\x3\x2\x2\x2\x13B\x139\x3\x2\x2\x2\x13C\x13D"+
		"\b,\x2\x2\x13DX\x3\x2\x2\x2\x13E\x140\t\t\x2\x2\x13F\x13E\x3\x2\x2\x2"+
		"\x140\x143\x3\x2\x2\x2\x141\x13F\x3\x2\x2\x2\x141\x142\x3\x2\x2\x2\x142"+
		"\x145\x3\x2\x2\x2\x143\x141\x3\x2\x2\x2\x144\x146\t\n\x2\x2\x145\x144"+
		"\x3\x2\x2\x2\x145\x146\x3\x2\x2\x2\x146\x147\x3\x2\x2\x2\x147\x148\t\v"+
		"\x2\x2\x148Z\x3\x2\x2\x2\x149\x14B\t\f\x2\x2\x14A\x149\x3\x2\x2\x2\x14B"+
		"\x14C\x3\x2\x2\x2\x14C\x14A\x3\x2\x2\x2\x14C\x14D\x3\x2\x2\x2\x14D\x14E"+
		"\x3\x2\x2\x2\x14E\x14F\b.\x2\x2\x14F\\\x3\x2\x2\x2\x10\x2\xEC\xF1\xF7"+
		"\x106\x110\x118\x11C\x126\x132\x139\x141\x145\x14C\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Group4_Interpreter