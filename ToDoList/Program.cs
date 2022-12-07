using System;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList
{
  public class Program
  {
    public static List<Item> toDoList = new List<Item> {};
    public static void Main()
    {
      Console.WriteLine("Welcome do the To Do List!");
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string userSelection = Console.ReadLine();
      if (userSelection.ToLower() == "add")
      {
       AddItem();

      } else if (userSelection.ToLower() == "view")
      {
        ViewList();

      } else
      {
        Console.WriteLine("Invalid Response");
        Main();
      }
    }

    public static void AddItem()
    {
      Console.WriteLine("What do you need to do?");
      string listItem = Console.ReadLine();
      Item newItem1 = new Item(listItem);
      toDoList.Add(newItem1);
      WhatNext();
    }

    public static void WhatNext()
    {
      Console.WriteLine("Would you like to add another task? [Y]/[N]");
      string userInput = Console.ReadLine();
      if (userInput.ToLower() == "y")
      {
        AddItem();
      } else if (userInput.ToLower() == "n")
      {
       Console.WriteLine("Would you like to view your To-Do List? [Y]/[N]");
       string userInput2 = Console.ReadLine();
       if (userInput2.ToLower() == "y")
       {
        ViewList();
       } else 
       {
       Console.WriteLine("Goodbye!");
       }
      } else 
      {
        Console.WriteLine("Goodbye!");
      }
    }

    public static void ViewList()
    {
      foreach (Item listItem in toDoList) 
      {
      Console.WriteLine(listItem.Description);
      }
      WhatNext();
    }
  }
}