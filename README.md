Julio Guerrero Bencosme - 1114981 
https://www.youtube.com/playlist?list=PL6bsk_Q0e0ZscmWxUSkQVNR1JUjgUpiAk

Kata21: Simple Lists
Perhaps there’s more to the humble list of values than you might think. Let’s experiment with some basic list processing.

Lists are one of the first data structures we learn as programmers. But familiarity doesn’t mean that we can’t learn a little from them.

For this kata we’re going to code up three implementations of a list that has the following basic interface:

The list consists of nodes. Each node has a string value, along with whatever housekeeping the list itself needs.
New nodes are added to the end of the list.
You can ask the list if it contains a given string. If it does, it returns the node containing that string.
You can delete a node from the list.
You can ask the list to return an array of all its values.

For the kata, where the idea is to practice, let’s write three implementations of the list:

A singly linked list (each node has a reference to the next node).
A doubly linked list (each node has a reference to both the next and previous nodes).
Some other implementation of your choosing, except that it should use no references (pointers) to collect nodes together in the list.
Obviously, we won’t be using predefined library classes as our list implementations…

