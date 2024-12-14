# Data Structures Tutorial

## I. Welcome

Data structures are ways of organizing code in ways that increase efficiency. They are often used when organizing or looking through large amounts of data.

The way in which the efficiency is measured is using the Big O notation. What this does is looks at the worse case scenario of how long it could take to look through or add something to the data. It ignores coeffiecients and constants (unless it is just constant, which is represented as 1). They are reduced to the following measurements:

* O(1) - This is the most efficient method. It will take the same amount of time each time. It is constant, represented with the red line.
* O(n) - This depends on the variable with how long it would take. It is linear, represented with the blue line. 
* O(n²) - This will take the variable and multiply it with itself, taking much longer with larger variables. It is exponential, represented with the green line. 

The x-axis represents the data size, and the y-axis represents how much time it could take (based on the worst case scenario).

![Image](images/big_o_graph.png)

This tutorial will cover three common data structures used in programming, and their respective Big O notations. 

## II. Queue

The queue data structure is very basic. It uses the rule of FIFO (First In, First Out). Every time something is added into the list of data, it is added to the back. Every time something is taken from the data, it is taken from the front. 

You have likely seen this used when listening to music. Typically when you add a song to the queue while you are listening to music, it adds it to the back end of the queue (unless of course you have a shuffle mode on, or specify the order yourself). The song that plays next is not the one that was most recently added, it is the one that has been waiting the longest. 

See [this example](https://github.com/danieljcross/data_struct/tree/master/fa24-final-project-danieljcross-main/ds1-example) of how this could be coded in C#. 

Big O: O(1)

Adding a song to the end of the queue has no dependancy on the number of songs in the list, so it will have the same efficiency no matter how many songs are in the list. 

Your task:

A hamburger restaurant wants to implement a FIFO rule so that there isn't one customer waiting longer for their food than others. They want to do this by serving customers in the same order in which they paid for their food. Update [Problem 1](https://github.com/danieljcross/data_struct/tree/master/fa24-final-project-danieljcross-main/ds1-problem) with your solution. 

Once you have completed, please compare your answer with the [Sample Solution](https://github.com/danieljcross/data_struct/tree/master/fa24-final-project-danieljcross-main/ds1-solution) before submitting a link to your personal GitHub repository. 

## III. Set

A set is a data structure that does not allow duplicate values. It does this efficiently by giving each piece of data a hash code, assigning it to a specific "bucket." When adding a piece of data, it looks for that piece of data in the bucket that it would belong to. If it already exists, it does not add it again. Otherwise it adds it to that bucket. 

An example of a use for this (from my own personal life) could be to help manage a wedding invite list. If Daniel and Emma each create their own invite list, they might each include their mutual friends. However, those friends should not get two invites. Running the data through a set will allow them to verify that each person only gets one invite, even if they are on both lists. 

See [this example](https://github.com/danieljcross/data_struct/tree/master/fa24-final-project-danieljcross-main/ds2-example) of how this could be coded in C#. 

Big O: O(n)

The big O can be kind of complicated with this one. When determining which bucket a piece of data should go into, there is a set algorithm to decide, which means that uses O(1). However, it has to search through every piece of data within that bucket. So the worst case scenario is 0(n) if all of the data somehow ends up in one bucket. However, good planning can still make buckets useful with some situations. 

Your task:

You have 13 playing cards. You know they are all hearts, but you are not sure if there are duplicates or not. In order to make sure you have one of each card in the suite (A, 2-10, J, Q, K), you decide to enter each of your cards into a set. Please do so and update your code into [Problem 2](https://github.com/danieljcross/data_struct/tree/master/fa24-final-project-danieljcross-main/ds2-problem) to prove that you indeed have one of each card. Keep in mind that the data has already been entered for you. You must write the code that will look through the set to see if of the cards are missing. It should display any missing cards. 

Once you have completed, please compare your answer with the [Sample Solution](https://github.com/danieljcross/data_struct/tree/master/fa24-final-project-danieljcross-main/ds2-solution) before submitting a link to your personal GitHub repository. 

## IV. Tree

* Introduction
* ...
* *(replace these lines with headings that you'd use to teach this data structure)*
* ...
* Efficiency of common operations
* Example Problem
* Problem to Solve