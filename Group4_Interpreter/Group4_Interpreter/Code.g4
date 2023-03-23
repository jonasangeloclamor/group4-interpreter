grammar Code;

programStructure: BEGIN_CODE programLines* END_CODE  EOF ;

programLines: variableInitialization | programStatements | ifCondition | whileLoop;

programStatements: (assignmentOperator | methodCall) ';' ;

variableInitialization: programDataTypes IDENTIFIERS (',' IDENTIFIERS)* ('=' expression)? ;
assignmentOperator: IDENTIFIERS '=' expression ;

beginBlocks: (BEGIN_CODE | BEGIN_IF | BEGIN_WHILE);

BEGIN_CODE: 'BEGIN' 'CODE' ;
END_CODE: 'END' 'CODE' ;

BEGIN_IF: 'BEGIN' 'IF' ;
END_IF: 'END' 'IF' ;
ifCondition: 'IF' '('expression')' BEGIN_IF beginBlocks END_IF elseIfCondition? ;
elseIfCondition: 'ELSE' (BEGIN_IF beginBlocks END_IF) | ifCondition ;

WHILE: 'WHILE' ;
BEGIN_WHILE: 'BEGIN' 'WHILE' ;
END_WHILE: 'END' 'WHILE' ;
whileLoop: WHILE '(' expression ')' BEGIN_WHILE beginBlocks* END_WHILE ;

programDataTypes: INT | FLOAT | BOOL | CHAR ;
INT: 'INT' ;
FLOAT: 'FLOAT';
CHAR: 'CHAR';
BOOL: 'BOOL';

constantValues: INTEGER_VALUES | FLOAT_VALUES | CHARACTER_VALUES | BOOLEAN_VALUES | STRING_VALUES ;
INTEGER_VALUES: [0-9]+ ;
FLOAT_VALUES: [0-9]+ '.' [0-9]+ ;
CHARACTER_VALUES: '\"TRUE\"' | '\"FALSE\"' ;
BOOLEAN_VALUES: '\'' ~[\r\n\'] '\'' ; 
STRING_VALUES: ('"' ~'"'* '"') | ('\'' ~'\''* '\'') ;

expression
    : constantValues                          
    | IDENTIFIERS                        
    | methodCall                      
    | '(' expression ')'                
    | 'NOT' expression                  
    | expression multDivModOperators expression      
    | expression addSubConcatenatorOperators expression       
    | expression comparisonOperators expression   
    | expression logicalOperators expression     
    | openParenthesis expression closeParenthesis  
    ; 

multDivModOperators: '*' | '/' | '%' ;
addSubConcatenatorOperators: '+' | '-' | '&' ;
comparisonOperators: '==' | '<>' | '>' | '<' | '>=' | '<='  ;
logicalOperators: LOGICAL_OPERATORS ;
openParenthesis: '[' ;
closeParenthesis: ']' ;

LOGICAL_OPERATORS: 'AND' | 'OR' | 'NOT' ;

// for DISPLAY: and SCAN:
methodCall: IDENTIFIERS ':' (expression (',' expression)*)? ;

// Not working
SCAN: 'SCAN:';
scanFunction: SCAN IDENTIFIERS (',' IDENTIFIER)* ;

IDENTIFIERS: [a-zA-Z_][a-zA-Z0-9_]* ;
COMMENTS: '#' ~[\r\n]* -> skip ;
BLANK_LINES: [ \t]* [\r]? [\n] ; 
WHITESPACES: [ \t\r]+ -> skip ;