# OOP Pillars

1. Inheritance   Parent => child

2. Encapsulation     hide internal members using 'private' (or 'protected') keyword

   Class x{

   ​	private _db;

   }

3. Abstraction   exposes public methods which  can reach private data

   ​				User                                                                                                                                               Driver

   ​						Public Properties {get;set;}  with read/write to private 								              Clutch, 

   ​						encapsulated data																						Accelerator, Gearbox

​					 (Private) Encapsulated data                                                                                                         Engine

4. Polymorphism     Parent method => Child override with different implementation



Interface - has no code block at all



​	Used so 'architect' of an application can provide, up front, clear naming conventions to be followed for methods in use in the application



​	Class implements multiple interfaces - has to fully out all code in every method

​     Safari Park : IShooter and Method will be 'Shoot' but camera different to gun

​	Interface IDoThis{

​			DoThis();   // no code 

​	}

​    Class MyClass : IDoThis{

​			DoThis(){  // code }

}



C#  - compare two objects   :   IComparable with   'CompareTo()' method





SOLID => 

​	SINGLE RESPONSIBILITY - DO ONE THING WELL

​	OPEN TO EXTENSION/CLOSED MODIFICATION    PICTURE : PLUG-IN FOR GAME OR CHROME BROWSER

​	LISKOV : SWAP PARENT/CHILD CLASSES EASILY

​	INTERFACE SEGREGATION - ONE INTERFACE HAS ONE METHOD

​	DEPENDENCY INVERSION -     Ienumberable<string>....    Manager in office with employees under you.  Need data formatted.  Should standardise the data at the highest level





Strong typed - types fixed at COMPILE time.   Helps with memory management at runtime as types already fixed

Weak typed - types fixed at RUNTIME time so harder to plan with memory management.  Python and Javascript use this method.  'Interpreted language' which runs live, line by line at runtime.



Struct  VALUE TYPE   NO INHERITANCE    SMALL AMOUNTS OF DATA    SIMILAR TO CLASS   PUBLIC MEMBERS











