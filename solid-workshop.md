Intensive SOLID workshop
===========================

from codemanship
Jason Gorman

Introduction
============
To be agile we must keep our code cheap and simkple to change in order to be agile (agile being the ability to respond to business cvhange)
We spend 50-80% of our time reading code
 * make code readable
 * make code simple to understand as possible
 * reduce duplication
 * separate dependencies to stop the ripple effect (changing 1 thing means we have to change anohter one)

highly recommend "refactoring: improving trhe design of existing code" by Martin Fowler

refactoring is improving the deisgn of existing code without changing what it does
refactoring process: run the tests the make a single refactoring, rinse and repeat

code smells anaology: smell in the fridge - if we leave it the smell will get worse
there are classes of code smell: [LOOK UP AND FILL THIS IN!]
 * complexity
 * responsibility problems
 * duplicate code (simple) fix with extract method or extract class etc.

Good refactoring habits:
 * run the tests after every refactoring
 * if refactoring fails, roll back
 * identify code smells and use appropriate refactorings
 * refactor directly to well-defined goals
 * check-in after every refactoring goal is met
 * never refactor on a red light
 * use automated refactorings whenever possible
 * do one refactoring at a time

One refactoring at a time: stay on the path of working code, don't go wandering

OO Design
==========
What is OO for?
Polymorphism
Gives us the ability to invert the function calling
this enables us to change implementation without changing calling code
therefore the only thing it's for is reducing the ripple effect

Dependencies
=============

 * Efferent & Afferent couplings

 every dependency has 2 couplings
 1 = efferent = outgoing coupling
 2 = afferent = incoming
 [1] -> [2]

To reduce couplings between dependencies we need to increase the cohesion
(if things have to dependent on each other better to have them in the same class)

 * Dependency analysis

class cohesion - avg relationships per method.
calculate number of internal relationships and divide it by the number of methods

 4 rules of dependency management

 1 minimise dependencies - how do it? write less code!
 2 localise dependencies  - how? package dependent things together (methods, fields, classes)
  why split stuff up? because 1 big class is unreadable and unmanageable
  therefore we have to split stuff up - but we need to manage that and minimise it. How?
 3 stabilise dependencies - how? if we have to depend on something - **depend on something that is dependable** - less likely to change!
    what is less likely to cahnge? naturally immutable things - or standards!  **have dependencies point to things that are expensive to change**
 4 abstract dependencies
 **depend on things that are easy to substitute - this is the point of OO as we do this with polymorphism**

Design Principles
==================

 * Simple design - it's very hard - developers find it very hard - good outcome = less code which means less dependencies
 * DRY - when we duplicate we duplicate dependencies
 * Tell, Don't ask -  [Missed explanation]
 don't ask for information instead ask classes to do something - and the class should have the data to accomplish that task
 Data Class is a code smell - aneamic data models - all data and no behaviour

 SOLID
 -----

 * SRP: why important? because if a class does 1 thing it is less likely to have to change therefore things that depend on it are depending on something more dependable
 also: helps us with the composobility of the software as each class does 1 thing

 in order to extract a repsonsilbiity we will probably have to affect dependencies, adding feature envy
 which design smell to choose? look at code churn in your repo...
 look at things which have lots of efferent couplings... will be affected by change
 look at complexity - things with more classes should be redesigned


Class Design Principles
=========================

Complimentary design principles
================================

