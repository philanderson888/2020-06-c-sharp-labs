# Quality Gates 1 And 2 and Sales Gate

- [Quality Gates 1 And 2 and Sales Gate](#quality-gates-1-and-2-and-sales-gate)
	- [Preparation For The Interview - Soft Skills](#preparation-for-the-interview---soft-skills)
		- [Bring in!](#bring-in)
	- [General Questions - Soft Skills](#general-questions---soft-skills)
- [Technical Interview Prep](#technical-interview-prep)
		- [C# Online Tech Test](#c-online-tech-test)
	- [Basic Coding](#basic-coding)
	- [Loops](#loops)
	- [C# Tech Questions (Move Into Codingame)](#c-tech-questions-move-into-codingame)
	- [ProProfs Tech Interview Quiz](#proprofs-tech-interview-quiz)
	- [Technical Questions](#technical-questions)
	- [Overview Of Basic Learning For Interviews](#overview-of-basic-learning-for-interviews)
		- [Random Term Review](#random-term-review)
	- [Lesson 1 Quiz](#lesson-1-quiz)
	- [Agile](#agile)
	- [Testing](#testing)

## Preparation For The Interview - Soft Skills

Composure - be relaxed but confident

Engaging - be sure to engage positively the interviewers.  If possible 'meet them' earlier on LinkedIn so you have an idea of what to expect of who the people are before you meet them.

Be sure to make eye contact when you first meet them, shake hands positively and try to relate to them as a human being rather than just someone who is interviewing you.

### Bring in!

Use a glass of water to calm your nerves!

Bring in a pad of paper to write down anything you don't understand.

## General Questions - Soft Skills

```
Tell us about yourself
Why did you join Sparta?
Why did you choose tech?
How do you see yourself in group?
Talk about successes / problems & give example
What do other people say about you?

Tell me a little bit about yourself
What degree do you have and why did you choose it?
In a team setting what part do you play?  How do you see yourself?
Do you have any work experience?  What have you done in the area of paid work?
Before Sparta talk about 2 challenges that you have overcome
What have been your biggest challenges here at Sparta?

Perhaps brush up on all these questions via a video on your phone.  
I know it sounds and feels silly but it can perhaps just get you over 
those hurdles of explaining yourself.
```

# Technical Interview Prep

### C# Online Tech Test

We are using CodinGame now but here is older test useful for prep practice.

40 questions C#  https://www.proprofs.com/quiz-school/story.php?title=software-fundamentals-1

## Basic Coding

Expect the technical interview to be tough so check out all the following structures and know that you know them : Strings, Char, Byte, Boolean, Array, List, Strack, Queue, Struct, Enum, OOP, Class, Method, Fields, Properties, Constructor, Instance, Static, Abstract, Polymorphism, virtual, override, abstract and override, Interface - just be aware of, not in detail.

## Loops

Loops - be prepared to do one on the wall.  If they asked you to do 'Fizz-Buzz' on the wall would you manage?  Try it in code and then on your wall.#

Remember there are four loops : for, do, do.while and foreach over an array..  For loop is over fixed number.  While and do.while are over a condition eg loop while records exist to be read from a database.

## C# Tech Questions (Move Into Codingame)

What is an assembly?

Which are the two main assembly types in .NET?

	.exe
	.dll


What does dotnet console create?

```
Creates a .NET Core console application

Outputs data to the console
```

What does dotnet run do?

Why do we test applications?

- Detecting faults in code earlier in the development life cycle
- Code can be proven to be more reliable by running tests on it
- Code is easier to maintain because after alterations are made we can re-run tests to prove it still passes, even after changes have been made
- We can build more and more detailed complex tests over time, which test more and more functionality
- We can automate and run many tests with a single test run

Is it possible to eliminate all defects during testing?

What are the three main test libraries used in Visual Studio?

What is Unit Testing?

What is TDD?

What is BDD?

What does Red Green Refactor refer to ?

What is the difference between Console.Write() and Console.WriteLine()?

Which two code structures can we use to encapsulate a database connection so it’s cleanly terminated?

```
Try..Catch..Finally

Using

While

Do..While
```

Databases

What does FluentAPI do?

```
Provides a structure to declare database constraints
```

What does serialization do

What is parsing?

```
Extracting relevant data
```

What is the purpose of streaming?

Where would we use Newtonsoft?

```
To serialize JSON
```

How do we push an existing exception from a child level up to the parent level?

```
throw;                        YES

throw new Exception()

throw ex;

catch(ex){}
```

What is an abstract class?

What is a sealed class?

Can an abstract class have real methods?

What is a concrete class?

What does it mean to instantiate an object?

What is a constructor?

Which are the 4 pillars of OOP?

```
Polymorphism
Encapsulation
Inheritance
Abstraction
```

Which are the 4 access modifiers?

```
Public
Private
Protected
Internal
```

A class can contain

```
Fields
Properties
Events
Methods
```

A struct is a

```
value type

```

An action delegate has how many return types

```
0
1
2
3
```

An action delegate accepts how many parameters

```
0
1
2
3
```

Lambdas are a shorthand way of writing

```
Named Methods

Anonymous Methods

Recursive Loops

Decision Statements
```

```csharp
Agile : basics
Waterfall : all-in-one
Agile: DELIVER VALUE FOR MONEY (WORKING CODE) IN INCREMENTS (SPRINT)
Sprint : dev team + product owner (talk to customer) + scrum master (runs 'scrum/sprints' : enabler : servant leader)
backlog = list of features which we are going to build
user stories : 'humanise' tech features which we're going to build 'Joe clicks on 'users' , 'new' , enter new user and submit
sprint backlog = mini-list of features just for this sprint

SQL : basics

C# : all core features  : data types, if.. , switch, loops (for, foreach, while, do.while)

While vs Do..While()
Collection
Faster - Array or collection?
x++;
break;
continue;

OOP meaning
4 pillars of OOP
class
method
overload
override
virtual
abstract class
abstract method
sealed class : has no child classes (useful for security)
static keyword : attached to class
collection
array (fixed) vs collection(resize)
list 
queue : enqueue dequeue
stack : push pop 
stack memory (fast) 
Note : Stack<int> is a place to store integers
	 : Stack memory is a fast place in our computer where we store running programs
heap memory (larger)
value type : int char bool
reference type : string array list  
char[] array is same as string
```

```csharp
What is a method return type?
What is a method parameter?
What is Pascal Case?
What is Camel Case
What is Snake Case?
What is Kebab Case?
What is an 'out' parameter
What does 'passing by reference' mean?
What is a reference type?
What is a value type
What is the Heap?
What is the Stack?

OOP
What is a constructor?
When do we use the 'new' keyword?
What is instantiation?
What is an instance?
Can we instantiate an abstract class?
Can we instantiate a sealed class?
What is NUNIT?
What is Entity Framework?
What is CRUD?
What does Try..Catch..Finally.. do?
What is a coding error?
What is an Exception?
Give some examples of exceptions

Can you create a github repo?  Write down about 10 things that you would do in order to create a master branch, then a dev branch, then push to the dev branch, then create a pull request to pull the dev branch into the master branch

How would  you view all your commits on a local system?

What does git reset do?  hard? soft?

What is HTTPS SSL?
What is SSH?

What does SQL distinct do?
what does SQL LIKE search for?
What would SQL LIKE %a% find?   a%  ?         %a    ?

SQL - know the basics.

Entity - just be aware of the basics, 
what Entity is 
   (allows you to talk to a database easily, 
    it's a Framework) and that it provides scaffolding 
     ie builds your pages for you.  
     Entity from Database builds code from tables.  
     Entity from Code builds the tables from code.

```

## ProProfs Tech Interview Quiz

This has a mix of interview and basic C#, OOP, Agile and SQL questions to help you prepare for an interview.

[https://www.proprofs.com/survey/t/?title=interview-thoughts-and-prep-c-agile-sql-oop-covered](https://www.proprofs.com/survey/t/?title=interview-thoughts-and-prep-c-agile-sql-oop-covered)

## Technical Questions

What is a method return type?

What is a method parameter?

What is Pascal Case?

What is Camel Case?

What is Snake Case?

What is Kebab Case?

What is an 'out' parameter?

What does 'passing by reference' mean?

What is a reference type?

What is a value type?

What is the Heap?

What is the Stack?

OOP

What is a constructor?

When do we use the 'new' keyword?

What is instantiation?

What is an instance?

Can we instantiate an abstract class?

Can we instantiate a sealed class?

What is NUNIT?

What is Entity Framework?

What is CRUD?

What does Try..Catch..Finally.. do?

What is a coding error?

What is an Exception?

Give some examples of System Exception types

Can you create a github repo? Write down about 10 things that you would do in order to create a master branch, then a dev branch, then push to the dev branch, then create a pull request to pull the dev branch into the master branch

How would you view all your commits on a local system?

What does git reset do? hard? soft?

What does HTTPS SSL encryption do to our web pages?

What is SSH? How does it secure our web communications?

What does SQL distinct do?

What does SQL LIKE search for?
What would SQL "LIKE '%a%' " find?

What would SQL "LIKE 'a%' " find?

What would SQL "LIKE '%a' " find?

Things to add : HTML image, headings, paragraph, small table, ordered list, unordered list, See if you can add some CSS styling with colour on some of the items.  Finally can you add a Javascript 'alert' box just to get going on Javascript? 

Create a new ASP Web Application which has got the Home, About and Contact pages.  See if you can develop this site by adding HTML content to the page.  

## Overview Of Basic Learning For Interviews

IDE Integrated Development Environment

```
Visual Studio
VSCode (web)
Xamarin (MAC) - Android/IOS
```

.NET

```
Large (4GB) library of code built up over years on Windows.
	C:\\Windows\\System32\\.......dll
```

.NET core

```
stripped down, open source version
```

C# : Microsoft

```
Goal : memory-safe (can't write directly to RAM)
(stops direct access to RAM addresses)
```

Compiler ****

```
Human code  Program.cs  ==>   Program.bin/exe/dll
               read this              can't read 

Compiler : take human-readable code and create 'binary' file (exe/dll) which
	can be sent to CPU for running.  .NET also creates 'CIL' code which
	is called 'Common Intermediate Langague' but it's a kind of half-way-house 		between human readable and the final binary code

ILDASM  (VS command prompt)
```

Type

```
int, char,bool    (VALUE TYPES, PRIMITIVES)  FAST, STACK MEMORY

string, array, list  (REFERENCE TYPES)   LARGE, SLOWER, ON HEAP

custom eg MyClass
```

Class - blueprint for creating object (field, property, methods)

Instantiate : new object

Method : function

4 Pillars
Abstract : hide fields and show PROPERTIES
Encapsulation : hiding
Inheritance
Polymorphism : many types: parent method : override in child method

SQL
Primary key : main index eg CustomerID(int), unique, not null

```
Index : not primary key but still stored for fast retrieval

Foreign key : Primary key in one table, but it's referenced in another table

	Orders : OrderID     : primary key
		 CustomerID  : foreign key

Relational : tables

NoSQL : no tables just raw JSON objects
```

Agile

```
Done
	Agreed as group.  Create sprint and set sprint goals (backlog items)
			
		MAIN BACKLOG ==> SPRINT BACKLOG  (DEFINE 'DONE')

			Code : formatted correctly?
			Tests : run?
			Naming conventions?
			Peer code review
Acceptance Criteria

	Testing : how we define tests in such a way so can approve code

		% of code base which has been tested

	Business : User Acceptance : end user validate your code meets
			business requirements

Agile : iterative : working code end of sprint

	Sprint 0 
	Sprint plan/ review/retro
```



```js
var x = 100;    // global scope

var y = function (){

	var z = 200;  // function scope 

	for (var i=0;i<10;i++){
		let a = 500;
	}
}
```


```cs
Class Dog{
    string name;
}

Main(){
	var d = new Dog();
	d.name="Fido";
}
```

Control Flow

```cs
if, else if, switch

while(x<10)
do {}  while (x<10)
for ( 1 to 10)  
for (int i=0;i<10;i++)
foreach (every item in array/collection)
```

String = array of char[] = {'h','e','l','l','o'}

int 16/32/64 number of bits used short/int/long

decimal 128 bits perfect rounding with money

float 32 / double 64 var x = 2.0; default is DOUBLE 64 bit

Null string x = null;

```cs
CAN'T DO   int x = null;
     	        int? x = null;
```

1. C# Basics

2.1 IDE

```
What is an IDE
What is Visual Studio
Downloading Visual Studio
Introduction to .NET
What is C#
Understanding the compiler
“Hello World”
Basic debugging
```

2.2 variables, Types, Control Flows & Exceptions

```
Variables and variable types
Data Types
Strings
Integers
Floats
Doubles
Null
Etc.
Null reference exceptions
Casting
Care in casting floats and doubles
If statements
Nested If statements
Conditional (ternary) Operator
Switch statement
Iterating (Loops)
For
Foreach
While
Jumping
Break
Continue
Goto
Return
Throw **
Throw exceptions & raising errors
Handling exceptions
Try
Catch
Chaining Catch blocks
Throw
```


3. Objects, Classes & OOP

```
Creating a VS project
Understanding namespaces
What is a class
Instantiation
Instantiation & Objects
Class constructors (initialisation)
The difference between Value Types and Reference Types
Methods
Method Types
Void
Method overriding? TBD
Method overloading
Encapsulation
Access Modifier types
Abstraction
Inheritance
Polymorphism – ‘Many shapes’ or single interface to many types
Example walkthroughs
SOLID Principles
```


4. Collections

```
Arrays
Lists
Dictionaries
Stack

Loops
Conditional if..else..
Exception try..catch..finally
String manipulate

Random Terms

META : data about data

PHOTO : raw data
	TIME TAKEN : metadata about photo
	TAG FACE   : metadata
```

```cs
var function DoThis() {
// run some code here
}

var x = function(c){
// run some code here
}

var x = ()=>{
// run some code
}

var x = c =>{}

DoThis();
```


### Random Term Review


```
Threading : one MAIN THREAD (public static void Main(string[] args)) plus sub-threads to do extra work
Tasks : clean way for programmer to initiate background threads without worrying about the detail
(Javascript has : WebWorker)
Thread-aware code take advantage of multi-core CPUs
Single-threaded application
C# ==> get away from problems in C / C++ where you manage memory and raw processes directly
Container :
Collection :
List()
List<T> = has [0] index so yes, can reach in and get middle item
Generics uses general type <T>
Stack<T> NO - only top item
Queue<T> NO - add at end, remove from front
Dictionary<Tkey,Tvalue>
Array : Fixed-size (much faster)
Collection : variable-size
Templates
Namespace : Container for our code
namespace x { class myClass {} }
namespace y { class myClass {} }
x.myClass
y.myclass
Servers
Docker : mini-server SHARES CORE 'KERNEL' AND EXPOSES UNIQUE 'WORK AREA' to store and use code
Containers : unique workspaces
Serverless architecture
Classes : Inheritance
Parent ,
Child : Parent (one parent only)
Interface (use multiple interfaces)
Interface : fully blank : does force you to create a certain method
IEnumerable : GetEnumerator which allows to count eg over an array
IComparable : CompareTo() which allows us to compare 2 objects by eg size, weight, color
Encapsulation : hiding code or exposing code
Access Modifier
private : in this class only
public : any class
internal : in same 'workspace' = 'assembly' which is the unit of compiled code, EXE or DLL
protected : access in this class and any child 'derived' classes
EXE run code
DLL reference code (library)
BASE : Parent class
DERIVED : Child class
static
class Parent {
void DoThis(){ // do something } // INSTANCE METHOD
static void DoThat(){ }
}
Main() {
var p01 = new Parent(); // p01 is an INSTANCE
p01.DoThis(); // P01.DoThis()
Parent.DoThat();
}

Abstraction : both hide (irrelevant) but also reveal essential (properties with get;set;) to external code. Keeps code neat.
Encapsulation : hiding code
Inheritance : BASE = Parent class ===> DERIVED = Child = Sub class
Polymorphism : Parent method : override this in child method. Poly = many, Morph = type/form . Allows runtime method to be changed.
Sealed class has no ... child (derived) classes
Class can inherit from one class but can USE / IMPLEMENT MULTIPLE INTERFACES
Interface : FORCES CERTAIN BEHAVIOUR
IEnumerable : can 'count' eg over an array
IComparable : can 'compare' items to sort
Abstract class CONTAINS AT LEAST ONE ABSTRACT METHOD
abstract void DoThis(); PARENT CLASS
override void DoThis(){ // code }

Interface : blank (abstract) methods

Abstract class : blank (abstract) and regular methods

Class : methods	CONCRETE

data types
agile
scrum
sprint
sprint 0 : pre-planning, setup environment
done
scrum master : servant leader, clear impediments
product owner : liaise with client
sprint : 2-4 weeks
dev team : 3-9
waterfall : fixed structure : analyse, plan, design, build, test, live
agile : build code in iterations : start simple. Then add 1 unit of functionality at a time. Customer gets working code. Embrace flexibility.
kanban : limit of tasks in use : continuous flow of work
xp : extreme programming = pair programming
spiral = agile
TDD test driven : tests written in UNIT TESTS (HARD CODED)
BDD behaviour driven : tests written in PLAIN ENGLISH
v-model : waterfall + extensive testing (good for military)
Javascript : weakly typed
C# : strongly typed
SQL : Structured query language
LINQ : Microsoft C# query to database
Relational database : tables are RELATED
MYSQL free opensource
SQLITE free opensource small (phones)
UNIX (paid)
MAC : IS UNIX
APACHE : free website
LINUX : free unix-like
UBUNTU : most common linux download
RED HAT : linux for businesses
devops
NOSQL stores data as JSON
JSON { field1:"data1", field2: 999} javascript object notation
AJAX : get data without page refresh
CRUD : CREATE READ UPDATE DELETE
INSERT = CREATE
SELECT = READ
KALI : IT Security : hacking tools
primary key UNIQUE ID IN TABLE
foreign key LINKS 2 TABLES
SOLID : GOOD CODING : .. SINGLE RESPONSIBILITY
CSS Media query : screen min/max-width:800px
var public / function scoped
z=500; // public
```

```cs
function x(){ var y = 10; z=50;}
// no y here

let IS BLOCK SCOPE

function dothis(){
	if(x>10){  let p=true; }
}
```

```
.net : WINDOWS ONLY : C#, C++
.net core : mini (new) version for web
.net framework = .net

wpf has GUI
console app text only

constructor : Method called when you CREATE A NEW OBJECT (Instantiate)
called when use 'New' keyword
```

```cs
Class Parent{}
Main(){ var p = new Parent(); }
Default constructor
class X{
public X(){}
}
```


Class Instructions (template) for building a new object
Object created from a class
Instantiate create object from class

cast = CHANGE TYPE

2.5 ==> 2
   double   int                     (int)d


box = CHANGE TYPE TO OBJECT

parse string "{"a":1,"b":2}" ==> take string MAKE (JSON) OBJECT
TryParse() SAFE
ParseInt() DANGEROUS

convert

script : line 1, to end
javascript : compile 'live' as you go

GUI ==> objects eg button, dropdown

Events ==> 'click' 'hover'

OOP : attach code to OBJECTS EG BUTTON, DROPDOWN BOX

OOP = OBJECT ORIENTED = MEANS 'objects' which we attach code to
button onclick()

BASH	Command line on MAC / Linux
Terminal on MAC
CMD	Old command line
Powershell	New command line
GitBash	Application to emulates (copies) the Linux environment
MD	Windows command
mkdir	Linux command

Random Review

Inheritance class Child : Parent

Interface : blank class, one method (can be more) which is fully blank

```

```cs
Interface IDoThis{							// COMPLETELY ABSTRACT : NO CODE
	// no fields
	// yes properties
	int x {get;set;} 		// PROPERTY
	DoThis();   // BLANK
}

class x : y, Iinterface01, Iinterface02, IDoThis{			// CONCRETE CLASS : ALL CODE FILLED
	public int x {get;set;}  	// must be declared
	public void DoThis(){} 		// must be declared
}
```

Abstract class : mix of blank (abstract) methods and real methods

```cs
abstract class MyClass{
	
	void RealMethod(){ // real code} 				// GOOD CODE

	abstract void  AbstractMethod();   // no code 			// MISSING CODE 

}

class Child : MyClass{							// this is now CONCRETE
	void AbstractMethod(){  // REAL CODE }	
}
```


```
Can only INSTANTIATE A CONCRETE CLASS !!!!

Agile : simple first then build ITERATIVELY AND PROGESSIVELY MORE COMPLEX
Sprint : goal is working code (NEXT ITERATION)
Waterfall : ANALYSIS, DESIGN, BUILD, TEST, RELEASE
Kanban : continuous with limiting of number of active tasks
Compiler csc.exe C Sharp Compiler !!!

.CS  text   ==> IL  Intermediate Language

C#, C++, VB ==>  IL    (ILDASM)            ==>  at RUNTIME ==> CLR  common language runtime : OPTIVMISED FOR
								HARDWARE (CPU/RAM)

Agile
	agilemanifesto.org
	increments : using Scrum which has sprints


scripting : 'top-down' line-by-line
OOP : code attached to OBJECTS eg Button : EVENT ==> RUN CODE ((EVENT HANDLER)) ==> DELEGATE ==> Method(s)
4 pillars :
Abstract	hide code ('_fields') also expose publicly code ('properties'){get;set;}
Encapsulation	hides code
Inherit	Parent Base Class : properties / fields/ methods also in Derived Child Class
Polymorphism	subclasses : have own version of methods declared in parent
Parent : HaveAParty(){ // parent code }
Child : override HaveAParty(){ // unique code here }
Class	Blueprint for creating objects : contains FIELDS, PROPERTIES, METHODS, EVENTS
Instantiate	Create object using new keyword var object01 = new MyClass();
Constructor	Method called with new .. keyword
Class
Abstract Class	Cannot instantiate because code incomplete. Contains empty methods marked as
'abstract'

```


```cs
abstract class Parent{
	abstract void DoThis();
	}
class Child : Parent{
	override void DoThis(){}
}
```

Concrete Class	has all code present

Interface

Polymorphism	

```cs
class Parent{
	virtual void DoThis(){}	// virtual = 'can override if you wish'
}
class Child{
override DoThis(){}
}
```


```
Field	_private
Property	public {get;set}
Method	= Function
Access Modifiers	public private
internal inside .exe or .dll ASSEMBLY .apk .app
protected parent base and all child derived classes
Struct	mini Class
Collection	list, dictionary, queue, stack
Generic	<T> for type int, bool, MyClass, Customer
var vs let in Javascript	var global, let is block scoped
Angular
React
Vue
Queue
Stack
Dictionary
Array
LinkedList	shortcuts to next item
Sealed	has no Child Derived classes
```


## Lesson 1 Quiz

What is VSTS?

What do Codepen, JSFiddle and Plunkr have in common?

```
They are all code editors
```

VSCode is used to

```
Edit .NET Core and web projects     YES

Edit Framework projects

```

What is a compiler?

What is CIL?

What is a high level language?

what is a low level language?

What is CIL?

```
Partially compiled code
```

What is CLR?

```
The C# runtime environment
```

What do F#, C# and C++ all compile to ?

```
CIL                  YES
Assembly language    
Low level code       
High level code
```

## Agile

Agile Manifesto
Collaboration over negotiation
Face to face over long distance
Embrace over fixed plan
Individuals over process
Working software over documentation

Scrum roles
Scrum master facilitator (not boss)
product owner backlog (belongs to customer) ie list of requirements
Dev team 3-9 multi-skilled

User story - expresses technicality in a very human form ie from point of view of user
As a ... when i ... then ...

Kanban 24/7 rolling work
Control number of working items at any one time

Deploy live
Maintainance
Helpdesk
1st password reset
2nd complex fix
3rd line developer fix
Gold/Silver/Platinum - £££ paid for given level of service eg 2 hour support

Testing
TDD tests first RED GREEN REFACTOR
BDD human readable test
Cloud
server moved to datacentre

Sprint 1-4 weeks : focused goal to build selected items from main backlog (mini list is called the sprint backlog). Goal of sprint is to build next 'iteration' of working software

Backlog = list of requirements (from customer)

Scrum methodology : practical outworking of agile ==> use sprints

4 meetings
Sprint plan
Daily standup : yesterday today blockers
Sprint review : working software (show off work, our 'iteration')
Sprint retro : internal review

Spotify : silos : larger organisation : groups of people with similar function


## Testing

Why?
Help to prove our product works (to us and customer)
Tests first, code second ==> helps to keep developers focused
Prove all requirements are met
Prove validating input
Contract/Budget ==> very hard for client to not pay us if we have all tests working

```
Can we fix all bugs? NEVER
	% CODE COVERAGE is % of code covered by tests
```

V-model : all stages have testing
UNIT TEST (MODULE)
INTEGRATION (JOIN MODULES)
SYSTEM TEST (OVERALL)
UAT USER ACCEPTANCE TEST (LIST OF REQUIREMENTS) ((USER LETS US KNOW))


