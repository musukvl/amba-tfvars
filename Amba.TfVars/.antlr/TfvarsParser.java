// Generated from c:/system/dev/hcl-parser/amba-tfvar-parser/Amba.TfvarsParser/Amba.TfvarsParser/Tfvars.g4 by ANTLR 4.13.1
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast", "CheckReturnValue"})
public class TfvarsParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.13.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, VARIABLE=17, 
		IN=18, STAR=19, DOT=20, LCURL=21, RCURL=22, LPAREN=23, RPAREN=24, EOF_=25, 
		NULL_=26, NATURAL_NUMBER=27, BOOL=28, DESCRIPTION=29, MULTILINESTRING=30, 
		STRING=31, IDENTIFIER=32, COMMENT=33, BLOCKCOMMENT=34, WS=35;
	public static final int
		RULE_file_ = 0, RULE_argument = 1, RULE_identifier = 2, RULE_expression = 3, 
		RULE_section = 4, RULE_val = 5, RULE_index = 6, RULE_list_ = 7, RULE_map_ = 8, 
		RULE_string = 9, RULE_signed_number = 10, RULE_operator_ = 11, RULE_number = 12;
	private static String[] makeRuleNames() {
		return new String[] {
			"file_", "argument", "identifier", "expression", "section", "val", "index", 
			"list_", "map_", "string", "signed_number", "operator_", "number"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'='", "'['", "']'", "','", "'+'", "'-'", "'/'", "'%'", "'>'", 
			"'>='", "'<'", "'<='", "'=='", "'!='", "'&&'", "'||'", "'variable'", 
			"'in'", "'*'", "'.'", "'{'", "'}'", "'('", "')'", null, "'nul'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, "VARIABLE", "IN", "STAR", "DOT", "LCURL", 
			"RCURL", "LPAREN", "RPAREN", "EOF_", "NULL_", "NATURAL_NUMBER", "BOOL", 
			"DESCRIPTION", "MULTILINESTRING", "STRING", "IDENTIFIER", "COMMENT", 
			"BLOCKCOMMENT", "WS"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "Tfvars.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public TfvarsParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@SuppressWarnings("CheckReturnValue")
	public static class File_Context extends ParserRuleContext {
		public TerminalNode EOF() { return getToken(TfvarsParser.EOF, 0); }
		public List<ArgumentContext> argument() {
			return getRuleContexts(ArgumentContext.class);
		}
		public ArgumentContext argument(int i) {
			return getRuleContext(ArgumentContext.class,i);
		}
		public File_Context(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_file_; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).enterFile_(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).exitFile_(this);
		}
	}

	public final File_Context file_() throws RecognitionException {
		File_Context _localctx = new File_Context(_ctx, getState());
		enterRule(_localctx, 0, RULE_file_);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(27); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(26);
				argument();
				}
				}
				setState(29); 
				_errHandler.sync(this);
				_la = _input.LA(1);
			} while ( _la==IDENTIFIER );
			setState(31);
			match(EOF);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ArgumentContext extends ParserRuleContext {
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public ArgumentContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_argument; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).enterArgument(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).exitArgument(this);
		}
	}

	public final ArgumentContext argument() throws RecognitionException {
		ArgumentContext _localctx = new ArgumentContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_argument);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(33);
			identifier();
			setState(34);
			match(T__0);
			setState(35);
			expression(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class IdentifierContext extends ParserRuleContext {
		public TerminalNode IDENTIFIER() { return getToken(TfvarsParser.IDENTIFIER, 0); }
		public IdentifierContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_identifier; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).enterIdentifier(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).exitIdentifier(this);
		}
	}

	public final IdentifierContext identifier() throws RecognitionException {
		IdentifierContext _localctx = new IdentifierContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_identifier);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(37);
			match(IDENTIFIER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ExpressionContext extends ParserRuleContext {
		public SectionContext section() {
			return getRuleContext(SectionContext.class,0);
		}
		public TerminalNode LPAREN() { return getToken(TfvarsParser.LPAREN, 0); }
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public TerminalNode RPAREN() { return getToken(TfvarsParser.RPAREN, 0); }
		public Operator_Context operator_() {
			return getRuleContext(Operator_Context.class,0);
		}
		public ExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_expression; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).enterExpression(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).exitExpression(this);
		}
	}

	public final ExpressionContext expression() throws RecognitionException {
		return expression(0);
	}

	private ExpressionContext expression(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		ExpressionContext _localctx = new ExpressionContext(_ctx, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 6;
		enterRecursionRule(_localctx, 6, RULE_expression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(45);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__1:
			case T__4:
			case T__5:
			case LCURL:
			case EOF_:
			case NULL_:
			case NATURAL_NUMBER:
			case BOOL:
			case DESCRIPTION:
			case MULTILINESTRING:
			case STRING:
			case IDENTIFIER:
				{
				setState(40);
				section();
				}
				break;
			case LPAREN:
				{
				setState(41);
				match(LPAREN);
				setState(42);
				expression(0);
				setState(43);
				match(RPAREN);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			_ctx.stop = _input.LT(-1);
			setState(53);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,2,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new ExpressionContext(_parentctx, _parentState);
					pushNewRecursionContext(_localctx, _startState, RULE_expression);
					setState(47);
					if (!(precpred(_ctx, 2))) throw new FailedPredicateException(this, "precpred(_ctx, 2)");
					setState(48);
					operator_();
					setState(49);
					expression(3);
					}
					} 
				}
				setState(55);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,2,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class SectionContext extends ParserRuleContext {
		public List_Context list_() {
			return getRuleContext(List_Context.class,0);
		}
		public Map_Context map_() {
			return getRuleContext(Map_Context.class,0);
		}
		public ValContext val() {
			return getRuleContext(ValContext.class,0);
		}
		public SectionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_section; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).enterSection(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).exitSection(this);
		}
	}

	public final SectionContext section() throws RecognitionException {
		SectionContext _localctx = new SectionContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_section);
		try {
			setState(59);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__1:
				enterOuterAlt(_localctx, 1);
				{
				setState(56);
				list_();
				}
				break;
			case LCURL:
				enterOuterAlt(_localctx, 2);
				{
				setState(57);
				map_();
				}
				break;
			case T__4:
			case T__5:
			case EOF_:
			case NULL_:
			case NATURAL_NUMBER:
			case BOOL:
			case DESCRIPTION:
			case MULTILINESTRING:
			case STRING:
			case IDENTIFIER:
				enterOuterAlt(_localctx, 3);
				{
				setState(58);
				val();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ValContext extends ParserRuleContext {
		public TerminalNode NULL_() { return getToken(TfvarsParser.NULL_, 0); }
		public Signed_numberContext signed_number() {
			return getRuleContext(Signed_numberContext.class,0);
		}
		public StringContext string() {
			return getRuleContext(StringContext.class,0);
		}
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public TerminalNode BOOL() { return getToken(TfvarsParser.BOOL, 0); }
		public TerminalNode DESCRIPTION() { return getToken(TfvarsParser.DESCRIPTION, 0); }
		public TerminalNode EOF_() { return getToken(TfvarsParser.EOF_, 0); }
		public ValContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_val; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).enterVal(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).exitVal(this);
		}
	}

	public final ValContext val() throws RecognitionException {
		ValContext _localctx = new ValContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_val);
		try {
			setState(68);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case NULL_:
				enterOuterAlt(_localctx, 1);
				{
				setState(61);
				match(NULL_);
				}
				break;
			case T__4:
			case T__5:
			case NATURAL_NUMBER:
				enterOuterAlt(_localctx, 2);
				{
				setState(62);
				signed_number();
				}
				break;
			case MULTILINESTRING:
			case STRING:
				enterOuterAlt(_localctx, 3);
				{
				setState(63);
				string();
				}
				break;
			case IDENTIFIER:
				enterOuterAlt(_localctx, 4);
				{
				setState(64);
				identifier();
				}
				break;
			case BOOL:
				enterOuterAlt(_localctx, 5);
				{
				setState(65);
				match(BOOL);
				}
				break;
			case DESCRIPTION:
				enterOuterAlt(_localctx, 6);
				{
				setState(66);
				match(DESCRIPTION);
				}
				break;
			case EOF_:
				enterOuterAlt(_localctx, 7);
				{
				setState(67);
				match(EOF_);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class IndexContext extends ParserRuleContext {
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public IndexContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_index; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).enterIndex(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).exitIndex(this);
		}
	}

	public final IndexContext index() throws RecognitionException {
		IndexContext _localctx = new IndexContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_index);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(70);
			match(T__1);
			setState(71);
			expression(0);
			setState(72);
			match(T__2);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class List_Context extends ParserRuleContext {
		public List<ExpressionContext> expression() {
			return getRuleContexts(ExpressionContext.class);
		}
		public ExpressionContext expression(int i) {
			return getRuleContext(ExpressionContext.class,i);
		}
		public List_Context(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_list_; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).enterList_(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).exitList_(this);
		}
	}

	public final List_Context list_() throws RecognitionException {
		List_Context _localctx = new List_Context(_ctx, getState());
		enterRule(_localctx, 14, RULE_list_);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(74);
			match(T__1);
			setState(86);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & 8566866020L) != 0)) {
				{
				setState(75);
				expression(0);
				setState(80);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,5,_ctx);
				while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						setState(76);
						match(T__3);
						setState(77);
						expression(0);
						}
						} 
					}
					setState(82);
					_errHandler.sync(this);
					_alt = getInterpreter().adaptivePredict(_input,5,_ctx);
				}
				setState(84);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==T__3) {
					{
					setState(83);
					match(T__3);
					}
				}

				}
			}

			setState(88);
			match(T__2);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class Map_Context extends ParserRuleContext {
		public TerminalNode LCURL() { return getToken(TfvarsParser.LCURL, 0); }
		public TerminalNode RCURL() { return getToken(TfvarsParser.RCURL, 0); }
		public List<ArgumentContext> argument() {
			return getRuleContexts(ArgumentContext.class);
		}
		public ArgumentContext argument(int i) {
			return getRuleContext(ArgumentContext.class,i);
		}
		public Map_Context(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_map_; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).enterMap_(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).exitMap_(this);
		}
	}

	public final Map_Context map_() throws RecognitionException {
		Map_Context _localctx = new Map_Context(_ctx, getState());
		enterRule(_localctx, 16, RULE_map_);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(90);
			match(LCURL);
			setState(97);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==IDENTIFIER) {
				{
				{
				setState(91);
				argument();
				setState(93);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==T__3) {
					{
					setState(92);
					match(T__3);
					}
				}

				}
				}
				setState(99);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(100);
			match(RCURL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class StringContext extends ParserRuleContext {
		public TerminalNode STRING() { return getToken(TfvarsParser.STRING, 0); }
		public TerminalNode MULTILINESTRING() { return getToken(TfvarsParser.MULTILINESTRING, 0); }
		public StringContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_string; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).enterString(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).exitString(this);
		}
	}

	public final StringContext string() throws RecognitionException {
		StringContext _localctx = new StringContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_string);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(102);
			_la = _input.LA(1);
			if ( !(_la==MULTILINESTRING || _la==STRING) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class Signed_numberContext extends ParserRuleContext {
		public NumberContext number() {
			return getRuleContext(NumberContext.class,0);
		}
		public Signed_numberContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_signed_number; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).enterSigned_number(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).exitSigned_number(this);
		}
	}

	public final Signed_numberContext signed_number() throws RecognitionException {
		Signed_numberContext _localctx = new Signed_numberContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_signed_number);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(105);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__4 || _la==T__5) {
				{
				setState(104);
				_la = _input.LA(1);
				if ( !(_la==T__4 || _la==T__5) ) {
				_errHandler.recoverInline(this);
				}
				else {
					if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
					_errHandler.reportMatch(this);
					consume();
				}
				}
			}

			setState(107);
			number();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class Operator_Context extends ParserRuleContext {
		public TerminalNode STAR() { return getToken(TfvarsParser.STAR, 0); }
		public Operator_Context(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_operator_; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).enterOperator_(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).exitOperator_(this);
		}
	}

	public final Operator_Context operator_() throws RecognitionException {
		Operator_Context _localctx = new Operator_Context(_ctx, getState());
		enterRule(_localctx, 22, RULE_operator_);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(109);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 655328L) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class NumberContext extends ParserRuleContext {
		public List<TerminalNode> NATURAL_NUMBER() { return getTokens(TfvarsParser.NATURAL_NUMBER); }
		public TerminalNode NATURAL_NUMBER(int i) {
			return getToken(TfvarsParser.NATURAL_NUMBER, i);
		}
		public TerminalNode DOT() { return getToken(TfvarsParser.DOT, 0); }
		public NumberContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_number; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).enterNumber(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof TfvarsListener ) ((TfvarsListener)listener).exitNumber(this);
		}
	}

	public final NumberContext number() throws RecognitionException {
		NumberContext _localctx = new NumberContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_number);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(111);
			match(NATURAL_NUMBER);
			setState(114);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,11,_ctx) ) {
			case 1:
				{
				setState(112);
				match(DOT);
				setState(113);
				match(NATURAL_NUMBER);
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public boolean sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 3:
			return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private boolean expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0:
			return precpred(_ctx, 2);
		}
		return true;
	}

	public static final String _serializedATN =
		"\u0004\u0001#u\u0002\u0000\u0007\u0000\u0002\u0001\u0007\u0001\u0002\u0002"+
		"\u0007\u0002\u0002\u0003\u0007\u0003\u0002\u0004\u0007\u0004\u0002\u0005"+
		"\u0007\u0005\u0002\u0006\u0007\u0006\u0002\u0007\u0007\u0007\u0002\b\u0007"+
		"\b\u0002\t\u0007\t\u0002\n\u0007\n\u0002\u000b\u0007\u000b\u0002\f\u0007"+
		"\f\u0001\u0000\u0004\u0000\u001c\b\u0000\u000b\u0000\f\u0000\u001d\u0001"+
		"\u0000\u0001\u0000\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001"+
		"\u0002\u0001\u0002\u0001\u0003\u0001\u0003\u0001\u0003\u0001\u0003\u0001"+
		"\u0003\u0001\u0003\u0003\u0003.\b\u0003\u0001\u0003\u0001\u0003\u0001"+
		"\u0003\u0001\u0003\u0005\u00034\b\u0003\n\u0003\f\u00037\t\u0003\u0001"+
		"\u0004\u0001\u0004\u0001\u0004\u0003\u0004<\b\u0004\u0001\u0005\u0001"+
		"\u0005\u0001\u0005\u0001\u0005\u0001\u0005\u0001\u0005\u0001\u0005\u0003"+
		"\u0005E\b\u0005\u0001\u0006\u0001\u0006\u0001\u0006\u0001\u0006\u0001"+
		"\u0007\u0001\u0007\u0001\u0007\u0001\u0007\u0005\u0007O\b\u0007\n\u0007"+
		"\f\u0007R\t\u0007\u0001\u0007\u0003\u0007U\b\u0007\u0003\u0007W\b\u0007"+
		"\u0001\u0007\u0001\u0007\u0001\b\u0001\b\u0001\b\u0003\b^\b\b\u0005\b"+
		"`\b\b\n\b\f\bc\t\b\u0001\b\u0001\b\u0001\t\u0001\t\u0001\n\u0003\nj\b"+
		"\n\u0001\n\u0001\n\u0001\u000b\u0001\u000b\u0001\f\u0001\f\u0001\f\u0003"+
		"\fs\b\f\u0001\f\u0000\u0001\u0006\r\u0000\u0002\u0004\u0006\b\n\f\u000e"+
		"\u0010\u0012\u0014\u0016\u0018\u0000\u0003\u0001\u0000\u001e\u001f\u0001"+
		"\u0000\u0005\u0006\u0002\u0000\u0005\u0010\u0013\u0013y\u0000\u001b\u0001"+
		"\u0000\u0000\u0000\u0002!\u0001\u0000\u0000\u0000\u0004%\u0001\u0000\u0000"+
		"\u0000\u0006-\u0001\u0000\u0000\u0000\b;\u0001\u0000\u0000\u0000\nD\u0001"+
		"\u0000\u0000\u0000\fF\u0001\u0000\u0000\u0000\u000eJ\u0001\u0000\u0000"+
		"\u0000\u0010Z\u0001\u0000\u0000\u0000\u0012f\u0001\u0000\u0000\u0000\u0014"+
		"i\u0001\u0000\u0000\u0000\u0016m\u0001\u0000\u0000\u0000\u0018o\u0001"+
		"\u0000\u0000\u0000\u001a\u001c\u0003\u0002\u0001\u0000\u001b\u001a\u0001"+
		"\u0000\u0000\u0000\u001c\u001d\u0001\u0000\u0000\u0000\u001d\u001b\u0001"+
		"\u0000\u0000\u0000\u001d\u001e\u0001\u0000\u0000\u0000\u001e\u001f\u0001"+
		"\u0000\u0000\u0000\u001f \u0005\u0000\u0000\u0001 \u0001\u0001\u0000\u0000"+
		"\u0000!\"\u0003\u0004\u0002\u0000\"#\u0005\u0001\u0000\u0000#$\u0003\u0006"+
		"\u0003\u0000$\u0003\u0001\u0000\u0000\u0000%&\u0005 \u0000\u0000&\u0005"+
		"\u0001\u0000\u0000\u0000\'(\u0006\u0003\uffff\uffff\u0000(.\u0003\b\u0004"+
		"\u0000)*\u0005\u0017\u0000\u0000*+\u0003\u0006\u0003\u0000+,\u0005\u0018"+
		"\u0000\u0000,.\u0001\u0000\u0000\u0000-\'\u0001\u0000\u0000\u0000-)\u0001"+
		"\u0000\u0000\u0000.5\u0001\u0000\u0000\u0000/0\n\u0002\u0000\u000001\u0003"+
		"\u0016\u000b\u000012\u0003\u0006\u0003\u000324\u0001\u0000\u0000\u0000"+
		"3/\u0001\u0000\u0000\u000047\u0001\u0000\u0000\u000053\u0001\u0000\u0000"+
		"\u000056\u0001\u0000\u0000\u00006\u0007\u0001\u0000\u0000\u000075\u0001"+
		"\u0000\u0000\u00008<\u0003\u000e\u0007\u00009<\u0003\u0010\b\u0000:<\u0003"+
		"\n\u0005\u0000;8\u0001\u0000\u0000\u0000;9\u0001\u0000\u0000\u0000;:\u0001"+
		"\u0000\u0000\u0000<\t\u0001\u0000\u0000\u0000=E\u0005\u001a\u0000\u0000"+
		">E\u0003\u0014\n\u0000?E\u0003\u0012\t\u0000@E\u0003\u0004\u0002\u0000"+
		"AE\u0005\u001c\u0000\u0000BE\u0005\u001d\u0000\u0000CE\u0005\u0019\u0000"+
		"\u0000D=\u0001\u0000\u0000\u0000D>\u0001\u0000\u0000\u0000D?\u0001\u0000"+
		"\u0000\u0000D@\u0001\u0000\u0000\u0000DA\u0001\u0000\u0000\u0000DB\u0001"+
		"\u0000\u0000\u0000DC\u0001\u0000\u0000\u0000E\u000b\u0001\u0000\u0000"+
		"\u0000FG\u0005\u0002\u0000\u0000GH\u0003\u0006\u0003\u0000HI\u0005\u0003"+
		"\u0000\u0000I\r\u0001\u0000\u0000\u0000JV\u0005\u0002\u0000\u0000KP\u0003"+
		"\u0006\u0003\u0000LM\u0005\u0004\u0000\u0000MO\u0003\u0006\u0003\u0000"+
		"NL\u0001\u0000\u0000\u0000OR\u0001\u0000\u0000\u0000PN\u0001\u0000\u0000"+
		"\u0000PQ\u0001\u0000\u0000\u0000QT\u0001\u0000\u0000\u0000RP\u0001\u0000"+
		"\u0000\u0000SU\u0005\u0004\u0000\u0000TS\u0001\u0000\u0000\u0000TU\u0001"+
		"\u0000\u0000\u0000UW\u0001\u0000\u0000\u0000VK\u0001\u0000\u0000\u0000"+
		"VW\u0001\u0000\u0000\u0000WX\u0001\u0000\u0000\u0000XY\u0005\u0003\u0000"+
		"\u0000Y\u000f\u0001\u0000\u0000\u0000Za\u0005\u0015\u0000\u0000[]\u0003"+
		"\u0002\u0001\u0000\\^\u0005\u0004\u0000\u0000]\\\u0001\u0000\u0000\u0000"+
		"]^\u0001\u0000\u0000\u0000^`\u0001\u0000\u0000\u0000_[\u0001\u0000\u0000"+
		"\u0000`c\u0001\u0000\u0000\u0000a_\u0001\u0000\u0000\u0000ab\u0001\u0000"+
		"\u0000\u0000bd\u0001\u0000\u0000\u0000ca\u0001\u0000\u0000\u0000de\u0005"+
		"\u0016\u0000\u0000e\u0011\u0001\u0000\u0000\u0000fg\u0007\u0000\u0000"+
		"\u0000g\u0013\u0001\u0000\u0000\u0000hj\u0007\u0001\u0000\u0000ih\u0001"+
		"\u0000\u0000\u0000ij\u0001\u0000\u0000\u0000jk\u0001\u0000\u0000\u0000"+
		"kl\u0003\u0018\f\u0000l\u0015\u0001\u0000\u0000\u0000mn\u0007\u0002\u0000"+
		"\u0000n\u0017\u0001\u0000\u0000\u0000or\u0005\u001b\u0000\u0000pq\u0005"+
		"\u0014\u0000\u0000qs\u0005\u001b\u0000\u0000rp\u0001\u0000\u0000\u0000"+
		"rs\u0001\u0000\u0000\u0000s\u0019\u0001\u0000\u0000\u0000\f\u001d-5;D"+
		"PTV]air";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}