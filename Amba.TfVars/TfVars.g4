// based on https://github.com/antlr/grammars-v4/blob/master/terraform/terraform.g4
  
grammar TfVars;
 
file_: (variable_definition)+ EOF;

variable_definition
    : identifier '=' expression
    ;
    
identifier
    : IDENTIFIER
    ;  

expression
    : section
    | LPAREN expression RPAREN 
    ;

section
    : list_
    | map_
    | val
    ;

val
    : NULL_
    | signed_number
    | string
    | boolean
    | DESCRIPTION
    | EOF_
    ;

index
    : '[' expression ']'
    ;

list_
    : '[' (expression (',' expression)* ','?)? ']'
    ;

map_
    : LCURL (map_pair ','?)* RCURL
    ;
    
map_pair 
    :  map_key '=' expression
    ;

map_key
    : IDENTIFIER | STRING
    ;


string
    : STRING
    | MULTILINESTRING
    ;

fragment DIGIT
    : [0-9]
    ;

signed_number
    : ('+' | '-')? number
    ;
 
LCURL
    : '{'
    ;

RCURL
    : '}'
    ;

LPAREN
    : '('
    ;

RPAREN
    : ')'
    ;

EOF_
    : '<<EOF' .*? 'EOF'
    ;

NULL_
    : 'null'
    ;

NATURAL_NUMBER
    : DIGIT+
    ;

number
    : NATURAL_NUMBER (DOT NATURAL_NUMBER)?
    ;

boolean
    : 'true'
    | 'false'
    ;
 

DESCRIPTION
    : '<<DESCRIPTION' .*? 'DESCRIPTION'
    ; 

MULTILINESTRING
    : '<<-EOF' .*? 'EOF'
    ;


IDENTIFIER
    : [a-zA-Z] ([a-zA-Z0-9_-])*
    ;

STRING
    : '"' ('\\"' | ~["\r\n])* '"'
    ;

comment : LINECOMMENT | BLOCKCOMMENT;

LINECOMMENT
    : ('#' | '//') ~ [\r\n]* -> channel(HIDDEN)
    ;
  
BLOCKCOMMENT
    : '/*' .*? '*/' -> channel(HIDDEN)
    ;

WS
    : [ \r\n\t]+ -> skip
    ;  
    
DOT
    : '.'
    ;