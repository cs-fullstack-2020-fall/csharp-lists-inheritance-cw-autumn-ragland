using System;
using System.Collections.Generic;

class ListClasswork
{
    // Ask the user to enter four names and add them to a List. Print each element from the List
    public void ex1()
    {
        Console.WriteLine("Exercise 1"); // exercise message
        // create an empty list of strings
        List<string> nameList = new List<string>();

        // prompt the user to eneter a name and add what that eneter to out list (x4)
        Console.Write("Enter name 1 of 4: ");
        nameList.Add(Console.ReadLine());

        Console.Write("Enter name 2 of 4: ");
        nameList.Add(Console.ReadLine());

        Console.Write("Enter name 3 of 4: ");
        nameList.Add(Console.ReadLine());

        Console.Write("Enter name 4 of 4: ");
        nameList.Add(Console.ReadLine());
        // output the names entered in the list formatted in the console
        Console.WriteLine($"Name 1 : {nameList[0]}\nName 2 : {nameList[1]}\nName 3 : {nameList[2]}\nName 4 : {nameList[3]}");
    }
    public void ex2()
    {
        Console.WriteLine("Exercise 2"); // exercise message
        // create a list of integers : 5, 3, 7, 4
        List<int> numList =  new List<int>(){5,3,7,4};
        // pass list of integers to another method
        updateNumList(numList);
    }
    public void updateNumList(List<int> numberList)
    {
        Console.WriteLine("Update a list of numbers"); // method message

        // output each number in the array
        Console.WriteLine($"Number List : {numberList[0]}, {numberList[1]}, {numberList[2]}, {numberList[3]}");

        // output third element
        Console.WriteLine($"The third element is : {numberList[2]}");
        // delete second element
        numberList.RemoveAt(1);
        // output third element again
        Console.WriteLine($"The third element is : {numberList[2]}");
    }
    public void ex3()
    {
        Console.WriteLine("Exercise 3"); // exercise message

        // defines a list of strings : Bob, John, Autumn, Kevin
        List<string> nameList = new List<string>(){"Bob", "John", "Autumn", "Kevin"};
        // remove Bob from the list by value
        nameList.Remove("Bob");
        // output all names in the list
        Console.WriteLine($"Name 1 : {nameList[0]}\nName 2 : {nameList[1]}\nName 3 : {nameList[2]}");
        // output length of the list
        Console.WriteLine($"The list of names is {nameList.Count} names long");
        // check if Kevin is in the list
        if(nameList.IndexOf("Kevin") >= 0)
        {
            // output Kevin's index position
            Console.WriteLine($"The name Kevin is at index position {nameList.IndexOf("Kevin")}");
        }
        else
        {
            Console.WriteLine("This name is not in the list!");
        }
    }
    public void ex4()
    {
        Console.WriteLine("Exercise 4");
        // defined an empty list of integers
        List<int> numList = new List<int>();

        // prompt the user to enter a number and parse + save their response in the console (x5)
        Console.Write("Enter number 1 of 5:");
        numList.Add(Int32.Parse(Console.ReadLine()));
        Console.Write("Enter number 2 of 5: ");
        numList.Add(Int32.Parse(Console.ReadLine()));
        Console.Write("Enter number 3 of 5: ");
        numList.Add(Int32.Parse(Console.ReadLine()));
        Console.Write("Enter number 4 of 5: ");
        numList.Add(Int32.Parse(Console.ReadLine()));
        Console.Write("Enter number 5 of 5: ");
        numList.Add(Int32.Parse(Console.ReadLine()));

        // output all numbers entered
        Console.WriteLine($"Number 1 : {numList[0]}\nNumber 2 : {numList[1]}\nNumber 3 : {numList[2]}\nNumber 4 : {numList[3]}\nNumber 5 : {numList[4]}");
        // add all numbers entered together
        int numSum = numList[0] + numList[1] + numList[2] + numList[3] + numList[4];
        // output sum of all numbers entered
        Console.WriteLine($"The sum of all the numbers you entered is {numSum}");
    }
    public void ex5()
    {
        Console.WriteLine("Exercise 5");
        List<int> numList = new List<int>(){15,4,18};
        min(numList);
        max(numList);
    }

    public void min(List<int> listOfNumbers)
    {
        Console.WriteLine("MIN");
        int minNum = listOfNumbers[0];
        if(listOfNumbers[1] < minNum)
        {
            minNum = listOfNumbers[1];
        }
        if(listOfNumbers[2] < minNum)
        {
            minNum = listOfNumbers[2];
        }
        Console.WriteLine($"The minimum number is : {minNum}");
    }

    public void max(List<int> listOfNumbers)
    {
        Console.WriteLine("MAX");
        int maxNum = listOfNumbers[0];
        if(listOfNumbers[1] > maxNum)
        {
            maxNum = listOfNumbers[1];
        }
        if(listOfNumbers[2] > maxNum)
        {
            maxNum = listOfNumbers[2];
        }
        Console.WriteLine($"The maximim number is : {maxNum}");
    }
}