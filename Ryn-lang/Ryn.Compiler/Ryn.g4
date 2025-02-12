grammar Ryn;

// === LEXER RULES ===

// Keywords
CLASS   : 'class';
FN      : 'fn';
LET     : 'let';
IF      : 'if';
ELSE    : 'else';
FOR     : 'for';
PRINT   : 'Print';

// Operators & Symbols
PUBLIC  : 'pub';
PRIVATE : 'priv';
PROTECTED : 'prot';

ASSIGN  : '=';
PLUS    : '+';
MINUS   : '-';
MULT    : '*';
DIV     : '/';

LT      : '<';
GT      : '>';
EQ      : '==';

LBRACE  : '{';
RBRACE  : '}';
LPAREN  : '(';
RPAREN  : ')';
SEMI    : ';';

// Identifiers & Literals
ID      : [a-zA-Z_][a-zA-Z0-9_]*;
NUMBER  : [0-9]+;
STRING  : '"' .*? '"';

// Ignore Whitespace & Comments
WS      : [ \t\r\n]+ -> skip;
COMMENT : '//' .*? '\n' -> skip;

// === PARSER RULES ===

// Entry point
program : classDecl* EOF;

classDecl : accessModifier CLASS ID LBRACE methodDecl* RBRACE;
methodDecl : accessModifier FN ID LPAREN RPAREN LBRACE statement* RBRACE;

statement
    : varDecl
    | printStmt
    | ifStmt
    | forStmt
    | exprStmt
    ;

varDecl : LET ID ASSIGN expr SEMI;
printStmt : PRINT LPAREN expr RPAREN SEMI;
ifStmt : IF LPAREN expr RPAREN LBRACE statement* RBRACE (ELSE LBRACE statement* RBRACE)?;
forStmt : FOR LPAREN varDecl exprStmt exprStmt RPAREN LBRACE statement* RBRACE;
exprStmt : expr SEMI;

expr
    : expr (PLUS | MINUS) expr   # BinaryExpr
    | expr (MULT | DIV) expr     # BinaryExpr
    | expr (LT | GT | EQ) expr   # ComparisonExpr
    | ID                         # IdentifierExpr
    | NUMBER                     # NumberExpr
    | STRING                     # StringExpr
    | LPAREN expr RPAREN         # ParenExpr
    ;
    
accessModifier : PUBLIC | PRIVATE | PROTECTED;
